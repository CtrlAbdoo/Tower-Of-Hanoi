using System;
using System.Windows.Forms;

namespace toh
{
	static class Program
	{
	
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new GameForm());
		}
	}
}
