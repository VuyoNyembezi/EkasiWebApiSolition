using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiDataAccess.Accounts.ViewModels
{

    //for registration 
    public class UserRegisterViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
        public int? RegionId { get; set; }
        public string VerificationCode { get; set; }
    }
    public class UserLoginViewModel
    {
     
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Password { get; set; }
        public string VerificationCode { get; set; }
    }


    public class UserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
        public DateTime? Registered { get; set; }
        public bool Approved { get; set; }
        public bool Active { get; set; }
        public int? RoleId { get; set; }
        public int? RegionId { get; set; }

    }
    public class UserViewModelWithDetails
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
        public DateTime? Registered { get; set; }
        public bool Approved { get; set; }
        public bool Active { get; set; }
        public string RoleName { get; set; }
        public string RegionName { get; set; }
    }

    public class UserResponseViewModel
    {
        public int? ReturnId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public int? Role { get; set; }

        public string Token { get; set; }
    }
}
