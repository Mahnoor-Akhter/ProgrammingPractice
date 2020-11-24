using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPractice
{
	public class song
	{
		//properties
		public string Title { get; set; }

		public string Artist { get; set; }
		public double Duration { get; set; }


		public   Genre MusicGenre { get; set; }
		//constructors
		public song (string title ,string artist,double duration, Genre musicGenre)
		{
			Title = title;
			Artist = artist;
			Duration = duration;
			MusicGenre = musicGenre;
		}
		public song(string title, string artist): this(title,artist,0,Genre.Other)
		{
			
		}
		public song():this("Unknown","Unknown")
		{
	
		}

		// methods
		public override string ToString()
		{
			return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
		   
		}

	}
	public enum Genre { Rock,Pop ,Dance, Other}
}
