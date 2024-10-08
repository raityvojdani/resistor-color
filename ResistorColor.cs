using System;
using System.Linq;

namespace resistor_color
{
    /// <summary>
    /// Represents the Resistor Color Code Utility.
    /// </summary>
    internal class ResistorColor
    {
        /// <summary>
        /// Array of resistor colors.
        /// </summary>
        private static readonly string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        /// <summary>
        /// Gets the array of resistor colors.
        /// </summary>
        public static string[] Colors => colors;

        /// <summary>
        /// Gets the color code for the given color.
        /// </summary>
        /// <param name="color">The color name.</param>
        /// <returns>The color code, or -1 if the color is not found.</returns>
        public static int ColorCode(string color)
        {
            return Array.IndexOf(colors, color);
        }
    }
}
