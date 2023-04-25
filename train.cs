using System;

namespace Hagwartz
{
    public class train
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        private long capacity;

        public long Capacity
        {
            get => capacity;
            set => capacity = value;
        }
        private long cabinNumber;

        public long CabinNumber
        {
            get => cabinNumber;
            set => cabinNumber = value;
        }
        private long chairNumber;

        public long ChairNumber
        {
            get => chairNumber;
            set => chairNumber = value;
        }
        private DateTime departureTime;

        public DateTime DepartureTime
        {
            get => departureTime;
            set => departureTime = value;
        }
    }
}