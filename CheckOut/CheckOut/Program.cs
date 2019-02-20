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

            double Total = 0;
            int ACount = 0;
            int OCount = 0;

            foreach (string item in Scanned)
                       {
                          if (item  == "Apple")
                            {
                                ACount = ACount + 1;
                            }
                          if (item == "Orange")
                            {
                                OCount = OCount + 1;
                            }
                        }
            //Offers

            Total = Total + ((Math.Floor(ACount / anApple.OfferRatio) 
                            + (ACount % anApple.OfferRatio))
                            * anApple.Price);
            // 2 for 1 with odd ones charge at normal price, i.e round up afterdividing by 2


            double t = (Math.Floor(OCount / anOrange.OfferRatio));
            double u = (OCount % anOrange.OfferRatio);

            double Tot = (t * anOrange.Price * 2) + (u * anOrange.Price);


            Total = Total + ((Math.Floor(OCount / anOrange.OfferRatio) * anOrange.Price * 2)
                            + ((OCount % anOrange.OfferRatio) * anOrange.Price));
           
            // 3 for 2, odd 1s and 2s charged at normal price

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
            private double offerRatio = 2.0;
            public double OfferRatio
            {
                get
                {
                    return this.offerRatio;
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
            private double offerRatio = 3;
            public double OfferRatio
            {
                get
                {
                    return this.offerRatio;
                }
            }
        }
    }
}
