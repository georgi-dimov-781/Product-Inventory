using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory_93
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt teniski = new Produkt(1, "Тениска - сезон Лято", 30, 15);
            Produkt kusi_gashti = new Produkt(2, "Къси гащи", 50, 12);
            Produkt pantaloni = new Produkt(3, "Официален панталон", 90, 7);
            Produkt qketa = new Produkt(4, "Пролетно яке - естествена кожа", 200, 15);
            Produkt obuvki = new Produkt(5, "Обувки", 80, 20);
            Produkt potnici = new Produkt(6, "Потник", 30, 15);
            Produkt rizi = new Produkt(7, "Риза", 70, 10);
            Produkt dunki = new Produkt(8, "Дънки", 50, 25);
            Produkt rokli = new Produkt(9, "Рокля", 100, 15);

            List<Produkt> allProdukti = new List<Produkt>();
            allProdukti.Add(teniski);
            allProdukti.Add(kusi_gashti);
            allProdukti.Add(pantaloni);
            allProdukti.Add(qketa);
            allProdukti.Add(obuvki);
            allProdukti.Add(potnici);
            allProdukti.Add(rizi);
            allProdukti.Add(dunki);
            allProdukti.Add(rokli);


            Console.WriteLine("Изберете желаните от Вас стоки от каталога:");

            foreach (Produkt produkt in allProdukti)
            {
                produkt.inventory();
            }

            Shop myShopping = new Shop(1, 1);
            int produktNumber;
            string continueShopping = "yes";
            while (continueShopping == "yes")
            {
                Console.WriteLine("\nИзберете своя продукт:");
                produktNumber = Convert.ToInt16(Console.ReadLine());
                if (produktNumber > 9)
                {
                    Console.WriteLine("Съжаляваме, избраната стока не присъства в каталога!");
                }
                else
                {
                   myShopping.addProdukt(allProdukti[produktNumber - 1]);
                }

                Console.WriteLine("\nЖелаете ли за продължите да купувате? (yes or no)");
                continueShopping = Console.ReadLine();

                if (continueShopping == "no")
                {
                    break;
                }

            }
            Console.Write("Моля изчакайте!");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Благодаря Ви за направената покупка!");
            myShopping.inventoryProdukt();
            Console.WriteLine("Общо: " + myShopping.totalPrice + " лева");


            Console.ReadKey();
        }


    }
    }

