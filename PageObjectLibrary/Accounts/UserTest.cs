using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.Accounts
{
    public static class UserTest
    {
        public static string GetEmail ()
        {
           string email = "juan.pablo.delgadillo.peredo@gmail.com";
            return email;
        }
        public static string GetPassword()
        {
            string password = "Control123";
            return password;
        }

    }
}
