using System.Collections.Generic;

namespace Hagwartz;

public class listOfColors
{
    private List<color> colorsList = new List<color>();

    public List<color> ColorsList
    {
        get => colorsList;
        set => colorsList = value;
    }

    public listOfColors()
    {
        ColorsList.Add(new color
        {
            Name = "Red",
            Measure = 100,
        });
        ColorsList.Add(new color
        {
            Name = "Blue",
            Measure = 100,
        });
        ColorsList.Add(new color
        {
            Name = "Yellow",
            Measure = 100,
        });
        ColorsList.Add(new color
        {
            Name = "Green",
            Measure = 100,
        });
        ColorsList.Add(new color
        {
            Name = "Purple",
            Measure = 100,
        });
        ColorsList.Add(new color
        {
            Name = "Orange",
            Measure = 100,
        });
        ColorsList.Add(new color
        {
            Name = "Pink",
            Measure = 100,
        });
    }
}