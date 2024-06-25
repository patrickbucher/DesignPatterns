using System.Runtime.CompilerServices;
using System;

namespace ParkingLot
{
    public class ParkingLot
    {
        public string Name { get; }
        public int Capacity { get; }
        public int Occupied { get; set; }

        public ParkingLot(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Occupied = 0;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Enter()
        {
            if (Occupied < Capacity)
            {
                Occupied++;
            }
            else
            {
                throw new InvalidOperationException("parking lot is full");
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Exit()
        {
            if (Occupied > 0)
            {
                Occupied--;
            }
            else
            {
                throw new InvalidOperationException("parking lot is empty");
            }
        }
    }
}
