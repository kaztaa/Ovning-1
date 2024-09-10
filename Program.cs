using System;
using System.Collections.Generic;


//Skapa klassen för anställd
class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        // Skapa lista för anställda
        List<Employee> employeeRegister = new List<Employee>();

        bool continueAdding = true;


        //While loop så länge continueAdding är true
        while (continueAdding)
        {
            Console.WriteLine("\nAdd och list emplyee(s) or quit? (A/L/Q)");
            string answer = Console.ReadLine().ToLower();

            if (answer == "a")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter salary: ");
                decimal salary;

                // Provar ändra string till decimal
                while (!decimal.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Invalid salary, please try again: ");
                }

                // Skapa en ny instans av klassen Employee med namn och lön
                employeeRegister.Add(new Employee(name, salary));
            }
            else if (answer == "l")
            {
                // Skriv ut listan
                Console.WriteLine("\nEmployee Register:");
                foreach (var employee in employeeRegister)
                {
                    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
                }
            }
            else if (answer == "q") 
            {
                continueAdding = false;
                //Detta stoppar while loopen

            }
        }


    }
}
