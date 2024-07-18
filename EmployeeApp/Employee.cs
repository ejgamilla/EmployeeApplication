using System;

namespace EmployeeApp
{
    // Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one of the objects is null, return false
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            // Compare the Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to compare Employee objects by Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method to match the behavior of the overloaded == operator
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return this.Id == employee.Id;
            }
            return false;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
