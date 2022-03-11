using EkasiDataAccess.Accounts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiServices.Account.TokenServices
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserLoginViewModel user);

        bool IsTokenValid(string key, string issuer, string token);

        string GenerateJwtToken(string email);
    }
}
