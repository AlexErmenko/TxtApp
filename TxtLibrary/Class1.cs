using System.Drawing;
using System.Windows.Forms;

using static System.Drawing.FontFamily;
using static System.Drawing.FontStyle;

namespace TxtLibrary
{
	public static class Extentions
	{
		public static void Nav(this Form from, in Form to)
		{
			from.Hide();
			to.Show();
		}

		public static void ResetStyle(this Form form)
		{
			form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			form.StartPosition   = FormStartPosition.CenterScreen;
			form.ShowIcon        = false;
			form.Font            = new Font(family: GenericSansSerif, emSize: 10, style: Regular);
		}
	}

	public class Class1 { }
}
