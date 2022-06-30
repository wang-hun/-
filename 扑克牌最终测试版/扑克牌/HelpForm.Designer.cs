/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/23
 * 时间: 18:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 扑克牌游戏
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helpquit
            // 
            this.helpquit.Location = new System.Drawing.Point(241, 800);
            this.helpquit.Name = "helpquit";
            this.helpquit.Size = new System.Drawing.Size(266, 66);
            this.helpquit.TabIndex = 0;
            this.helpquit.Text = "关闭";
            this.helpquit.UseVisualStyleBackColor = true;
            this.helpquit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.helpquiting);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(68, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "3.你最多可以拥有十张牌，当你手中的牌点数等于目标点时，请按\r\n下”OH!YE!“的按钮，你将获得等同于剩余牌堆数的分数。之后\r\n将进行洗牌，开始下一局游戏。\r\n" +
    "\r\n            \r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(68, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(656, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "  2.A记为1点，2记为2点，3记为3点。。。以此类推。\r\nJ,Q,K记作11,12,13点。大小王记为零点。\r\n\r\n            \r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(68, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(656, 79);
            this.label3.TabIndex = 3;
            this.label3.Text = " 4.手中点数不为目标点却点击了\"OH!YE!“的按钮，将扣除10点分\r\n数。剩余牌堆为零时，继续抽牌将结束游戏。当你凑够目标点数点\r\n击“OH!YE!“后，若你" +
    "手中有大王+50点分数，小王+30点分数。\r\n\r\n            \r\n";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(68, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(656, 66);
            this.label4.TabIndex = 4;
            this.label4.Text = "1.你可以点击抽牌获得一张牌，或者 双 击 一张你拥有的牌选择弃\r\n牌。\r\n\r\n            \r\n";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(68, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(656, 69);
            this.label5.TabIndex = 5;
            this.label5.Text = "5.当你抽牌后手牌总点数超过目标点，你将被扣除你手中\r\n当前点数与目标点的差的二倍的点数。当你分数小于等于-250\r\n时游戏结束。\r\n            \r\n" +
    "";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 20F);
            this.label6.Location = new System.Drawing.Point(287, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 59);
            this.label6.TabIndex = 6;
            this.label6.Text = "加强版规则说明";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(68, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(656, 69);
            this.label7.TabIndex = 7;
            this.label7.Text = "6.得到目标分数，你将进入下一轮游戏。每一轮难度将获得提升。";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 20F);
            this.label8.Location = new System.Drawing.Point(263, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 59);
            this.label8.TabIndex = 8;
            this.label8.Text = "闯关规则说明";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(68, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(627, 130);
            this.label9.TabIndex = 9;
            this.label9.Text = "7.第一轮和第二轮目标分数将锁定为21点。\r\n第三轮开始将出现随机目标分数，并且你将能看见下一张牌是什么。\r\n最终轮（第五轮）后牌抽完不会结束游戏，将会重新洗牌开" +
    "始下一局游戏。努力挑战更高的分数吧！！！";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(68, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(656, 94);
            this.label10.TabIndex = 10;
            this.label10.Text = "8.每一轮的需求分数是100的倍数\r\n例如 第一轮进入第二轮要求分数在100分以上\r\n第二轮进入第三轮要求分数在200分以上\r\n以此类推";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(68, 684);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(656, 44);
            this.label11.TabIndex = 11;
            this.label11.Text = "9..第二轮开始，每次抽牌后只有三十秒的思考时间。\r\n三十秒内没有抽卡或者点击“OH！YE！”会被判为失败。\r\n\r\n\r\n\r\n            \r\n";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(68, 728);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(656, 44);
            this.label12.TabIndex = 12;
            this.label12.Text = "10..第四轮开始，每次开局都要选择一次增益效果\r\n第五轮开始，每次开局都要选一次减益效果。\r\n\r\n\r\n\r\n            \r\n";
            // 
            // helpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 909);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Load += new System.EventHandler(this.helpform_Load);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button helpquit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
