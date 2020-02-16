using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDeTotNghiepFull.Database.Model
{
    class Staff
    {
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Name { get { return Name; } set { Name = value; } }
        public string Sex { get { return Sex; } set { Sex = Sex; } }
        public DateTime DateOfBirth { get { return DateOfBirth; } set { DateOfBirth = value; } }
        public string Address { get { return Address; } set { Address = value; } }
        public int IdentityNumber { get { return IdentityNumber; } set { IdentityNumber = value; } }
        public int PhoneNumber { get { return PhoneNumber; } set { PhoneNumber = value; } }
        public string Status { get { return Status; } set { Status = value; } }
        public string Note { get { return Note; } set { Note = value; } }
    }
}
