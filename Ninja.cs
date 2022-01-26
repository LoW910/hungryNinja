using System.Collections.Generic;

namespace HungryNinja
{
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        // private bool isFull;

        // add constructor

        public Ninja(){
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        
        // add public getter property called isFull
        public abstract bool IsFull{get;}

        // // public bool IsFull{
        // //     get{
        // //         if (calorieIntake >= 1200){
        // //             System.Console.WriteLine("Ninja is full and cannot eat anymore.");
        // //             return true;
        // //         } else {
        // //             return false;
        // //         }
        // //     }
        // // }

        // build out the Eat Method
        public abstract void Consume(IConsumable item);
        
        // // public void Eat(Food item){
        // //     if(!IsFull) {
        // //         System.Console.WriteLine($"Food: {item.Name} Spicy: {item.IsSpicy} Sweet: {item.IsSweet}");
        // //         FoodHistory.Add(item);
        // //         calorieIntake += item.Calories;
        // //         System.Console.WriteLine(calorieIntake);
        // //     }
        // // }
    }
}