using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TxtApplication
{
	partial class Main
	{
		/// <summary>
		///   Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		///   Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///   Required method for Designer support - do not modify
		///   the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextEditor = new System.Windows.Forms.RichTextBox();
			this.CreateTxt = new System.Windows.Forms.Button();
			this.SaveAsPdf = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ChoseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.FontDialog = new System.Windows.Forms.FontDialog();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.OpenTxt = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SaveAsPdfFile = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextEditor
			// 
			this.TextEditor.Dock = System.Windows.Forms.DockStyle.Top;
			this.TextEditor.Location = new System.Drawing.Point(0, 24);
			this.TextEditor.Margin = new System.Windows.Forms.Padding(4);
			this.TextEditor.Name = "TextEditor";
			this.TextEditor.Size = new System.Drawing.Size(956, 418);
			this.TextEditor.TabIndex = 0;
			this.TextEditor.Text = "";
			// 
			// CreateTxt
			// 
			this.CreateTxt.Location = new System.Drawing.Point(13, 456);
			this.CreateTxt.Margin = new System.Windows.Forms.Padding(4);
			this.CreateTxt.Name = "CreateTxt";
			this.CreateTxt.Size = new System.Drawing.Size(163, 51);
			this.CreateTxt.TabIndex = 1;
			this.CreateTxt.Text = "Створити новый текстовий файл";
			this.CreateTxt.UseVisualStyleBackColor = true;
			this.CreateTxt.Click += new System.EventHandler(this.CreateTxt_Click);
			// 
			// SaveAsPdf
			// 
			this.SaveAsPdf.Location = new System.Drawing.Point(789, 456);
			this.SaveAsPdf.Margin = new System.Windows.Forms.Padding(4);
			this.SaveAsPdf.Name = "SaveAsPdf";
			this.SaveAsPdf.Size = new System.Drawing.Size(154, 51);
			this.SaveAsPdf.TabIndex = 2;
			this.SaveAsPdf.Text = "Зберегти у формати PDF";
			this.SaveAsPdf.UseVisualStyleBackColor = true;
			this.SaveAsPdf.Click += new System.EventHandler(this.SaveAsPdf_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChoseFont});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(956, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ChoseFont
			// 
			this.ChoseFont.Name = "ChoseFont";
			this.ChoseFont.Size = new System.Drawing.Size(102, 20);
			this.ChoseFont.Text = "Обрати шрифт";
			this.ChoseFont.Click += new System.EventHandler(this.ChoseFont_Click);
			// 
			// FontDialog
			// 
			this.FontDialog.ShowApply = true;
			this.FontDialog.Apply += new System.EventHandler(this.FontDialog_Apply);
			// 
			// SaveFileDialog
			// 
			this.SaveFileDialog.DefaultExt = "txt";
			this.SaveFileDialog.FileName = "*.txt";
			this.SaveFileDialog.RestoreDirectory = true;
			this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.CheckPathExists = false;
			this.OpenFileDialog.DefaultExt = "txt";
			this.OpenFileDialog.FileName = "*.txt";
			this.OpenFileDialog.RestoreDirectory = true;
			this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
			// 
			// OpenTxt
			// 
			this.OpenTxt.Location = new System.Drawing.Point(194, 456);
			this.OpenTxt.Margin = new System.Windows.Forms.Padding(4);
			this.OpenTxt.Name = "OpenTxt";
			this.OpenTxt.Size = new System.Drawing.Size(162, 51);
			this.OpenTxt.TabIndex = 4;
			this.OpenTxt.Text = "Відкрити існуючий текстовий файл";
			this.OpenTxt.UseVisualStyleBackColor = true;
			this.OpenTxt.Click += new System.EventHandler(this.OpenTxt_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(395, 456);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 51);
			this.button1.TabIndex = 5;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SaveAsPdfFile
			// 
			this.SaveAsPdfFile.DefaultExt = "pdf";
			this.SaveAsPdfFile.FileName = "*.pdf";
			this.SaveAsPdfFile.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveAsPdfFile_FileOk);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 520);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.OpenTxt);
			this.Controls.Add(this.SaveAsPdf);
			this.Controls.Add(this.CreateTxt);
			this.Controls.Add(this.TextEditor);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Програма для роботи з текстовими файлами та конвертації їх в PDF формат";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RichTextBox       TextEditor;
		private Button            CreateTxt;
		private Button            SaveAsPdf;
		private MenuStrip         menuStrip1;
		private ToolStripMenuItem ChoseFont;
		private FontDialog        FontDialog;
		private SaveFileDialog    SaveFileDialog;
		private OpenFileDialog    OpenFileDialog;
		private Button            button1;
		private SaveFileDialog    SaveAsPdfFile;
		private Button            OpenTxt;
	}
}
