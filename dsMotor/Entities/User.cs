﻿namespace dsMotor.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string  Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
