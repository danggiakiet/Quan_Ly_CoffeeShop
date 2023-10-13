using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly
{
    public class doUongMenu
    {
        public string Ten { get; set; }
        public int Price { get; set; }

        public doUongMenu(string ten, int price)
        {
            this.Ten = ten;
            this.Price = price;
        }
    }
}
