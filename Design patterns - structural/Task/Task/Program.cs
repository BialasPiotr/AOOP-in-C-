using static Task.Car;
using Task.Macintosh;
using Task.Windows;

namespace Task;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a design pattern to demonstrate:");
        Console.WriteLine("1: Abstract Factory");
        Console.WriteLine("2: Builder");
        Console.Write("Your choice (enter a number): ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                DemonstrateAbstractFactory();
                break;
            case "2":
                DemonstrateBuilder();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void DemonstrateAbstractFactory()
    {
        var factoryA = new MacFactory();
        var factoryB = new WinFactory();

        var uiA = new UserInterface(factoryA);
        var uiB = new UserInterface(factoryB);

        Console.WriteLine("Demonstration for Mac:");
        uiA.DrawWindow();

        Console.WriteLine("\nDemonstration for Windows:");
        uiB.DrawWindow();
    }

    static void DemonstrateBuilder()
    {
        var builder = new CarBuilder();

        var car = builder.Reset()
                         .SetEngine("V6")
                         .SetSeats("4")
                         .SetTripComputer("Advanced")
                         .SetGps("Integrated")
                         .Build();

        Console.WriteLine("\nBuilt car:");
        Console.WriteLine($"Engine: {car.Engine}, Seats: {car.Seats}, Trip Computer: {car.TripComputer}, GPS: {car.Gps}");
    }
}
