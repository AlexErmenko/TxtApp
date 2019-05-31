using System;
using System.IO;

namespace TxtLibrary.UML
{
	public class File : IFile
	{
		public FileStream Open(string path)
		{
			using (var fs = new FileStream(path: path, mode: FileMode.Open)) return fs;
		}

		public string Read(string path)
		{
			using (var fs = new FileStream(path: path, mode: FileMode.Open))
			{
				using (var sr = new StreamReader(stream: fs)) return sr.ReadToEnd();
			}
		}

		public void Write(string path)
		{
			using (var fs = new FileStream(path: path, mode: FileMode.Open))
			{
				using (var sr = new StreamWriter(stream: fs)) sr.Write(value: path);
			}
		}

		public void Save(string type, string pathToSave)
		{
			var f = new File();
			f.Save(type: type, pathToSave: pathToSave);
		}

		public string Type     { get; set; }
		public string Encoding { get; set; }
	}
}
