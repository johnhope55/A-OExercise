using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple anApple = new Apple();
            Orange anOrange = new Orange();
            List<string> Scanned = new List<string>();
            String Item = "";

            Console.WriteLine("New order ");
            while (Item != "End")
            {
                Console.Write("Next Item ");
                Item = Console.ReadLine();
                if (Item != "Apple")
                    if(Item != "Orange")
                        if (Item != "End")
                        {
                            Console.WriteLine("Not Apple, Orange, or End, try again" );
                        }
                
                Scanned.Add(Item);
            }
            Console.Write("Order ");

            int Total = 0;

                      foreach (string item in Scanned)
                       {
                          if (item  == "Apple")
                            {
                                Total = Total + anApple.Price;
                            }
                          if (item == "Orange")
                            {
                                Total = Total + anOrange.Price;
                            }
                }
            Console.Write("Total =  " + Total);
            Console.Read();
        }


        class Apple
        {
            private int price = 60;
            public int Price
            {
                get
                {
                    return this.price;
                }
            }
        }
        class Orange
        {
            private int price = 25;
            public int Price
            {
                get
                {
                    return this.price;
                }
            }

        }
    }
}
