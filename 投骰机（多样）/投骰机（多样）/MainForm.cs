/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/11/5
 * 时间: 13:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 投骰机_多样_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		delegate void throwing(string a);
		Random ran=new Random();
		throwing th=showing;
		
		
		public static void showing(string a)
		{
			MessageBox.Show(a,"结果",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
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
		
		void Button6MouseClick(object sender, MouseEventArgs e)
		{
			
			string str;
			
			if (ran.NextDouble()<=0.5D)
			{
				str="正面";
			}else
			{
				str="反面";
			}
			th(str);
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		
		
		void Button2MouseClick(object sender, MouseEventArgs e)
		{
			th(ran.Next(1,5).ToString());
		}
		
		void Button3MouseClick(object sender, MouseEventArgs e)
		{
			th(ran.Next(1,7).ToString());
		}
		
		void Button4MouseClick(object sender, MouseEventArgs e)
		{
			th(ran.Next(1,13).ToString());
		}
		
		void Button5MouseClick(object sender, MouseEventArgs e)
		{
			th(ran.Next(1,25).ToString());
		}
		
		
		
		void Button7MouseClick(object sender, MouseEventArgs e)
		{
			th(ran.Next(1,Convert.ToInt32(numericUpDown1.Text)+1).ToString());
	
	}
		
		void Button8MouseClick(object sender, MouseEventArgs e)
		{
			int sum=0;
			int tem;
			string stra=string.Empty;
			for (int i = 0; i < Convert.ToInt32(numericUpDown3.Text); i++) {
				tem=ran.Next(0,Convert.ToInt32(numericUpDown2.Text)+1);
				stra+=tem.ToString()+",";
				sum+=tem;
			}
			MessageBox.Show(stra.ToString(),"结果",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			MessageBox.Show(sum.ToString(),"共计",MessageBoxButtons.OK,MessageBoxIcon.Error);
		
		}
		
		void Button1MouseClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show(ran.Next(1,5).ToString(),"结果",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
}
}
