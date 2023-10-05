using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly
{
    public class doUongThongKe
    {
        public string tenDoUong { get; set; }
        public int soLuongDaBan { get; set; }
        public doUongThongKe() { }
        public doUongThongKe(string tenDoUong, int soLuongDaBan)
        {
            this.tenDoUong = tenDoUong;
            this.soLuongDaBan = soLuongDaBan;
        }
    }
}
