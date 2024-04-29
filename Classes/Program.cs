namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Year = 2017;
            myCar.Make = "Ford";
            myCar.Model = "F-150";
            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
