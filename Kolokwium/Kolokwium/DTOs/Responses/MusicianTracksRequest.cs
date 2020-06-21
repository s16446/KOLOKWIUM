using Kolokwium.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Responses
{
	public class MusicianTracksRequest
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string NickName { get; set; }

		public Track Track { get; set; }

	}
}
