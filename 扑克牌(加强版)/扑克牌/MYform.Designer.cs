/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/27
 * 时间: 21:12
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 扑克牌游戏
{
	partial class MYform
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
			this.helpquit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// helpquit
			// 
			this.helpquit.Location = new System.Drawing.Point(271, 257);
			this.helpquit.Name = "helpquit";
			this.helpquit.Size = new System.Drawing.Size(228, 57);
			this.helpquit.TabIndex = 1;
			this.helpquit.Text = "关闭";
			this.helpquit.UseVisualStyleBackColor = true;
			this.helpquit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HelpquitMouseClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("幼圆", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(220, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 61);
			this.label1.TabIndex = 2;
			this.label1.Text = " 作者";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("幼圆", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Tomato;
			this.label2.Location = new System.Drawing.Point(348, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 61);
			this.label2.TabIndex = 3;
			this.label2.Text = " 亡魂";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("幼圆", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(197, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(356, 61);
			this.label3.TabIndex = 4;
			this.label3.Text = "大一上学期所做";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("幼圆", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(197, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(356, 69);
			this.label4.TabIndex = 5;
			this.label4.Text = "QQ：3555617336";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("幼圆", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label5.ForeColor = System.Drawing.Color.Tomato;
			this.label5.Location = new System.Drawing.Point(468, 193);
			this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(273, 61);
			this.label5.TabIndex = 6;
			this.label5.Text = "所用图片均来源于网络";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 40F);
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(50, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(191, 119);
			this.label6.TabIndex = 7;
			this.label6.Text = "加强版";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MYform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 326);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.helpquit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MYform";
			this.ShowIcon = false;
			this.Text = "关于作者";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button helpquit;
	}
}
