using System;
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
                            }
                        }
                    }
                }
            }
            
        }
    }
}