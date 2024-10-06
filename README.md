Resistor Color Code Utility
Overview
This is a simple C# console application that helps you determine the color codes of resistors based on standard resistor color-coding schemes. It allows users to look up the numerical values associated with color bands on a resistor and provides a list of all possible color bands.

Features
Displays a list of all available resistor colors.
Takes user input for a resistor color and returns the corresponding numeric value.
Validates user input and provides feedback if the entered color is invalid.
Requirements
.NET 6.0 or later
How to Run the Project
Clone the repository using the following command:

git clone https://github.com/yourusername/resistor_color.git
Navigate to the project directory:

cd resistor_color
Build and run the application:

dotnet run
Usage
When the program runs, it displays a list of all available resistor colors.
Enter a color name to get the corresponding color code value.
If the input is valid, the program displays the numeric code for that color.
If the input is invalid, an error message will be shown.
Example Output:

Color List: black, brown, red, orange, yellow, green, blue, violet, grey, white
Enter the color:
green
Color code for 'green' is: 5
Project Structure

resistor_color/
│   Program.cs         // Entry point of the application
│   ResistorColor.cs   // Contains logic for managing resistor colors
│   README.md          // This file
Code Explanation
The project contains two main classes:

Program:

Handles user interaction through the console.
Displays the list of available colors.
Takes user input and calls the ResistorColor class to retrieve the corresponding color code.
ResistorColor:

Contains a predefined list of colors in an array.
Provides a method (ColorCode) to look up the index of a color in the list.
Returns the entire list of colors through the Colors method.
