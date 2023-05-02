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
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password)
                {
                    return "login successfuly";
                    break;
                    
                }
                else
                {
                    if (i == ListOfAuthorizedPersons1.AuthorizedPersonsList.Count - 1)
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
        
    }
}