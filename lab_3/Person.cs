using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Person
    {
        private protected string Surname { get; set; }
        private protected string Name { get; set; }
        private protected DateTime DateBirth { get; set; }
        private protected char gender;
        private protected char Gender
        {
            set
            {
                gender = 'N';
                if (value == 'm' || value == 'w' || value == 'м' || value == 'ж') 
                {
                    gender = value;
                }
            }
            get
            {
                return gender;
            }
        }

        public Person(string surname, string name, DateTime datebirth, char gender)
        {
            Surname = surname;
            Name = name;
            DateBirth = datebirth;
            Gender = gender;
        }

        public int GetAge() 
        {
            if (DateBirth.Month > DateTime.Now.Month) 
            {
                return DateTime.Now.Year - DateBirth.Year;
            }
            return DateTime.Now.Year - DateBirth.Year - 1;
        }

        public void GetAge(object a) 
        {
            Console.WriteLine(GetAge());
        }

        public void GetSN() 
        {
            Console.WriteLine($"{Surname}.{Name[0]}");
        }

        public void GetGender() 
        {
            Console.WriteLine(Gender.ToString());
        }


    }
}
