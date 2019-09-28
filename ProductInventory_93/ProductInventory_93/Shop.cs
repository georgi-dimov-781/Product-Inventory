using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory_93
{
    class Shop
    {
        public int number;
        public int user_number;
        public double totalPrice;
        public List<Produkt> produktList = new List<Produkt>();

        public Shop(int number, int user_number)
        {
            this.number = number;
            this.user_number = user_number;
        }

        public void addProdukt(Produkt produkt)
        {
            if (produkt.nalichnost > 0)
            {
                Console.WriteLine("Вие добавихте " + produkt.produktName + " към своята количка");
                produktList.Add(produkt);
                this.totalPrice += produkt.price;
                produkt.nalichnost -= 1;
            }
            else
            {
                Console.WriteLine("Съжаляваме, стоката е изчерпана!");
            }

        }

        public void getTotalPrice()
        {
            this.totalPrice = 0;
            foreach (Produkt produkt in produktList)
            {
                this.totalPrice += produkt.price;
            }
        }

        public void inventoryProdukt()
        {
            Console.WriteLine("Вашите артикули са :");
            int i = 1;
            foreach (Produkt produkt in produktList)
            {
                Console.WriteLine(i + " - " + produkt.produktName + " - " + produkt.price + " лева");
                i++;
            }
        }
    }
}
