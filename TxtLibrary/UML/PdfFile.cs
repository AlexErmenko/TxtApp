using System;

namespace TxtLibrary.UML
{
	public class PdfFile : File, IFile
	{
		public new string Type { get; set; }
		public new string Encoding { get; set; }

		public void Open(string path)
		{
		}

		public void Read(string path)
		{
		}

		public void Write(string path)
		{
		}

		public void Close()
		{
		}

		public void Save(string type)
		{
		}

		public void Save()
		{
		}

	}
}