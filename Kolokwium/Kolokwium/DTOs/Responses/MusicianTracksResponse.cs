using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Responses
{
	public class MusicianTracksResponse
	{

		public int IdMusician { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int IdTrack { get; set; }

		public string TrackName { get; set; }

		public float Duration  { get; set; }

	}
}
