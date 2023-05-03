using System;
using System.Collections.Generic;

namespace Hagwartz
{
    public class botany:lesson
    {
        private List<plant> semester1Plants = new List<plant>();

        public List<plant> Semester1Plants
        {
            get => semester1Plants;
            set => semester1Plants = value;
        }

        private List<plant> semester2Plants = new List<plant>();

        public List<plant> Semester2Plants
        {
            get => semester2Plants;
            set => semester2Plants = value;
        }

        private List<plant> semester3Plants = new List<plant>();

        public List<plant> Semester3Plants
        {
            get => semester3Plants;
            set => semester3Plants = value;
        }

        private List<plant> semester4Plants = new List<plant>();

        public List<plant> Semester4Plants
        {
            get => semester4Plants;
            set => semester4Plants = value;
        }

        public botany(int semester)
        {
            base.Name = "Botany";
            base.Capacity = 150;
            base.NumberOfStudents = 0;
            base.PresentationSemester = semester;
            if (semester==1)
            {
                base.Time = new DateTime(2023, 5, 10, 8, 0, 0);

            }
            else if (semester==2)
            {
                base.Time = new DateTime(2023, 9, 10, 8, 0, 0);
            }
            else if (semester==3)
            {
                base.Time = new DateTime(2024, 1, 10, 8, 0, 0);
            }
            else
            {
                base.Time = new DateTime(2024, 5, 10, 8, 0, 0);
            }

        }
    }
}