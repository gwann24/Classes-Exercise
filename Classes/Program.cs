using Cars;
namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Cars.Cars Car1 = new Cars.Cars();
            Car1.Make = "Honda";
            Car1.Model = "Accord";
            Car1.Year = 2020;

            Console.WriteLine(Car1.Make);
            Console.WriteLine(Car1.Model);
            Console.WriteLine(Car1.Year);

        }
    }
}
