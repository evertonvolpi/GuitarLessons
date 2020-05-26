using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarLessons
{
    public class Song
    {
        public readonly string Code;
        public readonly string Title;
        public readonly string Artist;
        public int Complexity;

        public Song(string code, string title, string artist)
        {
            this.Code = code;
            this.Title = title;
            this.Artist = artist;
        }

    }
}