using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Hagwartz;

public class main
{
    public static void hagwartz()
    {
        admin admin1 = new admin();
        teacher teacher1 = new teacher();
        student student1 = new student();
        while (true)
        {
            Console.WriteLine("1-Admin");
            Console.WriteLine("2-teacher");
            Console.WriteLine("3-student");
            Console.WriteLine("4-exit");
            int request0 = Convert.ToInt32(Console.ReadLine());
            if (request0==4)
            {
                break;
            }

            if (request0==1)
            {
                while (true)
                {
                    Console.WriteLine("1-login");
                    Console.WriteLine("2-exit");
                    int request1 = Convert.ToInt32((Console.ReadLine()));
                    if (request1==2)
                    {
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Enter your username:");
                            string username = Console.ReadLine();
                            Console.Write("Enter your password:");
                            string password = Console.ReadLine();
                            string message = admin1.login(username, password);
                            Console.WriteLine(message);
                            if (message=="Not found")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("1-send invitation");
                                Console.WriteLine("2-send ticket");
                                Console.WriteLine("3-add lesson");
                                Console.WriteLine("4-show lessons");
                                Console.WriteLine("5-show requests");
                                Console.WriteLine("6-send accepted message");
                                Console.WriteLine("7-exit");
                                int request2 = Convert.ToInt32(Console.ReadLine());
                                if (request2==7)
                                {
                                    break;
                                }
                                else if (request2==1)
                                {
                                    admin1.sendInvitation();
                                }
                                else if (request2==2)
                                {
                                    train train1 = new train();
                                    Console.Write("Enter name of train:");
                                    string name = Console.ReadLine();
                                    train1.Name = name;
                                    Console.Write("Enter capacity of train:");
                                    long capacity = Convert.ToInt64(Console.ReadLine());
                                    train1.Capacity = capacity;
                                    Console.Write("Enter cabin number of ticket:");
                                    long cabinNumber = Convert.ToInt64(Console.ReadLine());
                                    train1.CabinNumber = cabinNumber;
                                    Console.Write("Enter chair number of ticket:");
                                    long chairNumber = Convert.ToInt64(Console.ReadLine());
                                    train1.ChairNumber = chairNumber;
                                    Console.Write("Enter departure time of train");
                                    DateTime departureTime = Convert.ToDateTime(Console.ReadLine());
                                    train1.DepartureTime = departureTime;
                                    admin1.sendTicket(train1);
                                }
                                else if (request2==3)
                                {
                                    Console.Write("Enter name of lesson:");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter time of lesson");
                                    DateTime time = Convert.ToDateTime(Console.ReadLine());
                                    Console.Write("Enter number of students of lesson");
                                    long numberOfStudent = Convert.ToInt64(Console.ReadLine());
                                    Console.Write("Enter capacity of lesson:");
                                    long capacity = Convert.ToInt64(Console.ReadLine());
                                    Console.Write("Enter presentation semester of lesson:");
                                    long presentationSemester = Convert.ToInt64(Console.ReadLine());
                                    admin1.addLesson(time, numberOfStudent, capacity, presentationSemester, name);
                                }
                                else if (request2==4)
                                {
                                    admin1.showLesson();
                                }
                                else if (request2==5)
                                {
                                    admin1.showRequest();
                                }
                                else
                                {
                                    admin1.sendAcceptedMessage();
                                }
                            }
                        }
                    }
                }
            }
            else if (request0==2)
            {
                while (true)
                {
                    Console.WriteLine("1-login");
                    Console.WriteLine("2-exit");
                    int request1 = Convert.ToInt32(Console.ReadLine());
                    if (request1==2)
                    {
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Enter your name:");
                            string name = Console.ReadLine();
                            Console.Write("Enter your family:");
                            string family = Console.ReadLine();
                            Console.Write("Enter your username:");
                            string username = Console.ReadLine();
                            Console.Write("Enter your password");
                            string password = Console.ReadLine();
                            string message = teacher1.login(name, family, username, password);
                            Console.WriteLine(message);
                            if (message=="Not found")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("1-Choose courses");
                                Console.WriteLine("2-Assign grade");
                                Console.WriteLine("3-Create botanical project");
                                Console.WriteLine("4-Confirm answer of botanical project");
                                Console.WriteLine("5-Creat chemical project");
                                Console.WriteLine("6-Confirm answer of chemical project");
                                Console.WriteLine("7-exit");
                                int request2 = Convert.ToInt32(Console.ReadLine());
                                if (request2==7)
                                {
                                    break;
                                }
                                else if (request2==1)
                                {
                                    Console.Write("Enter number of lessons you have choosed:");
                                    int sizeOfCurriculum = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter simultaneous teaching status:");
                                    bool simultaneousTeaching = Convert.ToBoolean(Console.ReadLine());
                                    List<lesson> curriculum = new List<lesson>();
                                    for (int i = 0; i < sizeOfCurriculum; i++)
                                    {
                                        Console.Write("Enter name of lesson:");
                                        curriculum[i].Name = Console.ReadLine();
                                        Console.Write("Enter time of lesson:");
                                        curriculum[i].Time = Convert.ToDateTime(Console.ReadLine());
                                        Console.Write("Enter capacity of lesson:");
                                        curriculum[i].Capacity = Convert.ToInt64(Console.ReadLine());
                                        Console.Write("Enter presentation semester of lesson:");
                                        curriculum[i].PresentationSemester = Convert.ToInt64(Console.ReadLine());
                                        Console.Write("Enter number of students of lesson:");
                                        curriculum[i].NumberOfStudents = Convert.ToInt64(Console.ReadLine());
                                    }

                                    teacher1.chooseCourses(curriculum, username, password, simultaneousTeaching);
                                }
                                else if (request2==2)
                                {
                                    Console.Write("Enter grade of lesson:");
                                    long grade = Convert.ToInt64(Console.ReadLine());
                                    Console.Write("Enter username of student:");
                                    string studentUsername = Console.ReadLine();
                                    Console.Write("Enter password of student:");
                                    string studentPassword = Console.ReadLine();
                                    teacher1.assignGrade(grade, username, password, studentUsername, studentPassword);
                                }
                                else if (request2==3)
                                {
                                    Console.Write("Enter number of plants of botanical project:");
                                    int sizeOfPlants = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter deadline of this project:");
                                    DateTime deadline = Convert.ToDateTime(Console.ReadLine());
                                    List<plant> projectPlants = new List<plant>();
                                    for (int i = 0; i < sizeOfPlants; i++)
                                    {
                                        Console.Write("Enter name of plant:");
                                        projectPlants[i].Name = Console.ReadLine();
                                        Console.Write("Enter number of plant:");
                                        projectPlants[i].Number = Convert.ToInt64(Console.ReadLine());
                                    }

                                    teacher1.createBotanicalProject(name, family, username, password, projectPlants,
                                        deadline);
                                }
                                else if (request2==4)
                                {
                                    Console.Write("Enter grade of botanical project:");
                                    int grade = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter name of student:");
                                    string studentName = Console.ReadLine();
                                    Console.Write("Enter family of student:");
                                    string studentFamily = Console.ReadLine();
                                    Console.Write("Enter username of student:");
                                    string studentUsername = Console.ReadLine();
                                    Console.Write("Enter password of student:");
                                    string studentPassword = Console.ReadLine();
                                    teacher1.confirmAnswerOfBotanicalProject(grade, studentName, studentFamily,
                                        studentUsername, studentPassword);
                                }
                                else if (request2==5)
                                {
                                    Console.Write("Enter number of colors of chimical project:");
                                    int sizeOfColors = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter deadline of this project:");
                                    DateTime deadline = Convert.ToDateTime(Console.ReadLine());
                                    List<color> colors = new List<color>();
                                    for (int i = 0; i < sizeOfColors; i++)
                                    {
                                        Console.Write("Enter name of color:");
                                        colors[i].Name = Console.ReadLine();
                                        Console.Write("Enter measure of color:");
                                        colors[i].Measure = Convert.ToInt64(Console.ReadLine());
                                    }

                                    teacher1.createChemicalProject(name, family, username, password, colors, deadline);
                                }
                                else
                                {
                                    Console.Write("Enter name of student:");
                                    string studentName = Console.ReadLine();
                                    Console.Write("Enter family of student:");
                                    string studentFamily = Console.ReadLine();
                                    Console.Write("Enter username of student:");
                                    string studentUsername = Console.ReadLine();
                                    Console.Write("Enter password of student:");
                                    string studentPassword = Console.ReadLine();
                                    int grade=0;
                                    teacher1.confirmAnswerOfChemicalProject(studentName, studentFamily, studentUsername,
                                        studentPassword, grade);
                                }
                            }
                        } 
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("1-login");
                    Console.WriteLine("2-exit");
                    int request1 = Convert.ToInt32(Console.ReadLine());
                    if (request1==2)
                    {
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Enter your name:");
                            string name = Console.ReadLine();
                            Console.Write("Enter your family:");
                            string family = Console.ReadLine();
                            Console.Write("Enter your username:");
                            string username = Console.ReadLine();
                            Console.Write("Enter your password:");
                            string password = Console.ReadLine();
                            string message=student1.login(name, family, username, password);
                            Console.WriteLine(message);
                            if (message=="Not found")
                            {
                                continue;
                            }
                            else
                            {
                                string checktimeMessage=student1.checkTime(name,family,username,password);
                                Console.WriteLine(checktimeMessage);
                                if (checktimeMessage=="Unfortunately,you did not catch the train")
                                {
                                    break;
                                }
                                else
                                {
                                    student1.randomGroup(name, family, username, password);
                                    student1.randomCode(name, family, username, password);
                                    Console.WriteLine("1-Show invitation");
                                    Console.WriteLine("2-Show ticket");
                                    Console.WriteLine("3-Send return request");
                                    Console.WriteLine("4-Show Dumbeldor answer");
                                    Console.WriteLine("5-Choose courses");
                                    Console.WriteLine("6-Show chart");
                                    Console.WriteLine("7-Answer botanical project");
                                    Console.WriteLine("8-Show botanical project grade");
                                    Console.WriteLine("9-Answer chemical project");
                                    Console.WriteLine("10-Show chemical project grade");
                                    Console.WriteLine("11-Show overall portfolio");
                                    Console.WriteLine("12-exit");
                                    int request2 = Convert.ToInt32(Console.ReadLine());
                                    if (request2==12)
                                    {
                                        break;
                                    }
                                    else if (request2==1)
                                    {
                                        student1.showInvitation(name, family, username, password);
                                    }
                                    else if (request2==2)
                                    {
                                        student1.showTicket(name, family, username, password);
                                    }
                                    else if (request2==3)
                                    {
                                        student1.sendReturnRequest(name, family, username, password);
                                    }
                                    else if (request2==4)
                                    {
                                        student1.showDumbledoreAnswer(name, family, username, password);
                                    }
                                    else if (request2==5)
                                    {
                                        Console.Write("Enter number of lessons you have choosed:");
                                        int sizeOfCurriculum = Convert.ToInt32(Console.ReadLine());
                                        List<lesson> Curriculum = new List<lesson>();
                                        for (int i = 0; i < sizeOfCurriculum; i++)
                                        {
                                            Console.Write("Enter name of lesson:");
                                            Curriculum[i].Name = Console.ReadLine();
                                            Console.Write("Enter time of lesson:");
                                            Curriculum[i].Time = Convert.ToDateTime(Console.ReadLine());
                                            Console.Write("Enter capacity of lesson:");
                                            Curriculum[i].Capacity = Convert.ToInt64(Console.ReadLine());
                                            Console.Write("Enter presentation semester of lesson:");
                                            Curriculum[i].PresentationSemester = Convert.ToInt64(Console.ReadLine());
                                            Console.Write("Enter number of students of lesson:");
                                            Curriculum[i].NumberOfStudents = Convert.ToInt64(Console.ReadLine());
                                        }

                                        student1.chooseCourses(name, family, username, password, Curriculum);
                                    }
                                    else if (request2==6)
                                    {
                                        student1.showChart(name, family, username, password);
                                    }
                                    else if (request2==7)
                                    {
                                        student1.answerBotanicalProject(name, family, username, password);
                                    }
                                    else if (request2==8)
                                    {
                                        student1.showBotanicalProjectGrade(name, family, username, password);
                                    }
                                    else if (request2==9)
                                    {
                                        color answer = new color();
                                        Console.Write("Enter name of answer's color:");
                                        answer.Name = Console.ReadLine();
                                        Console.Write("Enter measure of answer's color:");
                                        answer.Measure = Convert.ToInt64(Console.ReadLine());
                                        student1.answerChemicalProject(name, family, username, password, answer);
                                    }
                                    else if (request2==10)
                                    {
                                        student1.showChemicalProjectGrade(name, family, username, password);
                                    }
                                    else if (request2==11)
                                    {
                                        student1.showOverallPortfolio(name, family, username, password);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}