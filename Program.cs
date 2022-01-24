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

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int cal, bool isSpicy, bool isSweet){
            Name = name;
            Calories = cal;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }


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



    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        // private bool isFull;

        // add constructor

        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        
        // add public getter property called isFull
        public bool IsFull{
            get{
                if (calorieIntake >= 1200){
                    System.Console.WriteLine("Ninja is full and cannot eat anymore.");
                    return true;
                } else {
                    return false;
                }
            }
        }

        // build out the Eat Method
        public void Eat(Food item){
            if(!IsFull) {
                System.Console.WriteLine($"Food: {item.Name} Spicy: {item.IsSpicy} Sweet: {item.IsSweet}");
                FoodHistory.Add(item);
                calorieIntake += item.Calories;
                System.Console.WriteLine(calorieIntake);
            }
        }
    }





}
