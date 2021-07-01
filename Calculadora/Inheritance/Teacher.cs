using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Inheritance
{
    class Teacher : Person
    {
        public string Subject { get; set; }
        public float Salary { get; set; }

        public Teacher()
        {

        }

        public Teacher(string subject, float salary,
                       string name, string surname)
                       : base(name, surname)
        {
            Subject = subject;
            Salary = salary;
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   Guid.Equals(teacher.Guid) &&
                   Name == teacher.Name &&
                   Surname == teacher.Surname &&
                   Subject == teacher.Subject &&
                   Salary == teacher.Salary;
        }

        public override int GetHashCode()
        {
            int hashCode = 1700167176;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Guid.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Subject);
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            return hashCode;
        }
    }
}
