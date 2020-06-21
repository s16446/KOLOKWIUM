using Kolokwium.DTOs.Responses;
using Kolokwium.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
	public interface IMusicDbService
	{
		MusicianTracksResponse GetMusician(int id);
		Musician AddMusician(MusicianTracksRequest request);
	}
}
