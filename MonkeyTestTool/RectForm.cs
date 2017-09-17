using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MonkeyTest
{
	public partial class RectForm : Form
	{
		//====================================================================================
		// 変数
		//====================================================================================
		private Point m_start	= new Point();
		private Point m_end		= new Point();

		private Bitmap	m_bitmap	;
		private bool	m_isView	;

		private Action<Rectangle> m_onComplete;
		
		//====================================================================================
		// 変数（readonly）
		//====================================================================================
		private HotKey m_hotKey = new HotKey( 0, Keys.Escape );
		 
		//====================================================================================
		// 関数
		//====================================================================================
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public RectForm( Action<Rectangle> onComplete )
		{
			m_onComplete = onComplete;

			InitializeComponent();
			
			var bounds = Screen.PrimaryScreen.Bounds;

			pictureBox1.Location	= Point.Empty;
			pictureBox1.Size		= new Size( bounds.Width, bounds.Height );
			pictureBox1.Image		= m_bitmap;
			
			m_bitmap = new Bitmap( pictureBox1.Width, pictureBox1.Height );
			
			m_hotKey.HotKeyPush	+= new EventHandler( OnStop );
		}

		/// <summary>
		/// マウスが押された時に呼び出されます
		/// </summary>
		private void pictureBox1_MouseDown( object sender, MouseEventArgs e )
		{
			m_isView	= true;
			m_start.X	= e.X;
			m_start.Y	= e.Y;
		}
		
		/// <summary>
		/// マウスが移動された時に呼び出されます
		/// </summary>
		private void pictureBox1_MouseMove( object sender, MouseEventArgs e )
		{
			var p		= new Point();
			var start	= new Point();
			var end		= new Point();
 
			if ( !m_isView ) return;
			 
			p.X = e.X;
			p.Y = e.Y;
 
			UpdateRegion( m_start, p, ref start, ref end );
			DrawRegion( start, end );
			
			pictureBox1.Image = m_bitmap;
		}
		
		/// <summary>
		/// マウスが離された時に呼び出されます
		/// </summary>
		private void pictureBox1_MouseUp( object sender, MouseEventArgs e )
		{
			m_end.X = e.X;
			m_end.Y = e.Y;

			var x		= m_start.X;
			var y		= m_start.Y; 
			var width	= GetLength( m_start.X, m_end.X );
			var height	= GetLength( m_start.Y, m_end.Y );
			var rect	= new Rectangle( x, y, width, height ); 
			
			Close();

			m_onComplete( rect );
		}

		/// <summary>
		/// 矩形のサイズを更新します
		/// </summary>
		private void UpdateRegion( Point p1, Point p2, ref Point start, ref Point end )
		{
			start.X	= Math.Min( p1.X, p2.X );
			start.Y	= Math.Min( p1.Y, p2.Y );
			end.X	= Math.Max( p1.X, p2.X );
			end.Y	= Math.Max( p1.Y, p2.Y );
		}

		/// <summary>
		/// 長さを返します
		/// </summary>
		private int GetLength( int start, int end )
		{
			return Math.Abs( start - end );
		}
		
		/// <summary>
		/// 矩形領域を描画します
		/// </summary>
		private void DrawRegion( Point start, Point end )
		{
			var blackPen = new Pen( Color.Red )
			{
				DashStyle	= DashStyle.Solid, 
				Width		= 4, 
			};

			var g		= Graphics.FromImage( m_bitmap );
			var x		= start.X;
			var y		= start.Y; 
			var width	= GetLength( start.X, end.X );
			var height	= GetLength( start.Y, end.Y );
			
			g.Clear( SystemColors.Control );
			g.DrawRectangle
			(
				pen		: blackPen	, 
				x		: x			, 
				y		: y			, 
				width	: width		, 
				height	: height	
			);
			g.Dispose();
		}

		/// <summary>
		/// 停止する時に呼び出されます
		/// </summary>
		private void OnStop( object sender, EventArgs e )
		{
			Close();
		}
		
		/// <summary>
		/// フォームが閉じ始めた時に呼び出されます
		/// </summary>
		private void RectForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			m_hotKey.Dispose();
		}
	}
}
