using System;
using System.Windows.Forms;

using TxtLibrary;

namespace TxtApplication
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Nav(to: new Main());
		}
	}
}
