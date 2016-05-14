using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Assignment
{
    class Program
    {
        static void GetInfoPerson(string whose) {
            Console.WriteLine("Enter the {0}'s first name: ", whose);
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s last name", whose);
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s Birthday", whose);
            string birthDate = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s address 01", whose);
            string addr01 = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s address 02", whose);
            string addr02 = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s city", whose);
            string city = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s state", whose);
            string state = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s zip code", whose);
            string zipCode = Console.ReadLine();
            Console.WriteLine("Enter the {0}'s country", whose);
            string county = Console.ReadLine();
            PrintPersonDetails(firstName, lastName, birthDate);
        } // method GetStudentInformation

        static void PrintPersonDetails(string first, string last, string birthday)
        {
            Console.WriteLine("First  Name: " + first);
            Console.WriteLine("Second Name: " + last);
            Console.WriteLine("Birthday   : " + birthday);
        } // method PrintPersonDetails

        static void GetInfoProgram() {
            Console.WriteLine("Enter the program name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the department head: ");
            string head = Console.ReadLine();
            Console.WriteLine("Enter the degree: ");
            string degree = Console.ReadLine();
            PrintProgramDetails(name, head, degree);
        } // end method GetInfoProgram

        static void PrintProgramDetails(string name, string head, string degree)
        {
            Console.WriteLine("Program Name:    " + name);
            Console.WriteLine("Department Head: " + head);
            Console.WriteLine("Degree:          " + degree);
        } // method PrintProgramDetails

        static void GetInfoDegree()
        {
            Console.WriteLine("Enter the degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the credits requirement: ");
            string credit = Console.ReadLine();
            PrintDegreeDetails(name, credit);
        } // end method GetInfoProgram

        static void PrintDegreeDetails(string name, string credit)
        {
            Console.WriteLine("Degree Name:        " + name);
            Console.WriteLine("Credit Requirement: " + credit);
        } // method PrintProgramDetails

        static void GetInfoCourse()
        {
            Console.WriteLine("Enter the course name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the credit: ");
            string credit = Console.ReadLine();
            Console.WriteLine("Enter the duration in weeks: ");
            string duration = Console.ReadLine();
            Console.WriteLine("Enter the teacher's name: ");
            string teacher = Console.ReadLine();
            PrintProgramDetails(name, credit, duration);
        } // end method GetInfoProgram

        static void PrintCourseDetails(string name, string credit, string duration)
        {
            Console.WriteLine("Course Name:         " + name);
            Console.WriteLine("credit:              " + credit);
            Console.WriteLine("duration (in weeks): " + duration);
        } // method PrintProgramDetails
        
        static void Main(string[] args)
        {
            GetInfoPerson("Student");
            GetInfoPerson("Teacher");
            GetInfoProgram();
            GetInfoDegree();
            GetInfoCourse();
        }
    }
}
