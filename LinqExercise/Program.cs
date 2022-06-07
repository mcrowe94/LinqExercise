using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            var average = numbers.Average();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");


            //TODO: Print the Average of numbers

            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(num => num);
            Console.WriteLine("----------------------");
            Console.WriteLine("Ascending");

            foreach (var num in ascending)
            {
                Console.WriteLine(num);
            }


            var descending = numbers.OrderByDescending(x => x);
            Console.WriteLine("----------------------");
            Console.WriteLine("Descending");

            foreach (var num in descending)
            {
                Console.WriteLine(num);
            }
            

            //TODO: Order numbers in decsending order adn print to the console

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(num => num > 6);

            Console.WriteLine("Greater that 6");

            foreach (var num in greaterThanSix)
            {
                Console.WriteLine(num);
            }


            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var firstFour = ascending.Take(4);

            Console.WriteLine("First 4 ascending");

            foreach (var num in firstFour)
            {
                Console.WriteLine(num);
            }



            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 27;
            Console.WriteLine("With my age:");
            foreach (var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(item);
            }



            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            var filtered = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);

            Console.WriteLine("C or S Employees");
            foreach (var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
            }


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where(person => person.Age > 26).OrderBy(person => person.Age).ThenBy(person => person.FirstName).ThenBy(person => person.YearsOfExperience);

            Console.WriteLine("Over 26");
            foreach (var person in overTwentySix)
            {
                Console.WriteLine($"Age : {person.Age} Full Name: {person.FullName} YOE: {person.YearsOfExperience}");

            }


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            var yoeEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sumOfYOE = yoeEmployees.Sum(employee => employee.YearsOfExperience);
            var averageOfYOE = yoeEmployees.Average(employee => employee.YearsOfExperience);

            Console.WriteLine($"Sum {sumOfYOE} Average {averageOfYOE}");


            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Monica", "Crowe", 27, 1)).ToList();

            foreach (var item in employees )
            {
               Console.WriteLine($"{item.FirstName} {item.Age} {item.YearsOfExperience}");
            }





            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
