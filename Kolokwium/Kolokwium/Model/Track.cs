using System.Collections.Generic;

namespace Kolokwium.Model
{
	public class Track
	{
		public int IdTrack { get; set; }

		public string TrackName { get; set; }

		public float Duration  { get; set; }

		public int? IdAlbum  { get; set; }

		public Album Album  { get; set; }

		public ICollection<MusicianTrack> MusicianTracks { get; set; }
	}
}
