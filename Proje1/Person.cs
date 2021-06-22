using System;
using System.Collections.Generic;

namespace Proje1{
    public class Person
        {
            private string name;
            private string surname;
            private string phoneNumber;

            public Person(string name, string surname, string phoneNumber)
            {
                this.name = name;
                this.surname = surname;
                this.phoneNumber = phoneNumber;
            }

            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        }
}