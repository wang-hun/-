/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/11/5
 * 时间: 13:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 投骰机_多样_
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button8 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(29, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "四面色子";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1MouseClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(157, 35);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "六面色子";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2MouseClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(290, 35);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "八面色子";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button3MouseClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(428, 35);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "十二面色子";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button4MouseClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(428, 144);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "二十四";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button5MouseClick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(29, 144);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "硬币";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button6MouseClick);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(221, 194);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 6;
			this.button7.Text = "自定义";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button7MouseClick);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(212, 147);
			this.numericUpDown1.Minimum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(93, 21);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(212, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 29);
			this.label1.TabIndex = 8;
			this.label1.Text = "自定义色子面数";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(48, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(555, 279);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.button5);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.button6);
			this.tabPage1.Controls.Add(this.button7);
			this.tabPage1.Controls.Add(this.numericUpDown1);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(547, 253);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "扔一个";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button8);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.numericUpDown3);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.numericUpDown2);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(547, 253);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "你想扔几个";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(162, 80);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(162, 37);
			this.button8.TabIndex = 5;
			this.button8.Text = "扔！！！";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button8MouseClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "扔";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(281, 40);
			this.numericUpDown3.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(109, 21);
			this.numericUpDown3.TabIndex = 3;
			this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown3.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(363, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 37);
			this.label3.TabIndex = 2;
			this.label3.Text = "个";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(91, 39);
			this.numericUpDown2.Minimum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
			this.numericUpDown2.TabIndex = 1;
			this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown2.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(188, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 35);
			this.label2.TabIndex = 0;
			this.label2.Text = "面色子";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 316);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "投骰机（多样）";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
		
		
		
		
		
	}
}
