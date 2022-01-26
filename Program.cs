using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning of the Hungry Ninja!");

            // implementing abstract class for ninja removes below  lines
            Buffet eats = new Buffet();
            SweetTooth jay = new SweetTooth();
            SpiceHound dan = new SpiceHound();

            while(!dan.IsFull){
                System.Console.WriteLine("====== inside dans while ==========");
                dan.Consume(eats.Serve());
            }
            while(!jay.IsFull){
                System.Console.WriteLine("====== inside jays while ==========");
                jay.Consume(eats.Serve());
            }

            if(dan.ConsumptionHistory.Count > jay.ConsumptionHistory.Count){
                System.Console.WriteLine($"SpiceHound consumed {dan.ConsumptionHistory.Count} SweetTooth consumed {jay.ConsumptionHistory.Count}");
            } else {
                System.Console.WriteLine($"SweetTooth consumed {jay.ConsumptionHistory.Count} SpiceHound consumed {dan.ConsumptionHistory.Count}");

            }
            // // Ninja jay = new Ninja();
            // // while(!jay.IsFull){
            // //     jay.Eat(eats.Serve());
            // // }
            
            
            // // System.Console.WriteLine(eats.Menu);
            // // foreach (var item in eats.Menu)
            // // {
            // //     System.Console.WriteLine(item.Name);
            // // }

            // // Food numnum = eats.Serve();
            // // System.Console.WriteLine(numnum.Name);

            // // Food sumNewFood = new Food("Thai", 300, true, false);
            // // jay.Eat(eats.Serve());
            // // System.Console.WriteLine(jay.FoodHistory);
            // // System.Console.WriteLine("==========");
            // // foreach (var item in jay.FoodHistory)
            // // {
            // //     System.Console.WriteLine(item.Name);
            // // }



        }
    }

    


    









}
