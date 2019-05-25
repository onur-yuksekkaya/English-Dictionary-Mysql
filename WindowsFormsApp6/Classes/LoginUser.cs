using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Classes
{
    class LoginUser
    {
        public static bool userlogin { get; set; }
        public static string userID { get; set; }
        public static string userName { get; set; }
        public static string userRealName { get; set; }

        private LoginUser()
        {
            userlogin = false;
        }

    }
}
