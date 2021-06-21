using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace LayeredArchitectureExample.Core.Utilities.Security.Encryption
{
  public  class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) =>
            new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
    }
}
