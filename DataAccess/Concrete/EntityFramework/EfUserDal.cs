using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.DataAccess.EntityFramework;
using LayeredArchitectureExample.Core.Entities.Concrete;
using LayeredArchitectureExample.DataAccess.Abstract;

namespace LayeredArchitectureExample.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
