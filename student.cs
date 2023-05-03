using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class student:authorizedPersons
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
        
        private listOfAuthorizedPersons ListOfAuthorizedPersons = new listOfAuthorizedPersons();

        public listOfAuthorizedPersons ListOfAuthorizedPersons1
        {
            get => ListOfAuthorizedPersons;
            set => ListOfAuthorizedPersons = value;
        }

        string login(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name == ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name &&
                    _family == ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family &&
                    _username == ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username &&
                    _password == ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password &&
                    ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role == role.student)
                {
                    return "login successfully";
                }
                else
                {
                    if (i==ListOfAuthorizedPersons1.AuthorizedPersonsList.Count-1)
                    {
                        return "Not found";
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return null;
        }

        void checkTime(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password && ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    if (ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Tickets[0].DepartureTime.CompareTo(DateTime.Now)==-1)
                    {
                        Console.WriteLine("Congratulations,you have reached the train");
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately,you did not catch the train");
                    }
                }
            }
        }

        void showInvitation(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password)
                {
                    Console.WriteLine(ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Letter[0]);
                }
            }
        }

        void showTicket(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password)
                {
                    Console.WriteLine(ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Letter[1]);
                }
            }
        }
        
    }
}