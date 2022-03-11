using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiDataAccess.Accounts.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Cell { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
        public DateTime? Registered { get; set; }
        public bool Approved { get; set; }
        public string VerificationCode { get; set; }
        public bool Active { get; set; }


        //Naviagtion Properties
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public int? RegionId { get; set; }
        public Region Region { get; set; }
    }
}
