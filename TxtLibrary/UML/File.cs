using System;
using System.IO;

namespace TxtLibrary.UML
{
	public class File : IFile
	{
		public FileStream Open(string path)
		{
			using (var fs  = new FileStream(path,FileMode.Open))
			{
				return fs;
			}
		}

		public string Read(string path)
		{
			using (var fs = new FileStream(path, FileMode.Open))
			{
				using (var sr = new StreamReader(fs))
				{
					return sr.ReadToEnd();
				}
			}

		}

		public void Write(string path)
		{
			using (var fs = new FileStream(path, FileMode.Open))
			{
				using (var sr = new  StreamWriter(fs))
				{
					sr .Write(path);
				}
			}

		}

		public void Close()
		{

		}

		public void Save(string type, string pathToSave)
		{

		}

		public void Save(string type)
		{
		}

		public void Save()
		{
		}

		public string Type     { get; set; }
		public string Encoding { get; set; }
	}
}