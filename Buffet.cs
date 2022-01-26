using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet(){
            Menu = new List<Food>(){
                new Food("Tacos", 100, true, false),
                new Food("BBQ Chicken", 800, false, true),
                new Food("Steak", 300, false, true),
                new Food("Salad", 200, false, true),
                new Food("Fish", 500, true, false),
                new Food("Jerk beef bites", 400, true, false),
                new Food("Chocolate Cookies", 100, false, true)
            };
        }

        public Food Serve(){
            Random rand = new Random();
            int menuCount = Menu.Count;

            return Menu[rand.Next(menuCount)];

        }
    }
}