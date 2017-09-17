namespace MonkeyTest
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.xMinTextBox = new System.Windows.Forms.TextBox();
			this.yMinTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.xMaxTextBox = new System.Windows.Forms.TextBox();
			this.yMaxTextBox = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.intervalTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.settingContainer = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.downTimeTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rectButton = new System.Windows.Forms.Button();
			this.yPosTextBox = new System.Windows.Forms.TextBox();
			this.xPosTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cursorPosTimer = new System.Windows.Forms.Timer(this.components);
			this.clickTimer = new System.Windows.Forms.Timer(this.components);
			this.settingContainer.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// xMinTextBox
			// 
			this.xMinTextBox.Location = new System.Drawing.Point(74, 21);
			this.xMinTextBox.Name = "xMinTextBox";
			this.xMinTextBox.Size = new System.Drawing.Size(100, 22);
			this.xMinTextBox.TabIndex = 20;
			this.xMinTextBox.Text = "0";
			this.xMinTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.xMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// yMinTextBox
			// 
			this.yMinTextBox.Location = new System.Drawing.Point(74, 49);
			this.yMinTextBox.Name = "yMinTextBox";
			this.yMinTextBox.Size = new System.Drawing.Size(100, 22);
			this.yMinTextBox.TabIndex = 30;
			this.yMinTextBox.Text = "0";
			this.yMinTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.yMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "X座標";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Y座標";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(180, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "～";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(180, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "～";
			// 
			// xMaxTextBox
			// 
			this.xMaxTextBox.Location = new System.Drawing.Point(208, 21);
			this.xMaxTextBox.Name = "xMaxTextBox";
			this.xMaxTextBox.Size = new System.Drawing.Size(100, 22);
			this.xMaxTextBox.TabIndex = 40;
			this.xMaxTextBox.Text = "0";
			this.xMaxTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// yMaxTextBox
			// 
			this.yMaxTextBox.Location = new System.Drawing.Point(208, 52);
			this.yMaxTextBox.Name = "yMaxTextBox";
			this.yMaxTextBox.Size = new System.Drawing.Size(100, 22);
			this.yMaxTextBox.TabIndex = 50;
			this.yMaxTextBox.Text = "0";
			this.yMaxTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(12, 294);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(327, 23);
			this.startButton.TabIndex = 70;
			this.startButton.Text = "開始";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "押下間隔";
			// 
			// intervalTextBox
			// 
			this.intervalTextBox.Location = new System.Drawing.Point(93, 110);
			this.intervalTextBox.Name = "intervalTextBox";
			this.intervalTextBox.Size = new System.Drawing.Size(100, 22);
			this.intervalTextBox.TabIndex = 60;
			this.intervalTextBox.Text = "1000";
			this.intervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(199, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "ミリ秒";
			// 
			// settingContainer
			// 
			this.settingContainer.Controls.Add(this.rectButton);
			this.settingContainer.Controls.Add(this.label10);
			this.settingContainer.Controls.Add(this.downTimeTextBox);
			this.settingContainer.Controls.Add(this.label9);
			this.settingContainer.Controls.Add(this.xMinTextBox);
			this.settingContainer.Controls.Add(this.label6);
			this.settingContainer.Controls.Add(this.yMinTextBox);
			this.settingContainer.Controls.Add(this.intervalTextBox);
			this.settingContainer.Controls.Add(this.label1);
			this.settingContainer.Controls.Add(this.label5);
			this.settingContainer.Controls.Add(this.label2);
			this.settingContainer.Controls.Add(this.label3);
			this.settingContainer.Controls.Add(this.yMaxTextBox);
			this.settingContainer.Controls.Add(this.label4);
			this.settingContainer.Controls.Add(this.xMaxTextBox);
			this.settingContainer.Location = new System.Drawing.Point(12, 104);
			this.settingContainer.Name = "settingContainer";
			this.settingContainer.Size = new System.Drawing.Size(327, 173);
			this.settingContainer.TabIndex = 0;
			this.settingContainer.TabStop = false;
			this.settingContainer.Text = "設定";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(199, 141);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 15);
			this.label10.TabIndex = 63;
			this.label10.Text = "ミリ秒";
			// 
			// downTimeTextBox
			// 
			this.downTimeTextBox.Location = new System.Drawing.Point(93, 138);
			this.downTimeTextBox.Name = "downTimeTextBox";
			this.downTimeTextBox.Size = new System.Drawing.Size(100, 22);
			this.downTimeTextBox.TabIndex = 62;
			this.downTimeTextBox.Text = "20";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 141);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 15);
			this.label9.TabIndex = 61;
			this.label9.Text = "押下時間";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.yPosTextBox);
			this.groupBox2.Controls.Add(this.xPosTextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(327, 86);
			this.groupBox2.TabIndex = 100;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "カーソル座標";
			// 
			// rectButton
			// 
			this.rectButton.Location = new System.Drawing.Point(233, 80);
			this.rectButton.Name = "rectButton";
			this.rectButton.Size = new System.Drawing.Size(75, 23);
			this.rectButton.TabIndex = 91;
			this.rectButton.Text = "矩形選択";
			this.rectButton.UseVisualStyleBackColor = true;
			this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
			// 
			// yPosTextBox
			// 
			this.yPosTextBox.Location = new System.Drawing.Point(74, 49);
			this.yPosTextBox.Name = "yPosTextBox";
			this.yPosTextBox.ReadOnly = true;
			this.yPosTextBox.Size = new System.Drawing.Size(100, 22);
			this.yPosTextBox.TabIndex = 90;
			this.yPosTextBox.Text = "0";
			// 
			// xPosTextBox
			// 
			this.xPosTextBox.Location = new System.Drawing.Point(74, 24);
			this.xPosTextBox.Name = "xPosTextBox";
			this.xPosTextBox.ReadOnly = true;
			this.xPosTextBox.Size = new System.Drawing.Size(100, 22);
			this.xPosTextBox.TabIndex = 80;
			this.xPosTextBox.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 15);
			this.label8.TabIndex = 4;
			this.label8.Text = "Y座標";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "X座標";
			// 
			// cursorPosTimer
			// 
			this.cursorPosTimer.Enabled = true;
			this.cursorPosTimer.Interval = 1;
			this.cursorPosTimer.Tick += new System.EventHandler(this.cursorPosTimer_Tick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.startButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 340);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.settingContainer);
			this.Controls.Add(this.startButton);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MonkeyTest.Properties.Settings.Default, "MainFormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = global::MonkeyTest.Properties.Settings.Default.MainFormLocation;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "モンキーテストツール";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.settingContainer.ResumeLayout(false);
			this.settingContainer.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox xMinTextBox;
		private System.Windows.Forms.TextBox yMinTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox xMaxTextBox;
		private System.Windows.Forms.TextBox yMaxTextBox;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox intervalTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox settingContainer;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox yPosTextBox;
		private System.Windows.Forms.TextBox xPosTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Timer cursorPosTimer;
		private System.Windows.Forms.Timer clickTimer;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox downTimeTextBox;
		private System.Windows.Forms.Button rectButton;
	}
}

