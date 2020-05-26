using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarLessons
{
    public class Students
    {
        public readonly int ID;
        public readonly string Name;
        public string Course;
        public List<Song> StSongsChosen = new List<Song>();
        public int ComplexityTotal;

        public Students(string name)
        {
            this.Name = name;

            Random rdm = new Random();
            this.ID = rdm.Next(9000, 9999);
        }

        public virtual void CreateListOfSongs(List<Song> songs)
        {
            this.StSongsChosen.Clear();

            foreach(Song song in songs)
            {
                this.StSongsChosen.Add(song);
            }
        }
    }
}