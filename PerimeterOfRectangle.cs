//Write a program to calculate the perimeter of a rectangle. Take the length and width as inputs and use the formula: 
//Perimeter = 2 * (length + width).

using System;

class PerimeterOfRectangle
{
    static void Main()
    {
        double length, width, perimeter;
        Console.Write("Enter the length of the rectangle: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        width = double.Parse(Console.ReadLine());
        perimeter = 2 * (length + width);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }
}
 