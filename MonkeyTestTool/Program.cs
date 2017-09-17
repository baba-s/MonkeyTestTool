using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace MonkeyTest
{
	public static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		private static void Main( string[] args )
		{
			var app = new CustomApplication();
			app.Run( args );
		}
	}

	public sealed class CustomApplication : WindowsFormsApplicationBase
	{
		public CustomApplication() : base()
		{
			EnableVisualStyles 	 = true;
			IsSingleInstance 	 = true;
			MainForm 			 = new MainForm();
			StartupNextInstance += new StartupNextInstanceEventHandler( OnStart );
		}

		private void OnStart( object sender, StartupNextInstanceEventArgs e )
		{
			var mainForm = MainForm as MainForm;
			mainForm.LoadCommandLineArgs( e.CommandLine );
		}
	}
}
