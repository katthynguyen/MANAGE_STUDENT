using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class THAMSODTO
    {
        private int tuoiHocSinhToiThieu;
        private int tuoiHocSinhToiDa;
        private int siSoToiDa;
        private int soLuongMonHoc;
        private int diemDat;

        public int TuoiHocSinhToiThieu { get => tuoiHocSinhToiThieu; set => tuoiHocSinhToiThieu = value; }
        public int TuoiHocSinhToiDa { get => tuoiHocSinhToiDa; set => tuoiHocSinhToiDa = value; }
        public int SiSoToiDa { get => siSoToiDa; set => siSoToiDa = value; }
        public int SoLuongMonHoc { get => soLuongMonHoc; set => soLuongMonHoc = value; }
        public int DiemDat { get => diemDat; set => diemDat = value; }
    }
}
