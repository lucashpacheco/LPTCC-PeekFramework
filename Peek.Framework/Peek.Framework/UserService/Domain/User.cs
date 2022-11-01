using System;

namespace Peek.Framework.UserService.Domain
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePhoto { get; set; }


        public User(string id, string name, string email, DateTime birthdate, string profilePhoto)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthdate;
            ProfilePhoto = profilePhoto;
        }

        public User()
        {
        }
    }
}
