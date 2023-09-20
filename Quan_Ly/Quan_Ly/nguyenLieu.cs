using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly
{
    public class nguyenLieu
    {
        public string ten { get; set; }
        public string donVi { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }

        public nguyenLieu() { }

        public nguyenLieu(string ten, string donVi, int soLuong, int donGia)
        {
            this.ten = ten;
            this.donVi = donVi;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
    }
}
