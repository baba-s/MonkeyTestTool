using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyTest
{
	public partial class MainForm : Form
	{
		//====================================================================================
		// 定数（const）
		//====================================================================================
		private const int MOUSEEVENTF_LEFTDOWN	= 0x2;
		private const int MOUSEEVENTF_LEFTUP	= 0x4;

		private const string START_BUTTON_TEXT_ENABLE	= "開始";
		private const string START_BUTTON_TEXT_DISABLE	= "Shift + Esc で停止";
		
		//====================================================================================
		// 定数（static readonly）
		//====================================================================================
		private static readonly Random	m_random	= new Random();
		private static readonly Regex	m_numRegex	= new Regex( @"[^0-9]" );

		//====================================================================================
		// 変数
		//====================================================================================
		private int	m_xMin		;
		private int		m_xMax			;
		private int		m_yMin			;
		private int		m_yMax			;
		private int		m_interval		;
		private int		m_downTime		;
		private bool	m_isStarting	;
		
		//====================================================================================
		// 変数（readonly）
		//====================================================================================
		private HotKey m_hotKey = new HotKey( MOD_KEY.SHIFT, Keys.Escape );
		
		//====================================================================================
		// 関数
		//====================================================================================
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			
			clickTimer	.Tick		+= new EventHandler( OnStart );
			m_hotKey	.HotKeyPush	+= new EventHandler( OnStop );
		}
		
		/// <summary>
		/// 開始する時に呼び出されます
		/// </summary>
		private async void OnStart( object sender, EventArgs e )
		{
			var x = m_random.Next( m_xMin, m_xMax );
			var y = m_random.Next( m_yMin, m_yMax );

			Cursor.Position = new Point( x, y );
			mouse_event( MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0 );
			
			await Task.Delay( m_downTime );
			mouse_event( MOUSEEVENTF_LEFTUP, 0, 0, 0, 0 );
		}
		
		/// <summary>
		/// 停止する時に呼び出されます
		/// </summary>
		private void OnStop( object sender, EventArgs e )
		{
			if ( !m_isStarting ) return;

			clickTimer		.Stop();
			cursorPosTimer	.Start();

			startButton			.Enabled	= true;
			settingContainer	.Enabled	= true;
			startButton			.Text		= START_BUTTON_TEXT_ENABLE;
			
			var pos		= PointToScreen( startButton.Location );
			var size	= startButton.Size;

			pos.X += size.Width	 / 2;
			pos.Y += size.Height / 2;

			Cursor.Position = pos;
		}
		
		/// <summary>
		/// 開始ボタンが押された時に呼び出されます
		/// </summary>
		private void startButton_Click( object sender, EventArgs e )
		{
			m_xMin		= ToInt( xMinTextBox		.Text );
			m_xMax		= ToInt( xMaxTextBox		.Text );
			m_yMin		= ToInt( yMinTextBox		.Text );
			m_yMax		= ToInt( yMaxTextBox		.Text );
			m_interval	= ToInt( intervalTextBox	.Text );
			m_downTime	= ToInt( downTimeTextBox	.Text );

			m_interval = Math.Max( m_downTime, m_interval );

			clickTimer			.Interval	= m_interval;
			startButton			.Enabled	= false;
			settingContainer	.Enabled	= false;
			startButton			.Text		= START_BUTTON_TEXT_DISABLE;
			
			clickTimer		.Start();
			cursorPosTimer	.Stop();

			m_isStarting = true;
		}

		/// <summary>
		/// フォームが読み込まれる時に呼び出されます
		/// </summary>
		private void MainForm_Load( object sender, EventArgs e )
		{
			var settings = Properties.Settings.Default;

			xMinTextBox		.Text = settings.xMin		.ToString();
			xMaxTextBox		.Text = settings.xMax		.ToString();
			yMinTextBox		.Text = settings.yMin		.ToString();
			yMaxTextBox		.Text = settings.yMax		.ToString();
			intervalTextBox	.Text = settings.Interval	.ToString();
			downTimeTextBox	.Text = settings.DownTime	.ToString();

			var args = Environment.GetCommandLineArgs();

			LoadCommandLineArgs( args );
		}

		/// <summary>
		/// コマンドライン引数を読み込みます
		/// </summary>
		public void LoadCommandLineArgs( IList<string> args )
		{
			if ( args == null || args.Count == 0 ) return;

			LoadCommandLineArg( args, xMinTextBox		, "--xMin"		);
			LoadCommandLineArg( args, xMaxTextBox		, "--xMax"		);
			LoadCommandLineArg( args, yMinTextBox		, "--yMin"		);
			LoadCommandLineArg( args, yMaxTextBox		, "--yMax"		);
			LoadCommandLineArg( args, intervalTextBox	, "--interval"	);
			LoadCommandLineArg( args, downTimeTextBox	, "--downTime"	);
		}

		/// <summary>
		/// 指定されたコマンドライン引数を読み込みます
		/// </summary>
		private void LoadCommandLineArg( IList<string> args, TextBox textBox, string key )
		{
			var index = args.FindIndex( c => c.StartsWith( key ) );

			if ( index == -1 ) return;

			var arg = args.ElementAtOrDefault( index + 1 );

			if ( string.IsNullOrWhiteSpace( arg ) ) return;

			var replacedText	= m_numRegex.Replace( arg, string.Empty );
			var num				= ToInt( replacedText );

			textBox.Text = num.ToString();
		}
		
		/// <summary>
		/// フォームが閉じ始めた時に呼び出されます
		/// </summary>
		private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			var settings = Properties.Settings.Default;
			
			settings.xMin		= ToInt( xMinTextBox		.Text );
			settings.xMax		= ToInt( xMaxTextBox		.Text );
			settings.yMin		= ToInt( yMinTextBox		.Text );
			settings.yMax		= ToInt( yMaxTextBox		.Text );
			settings.Interval	= ToInt( intervalTextBox	.Text );
			settings.DownTime	= ToInt( downTimeTextBox	.Text );

			settings.Save();

			m_hotKey.Dispose();
		}

		/// <summary>
		/// カーソル座標の標示を更新する時に呼び出されます
		/// </summary>
		private void cursorPosTimer_Tick( object sender, EventArgs e )
		{
			var pos = Cursor.Position;

			xPosTextBox.Text	= pos.X.ToString();
			yPosTextBox.Text	= pos.Y.ToString();
		}

		/// <summary>
		/// テキストボックスでキーが入力された時に呼び出されます
		/// </summary>
		private void textBox_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( (e.KeyChar < '0' || '9' < e.KeyChar ) && e.KeyChar != '\b' )
			{
				e.Handled = true;
			}
		}
		
		/// <summary>
		/// テキストボックスのテキストが変更された時に呼び出されます
		/// </summary>
		private void textBox_TextChanged( object sender, EventArgs e )
		{
			var xMin = ToInt( xMinTextBox.Text );
			var xMax = ToInt( xMaxTextBox.Text );
			var yMin = ToInt( yMinTextBox.Text );
			var yMax = ToInt( yMaxTextBox.Text );

			var isEnableX	= xMin < xMax;
			var isEnableY	= yMin < yMax;
			var isEnable	= isEnableX && isEnableY;

			startButton.Enabled = isEnable;
		}
		
		//====================================================================================
		// 関数（static）
		//====================================================================================
		/// <summary>
		/// string を int に変換して返します
		/// </summary>
		private static int ToInt( string s )
		{
			int result;
			if ( int.TryParse( s, out result ) ) return int.Parse( s );
			return 0;
		}

		//====================================================================================
		// 外部エイリアス
		//====================================================================================
		[DllImport( "USER32.dll", CallingConvention = CallingConvention.StdCall )]
		static extern void mouse_event( int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo );
	}

	/// <summary>
	/// IList 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class IListExt
	{
		/// <summary>
		/// 指定された条件を満たす要素のインデックスを返します
		/// </summary>
		public static int FindIndex<T>( this IList<T> self, Predicate<T> match )
		{
			for ( int i = 0; i < self.Count; i++ )
			{
				if ( match( self[ i ] ) ) return i;
			}
			return -1;
		}
	}
}
