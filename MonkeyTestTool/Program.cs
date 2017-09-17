using Microsoft.VisualBasic.ApplicationServices;
using System;

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
			StartupNextInstance += new StartupNextInstanceEventHandler( OnStartupNext );
		}

		private void OnStartupNext( object sender, StartupNextInstanceEventArgs e )
		{
			var mainForm = MainForm as MainForm;
			mainForm.LoadCommandLineArgs( e.CommandLine );
		}
	}
}
