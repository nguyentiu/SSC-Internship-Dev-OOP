using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises.Exercise1
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public void SetName(string name) => this.name = name;
        public string GetName() => name;
        public void SetAge(int age) => this.age = age;
        public int GetAge() => age;
        public void SetEmail(string email) => this.email = email;
        public string GetEmail() => email;
    }

    public class Student : Person
    {
        public string StudentID { get; set; }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {GetName()}, Age: {GetAge()}, Email: {GetEmail()}, Student ID: {StudentID}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("John Doe");
            student.SetAge(21);
            student.SetEmail("john.doe@example.com");
            student.StudentID = "S12345";
            student.DisplayStudentInfo();
        }
    }
}
