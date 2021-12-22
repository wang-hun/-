
using System;
using System.Media;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;  
   

namespace 计时器__
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string time_now;
		DateTime now=new DateTime();
		TimeSpan timesum =new TimeSpan();
		TimeSpan me =new TimeSpan();
		int down_sum;
		DateTime down_time=new DateTime();

		
		
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
		
		void Button1Click(object sender, EventArgs e)
		{
			now=DateTime.Now;
			timer2.Start();//开始计时
		}
		
		void Button2Click(object sender, EventArgs e)
		{
            timer2.Stop();
			me=timesum;			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
            timer2.Stop();
			me=TimeSpan.Zero;
			timesum=TimeSpan.Zero;
			label_sum.Text="00:00:00";//清零			
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			 //z初始化
			 timer1.Start();
			 
		}
		
		void Timer1Tick(object sender, EventArgs e)//现在时间
		{
			
			time_now=DateTime.Now.ToString("yyyy-MM-dd")+"		"+DateTime.Now.DayOfWeek.ToString()+DateTime.Now.ToString("HH:mm:ss");
			label_now.Text=time_now;         
		}
		
		
		
		void Timer2Tick(object sender, EventArgs e)
		{
			    timesum=DateTime.Now-now+me;
            	label_sum.Text=timesum.ToString(@"hh\:mm\:ss");
		}
		
		
		
	
		
		
		
		
		
		
		
		void Button_enterMouseClick(object sender, MouseEventArgs e)
		{
			down_sum=Convert.ToInt32(numericUpDown1.Text)*3600+
				     Convert.ToInt32(numericUpDown2.Text)*60+
					 Convert.ToInt32(numericUpDown3.Text);
			down_time=DateTime.Now.AddSeconds(down_sum);
			timer3.Start();
		}
		
		void Timer3Tick(object sender, EventArgs e)
		{
			if (down_time<=DateTime.Now) {
				
				MessageBox.Show("倒计时结束！！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				label4.Text=TimeSpan.Zero.ToString(@"hh\:mm\:ss");
				timer3.Stop();
			}
			label4.Text=(down_time-DateTime.Now).ToString(@"hh\:mm\:ss");
		}
		
		void ErrorProvider1RightToLeftChanged(object sender, EventArgs e)
		{
			
		}
		
		
		
		
	}
}
