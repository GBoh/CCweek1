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
            get; set;
        }

        public string Act()
        {
            return "rock";
        }
    }

    class PlayerSciccors : IPlayer
    {
        public int NumberOfWins
        {
            get; set;
        }

        public string Act()
        {
            return "scissors";
        }
    }

    class PlayerPaper : IPlayer
    {
        public int NumberOfWins
        {
            get; set;
        }

        public string Act()
        {
            return "paper";
        }
    }

    class Game
    {
        public static IPlayer Fight(IPlayer player1, IPlayer player2)
        {
            if (player1.Act() == "rock" && player2.Act() == "scissors")
            {
                player1.NumberOfWins++;
                return player1;
            }
            if (player1.Act() == "rock" && player2.Act() == "paper")
            {
                player2.NumberOfWins++;
                return player2;
            }
            if (player1.Act() == "scissors" && player2.Act() == "paper")
            {
                player1.NumberOfWins++;
                return player1;
            }

            return null;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var rock = new PlayerRock();
            var scissors = new PlayerSciccors();
            var paper = new PlayerPaper();



            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var game = rnd.Next(3);
                switch (game)
                {
                    case 0:
                        Game.Fight(rock, scissors);
                        break;
                    case 1:
                        Game.Fight(rock, paper);
                        break;
                    case 2:
                        Game.Fight(scissors, paper);
                        break;
                }
                //Console.WriteLine(rnd.Next(3));
            }
            Console.WriteLine("Rock won {0} times", rock.NumberOfWins);
            Console.WriteLine("Paper won {0} times", paper.NumberOfWins);
            Console.WriteLine("Scissor won {0} times", scissors.NumberOfWins);

            var winner = MostWins(rock, paper, scissors);

            Console.WriteLine("the winner is " + winner);


            Console.ReadLine();
        }

        public static string MostWins(params IPlayer[] inputs)
        {
            var highestScore = 0;
            string winner = null;
            for (int i = 0; i < 3; i++)
            {
                if (inputs[i].NumberOfWins > highestScore)
                {
                    highestScore = inputs[i].NumberOfWins;
                    winner = inputs[i].Act();
                }
            }

            return winner;
        }
    }
}
