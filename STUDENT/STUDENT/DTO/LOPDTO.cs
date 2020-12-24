using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class LOPDTO
    {
        private string maLop;
        private int siSo;
        private string maKhoi;

        public string MaLop { get => maLop; set => maLop = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        public string MaKhoi { get => maKhoi; set => maKhoi = value; }
    }
}
