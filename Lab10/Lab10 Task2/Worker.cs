using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Task2
{
    class Worker
    {
        string name;
        string surname;
        DateTime birthday;
        DateTime employment;
        int salary;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }


        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public DateTime Employment
        {
            get
            {
                return employment;
            }

            set
            {
                employment = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public Worker(string name, string surname,DateTime birthday, DateTime employment, int salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Employment = employment;
            Salary = salary;
        }

        public int GetAge()
        {
            return (int)(DateTime.Now - Birthday).TotalDays / 365;
        }

        public int GetExperience()
        {
            return (int)(DateTime.Now - Employment).TotalDays / 365;
        }

        public int GetTotalPayment()
        {
            return GetExperience() * 12 * Salary;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
