using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.DataAccess;
using LayeredArchitectureExample.Core.Entities.Concrete;

namespace LayeredArchitectureExample.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
