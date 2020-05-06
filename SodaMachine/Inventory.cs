using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
   public class Inventory
        
    {
        //member variable
       public string typeCan;
      public  double canPriceGrape = .60;
       public double canPriceOrange = .30;
       public double canPriceLemon = .06;






        // constructor

        public Inventory()
        {
            typeCan = "Grape Soda, Orange Soda, Lemon Soda";

            if (double.TryParse(typeCan, out canPriceGrape))
            {
                Console.WriteLine("Grape Soda is" + typeCan);
                Console.ReadLine();
            }

            if (double.TryParse(typeCan,out canPriceOrange))
            {
                Console.WriteLine("Orange Soda is" + typeCan);
                Console.ReadLine();
            }

            if (double.TryParse(typeCan, out canPriceLemon))
            {
                Console.WriteLine("Lemon Soda is" + typeCan);
                Console.ReadLine();
            }

        }



        // member methods 




    }
}
