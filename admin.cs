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

        private Program program = new Program();

        public Program Program
        {
            get => program;
            set => program = value;
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
            this.Program.authorizedPersonsDetector();
            for (int i = 0; i < this.Program.authorizedPersonsDetector().Length; i++)
            {
                if (this.Program.authorizedPersonsDetector()[i].Role == role.student)
                {
                    this.Program.authorizedPersonsDetector()[i].Letter.Add("Dear " + Program.authorizedPersonsDetector()[i].Name + " " + Program.authorizedPersonsDetector()[i].Family + ":" + "Welcome to Hagwartz");
                }
            }
        }

        void sendTicket(train _train)
        {
            this.Program.authorizedPersonsDetector();
            for (int i = 0; i < this.Program.authorizedPersonsDetector().Length; i++)
            {
                if (this.Program.authorizedPersonsDetector()[i].Role == role.student)
                {
                    this.Program.authorizedPersonsDetector()[i].Letter.Add("train name:"+_train.Name+"      "+"departure time:"+_train.DepartureTime+"           "+"cabin number"+_train.CabinNumber+"          "+"chair number:"+_train.ChairNumber);
                }

            }
        }

        
    }
}