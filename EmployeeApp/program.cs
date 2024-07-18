using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            // Instantiate the second Employee object and assign values to its properties
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");

            // Change the Id of the second Employee object to match the first
            employee2.Id = 1;

            // Compare the two Employee objects again using the overloaded == operator
            areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine($"Are employee1 and employee2 equal after changing Id? {areEqual}");

            // Prevent the console from closing immediately
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
