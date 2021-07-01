﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Inheritance
{
    public class Person
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Guid = Guid.NewGuid();
        }

        public Person(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Guid.Equals(person.Guid) &&
                   Name == person.Name &&
                   Surname == person.Surname;
        }

        public override int GetHashCode()
        {
            int hashCode = 411991944;
            hashCode = hashCode * -1521134295 + Guid.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            return hashCode;
        }
    }


}
