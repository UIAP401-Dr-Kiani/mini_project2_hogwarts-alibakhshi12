using System.Collections.Generic;

namespace Hagwartz
{
    public class admin:authorizedPersons
    {
        private List<dorm> dormsList = new List<dorm>();

        public List<dorm> DormsList
        {
            get => dormsList;
            set => dormsList = value;
        }
    }
}