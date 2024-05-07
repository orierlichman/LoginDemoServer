﻿using LoginDemoServer.Models;
using LoginDemoServer.ModelsExt;

namespace LoginDemoServer.DTO
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Name { get; set; }
        //public ICollection<Grade> UserGrades { get; set; } = new List<Grade>();

        public Models.User ToModelsUser()
        {
            return new Models.User() { Email = Email, Password = Password, PhoneNumber = PhoneNumber, BirthDate = BirthDate, Name = Name };
        }

        public User() { }
        public User(Models.User modelUser)
        {
            this.PhoneNumber = modelUser.PhoneNumber;
            this.Name = modelUser.Name;
            this.Email = modelUser.Email;
            this.Password = modelUser.Password;
            this.BirthDate = modelUser.BirthDate;
            //this.UserGrades = modelUser.UserGrades;
        }
    }
}
