namespace resistor_color;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Color List: " + string.Join(", ", ResistorColor.Colors()));

        Console.WriteLine("Enter the color:");
        string? inputColor = Console.ReadLine()?.Trim().ToLower();

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
