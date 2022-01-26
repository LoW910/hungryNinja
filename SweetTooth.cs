namespace HungryNinja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull {
            get{
            if(calorieIntake > 1500) return true;
            return false;
        }}

        public override void Consume(IConsumable item)
        {
            System.Console.WriteLine($"{item.Name} inside consume function");
            if (!IsFull){
                if(item.IsSweet) calorieIntake += 10;
                
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                System.Console.WriteLine(item.GetInfo());
            } else {
                System.Console.WriteLine("SweetTooth is full and cannot eat anymore!");
            }
        }
    }
}