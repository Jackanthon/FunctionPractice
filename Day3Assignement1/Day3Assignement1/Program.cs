using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Hello, please choose from a list of options to find area: ");
            Console.WriteLine("Please choose which area you'd like to recieve.\n1. Area of triangle\n2. Area of square\n3. Area of rectangle");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 2)
            {
                Console.WriteLine("You choose square. Enter one side please.");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Now give me required either two sides or base and height");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            
            switch(choice)
            {
                case 1: AreaOfTriangle(num1, num2);
                    int area = AreaOfTriangle(num1, num2);
                    Console.WriteLine("Area of triangle: "+area);
                    break;
                case 2: AreaOfSquare(num1);
                    area = AreaOfSquare(num1);
                    Console.WriteLine("Area of square: "+area);
                    break;
                case 3: AreaOfRectangle(num1, num2);
                    area = AreaOfRectangle(num1, num2);
                    Console.WriteLine("Area of rectangle: "+area);
                    break;

            }
            Console.ReadLine();
        }
        static int AreaOfTriangle(int bottom, int height)
        {
            return (bottom * height) / 2;
        }
        static int AreaOfSquare(int side)
        {
            return side * side;
        }
        static int AreaOfRectangle(int side1, int side2)
        {
            return side1 * side2;
        }
    }
}
//Write a program in C# to calculate area of triangle, square and rectangle.
//Write 3 different functions for each shape to take dimensions of figure and display the area.
//You may create menus.

