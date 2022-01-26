using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning of the Hungry Ninja!");

            Buffet eats = new Buffet();
            Ninja jay = new Ninja();



            
            // System.Console.WriteLine(eats.Menu);
            // foreach (var item in eats.Menu)
            // {
            //     System.Console.WriteLine(item.Name);
            // }

            // Food numnum = eats.Serve();
            // System.Console.WriteLine(numnum.Name);

            // Food sumNewFood = new Food("Thai", 300, true, false);
            // jay.Eat(eats.Serve());
            // System.Console.WriteLine(jay.FoodHistory);
            // System.Console.WriteLine("==========");
            // foreach (var item in jay.FoodHistory)
            // {
            //     System.Console.WriteLine(item.Name);
            // }

            while(!jay.IsFull){
                jay.Eat(eats.Serve());
            }
            

        }
    }

    


    









}
