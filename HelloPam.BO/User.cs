using System;

namespace HelloPam.BO
{
    public class User
    {
        public int Id { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Profile { get; set; }
        public bool Statut { get; set; }
        public byte[] Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        

        public User()
        {

        }

        public User(int id, string username, string password, 
                        string fullname, int profile, bool statut, byte[] picture,
                        DateTime createdAt)
        {
            Id = id;
            Username = username;
            Password = password;
            Fullname = fullname;
            Profile = profile;
            Statut = statut;
            Picture = picture;
            CreatedAt = createdAt;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }


}
