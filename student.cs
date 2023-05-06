using System;
using System.Collections.Generic;
using static System.Random;
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
        admin admin = new admin();

        public admin Admin
        {
            get => admin;
            set => admin = value;
        }

        private availableCode AvailableCode = new availableCode();

        public availableCode AvailableCode1
        {
            get => AvailableCode;
            set => AvailableCode = value;
        }

        private listOfLessons ListOfLessons = new listOfLessons();

        public listOfLessons ListOfLessons1
        {
            get => ListOfLessons;
            set => ListOfLessons = value;
        }

        string login(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name &&
                    _family == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family &&
                    _username == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username &&
                    _password == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password &&
                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role == role.student)
                {
                    return "login successfully";
                }
                else
                {
                    if (i==this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count-1)
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

        string checkTime(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password && this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Tickets[0].DepartureTime.CompareTo(DateTime.Now)==-1)
                    {
                        return ("Congratulations,you have reached the train");
                    }
                    else
                    {
                        return ("Unfortunately,you did not catch the train");
                    }
                }
            }

            return null;
        }

        void showInvitation(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    Console.WriteLine(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Letter[0]);
                }
            }
        }

        void showTicket(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    Console.WriteLine(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Letter[1]);
                }
            }
        }

        void sendReturnRequest(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password && ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    this.Admin.Letter.Add("Hi Dumbledore, I'm "+ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name+" "+ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family+". I want to go my city");
                    Console.WriteLine("Sended successfully");
                }
            }
        }

        void showDumbledoreAnswer(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password && ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    Console.WriteLine(ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Letter[2]);
                }
            }
        }

        void randomGroup(string _name,string _family,string _username,string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&& _family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    this.ListOfAuthorizedPersons.AuthorizedPersonsList[i].Group.Type = (Type) new Random().Next();
                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Group.Score = new Random().Next();
                    Console.WriteLine("Successfully attributed");
                }
            }
        }

        void randomCode(string _name,string _family,string _username,string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name &&
                    _family == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family &&
                    _username == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username &&
                    _password == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password &&
                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role == role.student)
                {
                    int random = new Random().Next(0, 300);
                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].RoomNumber =
                        AvailableCode1.AvailableCodeList[random];
                    this.AvailableCode1.AvailableCodeList.RemoveAt(random);
                    Console.WriteLine("Successfully attributed");
                }
            }
        }

        void chooseCourses(string _name, string _family, string _username, string _password,List<lesson>Curriculum)
        {
            Curriculum = new List<lesson>();
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    if (Curriculum.Count>5&&Curriculum.Count<4)
                    {
                      Console.WriteLine("The number of courses selected has exceeded the limit"); 
                      break;
                    }
                    
                    for (int j = 1; j < Curriculum.Count+1; j++)
                    {
                        if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Chart.Contains(Curriculum[j - 1]))
                        {

                            if (Curriculum[j - 1].NumberOfStudents >= Curriculum[j - 1].Capacity)
                            {
                                Curriculum.RemoveAt(j - 1);
                            }

                            if (Curriculum[j].Time == Curriculum[j - 1].Time)
                            {
                                Curriculum.RemoveAt(j);
                            }
                            this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.AddRange(Curriculum);

                        }
                    }
                    Console.WriteLine("Choosed successfully");
                }
            }
        }

        void showChart(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    for (int j = 0; j < this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Chart.Count; j++)
                    {
                        Console.WriteLine(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Chart[j]);
                    }
                }
            }
        }

        void answerBotanicalProject(string _name,string _family,string _username,string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[1])||ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[2])||ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[3])||ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[4]))
                    {
                        if (DateTime.Now.CompareTo(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Deadline[0]) == -1)
                        {
                            Console.WriteLine("Your answer is sended");
                        }
                        else
                        {
                            Console.WriteLine("Sorry! it was too late to send your answer");
                        }
                    }
                }
            }
        }

        void showBotanicalProjectGrade(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    for (int j = 0; j < this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].GradeOfBotanicalProject.Count; j++)
                    {
                        Console.Write("your grade");
                        Console.Write(j+1);
                        Console.Write(":");
                        Console.WriteLine(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].GradeOfBotanicalProject[j]);
                    }
                }
            }
        }

        void answerChemicalProject(string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                    if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[0]))
                    {
                        if (DateTime.Now.CompareTo(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Deadline[1])==-1)
                        {
                            Console.WriteLine("Your answer is sended");
                        }
                        else
                        {
                            Console.WriteLine("Sorry! it was too late to send your answer");
                        }
                    }
                }
            }
        }
        
    }
}