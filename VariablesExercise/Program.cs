namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            string name;
            int age;
            char middleInitial;
            bool isOver18;
            double currentTemp;
            decimal price;

            //Initialize Variables
            name = "Caleb";
            age = 29;
            middleInitial = 'T';
            if (age >= 18) 
            { isOver18 = true; }
            else { isOver18 = false; }
            currentTemp = 64.3;
            price = 19.95m;


            //Interpolate
            Console.WriteLine($"Name: {name} \n" +
                              $"Age: {age} \n" +
                              $"Middle Initial: {middleInitial} \n" +
                              $"Over 18: {isOver18} \n" +
                              $"Current Temperature: {currentTemp} \n" +
                              $"Price: {price}");


        }
    }
}
