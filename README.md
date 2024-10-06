# 📊 Resistor Color Code Utility


## 📝 Overview
This project is a C# console application designed to help users determine the numerical values associated with resistor color codes. It displays a list of standard resistor color bands and allows the user to input a color to retrieve its numeric value.

The resistor color code is a way of representing resistance values using color bands. Each color has a specific value, and this utility makes it easy to look up those values without memorizing them.

## 🚀 Features
- Displays a list of all available resistor color bands.
- Accepts user input for a resistor color and returns the corresponding numeric value.
- Validates user input and provides feedback if the entered color is not part of the standard list.





## 💻 Requirements
- **.NET 6.0 SDK or later** (to build and run the project)

## 🛠 Installation
1. Clone the repository using the following command:
   ```bash
   git clone https://github.com/yourusername/resistor_color.git


## 📖 Usage
When the application starts, it displays the full list of resistor color bands.
Enter a color name (e.g., red, blue, green) when prompted.
The application will display the corresponding color code value.
If you enter an invalid color name, the program will notify you to enter a valid color from the list.


## 📌 Example Output
Here’s an example of what the output might look like:

```yaml
Color List: black, brown, red, orange, yellow, green, blue, violet, grey, white


Enter the color:
green
Color code for 'green' is: 5
```
If an invalid color is entered:

```css
Invalid color 'pink' entered. Please enter a valid color from the list.
```

## 📜 Code Explanation
The project consists of two primary classes:

Program:

The entry point of the application.
Handles user interaction and displays the color list.
Collects user input and calls the ResistorColor class for code lookups.
ResistorColor:

Contains a predefined array of colors.
Provides a method (ColorCode) to find the index (numeric value) of a color.
Returns the list of colors using the Colors method.
🔍 Color Code Mapping
Color	Code
Black	0
Brown	1
Red	2
Orange	3
Yellow	4
Green	5
Blue	6
Violet	7
Grey	8
White	9
