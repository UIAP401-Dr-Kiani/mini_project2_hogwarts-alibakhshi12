using System;

namespace Hagwartz.Properties;

public static class colorOperations
{
    static color A(color color1, color color2)
    {
        color1 = new color();
        color2 = new color();
        color color3 = new color();
        color3.Name = "Red";
        color3.Measure = 0;
        return color3;
    }

    static color B(color color1, color color2, color color3)
    {
        color1 = new color();
        color2 = new color();
        color3 = new color();
        color color4 = new color();
        color4.Name = "Green";
        color4.Measure = 0;
        return color4;
    }

    static color C(color color1, color color2, color color3, color color4)
    {
        color1 = new color();
        color2 = new color();
        color3 = new color();
        color4 = new color();
        color color5 = new color();
        color5.Name = "Blue";
        color5.Measure = 0;
        return color5;
    }
}