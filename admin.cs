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

        private listOfAuthorizedPersons list = new listOfAuthorizedPersons();

        public listOfAuthorizedPersons List
        {
            get => list;
            set => list = value;
        }

        private listOfLessons lessons = new listOfLessons();

        public listOfLessons Lessons
        {
            get => lessons;
            set => lessons = value;
        }

        public string login(string username, string password)
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

        public void sendInvitation()
        {
            for (int i = 0; i < this.List.AuthorizedPersonsList.Count; i++)
            {
                if (this.List.AuthorizedPersonsList[i].Role == role.student)
                {
                    this.List.AuthorizedPersonsList[i].Letter.Add("Dear " + this.List.AuthorizedPersonsList[i].Name + " " + this.List.AuthorizedPersonsList[i].Family + ":" + "Welcome to Hagwartz");
                }
            }
            Console.WriteLine("Sended succesfully");
        }

        public void sendTicket(train _train)
        {
            for (int i = 0; i < this.List.AuthorizedPersonsList.Count; i++)
            {
                if (this.List.AuthorizedPersonsList[i].Role == role.student)
                {
                    this.List.AuthorizedPersonsList[i].Tickets.Add(_train);
                    this.List.AuthorizedPersonsList[i].Letter.Add("train name:"+_train.Name+"      "+"departure time:"+_train.DepartureTime+"           "+"cabin number"+_train.CabinNumber+"          "+"chair number:"+_train.ChairNumber);
                }

            }
            Console.WriteLine("sended successfully");
        }

        public void addLesson(DateTime _dateTime, long _numberOfStudents, long _capacity, long _presentationSemester,
            string _name)
        {
            lesson lesson = new lesson();
            lesson.Name = _name;
            lesson.Capacity = _capacity;
            lesson.NumberOfStudents = _numberOfStudents;
            lesson.PresentationSemester = _presentationSemester;
            lesson.Time = _dateTime;
            this.Lessons.Lessons.Add(lesson);
            Console.WriteLine("Added sucessfully");
        }

        public void showLesson()
        {
            for (int i = 0; i < this.Lessons.Lessons.Count; i++)
            {
                Console.WriteLine(this.Lessons.Lessons[i]);
            }
        }

        void showRequest()
        {
            for (int i = 0; i < base.Letter.Count; i++)
            {
                Console.WriteLine(base.Letter[i]);
            }
        }

        void sendAcceptedMessage()
        {
            for (int i = 0; i < List.AuthorizedPersonsList.Count; i++)
            {
                if (List.AuthorizedPersonsList[i].Role==role.student)
                {
                    this.List.AuthorizedPersonsList[i].Letter.Add("Hi "+List.AuthorizedPersonsList[i].Name+" "+List.AuthorizedPersonsList[i].Family+". I accepted your request.");
                }
            }
            Console.WriteLine("Sended successfully");
        }

        
    }
}