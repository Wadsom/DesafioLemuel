using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsMotor.Domain.Entities;

namespace dsMotor.Infra.Persistence
{
    public class DsMotorDbContext
    {
        List<Motorcycle> Motorcycles = new List<Motorcycle>();
        List<User> Users = new List<User>();

        public DsMotorDbContext()
        {
            Motorcycles = new List<Motorcycle>()
            {
                new Motorcycle("Shineray", 2024,"KOSDAWF","Preta"),
                new Motorcycle("Honda", 2021,"K34D6WF","Preta"),
                new Motorcycle("Kawazaki",2014,"KCMVBFF","Vermelha"),
                new Motorcycle("Harley", 1980,"FVXSAG","Verde"),     
                new Motorcycle("Yamaha", 1995, "YAM1234", "Azul"),
                new Motorcycle("Kawasaki", 2005, "KAW5678", "Preto"),
                new Motorcycle("Ducati", 2010, "DUC9101", "Vermelho"),
                new Motorcycle("Honda", 2020, "HON2345", "Branco")
            };
            Users = new List<User>()
            {
                new User("Bob", "Bob@gmail.com", "123456"),
                new User("Dave", "Dave@gmail.com", "654321"),
                new User("Marley", "Marley@gmail.com", "789321"),
                new User("John", "John@gmail.com", "123789"),
            };
        }
    }
}
