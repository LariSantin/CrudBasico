using System;

namespace CrudBasico.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public Person() {}
        
        public Person(Guid id, string name, string email, string cpf)
        {
            Id = id;
            Name = name;
            Email = email;
            CPF = cpf;
        }
    }
}