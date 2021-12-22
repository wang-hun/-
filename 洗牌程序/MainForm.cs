/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/21
 * 时间: 21:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 洗牌程序
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string[]cardB=new string[52];
		public string[]cardA=new string[52]{
		"img/黑桃A.png",
		"img/黑桃2.png",
		"img/黑桃3.png",
		"img/黑桃4.png",
		"img/黑桃5.png",
		"img/黑桃6.png",
		"img/黑桃7.png",
		"img/黑桃8.png",
		"img/黑桃9.png",
		"img/黑桃10.png",
		"img/黑桃J.png",
		"img/黑桃Q.png",
		"img/黑桃K.png",
		"img/红桃A.png",
		"img/红桃2.png",
		"img/红桃3.png",
		"img/红桃4.png",
		"img/红桃5.png",
		"img/红桃6.png",
		"img/红桃7.png",
		"img/红桃8.png",
		"img/红桃9.png",
		"img/红桃10.png",
		"img/红桃J.png",
		"img/红桃Q.png",
		"img/红桃K.png",
		"img/方片A.png",
		"img/方片2.png",
		"img/方片3.png",
		"img/方片4.png",
		"img/方片5.png",
		"img/方片6.png",
		"img/方片7.png",
		"img/方片8.png",
		"img/方片9.png",
		"img/方片10.png",
		"img/方片J.png",
		"img/方片Q.png",
		"img/方片K.png",
		"img/梅花A.png",
		"img/梅花2.png",
		"img/梅花3.png",
		"img/梅花4.png",
		"img/梅花5.png",
		"img/梅花6.png",
		"img/梅花7.png",
		"img/梅花8.png",
		"img/梅花9.png",
		"img/梅花10.png",
		"img/梅花J.png",
		"img/梅花Q.png",
		"img/梅花K.png",
		}; 
		Random ran=new Random();
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void changecards(object sender, EventArgs e)
		{
			int num;
			string t;
			for (int i = 0; i < 51; i++) {
				num=ran.Next(i,51);
				cardB[i]=cardA[num];
				cardA[num]=null;
				for (int j = num; j>0; j--) {
					t=cardA[j];
					cardA[j]=cardA[j-1];
					cardA[j-1]=cardA[j];
				}
			}
			for (int i = 0; i < 51; i++) {
				cardA[i]=cardB[i];
			}
		}
		
		void putcards(object sender, EventArgs e)
		{
			p1.Load(cardA[1]);
			p2.Load(cardA[4]);
			p3.Load(cardA[7]);
			p4.Load(cardA[10]);
			p5.Load(cardA[13]);
			/*手牌分割  */
			p6.Load(cardA[2]);
			p7.Load(cardA[5]);
			p8.Load(cardA[8]);
			p9.Load(cardA[11]);
			p10.Load(cardA[14]);
			/* 手牌分割  */
			p11.Load(cardA[3]);
			p12.Load(cardA[6]);
			p13.Load(cardA[9]);
			p14.Load(cardA[12]);
			p15.Load(cardA[15]);
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
p1.Load(cardA[1]);
			p1.Load("img/卡背.png");
			p2.Load("img/卡背.png");
			p3.Load("img/卡背.png");
			p4.Load("img/卡背.png");
			p5.Load("img/卡背.png");
			/*手牌分割  */
			p6.Load("img/卡背.png");
			p7.Load("img/卡背.png");
			p8.Load("img/卡背.png");
			p9.Load("img/卡背.png");
			p10.Load("img/卡背.png");
			/* 手牌分割  */
			p11.Load("img/卡背.png");
			p12.Load("img/卡背.png");
			p13.Load("img/卡背.png");
			p14.Load("img/卡背.png");
			p15.Load("img/卡背.png");			
		}
	}
}
