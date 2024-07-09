using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = new List<string>();
            List<string> artists = new List<string>();
            List<string> playlist = new List<string>();

            songs.Add("Granade");
            songs.Add("Circle");
            songs.Add("Roar");
            songs.Add("Thriller");
            songs.Add("Umbrella");

            artists.Add("Bruno Mars");
            artists.Add("Post Malone");
            artists.Add("Katy Perry");
            artists.Add("Michael Jackson");
            artists.Add("Rihanna");
            ;
            int container1;
            foreach (string song in songs)
            {
                container1 = songs.IndexOf(song);
                playlist.Add(songs[container1] + " by: " + artists[container1]);
            }

            for (int i = 0; i < 3; i++)
            {
                int container2;
                foreach (string index in songs)
                {
                    if (i == 0)
                    {
                        container2 = songs.IndexOf(index);
                        Console.WriteLine(songs[container2]);
                    }
                    else if (i == 1)
                    {
                        container2 = songs.IndexOf(index);
                        Console.WriteLine(artists[container2]);
                    }
                    else if (i == 2)
                    {
                        container2 = songs.IndexOf(index);
                        Console.WriteLine(playlist[container2]);
                    }
                    else
                    {
                        break;
                    }



                }
                Console.WriteLine("");

            }
        }
    }
}
