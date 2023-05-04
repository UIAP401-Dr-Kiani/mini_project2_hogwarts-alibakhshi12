﻿using System;
using System.Collections.Generic;
namespace Hagwartz
{
    public class authorizedPersons:person
    {
        private long roomNumber;

        public long RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }

        private List<lesson> curriculum = new List<lesson>();

        public List<lesson> Curriculum
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
        private List<train> tickets = new List<train>();

        public List<train> Tickets
        {
            get => tickets;
            set => tickets = value;
        }

        private listOfLessons ListOfLessons = new listOfLessons();

        private List<lesson> chart = new List<lesson>();

        public List<lesson> Chart
        {
            get => chart;
            set => chart =ListOfLessons.Lessons;
        }
    }
}