using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {

            //detects if there is a connection and displays a message accordingly
            var message = (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) ? "Enjoy the sound clip!" : "Sorry no connection";
            Console.WriteLine(message);

            //plays a sound clip if there is a network connection
            if (message == "Enjoy the sound clip!") {

                //gets a random number
                var player =  new SoundPlayer();
                Random rnd = new Random();
                switch (rnd.Next(0, 4))
                {
                    case 1:
                        Console.WriteLine("You feeling lucky punk?");
                        player = new SoundPlayer(@"http://www.wavsource.com/snds_2015-08-16_6897529750891327/movie_stars/eastwood/punk.wav");
                        player.PlaySync();
                        break;

                    case 2:
                        Console.WriteLine("Surely you're not serious");
                        player = new SoundPlayer(@"http://www.wavsource.com/snds_2015-08-16_6897529750891327/movies/airplane/surely_a.wav");
                        player.PlaySync();
                        break;

                    case 3:
                        Console.WriteLine("Holy hole");
                        player = new SoundPlayer(@"http://www.wavsource.com/snds_2015-08-16_6897529750891327/tv/batman/holy_hole.wav");
                        player.PlaySync();
                        break;

                }

            }

            Console.ReadLine();
        }
    }
}
