using System;

namespace Hagwartz;

public class sport:lesson
{
    private sportsType typeOfSport;

    public sportsType TypeOfSport
    {
        get => typeOfSport;
        set => typeOfSport = value;
    }

    public sport()
    {
        base.Name = "Sport";
        base.Capacity = 200;
        base.NumberOfStudents = 0;
        base.PresentationSemester = 4;
        base.Time = new DateTime(2024, 5, 10, 8, 0, 0);
    }
    
}