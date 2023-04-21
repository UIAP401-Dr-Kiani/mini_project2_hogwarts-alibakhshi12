using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class student
    {
        private long passedUnits;

        public long PassedUnits
        {
            get => passedUnits;
            set => passedUnits = value;
        }

        private long term;

        public long Term
        {
            get => term;
            set => term = value;
        }

        private long dormNumber;

        public long DormNumber
        {
            get => dormNumber;
            set => dormNumber = value;
        }
    }
}