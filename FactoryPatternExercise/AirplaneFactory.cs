using System;
namespace FactoryPatternExercise
{
    public class AirplaneFactory
    {
        public AirplaneFactory()
        {
        }


        public static IAirplane GetAirplane(string planeType)
        {
            string airplane = "engines";
            switch (airplane)
            {
                case "engines":
                    return new Jet();
                case "propellers":
                    return new Propeller();
                default:
                    return new Propeller();

            }
        }
    }
}
