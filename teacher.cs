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
                if (_name==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password && ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.teacher)
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

        void chooseCourses(List<lesson>Curriculum,string username,string password,bool simaltaneousTeaching)
        {
            Curriculum = new List<lesson>();
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (username == ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username &&
                    password == ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password)
                {
                    if (simaltaneousTeaching == true)
                    {
                        this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.AddRange(Curriculum);
                        Console.WriteLine("Choosed Succesfully");
                    }
                    else
                    {
                        for (int j = 1; j < Curriculum.Count+1; j++)
                        {
                            if (Curriculum[j].Time ==Curriculum[j-1].Time )
                            {
                                Curriculum.RemoveAt(j);
                            }
                        }
                        this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.AddRange(Curriculum);
                        Console.WriteLine("Choosed Succesfully");
                    }
                }
            }
        }

        void assignGrade(long _grade,string _teacherUsername, string _teacherPassword, string _studentUsername,
            string _studentPassword)
        {
            for (int i = 0; i < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_teacherUsername==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_teacherPassword==ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.teacher)
                {
                    for (int j = 0; j < ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; j++)
                    {
                        if (_studentUsername==ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Username&&_studentPassword==ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Password&&ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Role==role.student)
                        {
                            for (int k = 0; k < this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Count; k++)
                            {
                                if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum[k]))
                                {
                                      this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum[k].Grade = _grade;
                                      if (_grade>=10)
                                      {
                                          this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Chart.Remove(ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum[k]);
                                      }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Graded successfully");
        }
        
    }
}