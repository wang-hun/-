/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2022/3/19
 * 时间: 10:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace 打字
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int d;
		double m,n;
		bool ex;
		long missnum=0;
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
		
		void ExbtClick(object sender, EventArgs e)
		{
			if (ex) 
			{
				m=0;n=0;missnum=0;
				exbt.Text="到此为止吧";
				ex=false;
				d=trackBar1.Value*10;
				timer1.Start();
				this.textBox1.Focus();
				return;
			}
			else
			{
			  exbt.Text="开始";
			  ex=true;
			  timer1.Stop();
			  this.textBox1.Focus();
			  return;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			ex=true;
			MessageBox.Show("请打开大写锁定","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			char rc;
			Random rd=new Random();
			if (label1.Text=="" || label1.Top>=this.Height) 
			{
			 	if(label1.Top>=this.Height){missnum++;miss.Text=missnum.ToString();}
				label1.Top=0;
			 	rc=(char)(rd.Next(65,90));
			 	label1.Text=Convert.ToString(rc);
			}
			else
			{
			label1.Top+=d;
			}
			//
			if (label2.Text=="" || label2.Top>=this.Height) 
			{
				if(label2.Top>=this.Height){missnum++;miss.Text=missnum.ToString();}
				label2.Top=0;
			 	rc=(char)(rd.Next(65,90));
			 	label2.Text=Convert.ToString(rc);
			}
			else
			{
			label2.Top+=d;
			}
			//
			if (label3.Text=="" || label3.Top>=this.Height) 
			{
				if(label3.Top>=this.Height){missnum++;miss.Text=missnum.ToString();}
				label3.Top=0;
			 	rc=(char)(rd.Next(65,90));
			 	label3.Text=Convert.ToString(rc);
			}
			else
			{
			label3.Top+=d;
			}
			//
			if (label4.Text=="" || label4.Top>=this.Height) 
			{
				if(label4.Top>=this.Height){missnum++;miss.Text=missnum.ToString();}
			 	label4.Top=0;
			 	rc=(char)(rd.Next(65,90));
			 	label4.Text=Convert.ToString(rc);
			}
			else
			{
			label4.Top+=d;
			}
		}
		
		void DiffbtClick(object sender, EventArgs e)
		{
			d=trackBar1.Value*10;
			this.textBox1.Focus();
			
		}
		
	
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			m+=1d;
			if (e.KeyChar==Convert.ToChar(label1.Text))
			{
				label1.Text="";
				n+=1d;
				
			}
			//
			if (e.KeyChar==Convert.ToChar(label2.Text))
			{
				label2.Text="";
				n+=1d;
				
			}
			//
			if (e.KeyChar==Convert.ToChar(label3.Text))
			{
				label3.Text="";
				n+=1d;
				
			}
			//
			if (e.KeyChar==Convert.ToChar(label4.Text))
			{
				label4.Text="";
				n+=1d;
				
			}
			if(n/m*100>=100)
			   {truevis.Text=(100).ToString("F2")+"%";}
			   else
		       {truevis.Text=(n/m*100).ToString("F2")+"%";}
			keydownnum.Text=m.ToString();
			textBox1.Text="";
			this.textBox1.Focus();
		}
	}
}
