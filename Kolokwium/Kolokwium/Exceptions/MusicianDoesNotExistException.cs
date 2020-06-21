using System;
using System.Runtime.Serialization;

namespace Kolokwium.Services
{
	[Serializable]
	internal class MusicianDoesNotExistException : Exception
	{
		public MusicianDoesNotExistException()
		{
		}

		public MusicianDoesNotExistException(string message) : base(message)
		{
		}

		public MusicianDoesNotExistException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected MusicianDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}