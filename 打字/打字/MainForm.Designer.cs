/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2022/3/19
 * 时间: 10:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 打字
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
			this.exbt = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.diffbt = new System.Windows.Forms.Button();
			this.notex = new System.Windows.Forms.Label();
			this.notex2 = new System.Windows.Forms.Label();
			this.truevis = new System.Windows.Forms.Label();
			this.keydownnum = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.NOTEX54 = new System.Windows.Forms.Label();
			this.miss = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// exbt
			// 
			this.exbt.Location = new System.Drawing.Point(755, 497);
			this.exbt.Name = "exbt";
			this.exbt.Size = new System.Drawing.Size(200, 79);
			this.exbt.TabIndex = 0;
			this.exbt.Text = "开始";
			this.exbt.UseVisualStyleBackColor = true;
			this.exbt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExbtClick);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("黑体", 20F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(62, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 41);
			this.label1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("黑体", 20F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(207, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 41);
			this.label2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("黑体", 20F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label3.Location = new System.Drawing.Point(349, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 41);
			this.label3.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("黑体", 20F);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(497, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 41);
			this.label4.TabIndex = 4;
			// 
			// trackBar1
			// 
			this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.trackBar1.Cursor = System.Windows.Forms.Cursors.Cross;
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(741, 56);
			this.trackBar1.Maximum = 6;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(214, 53);
			this.trackBar1.TabIndex = 5;
			this.trackBar1.Value = 1;
			// 
			// diffbt
			// 
			this.diffbt.Location = new System.Drawing.Point(802, 115);
			this.diffbt.Name = "diffbt";
			this.diffbt.Size = new System.Drawing.Size(119, 54);
			this.diffbt.TabIndex = 6;
			this.diffbt.Text = "确认变速";
			this.diffbt.UseVisualStyleBackColor = true;
			this.diffbt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiffbtClick);
			// 
			// notex
			// 
			this.notex.BackColor = System.Drawing.Color.Transparent;
			this.notex.ForeColor = System.Drawing.Color.Fuchsia;
			this.notex.Location = new System.Drawing.Point(766, 172);
			this.notex.Name = "notex";
			this.notex.Size = new System.Drawing.Size(178, 42);
			this.notex.TabIndex = 7;
			this.notex.Text = "准确率";
			this.notex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// notex2
			// 
			this.notex2.BackColor = System.Drawing.Color.Transparent;
			this.notex2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.notex2.Location = new System.Drawing.Point(766, 256);
			this.notex2.Name = "notex2";
			this.notex2.Size = new System.Drawing.Size(178, 42);
			this.notex2.TabIndex = 8;
			this.notex2.Text = "按键次数";
			this.notex2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// truevis
			// 
			this.truevis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.truevis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.truevis.Location = new System.Drawing.Point(766, 214);
			this.truevis.Name = "truevis";
			this.truevis.Size = new System.Drawing.Size(178, 42);
			this.truevis.TabIndex = 9;
			this.truevis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// keydownnum
			// 
			this.keydownnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.keydownnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.keydownnum.Location = new System.Drawing.Point(766, 298);
			this.keydownnum.Name = "keydownnum";
			this.keydownnum.Size = new System.Drawing.Size(178, 42);
			this.keydownnum.TabIndex = 10;
			this.keydownnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.Transparent;
			this.textBox1.Location = new System.Drawing.Point(207, 608);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(328, 16);
			this.textBox1.TabIndex = 11;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// NOTEX54
			// 
			this.NOTEX54.BackColor = System.Drawing.Color.Transparent;
			this.NOTEX54.ForeColor = System.Drawing.Color.Red;
			this.NOTEX54.Location = new System.Drawing.Point(766, 340);
			this.NOTEX54.Name = "NOTEX54";
			this.NOTEX54.Size = new System.Drawing.Size(178, 42);
			this.NOTEX54.TabIndex = 12;
			this.NOTEX54.Text = "MISS";
			this.NOTEX54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// miss
			// 
			this.miss.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.miss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.miss.Location = new System.Drawing.Point(766, 382);
			this.miss.Name = "miss";
			this.miss.Size = new System.Drawing.Size(178, 42);
			this.miss.TabIndex = 13;
			this.miss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(956, 623);
			this.Controls.Add(this.miss);
			this.Controls.Add(this.NOTEX54);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.keydownnum);
			this.Controls.Add(this.truevis);
			this.Controls.Add(this.notex2);
			this.Controls.Add(this.notex);
			this.Controls.Add(this.diffbt);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.exbt);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "打字练习";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label miss;
		private System.Windows.Forms.Label NOTEX54;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label keydownnum;
		private System.Windows.Forms.Label truevis;
		private System.Windows.Forms.Label notex2;
		private System.Windows.Forms.Label notex;
		private System.Windows.Forms.Button diffbt;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button exbt;
	}
}
