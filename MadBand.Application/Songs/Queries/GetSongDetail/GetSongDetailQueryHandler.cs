using MadBand.Application.Exceptions;
using MadBand.Application.Interfaces;
using MadBand.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.Songs.Queries.GetSongDetail
{
	public class GetSongDetailQueryHandler:IRequestHandler<GetSongDetailQuery,SongDetailModel>
	{
		private readonly IContext _context;
		public GetSongDetailQueryHandler(IContext context)
		{
			_context = context;
		}

		public async Task<SongDetailModel> Handle(GetSongDetailQuery request, CancellationToken cancellationToken)
		{
			Song entity = await _context.Songs
				.FindAsync(request.Id);

			if(entity == null)
			{
				throw new NotFoundException(nameof(Song), request.Id);
			}

			return new SongDetailModel
			{
				Id = entity.SongID,
				Title = entity.Title
			};
		}
	}
}
