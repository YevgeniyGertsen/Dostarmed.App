using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dostarmed.Lib

   
{
    public enum UserAccess { admin = 1, user = 2, none = 3}
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserAccess UserAccess { get; set; }

        public Organisation Organisation { get; set; }
    }
}
