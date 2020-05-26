using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarLessons
{
    public class ToolBox
    {
        public static List<Song> AvailableSongs()
        {
            List<Song> songs = new List<Song>();

            Song song = new Song("olm113", "Old Man", "Neil Young");
            song.Complexity = 1;
            songs.Add(song);

            song = new Song("cth132", "Closer to the heart", "Rush");
            song.Complexity = 1;
            songs.Add(song);

            song = new Song("grs423", "Ghost riders in the sky", "Johnny Cash");
            song.Complexity = 1;
            songs.Add(song);

            song = new Song("wyh231", "Wish you were here", "Pink Floyd");
            song.Complexity = 2;
            songs.Add(song);

            song = new Song("brg213", "Blues run the game", "Jackson C. Frank");
            song.Complexity = 2;
            songs.Add(song);

            song = new Song("ysg412", "Your song", "Elton John");
            song.Complexity = 2;
            songs.Add(song);

            song = new Song("stt123", "Stop this train", "John Mayer");
            song.Complexity = 3;
            songs.Add(song);

            song = new Song("trs321", "The Rain Song", "Led Zeppelin");
            song.Complexity = 3;
            songs.Add(song);

            song = new Song("adm432", "&#x000C1guas de Mar&#x000E7o", "Tom Jobim");
            song.Complexity = 4;
            songs.Add(song);

            song = new Song("rbs421", "Revelation Blues", "The Tallest Man On Earth");
            song.Complexity = 4;
            songs.Add(song);

            return songs;
        }

        public static Song GetSongByCode(string code)
        {
            foreach(Song song in AvailableSongs())
            {
                if(song.Code == code)
                {
                    return song;
                }
            }
            return null;
        }
    }
}