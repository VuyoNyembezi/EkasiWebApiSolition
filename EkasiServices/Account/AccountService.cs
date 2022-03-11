using EkasiDataAccess;
using EkasiDataAccess.Accounts.Models;
using EkasiDataAccess.Accounts.ViewModels;
using EkasiServices.Account.SecurityServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiServices.Account
{
    public class AccountService : IAccountService
    {
        private EkasiDbContext _db;

        public AccountService(EkasiDbContext db)
        {
            _db = db;
        }

        public int UserRegister(UserRegisterViewModel user)
        {
            if (user != null)
            {
                    var KeyNew = SecurityService.GeneratePassword(20);
                    var password = SecurityService.EncodePassword(user.Password, KeyNew);
                    user.Password = password;
                    user.VerificationCode = KeyNew;

                    var _user = new User()
                    {
                        Name = user.Name,
                        Email = user.Email,
                        Cell = user.Cell,
                        Password = user.Password,
                        OTP = user.OTP,
                        RegionId = user.RegionId,
                        Registered = DateTime.Now
                    };
                    _db.Users.Add(_user);
                    _db.SaveChanges();

                return 1;
            }
            return -1;
          
        }

        public int UserLogin(UserLoginViewModel login)
        {
            var getUser =  _db.Users.FirstOrDefault(u => u.Email == login.Email);
            
            if (getUser !=null)
            {
                var hashCode = getUser.VerificationCode;
                var encodingpasswordString = SecurityService.EncodePassword(login.Password, hashCode);
                getUser.Password = encodingpasswordString;
                if(getUser.Email == login.Email || getUser.Cell == login.Cell && getUser.Password == login.Password)
                {
                   return  1;
                }
                return -1;
            }
            return -1;
        }
    }
}
