namespace TxtLibrary.UML
{
	public interface IFile
	{
		string Type     { get; set; }
		string Encoding { get; set; }
		void   Open();
		void   Read();
		void   Write();
		void   Close();
		void   Save(string type);
		void   Save();
	}
}