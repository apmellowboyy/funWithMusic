using System;
using System.Runtime.CompilerServices;
namespace movies
{
    class Program
    {
        enum Genre
        {
            Rap,
            Country,
            Rock,
            Swing,
            Jazz
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Genre = genre;
            }
            public void setTitle(string title)
            { Title = title; }
            public void setLength(string length)
            { Length = length; }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is your favorite Artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is your favorite album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is the Album?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("\nR- Rap\nC - Country\nT - Rock\nS - Swing\nJ - Jazz");
            Genre tempGenre = Genre.Rap;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'T':
                    tempGenre = Genre.Rock;
                    break;
                case 'S':
                    tempGenre = Genre.Swing;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{music.Display()}");
            Music moreMusic = music;
            moreMusic.setTitle("Real Slim Shady");
            moreMusic.setLength("4:28");
            Console.WriteLine("Song 1");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine();
            Console.WriteLine("Song 2");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}