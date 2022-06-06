using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 100,
                MainColor = "green",
                MaximumOccupancy = 1
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 200,
                MainColor = "silver",
                MaximumOccupancy = 5
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 25,
                MainColor = "fluorescent orange",
                MaximumOccupancy = 4
            };
            Ram bigOleTruck = new Ram()
            {
                FuelCapacity = 18,
                MainColor = "dumb camo",
                MaximumOccupancy = 3,
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            bigOleTruck.Drive();

            fxs.Turn("right");
            modelS.Turn("right");
            mx410.Turn("right");
            bigOleTruck.Turn("right");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            bigOleTruck.Stop();
        }
    }
}
