using System;

namespace Hagwartz
{
    public class lesson
    {
        private DateTime time;

        public DateTime Time
        {
            get => time;
            set => time = value;
        }
        private long numberOfStudents;

        public long NumberOfStudents
        {
            get => numberOfStudents;
            set => numberOfStudents = value;
        }
        private long capacity;

        public long Capacity
        {
            get => capacity;
            set => capacity = value;
        }
        private long presentationSemester;

        public long PresentationSemester
        {
            get => presentationSemester;
            set => presentationSemester = value;
        }
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        private long grade;

        public long Grade
        {
            get => grade;
            set => grade = value;
        }
    }
}