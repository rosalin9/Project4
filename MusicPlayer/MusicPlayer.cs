using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    public class MusicPlayer
    {
        private string title;
        private string artistName;
        private string albumName;
        private double time;

        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string ArtistName 
        {
            get
            {
                return artistName;
            }
            set
            {
                artistName = value;
            }
        }
        public string AlbumName 
        {
            get
            {
                return albumName;
            }
            set
            {
                albumName = value;
            }
        }
        public double Time 
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }


    }
}
