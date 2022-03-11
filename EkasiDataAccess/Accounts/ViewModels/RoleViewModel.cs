using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiDataAccess.Accounts.ViewModels
{
    public class RoleViewModel
    {
        public string Name { get; set; }
    }
    public class RoleWithUsersViewModel
    {
        public string Name { get; set; }
        public List<RoleUserVM> Users { get; set; }
    }
    public class RoleUserVM
    {
        public List<string> Users { get; set; }
    }
}
