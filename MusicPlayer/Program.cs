using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    public class Program
    {
        static Dictionary<int, MusicPlayer> player = new Dictionary<int, MusicPlayer>();

        
        static void CreatePlaylist()
        {

            MusicPlayer player1 = new MusicPlayer();

            Console.Write("Enter the Playlist number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Title name of the Playlist: ");
            player1.Title = Console.ReadLine();
      
            Console.Write("Enter the Artist name of the song: ");
            player1.ArtistName = Console.ReadLine();

            Console.Write("Enter the Album name of the song: ");
            player1.AlbumName = Console.ReadLine();

            Console.Write("Enter the Duration of the song: ");
            player1.Time = Convert.ToDouble(Console.ReadLine());
            
            player.Add(n, player1);
             
        }

        static void ShufflePlaylist()
        {
            Random random = new Random();
            int n = player.Count;
            for(int i = player.Count - 1; i> 1; i--) 
            {
                int rnd = random.Next(i+1);
                MusicPlayer value = player[rnd];
                player[rnd] = player[i];
                player[i] = value;
            }
        }
        static void DisplayPlaylist()
        {
            Console.WriteLine("Serial      Title       Artist Name      Album Name           Duration");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (var item in player) 
            {
                Console.Write("{0,-13}", item.Key);
                Console.Write("{0,-15}",item.Value.Title);
                Console.Write("{0,-15}", item.Value.ArtistName);
                Console.Write("{0,-26}", item.Value.AlbumName);
                Console.WriteLine(item.Value.Time);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("1. Create Playlist");
            Console.WriteLine("2. Shufflelist");
            Console.WriteLine("3. Displaylist");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int op;
            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CreatePlaylist();
                        break;
                    case 2:
                        ShufflePlaylist();
                        break;
                    case 3:
                        DisplayPlaylist();
                        break;

                }
            } while (op > 0 && op < 4);

        }
    }
}
