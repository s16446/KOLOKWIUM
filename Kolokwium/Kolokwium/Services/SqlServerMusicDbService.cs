using Kolokwium.DTOs.Responses;
using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
	public class SqlServerMusicDbService : IMusicDbService
	{
		private readonly MusicDbContext _context;

		public SqlServerMusicDbService(MusicDbContext context)
		{
			_context = context;	
		}	

		public MusicianTracksResponse GetMusician(int id)
		{
			var _musician = _context.Musicians.SingleOrDefault(m => m.IdMusician == id);

			if (_musician == null)
			{
				throw new MusicianDoesNotExistException($"Musician with an id={id} does not exist.");
			}

			var res = 
				from m in _context.Musicians
				join mt in _context.MusicianTracks 
				on m.IdMusician equals mt.IdMusician 
				join t in _context.Tracks 
				on mt.IdTrack equals t.IdTrack
				where m.IdMusician == id
				select new MusicianTracksResponse 
				{
					IdMusician = m.IdMusician,
					FirstName = m.FirstName,
					LastName = m.LastName,
					IdTrack = t.IdTrack,
					TrackName = t.TrackName,
					Duration = t.Duration
				};
			return res.FirstOrDefault();

		}

		public Musician AddMusician(MusicianTracksRequest request)
		{
			var _track = _context.Tracks.FirstOrDefault( t => t.TrackName == request.Track.TrackName);

			if (_track != null)
			{
				throw new TrackAlreadyExistException($"Track with the name {request.Track.TrackName} already exists.");
			}

			var _musician = new Musician {
				FirstName = request.FirstName,
				LastName = request.LastName,
				Nickname = request.NickName
			};

			_track = new Track {
				TrackName = request.Track.TrackName,
				Duration = request.Track.Duration
			};

			_context.MusicianTracks.AddRange(_musician.MusicianTracks);
			_context.Tracks.Add(_track);
			_context.Musicians.Add(_musician);
			_context.SaveChanges();

			return _musician;

		}
	}
}
