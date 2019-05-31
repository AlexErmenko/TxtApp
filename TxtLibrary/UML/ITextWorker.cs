using System;

namespace TxtLibrary.UML
{
	public interface ITextWorker
	{
		void Convert(IFile file);
		void Read(IFile    file);
		void Write(IFile   file);
	}
}
