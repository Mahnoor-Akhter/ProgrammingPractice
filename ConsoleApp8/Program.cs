using System;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace ProgrammingPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			song s1 = new song("Beautiful People", "ED Sheeran", 3.15, Genre.Pop);
			song s2 = new song("Dance Monkey", "Tones & 1", 4.20, Genre.Dance);
			song s3 = new song("Circles", "Post Maloan", 3.25, Genre.Pop);
			song s4 = new song("Ride IT", "Regard", 3.37, Genre.Dance);
			song s5 = new song("South of the border", "ED Sheeran", 4.26, Genre.Pop);

			List<song> playlist = new List<song>();

			playlist.Add(s1);
			playlist.Add(s2);
			playlist.Add(s3);
			playlist.Add(s4);
			playlist.Add(s4);
			playlist.Add(s5);
			Display(playlist);

			//foreach (song song in playlist)
			//{
			//	Console.WriteLine(song);
			//}



		
		}
		private static void Display (List<song> playlist)
		{
			Console.WriteLine("{0,-20}{1,-25}{2,-10}{3,-10}", "Artist", "Song", "Duration", "Genre");
			foreach (song song in playlist)
			{
				Console.WriteLine($"{song.Artist,-20}{song.Title,-25}{song.Duration,-10}{song.MusicGenre,-10}");
			}
		}
	}
}
