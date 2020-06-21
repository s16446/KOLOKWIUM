using System;
using System.Runtime.Serialization;

namespace Kolokwium.Services
{
	[Serializable]
	internal class TrackAlreadyExistException : Exception
	{
		public TrackAlreadyExistException()
		{
		}

		public TrackAlreadyExistException(string message) : base(message)
		{
		}

		public TrackAlreadyExistException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected TrackAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}