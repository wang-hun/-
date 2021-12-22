/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/21
 * 时间: 21:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 洗牌程序
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
			this.ccard = new System.Windows.Forms.Button();
			this.pcard = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.p5 = new System.Windows.Forms.PictureBox();
			this.p4 = new System.Windows.Forms.PictureBox();
			this.p3 = new System.Windows.Forms.PictureBox();
			this.p2 = new System.Windows.Forms.PictureBox();
			this.p1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.p9 = new System.Windows.Forms.PictureBox();
			this.p10 = new System.Windows.Forms.PictureBox();
			this.p8 = new System.Windows.Forms.PictureBox();
			this.p6 = new System.Windows.Forms.PictureBox();
			this.p7 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.p14 = new System.Windows.Forms.PictureBox();
			this.p15 = new System.Windows.Forms.PictureBox();
			this.p13 = new System.Windows.Forms.PictureBox();
			this.p11 = new System.Windows.Forms.PictureBox();
			this.p12 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.p14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p12)).BeginInit();
			this.SuspendLayout();
			// 
			// ccard
			// 
			this.ccard.Location = new System.Drawing.Point(81, 39);
			this.ccard.Name = "ccard";
			this.ccard.Size = new System.Drawing.Size(237, 73);
			this.ccard.TabIndex = 0;
			this.ccard.Text = "洗牌";
			this.ccard.UseVisualStyleBackColor = true;
			this.ccard.Click += new System.EventHandler(this.changecards);
			// 
			// pcard
			// 
			this.pcard.Location = new System.Drawing.Point(466, 39);
			this.pcard.Name = "pcard";
			this.pcard.Size = new System.Drawing.Size(241, 71);
			this.pcard.TabIndex = 1;
			this.pcard.Text = "发牌";
			this.pcard.UseVisualStyleBackColor = true;
			this.pcard.Click += new System.EventHandler(this.putcards);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.p5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.p4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.p3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.p2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.p1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 128);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 117);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// p5
			// 
			this.p5.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p5.Location = new System.Drawing.Point(431, 3);
			this.p5.Name = "p5";
			this.p5.Size = new System.Drawing.Size(100, 111);
			this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p5.TabIndex = 4;
			this.p5.TabStop = false;
			// 
			// p4
			// 
			this.p4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p4.Location = new System.Drawing.Point(324, 3);
			this.p4.Name = "p4";
			this.p4.Size = new System.Drawing.Size(100, 111);
			this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p4.TabIndex = 3;
			this.p4.TabStop = false;
			// 
			// p3
			// 
			this.p3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p3.Location = new System.Drawing.Point(217, 3);
			this.p3.Name = "p3";
			this.p3.Size = new System.Drawing.Size(100, 111);
			this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p3.TabIndex = 2;
			this.p3.TabStop = false;
			// 
			// p2
			// 
			this.p2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p2.Location = new System.Drawing.Point(110, 3);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(100, 111);
			this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p2.TabIndex = 1;
			this.p2.TabStop = false;
			// 
			// p1
			// 
			this.p1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p1.Location = new System.Drawing.Point(3, 3);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(100, 111);
			this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p1.TabIndex = 0;
			this.p1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Controls.Add(this.p9, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.p10, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.p8, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.p6, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.p7, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(113, 261);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 111);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// p9
			// 
			this.p9.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p9.Location = new System.Drawing.Point(324, 3);
			this.p9.Name = "p9";
			this.p9.Size = new System.Drawing.Size(100, 105);
			this.p9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p9.TabIndex = 9;
			this.p9.TabStop = false;
			// 
			// p10
			// 
			this.p10.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p10.Location = new System.Drawing.Point(431, 3);
			this.p10.Name = "p10";
			this.p10.Size = new System.Drawing.Size(100, 105);
			this.p10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p10.TabIndex = 8;
			this.p10.TabStop = false;
			// 
			// p8
			// 
			this.p8.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p8.Location = new System.Drawing.Point(217, 3);
			this.p8.Name = "p8";
			this.p8.Size = new System.Drawing.Size(100, 105);
			this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p8.TabIndex = 7;
			this.p8.TabStop = false;
			// 
			// p6
			// 
			this.p6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p6.Location = new System.Drawing.Point(3, 3);
			this.p6.Name = "p6";
			this.p6.Size = new System.Drawing.Size(100, 105);
			this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p6.TabIndex = 6;
			this.p6.TabStop = false;
			// 
			// p7
			// 
			this.p7.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p7.Location = new System.Drawing.Point(110, 3);
			this.p7.Name = "p7";
			this.p7.Size = new System.Drawing.Size(100, 105);
			this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p7.TabIndex = 5;
			this.p7.TabStop = false;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel3.ColumnCount = 5;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.Controls.Add(this.p14, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.p15, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.p13, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.p11, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.p12, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(113, 391);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(538, 105);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// p14
			// 
			this.p14.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p14.Location = new System.Drawing.Point(324, 3);
			this.p14.Name = "p14";
			this.p14.Size = new System.Drawing.Size(100, 99);
			this.p14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p14.TabIndex = 9;
			this.p14.TabStop = false;
			// 
			// p15
			// 
			this.p15.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p15.Location = new System.Drawing.Point(431, 3);
			this.p15.Name = "p15";
			this.p15.Size = new System.Drawing.Size(100, 99);
			this.p15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p15.TabIndex = 8;
			this.p15.TabStop = false;
			// 
			// p13
			// 
			this.p13.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p13.Location = new System.Drawing.Point(217, 3);
			this.p13.Name = "p13";
			this.p13.Size = new System.Drawing.Size(100, 99);
			this.p13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p13.TabIndex = 7;
			this.p13.TabStop = false;
			// 
			// p11
			// 
			this.p11.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p11.Location = new System.Drawing.Point(3, 3);
			this.p11.Name = "p11";
			this.p11.Size = new System.Drawing.Size(100, 99);
			this.p11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p11.TabIndex = 6;
			this.p11.TabStop = false;
			// 
			// p12
			// 
			this.p12.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p12.Location = new System.Drawing.Point(110, 3);
			this.p12.Name = "p12";
			this.p12.Size = new System.Drawing.Size(100, 99);
			this.p12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.p12.TabIndex = 5;
			this.p12.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 20F);
			this.label1.Location = new System.Drawing.Point(14, 158);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 63);
			this.label1.TabIndex = 4;
			this.label1.Text = "A";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 20F);
			this.label2.Location = new System.Drawing.Point(14, 286);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 63);
			this.label2.TabIndex = 5;
			this.label2.Text = "B";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 20F);
			this.label3.Location = new System.Drawing.Point(14, 414);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 63);
			this.label3.TabIndex = 6;
			this.label3.Text = "C";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 514);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pcard);
			this.Controls.Add(this.ccard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "洗牌程序";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.p14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p12)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox p12;
		private System.Windows.Forms.PictureBox p11;
		private System.Windows.Forms.PictureBox p13;
		private System.Windows.Forms.PictureBox p15;
		private System.Windows.Forms.PictureBox p14;
		private System.Windows.Forms.PictureBox p7;
		private System.Windows.Forms.PictureBox p6;
		private System.Windows.Forms.PictureBox p8;
		private System.Windows.Forms.PictureBox p10;
		private System.Windows.Forms.PictureBox p9;
		private System.Windows.Forms.PictureBox p1;
		private System.Windows.Forms.PictureBox p2;
		private System.Windows.Forms.PictureBox p3;
		private System.Windows.Forms.PictureBox p4;
		private System.Windows.Forms.PictureBox p5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button pcard;
		private System.Windows.Forms.Button ccard;
	}
}
