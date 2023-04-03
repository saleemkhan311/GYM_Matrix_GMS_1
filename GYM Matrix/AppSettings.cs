using System;
using System.Collections.Generic;
using System.Text;

namespace GYM_Matrix
{
    class AppSettings
    {
       
        public static string ConString()
        {
            string connectString = "server=localhost;Database=gym_matrix;Uid=root;Pwd=''";

            return connectString;
        }
    }
}
