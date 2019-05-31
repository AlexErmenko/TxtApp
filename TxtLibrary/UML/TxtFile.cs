using System;
using System.Collections.Generic;
using System.IO;

namespace TxtLibrary.UML
{
	public class TxtFile : File, IFile
	{
		public string Type     { get; set; }
		public string Encoding { get; set; }

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

		public void Save(string type, string filePath) { }

		public void Write(string path, IEnumerable<string> list)
		{
			using (var fs = new FileStream(path: path, mode: FileMode.Open))
			{
				using (var sr = new StreamWriter(stream: fs))
					foreach (string line in list)
						sr.Write(value: line);
			}
		}
	}
}
