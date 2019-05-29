using System.IO;

namespace TxtLibrary.UML
{
	public interface IFile
	{
		string Type     { get; set; }
		string Encoding { get; set; }
		FileStream Open(string path);
		string Read(string path);
		void   Write(string path);
		void   Save(string type, string pathToSave);
	}
}