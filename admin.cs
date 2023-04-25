using System;
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

        string login(string username, string password)
        {
            if (username=="AliBakhshi" && password=="1382")
            {
                return ("login successfully");
            }
            else
            {
                return null;
            }
        }
    }
}