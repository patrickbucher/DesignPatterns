using System.Threading;
using System;

namespace ParkingLot
{
    class Program
    {
        private const int maxFillIntervalMillis = 1000;
        private const int maxEmptyIntervalMillis = 2000;
        private const int initialFillPhaseMillis = 5000;
        private const int refreshDisplayIntervalMillis = 250;

        static void Main(string[] args)
        {
            ParkingLot lot = new("Bahnhof Parking", 100);
            Thread fill = new(Program.Fill);
            Thread empty = new(Program.Empty);
            Thread display = new(Program.DisplayState);

            display.Start(lot);
            fill.Start(lot);
            Thread.Sleep(initialFillPhaseMillis);
            empty.Start(lot);

            fill.Join();
            empty.Join();
            display.Join();
        }

        public static void Fill(object? data)
        {
            if (data == null)
            {
                throw new Exception("data must be a valid parking lot");
            }
            Random random = new();
            ParkingLot lot = (ParkingLot)data;
            while (lot.Occupied < lot.Capacity)
            {
                lot.Enter();
                Thread.Sleep(random.Next() % maxFillIntervalMillis);
                Console.WriteLine($"A car entered the lot '{lot.Name}'.");
            }
        }

        public static void Empty(object? data)
        {
            if (data == null)
            {
                throw new Exception("data must be a valid parking lot");
            }
            Random random = new();
            ParkingLot lot = (ParkingLot)data;
            while (lot.Occupied > 0)
            {
                lot.Exit();
                Thread.Sleep(random.Next() % maxEmptyIntervalMillis);
                Console.WriteLine($"A car left the lot '{lot.Name}'.");
            }
        }

        public static void DisplayState(object? data)
        {
            if (data == null)
            {
                throw new Exception("data must be a valid parking lot");
            }
            ParkingLot lot = (ParkingLot)data;
            while (true)
            {
                Console.WriteLine($"{lot.Name}: {lot.Occupied}/{lot.Capacity} occupied");
                Thread.Sleep(refreshDisplayIntervalMillis);
            }
        }
    }
}
