using System.Collections.Generic;

namespace HungryNinja
{
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