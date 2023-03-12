using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Worker_hour_payment:Worker_with_fixed_salary
    {
        private int CountHours { get; set; } = 0;
        private decimal PaymentHours { get; set; } = 1000;


        public Worker_hour_payment(int countHours, decimal paymentHours, decimal salary, int premium, string surname, string name, DateTime datebith, char gender)
            : base(salary, premium, surname, name, datebith, gender)
        {
            CountHours = countHours;
            PaymentHours = paymentHours;
        }

        public override decimal GetAllIncome()
        {
            return PaymentHours * CountHours;
        }
    }
}
