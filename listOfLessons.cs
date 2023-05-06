using System.Collections.Generic;

namespace Hagwartz;

public class listOfLessons
{
    private List<lesson> lessons = new List<lesson>();
    public List<lesson> Lessons
    {
        get => lessons;
        set => lessons = value;
    }

    private chemistry Chemistry = new chemistry();
    private botany Botany1 = new botany(1);
    private botany Botany2 = new botany(2);
    private botany Botany3 = new botany(3);
    private botany Botany4 = new botany(4);
    private magic Magic = new magic();
    private sport Sport = new sport();

    public listOfLessons()
    {
        this.Lessons.Add(Chemistry);
        this.Lessons.Add(Botany1);
        this.Lessons.Add(Botany2);
        this.Lessons.Add(Botany3);
        this.Lessons.Add(Botany4);
        this.Lessons.Add(Magic);
        this.Lessons.Add(Sport);
    }

}