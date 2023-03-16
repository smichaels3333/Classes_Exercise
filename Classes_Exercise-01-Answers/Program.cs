using System;
using System.Security.Cryptography.X509Certificates;

namespace Classes_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region// TODO: Create a public Employee class

            // Inside of the Employee class:
            // TODO: DONE - Create a private field _password of type string

            // TODO: DONE - Create a public FirstName property of type string
            // TODO: DONE - Create a public MiddleInitial property of type char
            // TODO: DONE - Create a public LastName property of type string
            // TODO: DONE - Create a public EmailAddress property of type string
            // TODO: DONE - Create a public PhoneNumber property of type string
            // TODO: DONE - Create a public Title property of type string
            // TODO: DONE - Create a public DateOfBirth property of type DateTime

            // TODO: DONE - Create a parameterized constructor that sets all of the properties correctly
            // Thought experiment: (True or False) We can instantiate this class with a default constructor
            // TODO: false (bc we created a parameterized constructor we overrided the default. So, if we want to be able to use the default we must explicitly type it out)

            // TODO: Create a method that sets the employee's password

            // TODO: DONE - Create a method to display the employee's password
            // TODO: Create an EmployeeReport() method that takes in an employee and returns all of the props creatively displayed to the console

            #endregion

            #region// TODO: Create a public Product class 

            // TODO: DONE - Create a public Product class

            // TODO: Create a private field _productID of type long
            // TODO: Create a private field _productCount of type int

            // TODO: Create a public Name property of type string
            // TODO: Create a public Price property of type double
            // TODO: Create a public CategoryID property of type int
            // TODO: Create a public OnSale property of type bool
            // TODO: Create a public StockLevel property of type int

            // TODO: Create a default constructor that increments the _productCount every time a new product is created
            // TODO: Create a parameterized constructor that does the same thing and initializes all of the properties

            // TODO: Create a method that gets the _productID and displays it creatively
            // TODO: Create a method that sets the _productID
            // TODO: Create a method that shows the current product count


            #endregion

            // TODO: Create a new employee and give all of its properties values
            var newEmployee = new Employee("John", 'C', "Smith","johnsmith@email.com", "(111) 111-1111", "Software Engineer",DateTime.Today);


            // TODO: Call all of the methods you created inside of that class
            Employee.SetPassword(newEmployee, "password");
            Employee.DisplayPassword(newEmployee);
            Employee.EmployeeReport(newEmployee);

            // TODO: Create a new product and give all of its properties values
            var newProduct = new Product()
            {
                Name = "PS6",
                Price = 599.99,
                CategoryID = 1,
                OnSale = true,
                StockLevel = 1,
            };

            // TODO: Call all of the methods you created inside of that class

            Product.ShowProductCount(newProduct);
            Product.AssignProductValue(newProduct,11);
            Product.ShowProductID(newProduct);

        }
    }
}
