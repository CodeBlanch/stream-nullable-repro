using System.IO;

namespace StreamNullable
{
	public sealed class MyCustomStream : MemoryStream
	{
		private readonly byte[] _Header = new byte[128];

		public void WriteHeader(Stream destination)
		{
			ValidateCopyToArguments(destination, bufferSize: 128);

			destination.Write(_Header);
		}
	}
}