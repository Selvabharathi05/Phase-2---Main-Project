using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLibrary
{
    public class Player
    {
        public int PlayerID { get; set; }

        public string PlayerName { get; set; }

        public int PlayerAge { get; set; }


    }

    interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }

    public class OneDayTeam : Player, ITeam
    {
        public static List<Player> onedayteam = new List<Player>();

        
        
        public OneDayTeam()
        {
            onedayteam.Capacity = 11;
        }
        public void Add(Player player)
        {
            onedayteam.Add(player);
        }

        public  List<Player> GetAllPlayers()
        {
            return onedayteam;
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = null;

            foreach (var item in onedayteam)
            {
                if (item.PlayerID == playerId)
                {
                    player = item;
                    break;
                }
               
            }
            return player;

        }

        public Player GetPlayerByName(string playerName)
        {
            Player player = null;

            foreach (var item in onedayteam)
            {
                if (item.PlayerName == playerName)
                {
                    player = item;
                    break;
                }
                  
            }
            return player;
        }

        public void Remove(int playerId)
        {
            Player player = null;

            foreach (var item in onedayteam)
            {
                if (item.PlayerID == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", item.PlayerID);
                    player = item;
                }
            }
            onedayteam.Remove(player);


        }
  
    }
}
