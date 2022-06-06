using System;
using System.Globalization;
using System.Collections.Generic;
using aula42.Entities;


namespace aula42
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>(); // instânciação de Lista de funcionários

            Console.WriteLine("Enter the number of Employees : "); //Insira a quantidade de funcionários : 
            int N = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < N; i++)
            {
                Console.Write("Outsourced ?(y/n)  : "); //Tercerizado ?
                char ch = char.Parse(Console.ReadLine());
                if (ch != 'y' && ch != 'Y' && ch != 'n' && ch != 'N')
                {
                    Console.WriteLine("Error ! Please enter a valid value!"); //erro!Entre com um valor válido
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Employee name : "); //Entre com o nome do empregado
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter user hours worked : ");//Insira as horas trabalhadas do usuário
                    int hours = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much does the employee earn per hour?"); // Quanto o funcionário ganha por hora
                    double ValueperHour = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (ch == 'y' || ch == 'Y')
                    {
                        Console.WriteLine("Enter the value of the subcontractor's bonus : "); //Entre com o valor da bonificação do terceirizado 
                        double AdditionalCharge = double.Parse(Console.ReadLine());
                        employees.Add(new OutsourEmployee(name, hours, ValueperHour, AdditionalCharge));
                    }
                    else
                    {
                        employees.Add(new Employee(name, hours ,ValueperHour));
                    }
                    Console.WriteLine( );
                    Console.WriteLine("PAYMENTS:");
                    foreach (Employee emp in employees)
                    {
                        Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }

        }
    }
}
