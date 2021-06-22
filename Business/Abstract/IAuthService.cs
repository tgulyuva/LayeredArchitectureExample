using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.Entities.Concrete;
using LayeredArchitectureExample.Core.Utilities.Results;
using LayeredArchitectureExample.Core.Utilities.Security.JWT;
using LayeredArchitectureExample.Entities.DTOs;

namespace LayeredArchitectureExample.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
