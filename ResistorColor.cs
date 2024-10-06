using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resistor_color;
internal class ResistorColor
{
    public static string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {

        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i] == color) { return i; }

        }
        return -1;
    }

    public static string[] Colors()
    {
        return colors;
    }
}
