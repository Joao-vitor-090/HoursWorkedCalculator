using System;

namespace aula42.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueperHour { get; set; }

        public Employee()
        {

        }
        public Employee(string name, int hours, double valueperhour)
        {
            Name = name; //nomed funcionário
            Hours = hours; //horas trabalhadas
            ValueperHour = valueperhour; //valor por horas

        }

        public double Payment() //total a pagar
        {
            return Hours* ValueperHour;
        }
    }


}
