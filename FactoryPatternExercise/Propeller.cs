using System;
namespace FactoryPatternExercise
{
    public class Propeller : IAirplane
    {
        public Propeller()
        {
        }

        public void Fly()
        {
            Console.WriteLine("Building a new propeller airplane!");
        }
    }
}
