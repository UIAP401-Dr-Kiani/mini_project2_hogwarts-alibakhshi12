using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class person
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        private string family;

        public string Family
        {
            get => family;
            set => family = value;
        }
        private string dateOfBirth;

        public string DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
        private Gender gender;

        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }
        private string father;

        public string Father
        {
            get => father;
            set => father = value;
        }
        private string username;

        public string Username
        {
            get => username;
            set => username = value;
        }
        private string password;

        public string Password
        {
            get => password;
            set => password = value;
        }
        private string type;

        public string Type
        {
            get => type;
            set => type = value;
        }
    }
}