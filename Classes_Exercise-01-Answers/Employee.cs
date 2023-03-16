using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_01_Answers
{
    public class Employee
    {
        
        private string _password;
        public string FirstName { get; set; }
        public char MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(string firstName, char middle, string lastName, string email, string phoneNumber, string title, DateTime dob)
        {
            FirstName = firstName;
            MiddleInitial = middle;
            LastName = lastName;
            EmailAddress = email;
            PhoneNumber = phoneNumber;
            Title = title;
            DateOfBirth = dob;
        }
        
        public static void SetPassword(Employee e, string pass)
        {
            e._password = pass;
        }
        public static void DisplayPassword(Employee e)
        {
            Console.WriteLine($"The password is {e._password}");
        }
        // TODO: Create an EmployeeReport() method that takes in an employee and returns all of the props creatively displayed to the console
        public static void EmployeeReport(Employee e)
        {
            Console.WriteLine($"First Name:\t{e.FirstName}\n");
            Console.WriteLine($"Middle Initial:\t{e.MiddleInitial}\n");
            Console.WriteLine($"Last Name:\t{e.LastName}\n");
            Console.WriteLine($"Email Address:\t{e.EmailAddress}\n");
            Console.WriteLine($"Phone Number:\t{e.PhoneNumber}\n");
            Console.WriteLine($"Title:\t{e.Title}\n");
            Console.WriteLine($"Date of Birth:/t{e.DateOfBirth}\n");
        }

    }




}

