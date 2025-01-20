//Write a program to calculate the volume of a cylinder. Take the radius and height as inputs and use the formula: 
//Volume = π * radius^2 * height.

using System;

class VolumeOfCylinder
{
    static void Main()
    {
        double radius, height, volume;
        Console.Write("Enter the radius of the cylinder: ");
        radius = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the cylinder: ");
        height = double.Parse(Console.ReadLine());
        volume = Math.PI * radius * radius * height;
        Console.WriteLine("The volume of the cylinder is: " + volume);
    }
}