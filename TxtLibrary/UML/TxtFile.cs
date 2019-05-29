using System;

namespace TxtLibrary.UML
{
	public class TxtFile : IFile
	{
		public string Type     { get; set; }
		public string Encoding { get; set; }

		public void Open()
		{
			throw new NotImplementedException();
		}

		public void Read()
		{
			throw new NotImplementedException();
		}

		public void Write()
		{
			throw new NotImplementedException();
		}

		public void Close()
		{
			throw new NotImplementedException();
		}

		public void Save(string type)
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}