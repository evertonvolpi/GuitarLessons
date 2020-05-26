using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarLessons
{
    public class TwoDays : Students
    {
        public static int MaxNumOfSongs;
        public static int MaxTotalComplexity;

        public TwoDays(string name) : base(name)
        {
            Course = "Two days/week";
        }

        public override void CreateListOfSongs(List<Song> songs)
        {
            int complexity = 0;

            foreach (Song song in songs)
            {
                complexity += song.Complexity;
            }

            if (complexity > MaxTotalComplexity)
            {
                throw new Exception($"Your selection exceeds the maximum complexity for a two days/week course (max: {MaxTotalComplexity}).");
            }

            else if (songs.Count() > MaxNumOfSongs)
            {
                throw new Exception($"Your selection exceeds the maximum number of songs for a two days/week course (max: {MaxNumOfSongs} songs).");
            }

            else
            {
                base.CreateListOfSongs(songs);
                ComplexityTotal = complexity;
            }
        }

        public override string ToString()
        {
            return ($"{Name} (#{ID}) - Two days/Week");
        }

    }
}