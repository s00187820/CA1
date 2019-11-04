using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Song2
    {
        enum Genre
        {
            Rock,
            Pop,
            Dance,
            Other,

        }
         public string title;
         public string artist;
         public double duration;

        Genre genre;


        public Song(string a, string t)
        {
            this.artist = a;
            this.title = t;

        }

        public Song1(string a, string t)
        {
            this.artist = a;
            this.title = t;

        }
        public Song2(string a, string t)
        {
            this.artist = a;
            this.title = t;

        }




        song1("ED Sheeran", "Beatiful People", "3:15", "Pop");
        song2("Regard", "Ride It", "3:37", "Dance");
        song3("Tones & I", "Dance Monkey", "4:20", "Dance");
        song4("Post Malone", "Circles", "3:25", "Pop");
        song5("ED Sheeran", "South OF the Border", "4:26", "Other");


    }
}
