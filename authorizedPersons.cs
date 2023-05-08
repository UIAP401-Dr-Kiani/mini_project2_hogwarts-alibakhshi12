using System;
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

        private List<plant> lsitOfProjectPlants = new List<plant>();

        public List<plant> LsitOfProjectPlants
        {
            get => lsitOfProjectPlants;
            set => lsitOfProjectPlants = value;
        }

        private List<DateTime> deadline = new List<DateTime>();

        public List<DateTime> Deadline
        {
            get => deadline;
            set => deadline = value;
        }

        private List<int> gradeOfBotanicalProject = new List<int>();

        public List<int> GradeOfBotanicalProject
        {
            get => gradeOfBotanicalProject;
            set => gradeOfBotanicalProject = value;
        }

        private List<color> listOfProjectColors = new List<color>();

        public List<color> ListOfProjectColors
        {
            get => listOfProjectColors;
            set => listOfProjectColors = value;
        }

        private List<int> gradeOfChemicalProject = new List<int>();

        public List<int> GradeOfChemicalProject
        {
            get => gradeOfChemicalProject;
            set => gradeOfChemicalProject = value;
        }

        private List<char> chemicalOperations = new List<char>();

        public List<char> ChemicalOperations
        {
            get => chemicalOperations;
            set => chemicalOperations = value;
        }

        private List<color> answerOfChemicalProject = new List<color>();

        public List<color> AnswerOfChemicalProject
        {
            get => answerOfChemicalProject;
            set => answerOfChemicalProject = value;
        }
    }
}