using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class person
    {
        private string firstName;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        private string lastName;

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        private long birthYear;

        public long BirthYear
        {
            get => birthYear;
            set => birthYear = value;
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
        private breedType breed;

        public breedType Breed
        {
            get => breed;
            set => breed = value;
        }
    }
}