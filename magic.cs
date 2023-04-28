using System;
using System.Collections.Generic;

namespace Hagwartz
{
    public class magic:lesson
    {
        private List<string> words = new List<string>();

        public List<string> Words
        {
            get => words;
            set => words = value;
        }

        public magic()
        {
            base.Name = "Magic";
            base.Capacity = 100;
            base.NumberOfStudents = 0;
            base.PresentationSemester = 3;
            base.Time = new DateTime(2024, 1, 10, 8, 0, 0);
        }
    }
}