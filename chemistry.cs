using System.Collections.Generic;

namespace Hagwartz
{
    public class chemistry:lesson
    {
        private List<string> chemicalMaterialsList = new List<string>();

        public List<string> ChemicalMaterialsList
        {
            get => chemicalMaterialsList;
            set => chemicalMaterialsList = value;
        }
    }
}