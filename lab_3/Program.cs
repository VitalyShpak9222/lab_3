using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Program
    {
        private static void Print(object a)
        {
            Console.WriteLine(a.ToString());
        }

        static void Main(string[] args)
        {
            string[] array_name = { "Николай", "Иван", "Лаврантий", "Дарина", "Альбина"};
            string[] array_surname = { "Васильев", "Кузнецов", "Соколов", "Оденцова", "Павлова"};
            char[] array_gender = { 'm', 'w', 'м', 'ж' };
            Console.WriteLine("О скольких людях выводить информацию?");
            int count = int.Parse(Console.ReadLine());
            Person[] people = new Person[count];
            Random x = new Random();
            for (int i = 0; i < count; i++) 
            {
                people[i] = new Person(array_surname[x.Next() % array_surname.Count()], array_name[x.Next() % array_name.Count()], DateTime.Now.AddYears(-x.Next(0, 100)), array_gender[x.Next() % array_gender.Count()]);
                people[i].GetSN();
                people[i].GetAge("1");
                people[i].GetGender();
                Console.WriteLine("------------------------------------------");
            }
            
            Console.WriteLine("тест класса рабочего с фиксированным окладом");
            Worker_with_fixed_salary[] worker_With_Fixed_Salaries = new Worker_with_fixed_salary[count];
            for (int i = 0; i < count; i++)
            {
                worker_With_Fixed_Salaries[i] = new Worker_with_fixed_salary(x.Next(), x.Next(10, 100), array_surname[x.Next() % array_surname.Count()], array_name[x.Next() % array_name.Count()], DateTime.Now.AddYears(-x.Next(0, 100)), array_gender[x.Next() % array_gender.Count()]);
                Print(worker_With_Fixed_Salaries[i].GetAllIncome());
                Print(worker_With_Fixed_Salaries[i].GetNalog());
                Print(worker_With_Fixed_Salaries[i].GetIncome());
                Console.WriteLine("-----------------------------------------");
            }


            Console.WriteLine("тест класса рабочего с почасовой оплатой");
            Worker_hour_payment[] worker_Hour_Payments = new Worker_hour_payment[count];
            for (int i = 0; i < count; i++)
            {
                worker_Hour_Payments[i] = new Worker_hour_payment(x.Next(10, 100), x.Next(100, 5000), x.Next(), x.Next(10, 100), array_surname[x.Next() % array_surname.Count()], array_name[x.Next() % array_name.Count()], DateTime.Now.AddYears(-x.Next(0, 100)), array_gender[x.Next() % array_gender.Count()]);
                Print(worker_Hour_Payments[i].GetAllIncome());
                Print(worker_Hour_Payments[i].GetNalog());
                Print(worker_Hour_Payments[i].GetIncome());
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
