using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
	public class MusicLabel
	{
		public int IdMusicLabel { get; set; }

		public string Name { get; set; }

		public ICollection<Album> Albums { get; set; }
	}
}
