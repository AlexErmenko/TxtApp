using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TxtLibrary;
using static System.IO.File;
using static System.Windows.Forms.DialogResult;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static TxtApplication.Properties.Resources;
using Font = System.Drawing.Font;

namespace TxtApplication
{
	/// <summary>
	///     Головне вікно демонстраційної програми
	/// </summary>
	public partial class Main : Form
	{
		/// <summary>
		///     Ініціалізація візуальних компонентів та нормалізація зовнішнього вигляду форми
		/// </summary>
		public Main()
		{
			InitializeComponent();
			this.ResetStyle();
		}

		/// <summary>
		///     Створення текстового документа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreateTxt_Click(object sender, EventArgs e)
		{
			if (TextEditor.Text.Length > 0)
			{
				DialogResult result =
						MessageBox.Show(text: WantSave, caption: AppTitle, buttons: YesNo,
										icon: Question);

				if (result != Yes) TextEditor.Clear();
				else SaveFileDialog.ShowDialog();

				TextEditor.Clear();
				TextEditor.Select();
			}
		}

		/// <summary>
		///     Відкриття файлу
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenTxt_Click(object sender, EventArgs e)
		{
			if (TextEditor.Text.Length == 0)
			{
				OpenFileDialog.ShowDialog();

				return;
			}

			if (MessageBox.Show(text: CurrentTextWillMissing, caption: AppTitle, buttons: YesNo,
								icon: Information)
			== Yes)
				OpenFileDialog.ShowDialog();
			else
				SaveFileDialog.ShowDialog();
		}

		/// <summary>
		///     Діалогове вікно вибори шрифта
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChoseFont_Click(object sender, EventArgs e)
		{
			if (TextEditor.Text.Length > 0)
			{
				DialogResult result                 = FontDialog.ShowDialog();
				Font         font                   = null;
				if (result == DialogResult.OK) font = FontDialog.Font;
				TextEditor.Font = font;
			}
			else
			{
				MessageBox.Show(text: FontMessage, caption: "", buttons: OKCancel,
								icon: Information);
			}
		}

		/// <summary>
		///     Збереження файлу у форматі PDF
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveAsPdf_Click(object sender, EventArgs e) => SaveAsPdfFile.ShowDialog();

		/// <summary>
		///     Збереження поточної інформації
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e) => SaveFileDialog.ShowDialog();

		/// <summary>
		///     Встановлення шрифта
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void FontDialog_Apply(object _, EventArgs e) => TextEditor.Font = FontDialog.Font;

		/// <summary>
		///     Збереження поточної інформації до файлу
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			var filePath = SaveFileDialog.FileName;
			if (!Exists(path: filePath)) Create(path: filePath).Close();

			using var fs = new FileStream(path: filePath, mode: FileMode.Open);
			using var sw = new StreamWriter(stream: fs);
			sw.Write(value: TextEditor.Text);
		}

		/// <summary>
		///     Завантаження тексту з файлу до редактора
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			TextEditor.LoadFile(path: OpenFileDialog.FileName, fileType: RichTextBoxStreamType.PlainText);
		}


		void Convert(string filePath, string fileOut)
		{
			var sr = new StreamReader(filePath);
			var document = new Document();
			PdfWriter.GetInstance(document, new FileStream(fileOut, FileMode.Create));
			document.Open();
			document.Add(new Paragraph(sr.ReadToEnd()));
			document.Close();
			System.Diagnostics.Process.Start(fileOut);
		}

		private void SaveAsPdfFile_FileOk(object sender, CancelEventArgs e)
		{
			var       path = SaveAsPdfFile.FileName;

			var outPath = path.Replace(".txt", ".pdf");

			Convert(path, outPath);

			using var fs   = new FileStream(path: path, mode: FileMode.Create);

			var document = new Document(pageSize: PageSize.A4, marginLeft: 25, marginRight: 25,
										marginTop: 30, marginBottom: 30);

			PdfWriter pdfWriter = PdfWriter.GetInstance(document: document, os: fs);
			document.Open();
			document.Add(element: new Paragraph(str: TextEditor.Text));
			document.Close();
			pdfWriter.Close();
		}
	}
}