using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Class7
{
    public enum Genre
    {
        Rock,
        Metal,
        Psytrance
    }
    public class Song
    {
        public string Title { get; set; }
        public string _tasd { get; set; }
        public Genre Genre { get; set; }
    }
    public class Person
    {
        public string Name { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
