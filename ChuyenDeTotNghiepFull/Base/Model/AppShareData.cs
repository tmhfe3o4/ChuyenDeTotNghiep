using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDeTotNghiepFull.Base.Model
{
    class AppShareData
    {
        private static AppShareData _instance;

        public static AppShareData Instance()
        {
            if (_instance == null)
            {
                _instance = new AppShareData();
            }
            return _instance;
        }
    }
}
