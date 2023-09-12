using System;

public enum GameName { League_of_Legends, CSGO, Valorant, _6_Siege, Other }

namespace MatchMaker.Models
{
    public class User
    {
        public User()
        {
            UserName = string.Empty;
            BirthsDay = new DateTime();
            PlayedGame = GameName.Other;
            AboutMe = string.Empty;
        }

        public User(string UserName, DateTime birthsDay, GameName schoolClass)
        {
            UserName = UserName;
            BirthsDay = birthsDay;
            PlayedGame = schoolClass;
            AboutMe = string.Empty;
        }
        public string UserName { get; set; }
        public DateTime BirthsDay { get; set; }
        public GameName PlayedGame { get; set; }
        public string AboutMe { get; set; }
    }
}
