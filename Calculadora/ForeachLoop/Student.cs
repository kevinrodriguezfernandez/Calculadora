using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ForeachLoop
{
    public class Student
    {
        public Guid Guid { get; set; }  //codigo unico de cada instancia de la clase.
        public int StudentId { get; set; } //esto por debajo lee y escribe en la variable privada.
        public String Name { get; set; } // ya me hace el getter y el setter

        public String Surname { get; set; }

        public int Age { get; set; }

        //Stiatic variable that must be initialized at run time.
        //static means shared
        public static int STUDENT_COUNTER; //Shared entre todos los objetos creados de la clase

        //Static constructor is called at most one time, before any
        // instance constructor is invoked or member is accessed.
        static Student()
        {
            STUDENT_COUNTER = 0;
        }
        public Student()
        {
            STUDENT_COUNTER += 1;
            Guid = Guid.NewGuid();
        }

        //si le pasase algun parametro al this tendria que hacer otro constructor
        public Student(int studentId, string name, string surname, int age) : this() 
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = -1235398547;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }


    }
}
