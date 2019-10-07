using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Figure
    {
        protected double radius, width, height, side1, side2, side3;
        Random rand = new Random();
        string[] colors = { "Red", "Blue", "Green", "Black", "White" };
        public string getColor()
        {
            return colors[rand.Next(0, colors.Length)];
        }
        public void getInfo(string style, double perimeter, double area)
        {
            Console.Write("Name: " + style + "; Color: " + getColor() + "; Perimeter: " + perimeter + "; Area: " + area);
        }     
    }
    class Circle : Figure
    {
        const double PI = 3.141592653589793238463;
        public Circle(double radius)
        {
            this.radius = radius;
            getInfo("Cyrcle", 2 * PI * radius, PI * (radius *= radius));
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            getInfo((width == height ? "Square" : "Rectangle"), 2 * (width + height), width * height / 2);
        }
    }
    class Triangle : Figure
    {
        public Triangle(double side1,double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            double p = 0.5 * (side1 + side2 + side3);
            getInfo((side1 != side2 && side1 != side3 && side2 != side3 ? "Versatile" : (side1 == side2 && side1 == side3 && side2 == side3 ? "Equilateral" : "Isosceles")), side1 + side2 + side3, Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            string number;
            Console.WriteLine("Enter your figure: ");
            Console.WriteLine("\tFor circle 1, for rectangle 2, for triangle 3");
            number = Console.ReadLine();
            switch(number)
            {
                case "1":
                    Console.Write("Enter radius = ");
                    Figure circle = new Circle(Convert.ToDouble(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Enter width = ");
                    double w = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height = ");
                    Figure rectangle = new Rectangle(w, Convert.ToDouble(Console.ReadLine()));
                    break;
                case "3":
                    Console.Write("Enter side 1 = ");
                    double side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side 2 = ");
                    double side2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side 3 = ");
                    Figure triangle = new Triangle(side1, side2, Convert.ToDouble(Console.ReadLine()));
                    break;

            }
            Console.ReadKey();
        }
    }
}
