
namespace 计时器__
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button_start = new System.Windows.Forms.Button();
			this.button_pause = new System.Windows.Forms.Button();
			this.button_C = new System.Windows.Forms.Button();
			this.label_now = new System.Windows.Forms.Label();
			this.label_sum = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.计时器 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.Button_enter = new System.Windows.Forms.Button();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.计时器.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_start
			// 
			this.button_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_start.Location = new System.Drawing.Point(32, 191);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(62, 75);
			this.button_start.TabIndex = 1;
			this.button_start.Text = "开始";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1Click);
			// 
			// button_pause
			// 
			this.button_pause.Location = new System.Drawing.Point(104, 191);
			this.button_pause.Name = "button_pause";
			this.button_pause.Size = new System.Drawing.Size(91, 75);
			this.button_pause.TabIndex = 2;
			this.button_pause.Text = "暂停";
			this.button_pause.UseVisualStyleBackColor = true;
			this.button_pause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2Click);
			// 
			// button_C
			// 
			this.button_C.Location = new System.Drawing.Point(211, 191);
			this.button_C.Name = "button_C";
			this.button_C.Size = new System.Drawing.Size(72, 75);
			this.button_C.TabIndex = 3;
			this.button_C.Text = "清零";
			this.button_C.UseVisualStyleBackColor = true;
			this.button_C.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button3Click);
			// 
			// label_now
			// 
			this.label_now.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label_now.Font = new System.Drawing.Font("宋体", 20F);
			this.label_now.ForeColor = System.Drawing.Color.Red;
			this.label_now.Location = new System.Drawing.Point(32, 3);
			this.label_now.Name = "label_now";
			this.label_now.Size = new System.Drawing.Size(251, 81);
			this.label_now.TabIndex = 4;
			this.label_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_sum
			// 
			this.label_sum.BackColor = System.Drawing.Color.Gold;
			this.label_sum.Font = new System.Drawing.Font("宋体", 20F);
			this.label_sum.ForeColor = System.Drawing.Color.Olive;
			this.label_sum.Location = new System.Drawing.Point(32, 102);
			this.label_sum.Name = "label_sum";
			this.label_sum.Size = new System.Drawing.Size(251, 73);
			this.label_sum.TabIndex = 5;
			this.label_sum.Text = "00:00:00";
			this.label_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// 计时器
			// 
			this.计时器.Controls.Add(this.tabPage1);
			this.计时器.Controls.Add(this.tabPage2);
			this.计时器.Controls.Add(this.tabPage3);
			this.计时器.Location = new System.Drawing.Point(66, 30);
			this.计时器.Name = "计时器";
			this.计时器.SelectedIndex = 0;
			this.计时器.Size = new System.Drawing.Size(318, 326);
			this.计时器.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label_sum);
			this.tabPage1.Controls.Add(this.button_start);
			this.tabPage1.Controls.Add(this.button_pause);
			this.tabPage1.Controls.Add(this.button_C);
			this.tabPage1.Controls.Add(this.label_now);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(310, 300);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "计时器";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.Button_enter);
			this.tabPage2.Controls.Add(this.numericUpDown3);
			this.tabPage2.Controls.Add(this.numericUpDown2);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.numericUpDown1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(310, 300);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "倒计时";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.SandyBrown;
			this.label4.Font = new System.Drawing.Font("宋体", 40F);
			this.label4.Location = new System.Drawing.Point(27, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(246, 84);
			this.label4.TabIndex = 7;
			this.label4.Text = "00:00:00";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Button_enter
			// 
			this.Button_enter.Location = new System.Drawing.Point(77, 62);
			this.Button_enter.Name = "Button_enter";
			this.Button_enter.Size = new System.Drawing.Size(153, 53);
			this.Button_enter.TabIndex = 6;
			this.Button_enter.Text = "开始倒计时";
			this.Button_enter.UseVisualStyleBackColor = true;
			this.Button_enter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_enterMouseClick);
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.InterceptArrowKeys = false;
			this.numericUpDown3.Location = new System.Drawing.Point(178, 18);
			this.numericUpDown3.Maximum = new decimal(new int[] {
									60,
									0,
									0,
									0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(54, 21);
			this.numericUpDown3.TabIndex = 5;
			this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.InterceptArrowKeys = false;
			this.numericUpDown2.Location = new System.Drawing.Point(100, 18);
			this.numericUpDown2.Maximum = new decimal(new int[] {
									60,
									0,
									0,
									0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(54, 21);
			this.numericUpDown2.TabIndex = 4;
			this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(238, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "秒";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "分";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(77, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "时";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.InterceptArrowKeys = false;
			this.numericUpDown1.Location = new System.Drawing.Point(17, 18);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(54, 21);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.monthCalendar1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(310, 300);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "日历";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BackColor = System.Drawing.Color.LightGray;
			this.monthCalendar1.ForeColor = System.Drawing.Color.DimGray;
			this.monthCalendar1.Location = new System.Drawing.Point(45, 65);
			this.monthCalendar1.MaxSelectionCount = 1;
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ButtonFace;
			this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
			// 
			// timer3
			// 
			this.timer3.Interval = 800;
			this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(439, 368);
			this.Controls.Add(this.计时器);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "计时器--";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.计时器.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Button Button_enter;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl 计时器;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label_sum;
		private System.Windows.Forms.Label label_now;
		private System.Windows.Forms.Button button_C;
		private System.Windows.Forms.Button button_pause;
		private System.Windows.Forms.Button button_start;
		
	}
}
		
		
