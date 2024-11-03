namespace SOLIDprinciples
{
    //Задание 1
    public class Employee
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public double HourlyRate { get; private set; }

        public Employee(string name, string position, double hourlyRate)
        {
            Name = name;
            Position = position;
            HourlyRate = hourlyRate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: { Name}, Должность: { Position}, Почасовая ставка: { HourlyRate}");
        }
    }
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee, double hoursWorked)
        {
            return employee.HourlyRate * hoursWorked;
        }
    }


    //Задание 2
    public abstract class Discount
    {
        public abstract double Calculate(double originalPrice);
    }
    public class PercentageDiscount : Discount
    {
        private double _percentage;

        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }

        public override double Calculate(double originalPrice)
        {
            return originalPrice - (originalPrice * _percentage / 100);
        }
    }
    public class FixedAmountDiscount : Discount
    {
        private double _amount;

        public FixedAmountDiscount(double amount)
        {
            _amount = amount;
        }

        public override double Calculate(double originalPrice)
        {
            return originalPrice - _amount;
        }
    }

    //Задание 3
    public interface IFlyingBird
    {
        void Fly();
    }
    public class Bird
    {
        public string Name { get; private set; }

        public Bird(string name)
        {
            Name = name;
        }
        public void Sing()
        {
            Console.WriteLine($"{Name} поет!");
        }
    }
    public class FlyingBird : Bird, IFlyingBird
    {
        public FlyingBird(string name) : base(name)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} летит!");
        }
    }
    public class Penguin : Bird
    {
        public Penguin(string name) : base(name)
        {
        }
    }


    //Задание 4
    public interface IMultiFunctionPrinter
    {
        void Print(string document);
        void Scan(string document);
    }
    public interface IPrinter
    {
        void Print(string document);
    }
    public class MultiFunctionPrinter : IMultiFunctionPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печать документа: { document}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Сканирование документа: { document}");
        }
    }
    public class SimplePrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печать документа: {document}");
        }
    }


    //Задание 5
    public interface ILogger
    {
        void Log(string message);
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Лог в консоль: { message}");
        }
    }
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Лог в файл: { message}");
        }
    }
    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            _logger.Log("Приложение запущено");
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}

