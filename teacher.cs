﻿using System;
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
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name && _family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family && _username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username && _password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password && this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.teacher)
                {
                    return "login successfuly";
                    break;
                    
                }
                else
                {
                    if (i == this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count - 1)
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
                if (username == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username &&
                    password == this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password)
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
            for (int i = 0; i <this. ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_teacherUsername==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_teacherPassword==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.teacher)
                {
                    for (int j = 0; j < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; j++)
                    {
                        if (_studentUsername==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Username&&_studentPassword==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Role==role.student)
                        {
                            for (int k = 0; k < this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Count; k++)
                            {
                                if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum[k]))
                                {
                                      this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum[k].Grade = _grade;
                                      if (_grade>=10)
                                      {
                                          this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Chart.Remove(this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum[k]);
                                      }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Graded successfully");
        }

        void creatBotanicalProject(string _name, string _family, string _username, string _password, List<plant> projectPlants,DateTime _deadline)
        {
            projectPlants = new List<plant>();
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.teacher)
                {
                    if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[1])||ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[2])||ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[3])||ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[4]))
                    {
                        for (int j = 0; j < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; j++)
                        {
                            if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Role==role.student)
                            {
                                if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Contains(ListOfLessons1.Lessons[1])||ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Contains(ListOfLessons1.Lessons[2])||ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Contains(ListOfLessons1.Lessons[3])||ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Contains(ListOfLessons1.Lessons[4]))
                                {
                                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].LsitOfProjectPlants.AddRange(projectPlants);
                                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Deadline.Add(_deadline);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Created successfully");
        }

        void confirmAnswer(int _grade, string _name, string _family, string _username, string _password)
        {
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.student)
                {
                   this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].GradeOfBotanicalProject.Add(_grade);
                    Console.WriteLine("Confirmed successfully");
                }
            }
        }

        void createChemicalProject(string _name, string _family, string _username, string _password, List<color> colors,DateTime _deadline)
        {
            colors = new List<color>();
            for (int i = 0; i < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; i++)
            {
                if (_name==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Name&&_family==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Family&&_username==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Username&&_password==this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Password&&this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Role==role.teacher)
                {
                    if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[i].Curriculum.Contains(ListOfLessons1.Lessons[0]))
                    {
                        for (int j = 0; j < this.ListOfAuthorizedPersons1.AuthorizedPersonsList.Count; j++)
                        {
                            if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Role==role.student)
                            {
                                if (this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Curriculum.Contains(ListOfLessons1.Lessons[0]))
                                {
                                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].ListOfProjectColors.AddRange(colors);
                                    this.ListOfAuthorizedPersons1.AuthorizedPersonsList[j].Deadline.Add(_deadline);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Created successfully");
        }
        
    }
}