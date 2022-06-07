using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicles
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage {get; set;} = 26;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by playing music obnoxiously loud. 'some overplayed pop country song'");
        }

        public override void Turn(string direction)
        {
           Console.WriteLine($"The {MainColor} Ram turned {direction} without using their blinker. Classic.");
        }
    }
}