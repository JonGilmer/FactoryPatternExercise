using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string planeType = "";

            Console.WriteLine("Do you want to fly a plane with engines or propellers?");
            Console.WriteLine("\t(Type \"engines\" or \"propellers\" to choose)");
            planeType = Console.ReadLine();

            var yourPlane = AirplaneFactory.GetAirplane(planeType);
            yourPlane.Fly();
            Console.ReadKey();
        }
    }
}
