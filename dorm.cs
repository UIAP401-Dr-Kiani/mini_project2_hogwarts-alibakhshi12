namespace Hagwartz
{
    public class dorm
    {
        private string group;

        public string Group
        {
            get => group;
            set => group = value;
        }

        private long floor;

        public long Floor
        {
            get => floor;
            set => floor = value;
        }

        private long room;

        public long Room
        {
            get => room;
            set => room = value;
        }

        private long bed;

        public long Bed
        {
            get => bed;
            set => bed = value;
        }

        private Gender gender;

        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        private static int code;

        public static int Code
        {
            get => code;
            set => code = value;
        }

        private availableCode AvailableCode = new availableCode();

        public availableCode AvailableCode1
        {
            get => AvailableCode;
            set => AvailableCode = value;
        }

        public dorm()
        {
            Code = 101;
            while (Code%1000<700)
            {
                if (Code%10<6)
                {
                    this.AvailableCode1.AvailableCodeList.Add(Code);
                }

                Code++;
            }
        }
    }
}