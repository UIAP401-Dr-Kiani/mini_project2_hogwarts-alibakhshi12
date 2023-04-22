using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class teacher:authorizedPersons
    {
        private bool simultaneousTeaching;

        public bool SimultaneousTeaching
        {
            get => simultaneousTeaching;
            set => simultaneousTeaching = value;
        }
    }
}