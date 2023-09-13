using System;



namespace MatchMaker.Models
{
    public class User
    {
        public User()
        {
            UserName = string.Empty;
            BirthsDay = new DateTime();
            AboutMe = string.Empty;
        }

        public User(string UserName, DateTime birthsDay)
        {
            UserName = UserName;
            BirthsDay = birthsDay;
            AboutMe = string.Empty;
        }
        public string UserName { get; set; }
        public DateTime BirthsDay { get; set; }
        public string AboutMe { get; set; }
    }
}
