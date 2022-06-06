using System;

namespace aula42.Entities
{
    class OutsourEmployee: Employee
    {

       public double AdditionalCharge { get; set; }

        public OutsourEmployee()
        {

        }
        public OutsourEmployee(string name, int hours, double valueperhour, double additionalcharge)
            :base(name,hours,valueperhour)
        {
            AdditionalCharge = additionalcharge;
        }
        public double payment()
        {

            return Hours * ValueperHour + (AdditionalCharge + 1.1); 
        }

    }
}
