namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "Ford";
            car1.Model = "Bronco";
            car1.Year = 2005;

            Console.WriteLine($"Make: {car1.Make}");
            Console.WriteLine($"Model: {car1.Model}");
            Console.WriteLine($"Year: {car1.Year}");
        }
    }
}
