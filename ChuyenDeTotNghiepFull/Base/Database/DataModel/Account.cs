using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDeTotNghiepFull.Database.Model
{
    class Account
    {
        public int id { get { return id; } set { id = value; } }
        public int Id_Staff { get { return Id_Staff; } set { Id_Staff = value; } }
        public string username { get { return username; } set { username = value; } }
        public string password { get { return password; } set { password = value; } }
    }
}
