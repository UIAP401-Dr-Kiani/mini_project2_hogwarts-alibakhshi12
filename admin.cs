﻿using System;
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

        private listOfAuthorizedPersons list = new listOfAuthorizedPersons();

        public listOfAuthorizedPersons List
        {
            get => list;
            set => list = value;
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
            for (int i = 0; i < this.List.AuthorizedPersonsList.Count; i++)
            {
                if (this.List.AuthorizedPersonsList[i].Role == role.student)
                {
                    this.List.AuthorizedPersonsList[i].Letter.Add("Dear " + this.List.AuthorizedPersonsList[i].Name + " " + this.List.AuthorizedPersonsList[i].Family + ":" + "Welcome to Hagwartz");
                }
            }
        }

        void sendTicket(train _train)
        {
            for (int i = 0; i < this.List.AuthorizedPersonsList.Count; i++)
            {
                if (this.List.AuthorizedPersonsList[i].Role == role.student)
                {
                    this.List.AuthorizedPersonsList[i].Letter.Add("train name:"+_train.Name+"      "+"departure time:"+_train.DepartureTime+"           "+"cabin number"+_train.CabinNumber+"          "+"chair number:"+_train.ChairNumber);
                }

            }
        }

        
    }
}