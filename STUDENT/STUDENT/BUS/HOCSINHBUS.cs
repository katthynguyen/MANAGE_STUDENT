using STUDENT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.BUS
{
    public class HOCSINHBUS
    {
        public DataTable GetAllHocSinh()
        {
            HOCSINHDAO dao = new HOCSINHDAO();
            return dao.GetAllHocSinh();
        }
    }
}
