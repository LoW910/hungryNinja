using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        //constructor
        public Buffet(){
            Menu = new List<IConsumable>(){
                new Food("Tacos", 100, true, false),
                new Food("BBQ Chicken", 800, false, true),
                new Food("Steak", 300, false, true),
                new Food("Salad", 200, false, true),
                new Food("Fish", 500, true, false),
                new Food("Jerk beef bites", 400, true, false),
                new Food("Chocolate Cookies", 100, false, true),
                new Drink("Crown Royal", 150, true, false),
                new Drink("Dr. Pepper", 100, false, true),
                new Drink("Komdo Drago Martini", 100, false, true),
                new Drink("Coke", 100, true, false)
            };
        }

        public IConsumable Serve(){
            Random rand = new Random();
            int menuCount = Menu.Count;

            return Menu[rand.Next(menuCount)];

        }
    }
}