/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/22
 * 时间: 19:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 扑克牌
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.cardsstcknum = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.restcard = new System.Windows.Forms.Button();
			this.incardbutton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.p7 = new System.Windows.Forms.PictureBox();
			this.p6 = new System.Windows.Forms.PictureBox();
			this.p8 = new System.Windows.Forms.PictureBox();
			this.p10 = new System.Windows.Forms.PictureBox();
			this.p9 = new System.Windows.Forms.PictureBox();
			this.p2 = new System.Windows.Forms.PictureBox();
			this.p1 = new System.Windows.Forms.PictureBox();
			this.p3 = new System.Windows.Forms.PictureBox();
			this.p5 = new System.Windows.Forms.PictureBox();
			this.p4 = new System.Windows.Forms.PictureBox();
			this.help = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.goal = new System.Windows.Forms.Label();
			this.saywin = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.gamesnum = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("黑体", 10F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "剩余牌数：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cardsstcknum
			// 
			this.cardsstcknum.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cardsstcknum.Font = new System.Drawing.Font("宋体", 30F);
			this.cardsstcknum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.cardsstcknum.Location = new System.Drawing.Point(106, 0);
			this.cardsstcknum.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.cardsstcknum.Name = "cardsstcknum";
			this.cardsstcknum.Size = new System.Drawing.Size(110, 54);
			this.cardsstcknum.TabIndex = 1;
			this.cardsstcknum.Text = "54";
			this.cardsstcknum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cardsstcknum);
			this.panel1.Location = new System.Drawing.Point(68, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(219, 56);
			this.panel1.TabIndex = 2;
			// 
			// restcard
			// 
			this.restcard.BackColor = System.Drawing.Color.LightGray;
			this.restcard.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.restcard.Font = new System.Drawing.Font("宋体", 20F);
			this.restcard.ForeColor = System.Drawing.Color.Red;
			this.restcard.Location = new System.Drawing.Point(92, 89);
			this.restcard.Name = "restcard";
			this.restcard.Size = new System.Drawing.Size(173, 69);
			this.restcard.TabIndex = 3;
			this.restcard.Text = "重新洗牌";
			this.restcard.UseVisualStyleBackColor = false;
			this.restcard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset);
			// 
			// incardbutton
			// 
			this.incardbutton.BackColor = System.Drawing.Color.LightGray;
			this.incardbutton.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.incardbutton.Font = new System.Drawing.Font("宋体", 20F);
			this.incardbutton.ForeColor = System.Drawing.Color.ForestGreen;
			this.incardbutton.Location = new System.Drawing.Point(520, 89);
			this.incardbutton.Name = "incardbutton";
			this.incardbutton.Size = new System.Drawing.Size(173, 69);
			this.incardbutton.TabIndex = 4;
			this.incardbutton.Text = "抽牌";
			this.incardbutton.UseVisualStyleBackColor = false;
			this.incardbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.incard);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 10;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Controls.Add(this.p7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p6, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p8, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p10, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p9, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p5, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.p4, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 175);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 126);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// p7
			// 
			this.p7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p7.Location = new System.Drawing.Point(477, 3);
			this.p7.Name = "p7";
			this.p7.Size = new System.Drawing.Size(71, 120);
			this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p7.TabIndex = 9;
			this.p7.TabStop = false;
			this.p7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p7bin);
			// 
			// p6
			// 
			this.p6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p6.Location = new System.Drawing.Point(398, 3);
			this.p6.Name = "p6";
			this.p6.Size = new System.Drawing.Size(71, 120);
			this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p6.TabIndex = 8;
			this.p6.TabStop = false;
			this.p6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p6bin);
			// 
			// p8
			// 
			this.p8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p8.Location = new System.Drawing.Point(556, 3);
			this.p8.Name = "p8";
			this.p8.Size = new System.Drawing.Size(71, 120);
			this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p8.TabIndex = 7;
			this.p8.TabStop = false;
			this.p8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p8bin);
			// 
			// p10
			// 
			this.p10.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p10.Location = new System.Drawing.Point(714, 3);
			this.p10.Name = "p10";
			this.p10.Size = new System.Drawing.Size(71, 120);
			this.p10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p10.TabIndex = 6;
			this.p10.TabStop = false;
			this.p10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.P10bin);
			// 
			// p9
			// 
			this.p9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p9.Location = new System.Drawing.Point(635, 3);
			this.p9.Name = "p9";
			this.p9.Size = new System.Drawing.Size(71, 120);
			this.p9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p9.TabIndex = 5;
			this.p9.TabStop = false;
			this.p9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p9bin);
			// 
			// p2
			// 
			this.p2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p2.Location = new System.Drawing.Point(82, 3);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(71, 120);
			this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p2.TabIndex = 4;
			this.p2.TabStop = false;
			this.p2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p2bin);
			// 
			// p1
			// 
			this.p1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p1.Location = new System.Drawing.Point(3, 3);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(71, 120);
			this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p1.TabIndex = 3;
			this.p1.TabStop = false;
			this.p1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.P1bin);
			// 
			// p3
			// 
			this.p3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p3.Location = new System.Drawing.Point(161, 3);
			this.p3.Name = "p3";
			this.p3.Size = new System.Drawing.Size(71, 120);
			this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p3.TabIndex = 2;
			this.p3.TabStop = false;
			this.p3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p3bin);
			// 
			// p5
			// 
			this.p5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p5.Location = new System.Drawing.Point(319, 3);
			this.p5.Name = "p5";
			this.p5.Size = new System.Drawing.Size(71, 120);
			this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p5.TabIndex = 1;
			this.p5.TabStop = false;
			this.p5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p5bin);
			// 
			// p4
			// 
			this.p4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p4.Location = new System.Drawing.Point(240, 3);
			this.p4.Name = "p4";
			this.p4.Size = new System.Drawing.Size(71, 120);
			this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p4.TabIndex = 0;
			this.p4.TabStop = false;
			this.p4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p4bin);
			// 
			// help
			// 
			this.help.Cursor = System.Windows.Forms.Cursors.Help;
			this.help.Font = new System.Drawing.Font("宋体", 20F);
			this.help.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
			this.help.Location = new System.Drawing.Point(12, 9);
			this.help.Name = "help";
			this.help.Size = new System.Drawing.Size(50, 50);
			this.help.TabIndex = 6;
			this.help.UseVisualStyleBackColor = true;
			this.help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.helpclick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.goal);
			this.panel2.Location = new System.Drawing.Point(487, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(219, 56);
			this.panel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Font = new System.Drawing.Font("黑体", 10F);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 54);
			this.label2.TabIndex = 0;
			this.label2.Text = "分数：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// goal
			// 
			this.goal.BackColor = System.Drawing.SystemColors.ControlLight;
			this.goal.Font = new System.Drawing.Font("宋体", 30F);
			this.goal.ForeColor = System.Drawing.Color.Teal;
			this.goal.Location = new System.Drawing.Point(107, 0);
			this.goal.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.goal.Name = "goal";
			this.goal.Size = new System.Drawing.Size(110, 54);
			this.goal.TabIndex = 1;
			this.goal.Text = "0";
			this.goal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// saywin
			// 
			this.saywin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saywin.Font = new System.Drawing.Font("华文琥珀", 36.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.saywin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.saywin.Location = new System.Drawing.Point(293, 89);
			this.saywin.Name = "saywin";
			this.saywin.Size = new System.Drawing.Size(181, 68);
			this.saywin.TabIndex = 8;
			this.saywin.Text = "21点!";
			this.saywin.UseVisualStyleBackColor = true;
			this.saywin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.win21);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Font = new System.Drawing.Font("黑体", 10F);
			this.label3.Location = new System.Drawing.Point(293, 315);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 54);
			this.label3.TabIndex = 2;
			this.label3.Text = "当前对局数：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gamesnum
			// 
			this.gamesnum.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gamesnum.Font = new System.Drawing.Font("宋体", 30F);
			this.gamesnum.ForeColor = System.Drawing.Color.Olive;
			this.gamesnum.Location = new System.Drawing.Point(400, 315);
			this.gamesnum.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.gamesnum.Name = "gamesnum";
			this.gamesnum.Size = new System.Drawing.Size(110, 54);
			this.gamesnum.TabIndex = 2;
			this.gamesnum.Text = "1";
			this.gamesnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Font = new System.Drawing.Font("宋体", 18F);
			this.linkLabel1.Location = new System.Drawing.Point(669, 335);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(145, 38);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "关于作者";
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 378);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.gamesnum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.saywin);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.help);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.incardbutton);
			this.Controls.Add(this.restcard);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "黑杰克";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label gamesnum;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button saywin;
		private System.Windows.Forms.Label goal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button help;
		private System.Windows.Forms.PictureBox p5;
		private System.Windows.Forms.PictureBox p3;
		private System.Windows.Forms.PictureBox p1;
		private System.Windows.Forms.PictureBox p2;
		private System.Windows.Forms.PictureBox p9;
		private System.Windows.Forms.PictureBox p10;
		private System.Windows.Forms.PictureBox p8;
		private System.Windows.Forms.PictureBox p6;
		private System.Windows.Forms.PictureBox p7;
		private System.Windows.Forms.PictureBox p4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button incardbutton;
		private System.Windows.Forms.Button restcard;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label cardsstcknum;
		private System.Windows.Forms.Label label1;
	}
}
