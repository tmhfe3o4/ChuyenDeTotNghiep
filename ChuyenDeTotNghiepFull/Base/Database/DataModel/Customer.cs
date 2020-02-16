using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDeTotNghiepFull.Database.Model
{
    class Customer
    {
        public int Id { get { return Id; } set { Id = value; } }
        public string Sex { get { return Sex; } set { Sex = value; } }
        public DateTime DateOfBirth { get { return DateOfBirth; } set { DateOfBirth = value; } }
        public string Name { get { return Name; } set { Name = value; } }
        public string PhoneNumber { get { return PhoneNumber; } set { PhoneNumber = value; } }
    }
}
