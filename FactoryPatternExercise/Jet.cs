using System;
namespace FactoryPatternExercise
{
    public class Jet : IAirplane
    {
        public Jet()
        {
        }

        public void Fly()
        {
            Console.WriteLine("Building a new jet airplane!");
        }
    }
}
