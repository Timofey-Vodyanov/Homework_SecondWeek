namespace OOPprinciples
{
    //Задание 1
    class BankAccount
    {
        private int _accountBalance;
        public int AccountBalance { get { return _accountBalance; } }
        public int withdraw(int amount)
        {
            _accountBalance -= amount;
            return amount;
        }
        public void topUp(int amount)
        {
            _accountBalance += amount;
        }
    }

    //Задание 2
    class Vehicle
    {
        public string ManufacturerName { get; set; } = "";
        public string Model { get; set; } = "";
    }
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }
    class Bicycle : Vehicle
    {
        public bool HasGear { get; set; }
    }

    //Задание 3
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав!");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Мяу!");
        }
    }

    //Задание 4
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius; // Площадь круга: π * r^2
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
