namespace HungryNinja
{
    class SpiceHound : Ninja
    {
        public override bool IsFull{
            get{
                if (calorieIntake > 1200) return true;
                return false;
            }
        } 

        public override void Consume(IConsumable item)
        {
            if(!IsFull){
                if(item.IsSpicy) calorieIntake -= 5;

                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                System.Console.WriteLine(item.GetInfo());

            } else {
                System.Console.WriteLine("SpiceHound is full and cannot eat anymore!");
            }
        }
    }
}