using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssors
{
    public interface IPlayer
    {
        int NumberOfWins { get; set; }
        string Act();
    }

    class PlayerRock : IPlayer
    {
        public int NumberOfWins
        {
            get
            {
                return 0;
            }

            set
            {
                //throw new NotImplementedException();
            }
        }

        public string Act()
        {
            return "";
        }
    }

    class PlayerSciccors : IPlayer
    {
        public int NumberOfWins
        {
            get
            {
                return 0;
            }

            set
            {
                //throw new NotImplementedException();
            }
        }

        public string Act()
        {
            return "";
        }
    }






    class Game
    {
        public static IPlayer Fight(IPlayer player1, IPlayer player2)
        {
            if (player1 == PlayerRock && player2 == PlayerSciccors)
            {
                player1.Act();
                player1.NumberOfWins++;
                return player1;
            }
            else
            {
                return player2;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var game = rnd.Next(1);
                switch (game)
                {
                    case 0:
                        Game.Fight(PlayerRock, PlayerSciccors);
                        break;
                }
                //Console.WriteLine(rnd.Next(3));
            }

            Console.ReadLine();
        }
    }
}
