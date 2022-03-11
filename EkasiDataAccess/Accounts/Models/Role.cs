using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiDataAccess.Accounts.Models
{
    public class Role
         
    { 
        public int Id { get; set; }
         public string Name { get; set; }

        //Naviagtion Properties
        public List<User> Users { get; set; }
    }
}
