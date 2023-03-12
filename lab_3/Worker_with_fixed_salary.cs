using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_3
{
    internal class Worker_with_fixed_salary:Person
    {
        private decimal Salary { get; set; } = 100000;
        private protected int Premium { get; set; } = 50;

        public Worker_with_fixed_salary(decimal salary, int premium, string surname, string name, DateTime datebith, char gender)
            :base(surname, name, datebith, gender)
        {
            Salary = salary;
            Premium = premium;
        }

        public virtual decimal GetAllIncome()
        {
            return Salary + Salary*Premium/100;
        }

        public decimal GetNalog() 
        {
            return GetAllIncome() * 13 / 100;
        }

        public decimal GetIncome()
        {
            return GetAllIncome() - GetNalog() ;
        }

    }
}
