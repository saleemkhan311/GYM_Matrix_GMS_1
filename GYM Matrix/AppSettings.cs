using System;
using System.Collections.Generic;
using System.Text;

namespace GMS
{
    class AppSettings
    {
       
        public static string ConString()
        {
            string connectString = "server=localhost;Database=gms;Uid=root;Pwd=''";

            return connectString;
        }
    }
}
