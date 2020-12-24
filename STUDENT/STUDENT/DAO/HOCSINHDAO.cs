using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DAO
{
    public class HOCSINHDAO
    {
        public void InsertHocSinh(HOCSINHDTO hs)
        {
            
        }

        public void UpdateHocSinh(HOCSINHDTO hs)
        {

        }
        public void DeleteSinh(HOCSINHDTO hs)
        {
            
        }
        public DataTable GetAllHocSinh()
        {
            string query = "SELECT * FROM HOCSINH";
            return SqlProvider.ExecuteQuery(query);
        }
    }
}
