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
        
        public dorm()
        {
            Code = 101;
        }
    }
}