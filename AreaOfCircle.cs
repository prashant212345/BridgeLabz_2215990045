//Write a program to calculate the area of a circle. Take the radius as input and use the formula: 
//Area = π * radius^2. 

using System;

class AreaOfCircle
{
    static void Main()
    {
        double radius, area;
        Console.Write("Enter the radius of the circle: ");
        radius = double.Parse(Console.ReadLine());
        area = Math.PI * radius * radius;
        Console.WriteLine("The area of the circle is: " + area);
    }
}