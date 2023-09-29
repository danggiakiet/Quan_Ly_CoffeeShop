using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly
{
    public class nhanVien
    {
        public string maNV { get; set; }
        public string ten { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngaySinh { get; set; }
        public int luong { get; set; }

        public nhanVien() { }

        public nhanVien(string maNV,string ten, string soDienThoai, DateTime ngaySinh, int luong)
        {
            this.maNV = maNV;
            this.ten = ten;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
            this.luong = luong;
        }
    }
}
