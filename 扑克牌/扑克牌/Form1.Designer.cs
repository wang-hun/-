/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/23
 * 时间: 18:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 扑克牌
{
	partial class helpform
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
			this.helpquit.Location = new System.Drawing.Point(218, 355);
			this.helpquit.Name = "helpquit";
			this.helpquit.Size = new System.Drawing.Size(228, 57);
			this.helpquit.TabIndex = 0;
			this.helpquit.Text = "关闭";
			this.helpquit.UseVisualStyleBackColor = true;
			this.helpquit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.helpquiting);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F);
			this.label1.Location = new System.Drawing.Point(58, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(584, 71);
			this.label1.TabIndex = 1;
			this.label1.Text = "\r\n          3.你最多可以拥有十张牌，当你手中的牌点数等于21点时，请按下\r\n”21！“的按钮，你将获得等同于剩余牌堆数+对局数x10的分数。之后将进" +
			"\r\n行洗牌，开始下一局游戏。\r\n\r\n            \r\n";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(58, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(562, 38);
			this.label2.TabIndex = 2;
			this.label2.Text = "          2.A记为1点，2记为2点，3记为3点。。。以此类推。J,Q,K记作十点\r\n。大小王记为零点。\r\n\r\n            \r\n";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 12F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(58, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(562, 68);
			this.label3.TabIndex = 3;
			this.label3.Text = "          4.手中点数不为21点却点击了21！的按钮，将扣除5点分数。剩余\r\n牌堆为零时，继续抽牌将结束本局游戏，开启下一局游戏，且扣除20点分\r\n数。" +
			"点击重新洗牌将扣除50点分数。当你凑够21点点击21！后，若你手\r\n中有大王+50点分数，小王+30点分数。\r\n\r\n            \r\n";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 12F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(58, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(562, 57);
			this.label4.TabIndex = 4;
			this.label4.Text = "          1.你可以点击抽牌获得一张牌，或者 双 击 一张你拥有的牌选择弃\r\n牌。或者点击重新洗牌，将所有拥有的牌及剩余牌堆的牌重新洗切，并开\r\n始下一" +
			"局游戏。\r\n\r\n            \r\n";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 12F);
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(58, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(562, 38);
			this.label5.TabIndex = 5;
			this.label5.Text = "          5.当你抽牌后手牌总点数超过21点，你将被扣除你手中当前点数与\r\n21点的差的两倍的点数。当你分数小于等于-250时游戏结束。\r\n      " +
			"      \r\n";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 20F);
			this.label6.Location = new System.Drawing.Point(246, -2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(209, 51);
			this.label6.TabIndex = 6;
			this.label6.Text = "规则说明";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// helpform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 424);
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
			this.Name = "helpform";
			this.ShowIcon = false;
			this.Text = "HELP";
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
