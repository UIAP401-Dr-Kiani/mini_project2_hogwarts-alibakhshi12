using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class chemistry:lesson
    {
        private List<string> chemicalMaterialsList = new List<string>();

        public chemistry()
        {
            base.Name = "Chemistry";
            base.Capacity = 120;
            base.NumberOfStudents = 100;
            base.PresentationSemester = 1;
            base.Time = new DateTime(2023, 5, 10, 8, 0, 0);
        }
        
        public List<string> ChemicalMaterialsList
        {
            get => chemicalMaterialsList;
            set => chemicalMaterialsList = value;
        }
    }
}