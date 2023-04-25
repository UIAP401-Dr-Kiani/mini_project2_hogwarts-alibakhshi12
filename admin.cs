using System;
using System.Collections.Generic;

namespace Hagwartz
{
    public class admin : authorizedPersons
    {
        private List<dorm> dormsList = new List<dorm>();

        public List<dorm> DormsList
        {
            get => dormsList;
            set => dormsList = value;
        }

        string login(string username, string password)
        {
            if (username == "AliBakhshi" && password == "1382")
            {
                return ("login successfully");
            }
            else
            {
                return ("Not found");
            }
        }

        void sendInvitation()
        {
            Program.authorizedPersonsDetector();
            for (int i = 0; i < Program.authorizedPersonsDetector().Length; i++)
            {
                if (Program.authorizedPersonsDetector()[i].Role == role.student)
                {
                    Program.authorizedPersonsDetector()[i].Letter.Add("Dear " + Program.authorizedPersonsDetector()[i].Name + " " + Program.authorizedPersonsDetector()[i].Family + ":" + "Welcome to Hagwartz");
                }
            }
        }

        void sendTicket(train _train)
        {
            Program.authorizedPersonsDetector();
            for (int i = 0; i < Program.authorizedPersonsDetector().Length; i++)
            {
                if (Program.authorizedPersonsDetector()[i].Role == role.student)
                {
                    Program.authorizedPersonsDetector()[i].Letter.Add("train name:"+_train.Name+"      "+"departure time:"+_train.DepartureTime+"           "+"cabin number"+_train.CabinNumber+"          "+"chair number:"+_train.ChairNumber);
                }

            }
        }

        
    }
}