using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiDataAccess.Accounts.ViewModels
{
    class RegionViewModel
    {
        public string Name { get; set; }
    }
    public class RegionWithUsersViewModel
    {
        public string Name { get; set; }
        public List<RegionUsersVM> Users { get; set; }
    }
    public class RegionUsersVM
    {
        public List<string> Users { get; set; }
    }
}
