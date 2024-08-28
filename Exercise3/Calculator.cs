using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises.Exercise3
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
        public string Add(string a, string b) => a + b;
    }
    public class Employee
    {
        public virtual string GetRole() => "Employee";
    }

    public class Manager : Employee
    {
        public override string GetRole() => "Manager";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"Add int: {calc.Add(5, 10)}");
            Console.WriteLine($"Add double: {calc.Add(5.5, 10.5)}");
            Console.WriteLine($"Add string: {calc.Add("Hello, ", "World!")}");

            Employee emp = new Manager();
            Console.WriteLine($"Role: {emp.GetRole()}");
        }
    }
}
