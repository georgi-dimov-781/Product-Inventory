using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory_93
{
    class Produkt
    {
        public int number;
        public string produktName;
        public double price;
        public int nalichnost;

        public Produkt(int number, string produktName, double price, int nalichnost)
        {
            this.number = number;
            this.produktName = produktName;
            this.price = price;
            this.nalichnost = nalichnost;
        }

        public void inventory()
        {
            Console.WriteLine(number + " - " + produktName + " - " + price + " лева - " + nalichnost + " броя в наличност");
        }
    }
}
