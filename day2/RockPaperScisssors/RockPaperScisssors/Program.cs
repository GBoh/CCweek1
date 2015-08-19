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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        
        public string Act()
        {
            return "";
        }
    }






    class Game
    {
        public IPlayer Fight(IPlayer player1, IPlayer player2)
        {

            return IPlayer;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                rnd.Next(3);
                //Console.WriteLine(rnd.Next(3));
            }

            Console.ReadLine();
        }
    }
}
