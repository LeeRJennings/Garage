using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage {get; set;} = 42;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past. Zoooooom!");
        }
    }
}