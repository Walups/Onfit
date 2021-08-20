using System;

namespace IDontKnow{

    public class User{

        private string name;
        private string email; 
        private DateTime birthDate;
        private int age;

        //convenção C#: Atributos privados são nomeados em minusculo

        public string Name { get => name; set => name = value;}
        public string Email {get => email; set => email = value;}
        public DateTime BirthDate {get => birthDate; set=> birthDate = value;}
        public int Age {get => age; set => age = value;}

    }

}