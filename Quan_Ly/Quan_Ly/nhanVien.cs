using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly
{
    public class nhanVien
    {
        public string ten { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngaySinh { get; set; }
        public int luong { get; set; }

        public nhanVien() { }

        public nhanVien(string ten, string soDienThoai, DateTime ngaySinh, int luong)
        {
            this.ten = ten;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
            this.luong = luong;
        }
    }
}
