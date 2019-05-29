using System;
using System.Collections.Generic;
using System.IO;

namespace TxtLibrary.UML
{
	public class TxtFile : File, IFile
	{
		public string Type { get; set; }
		public string Encoding { get; set; }

		public FileStream Open(string path)
		{
			using (var fs = new FileStream(path, FileMode.Open))
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

		public void Write(string path, IEnumerable<string> list)
		{
			using (var fs = new FileStream(path, FileMode.Open))
			{
				using (var sr = new StreamWriter(fs))
				{
					foreach (var line in list) sr.Write(line);
				}
			}
		}


		public void Save(string type,string filePath)
		{
		}

	}
}