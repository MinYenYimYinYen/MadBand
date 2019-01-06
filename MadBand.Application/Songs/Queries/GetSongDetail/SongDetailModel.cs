using MadBand.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MadBand.Application.Songs.Queries.GetSongDetail
{
	public class SongDetailModel
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public static Expression<Func<Song, SongDetailModel>> Projection => song =>
		new SongDetailModel
		{
			Id = song.SongID,
			Title = song.Title
		};

		public static SongDetailModel Create(Song song)
		{
			return Projection.Compile().Invoke(song);
		}
	}
}

