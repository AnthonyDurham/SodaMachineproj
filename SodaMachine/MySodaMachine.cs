using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
   public class MySodaMachine: Inventory
    {                                                                   // have errors was unsure of why i could not instanceate the
        List<Coin> coins;                                               // inventory values over and was unsure on the return change 
                                                                           // if not met to set value i i tried below 

        public MySodaMachine()
        {
            coins = new List<Coin>();
        }

        public void StockChangeInMachine()
        {

            for (int i = 0; i <= 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }



            for (int i = 0; i <= 20; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
            }



            for (int i = 0; i <= 20; i++)
            {
                Nickel nickel = new Nickel();
                coins.Add(nickel);
            }



            for (int i = 0; i <= 50; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }
                                                                        // these errors are new that i dont under stand at first it says can 
                                                                 //priceGrape was to restricted so i changed the variable from inventory to public 
            if (coins < canPriceGrape)                              // now thw whole thing is a error whould like clarity 


            {// wasnt sure how to return money 
                Console.WriteLine("Did not put in enough money");
                Console.ReadLine();

            }

            if (coins < canPriceOrange)


            {
                Console.WriteLine("Did not put in enough money");
                Console.ReadLine();

            }

            if (coins < canPriceLemon)


            {
                Console.WriteLine("Did not put in enough money");
                Console.ReadLine();

            }

            if (coins = canPriceGrape)


            {
                Console.WriteLine("You have just purchased a Grape soda ");
                Console.ReadLine();


            }

            if (coins = canPriceOrange)


            {
                Console.WriteLine("You have just purchased a Orange soda ");
                Console.ReadLine();


            }


            if (coins = canPriceLemon)


            {
                Console.WriteLine("You have just purchased a Lemon soda ");
                Console.ReadLine();


            }


        }
    }
}
