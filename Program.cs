namespace resistor_color;

/// <summary>
/// Main program class for the Resistor Color Code Utility.
/// </summary>
internal class Program
{
    /// <summary>
    /// Main method to run the Resistor Color Code Utility.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static void Main(string[] args)
    {
        DisplayColorList();
        string? inputColor = GetUserInput();
        DisplayColorCode(inputColor);
    }

    /// <summary>
    /// Displays the list of resistor colors.
    /// </summary>
    private static void DisplayColorList()
    {
        Console.WriteLine("Color List: " + string.Join(", ", ResistorColor.Colors()));
    }

    /// <summary>
    /// Gets the user input for the resistor color.
    /// </summary>
    /// <returns>The user input color.</returns>
    private static string? GetUserInput()
    {
        Console.WriteLine("Enter the color:");
        return Console.ReadLine()?.Trim().ToLower();
    }

    /// <summary>
    /// Displays the color code for the given color.
    /// </summary>
    /// <param name="inputColor">The input color.</param>
    private static void DisplayColorCode(string? inputColor)
    {
        int colorCode = ResistorColor.ColorCode(inputColor);

        if (colorCode != -1)
        {
            Console.WriteLine($"Color code for '{inputColor}' is: {colorCode}");
        }
        else
        {
            Console.WriteLine($"Invalid color '{inputColor}' entered. Please enter a valid color from the list.");
        }
    }
}
