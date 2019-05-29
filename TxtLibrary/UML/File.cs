using System;

namespace TxtLibrary.UML
{
	public class File : IFile
	{
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

		public string Type     { get; set; }
		public string Encoding { get; set; }
	}
}