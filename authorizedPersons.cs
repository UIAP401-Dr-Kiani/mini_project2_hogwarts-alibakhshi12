using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class authorizedPersons
    {
        private long roomNumber;

        public long RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }

        private List<string> curriculum = new List<string>();

        public List<string> Curriculum
        {
            get => curriculum;
            set => curriculum = value;
        }

        private Pet pet;

        public Pet Pet
        {
            get => pet;
            set => pet = value;
        }

        private group group;

        public group Group
        {
            get => group;
            set => group = value;
        }

        private bool havingLuggage;

        public bool HavingLuggage
        {
            get => havingLuggage;
            set => havingLuggage = value;
        }

        private role role;

        public role Role
        {
            get => role;
            set => role = value;
        }

        private List<string> letter = new List<string>();

        public List<string> Letter
        {
            get => letter;
            set => letter = value;
        }
    }
}