using MadBand.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.Songs.Queries.GetSongDetail
{
	public class GetSongDetailQuery : IRequest<SongDetailModel>, IQueryByID<int>
	{
		public int Id { get; set; }
	}
}
