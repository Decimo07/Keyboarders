using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Keyboarders.Class
{
    internal class dbconnection
    {
        public string mycon()
        {
            string dbcon = @"server=localhost;user id=root;database=library_system";
            return dbcon;
        }
    }
}
