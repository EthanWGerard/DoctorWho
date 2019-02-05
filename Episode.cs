using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5A
{
    /// <summary>
    /// this class contains information on how to create an episode
    /// </summary>
    class Episode
    {
        public string story;    //story of a episode
        public int season;      //season of a episode
        public int year;        //year of a episode
        public string title;    //title of a episode

        public Episode(string story, int season, int year, string title)
        {
            this.story = story;
            this.season = season;
            this.year = year;
            this.title = title;
        }
    }
}
