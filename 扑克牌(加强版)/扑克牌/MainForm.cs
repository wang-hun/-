/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/22
 * 时间: 19:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using 扑克牌游戏;

namespace 扑克牌
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int target=42;
		public struct card
		{
		public string name;
		public int cnum;
		public card(string c,int n)
		{
		this.name=c;
		this.cnum=n;
        }
		}
		
		
		public card[]table=new card[10];
		card 空牌=new card("img/卡背.png",0);
		card 黑桃A=new card("img/黑桃A.png",1);
		card 黑桃2=new card("img/黑桃2.png",2);
		card 黑桃3=new card("img/黑桃3.png",3);
		card 黑桃4=new card("img/黑桃4.png",4);
		card 黑桃5=new card("img/黑桃5.png",5);
		card 黑桃6=new card("img/黑桃6.png",6);
		card 黑桃7=new card("img/黑桃7.png",7);
		card 黑桃8=new card("img/黑桃8.png",8);
		card 黑桃9=new card("img/黑桃9.png",9);
		card 黑桃10=new card("img/黑桃10.png",10);
		card 黑桃J=new card("img/黑桃J.png",11);
		card 黑桃Q=new card("img/黑桃Q.png",12);
		card 黑桃K=new card("img/黑桃K.png",13);
		card 红桃A=new card("img/红桃A.png",1);
		card 红桃2=new card("img/红桃2.png",2);
		card 红桃3=new card("img/红桃3.png",3);
		card 红桃4=new card("img/红桃4.png",4);
		card 红桃5=new card("img/红桃5.png",5);
		card 红桃6=new card("img/红桃6.png",6);
		card 红桃7=new card("img/红桃7.png",7);
		card 红桃8=new card("img/红桃8.png",8);
		card 红桃9=new card("img/红桃9.png",9);
		card 红桃10=new card("img/红桃10.png",10);
		card 红桃J=new card("img/红桃J.png",11);
		card 红桃Q=new card("img/红桃Q.png",12);
		card 红桃K=new card("img/红桃K.png",13);
		card 方片A=new card("img/方片A.png",1);
		card 方片2=new card("img/方片2.png",2);
		card 方片3=new card("img/方片3.png",3);
		card 方片4=new card("img/方片4.png",4);
		card 方片5=new card("img/方片5.png",5);
		card 方片6=new card("img/方片6.png",6);
		card 方片7=new card("img/方片7.png",7);
		card 方片8=new card("img/方片8.png",8);
		card 方片9=new card("img/方片9.png",9);
		card 方片10=new card("img/方片10.png",10);
		card 方片J=new card("img/方片J.png",11);
		card 方片Q=new card("img/方片Q.png",12);
		card 方片K=new card("img/方片K.png",13);
		card 梅花A=new card("img/梅花A.png",1);
		card 梅花2=new card("img/梅花2.png",2);
		card 梅花3=new card("img/梅花3.png",3);
		card 梅花4=new card("img/梅花4.png",4);
		card 梅花5=new card("img/梅花5.png",5);
		card 梅花6=new card("img/梅花6.png",6);
		card 梅花7=new card("img/梅花7.png",7);
		card 梅花8=new card("img/梅花8.png",8);
		card 梅花9=new card("img/梅花9.png",9);
		card 梅花10=new card("img/梅花10.png",10);
		card 梅花J=new card("img/梅花J.png",11);
		card 梅花Q=new card("img/梅花Q.png",12);
		card 梅花K=new card("img/梅花K.png",13);
		card 大王=new card("img/大王.png",0);
		card 小王=new card("img/小王.png",0);
		private  Stack<card> bin=new Stack<card>();
		private  Stack<card> now=new Stack<card>();
		private  Stack<card> tem1=new Stack<card>();
		private Stack<card> tem2=new Stack<card>();
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			loading_instack();
			changecard();
			MessageBox.Show("如果您是第一次游玩，建议点击主窗口左上的帮助按钮，获取游戏规则说明\n关于加强版的说明：你需要更好的心算能力了。因为运算只会变困难。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			for (int i = 0; i <10; i++) {
				table[i]=空牌;
			}
			cardload();
			target=ran.Next(41,72);
			targettext.Text=Convert.ToString(target);
			
		}
		private void changecard()
		{
		   /* 洗牌函数，该程序的核心。
		    * 交替打乱然后进行堆叠。
		    * 之后进行任意的切牌。
		    */
		   for (int i = 0; i < 2; i++) {
		      	randwash();
		   }
		  
 			for (int i = 0; i < 3; i++) {
		   	half();
		   	wash();
		   }		   
		   
		   
		   
		
		}
		private void loading_instack()
		{
		/*
 		 * 窗口加载时将外部数组牌堆压入now的
		 * 栈中，now作为初始牌堆。 
		 */
		 now.Push(黑桃A);
		now.Push(黑桃2);
		now.Push(黑桃3);
		now.Push(黑桃4);
		now.Push(黑桃5);
		now.Push(黑桃6);
		now.Push(黑桃7);
		now.Push(黑桃8);
		now.Push(黑桃9);
		now.Push(黑桃10);
		now.Push(黑桃J);
		now.Push(黑桃Q);
		now.Push(黑桃K);
		now.Push(红桃A);
		now.Push(红桃2);
		now.Push(红桃3);
		now.Push(红桃4);
		now.Push(红桃5);
		now.Push(红桃6);
		now.Push(红桃7);
		now.Push(红桃8);
		now.Push(红桃9);
		now.Push(红桃10);
		now.Push(红桃J);
		now.Push(红桃Q);
		now.Push(红桃K);
		now.Push(方片A);
		now.Push(方片2);
		now.Push(方片3);
		now.Push(方片4);
		now.Push(方片5);
		now.Push(方片6);
		now.Push(方片7);
		now.Push(方片8);
		now.Push(方片9);
		now.Push(方片10);
		now.Push(方片J);
		now.Push(方片Q);
		now.Push(方片K);
		now.Push(梅花A);
		now.Push(梅花2);
		now.Push(梅花3);
		now.Push(梅花4);
		now.Push(梅花5);
		now.Push(梅花6);
		now.Push(梅花7);
		now.Push(梅花8);
		now.Push(梅花9);
		now.Push(梅花10);
		now.Push(梅花J);
		now.Push(梅花Q);
		now.Push(梅花K);
		now.Push(大王);
		now.Push(小王);
		}
		private void half()
		{//对现有牌堆进行折半
		for (int i = 0; i <27; i++) {
		   	tem1.Push(now.Pop());
		}
		for (int i = 0; i <27; i++) {
		   	tem2.Push(now.Pop());
		}	
		
		}
		private void wash()
		{//实现交叉洗牌。
		for (int i = 0; i < 54; i++) 
		   {
		   	switch(i%2)
		   	{
		   		case 1:now.Push(tem1.Pop());
		   		break;
		   		case 0:now.Push(tem2.Pop());
		   		break;
		   	}
		   }
		
		}
		private void randwash()
		{//模拟切牌的过程。
			for (int i = 0; i<ran.Next(1,20); i++) {
				tem1.Push(now.Pop());
		  }
			for (int i = 0; i <ran.Next(1,20); i++) {
				tem2.Push(now.Pop());
		  }
			foreach (var a in tem1) {
				now.Push(a);
			}
			tem1.Clear();
			foreach (var a in tem2) {
				now.Push(a);
			}
			tem2.Clear();
		}
		
		void helpclick(object sender, MouseEventArgs e)
		{
			helpform helping=new helpform();
			helping.ShowDialog();
			
		}
		
		void incard(object sender, MouseEventArgs e)
		{
			if (incard(空牌)) {
				if(now.Count==0)
				{
					MessageBox.Show("没牌了！！！,正在进行下一局","GameOver");
					goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)-20);
					ENDING(isItGameOver());
					return;
				}
						incard(now.Pop());
						cardload();
						cardsstcknum.Text=Convert.ToString(now.Count);
						goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)+goalcol()*3);
						if(isItGameOver())
						{ENDING(true);}
						
						return;
					
			}
			MessageBox.Show("你的手牌满了！！！！","魂淡，看看手牌",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
			
		}
		
		bool isItGameOver()
		{
			return Convert.ToInt32(goal.Text)<=-250;
		
		}
		void ENDING(bool b)
		{
		  if (b==true) 
		  {
			DialogResult result=MessageBox.Show("你输了！！是否重新开始新一轮游戏？","分数少于-250",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
		  	if (result==DialogResult.Yes) {
			cleartable();
			changecard();
			gamesnum.Text="0";
			goal.Text="0";
			return;			
			}else{
				Close();
			}
		  }
			return;
		}
		void cleartable()
		{
			for (int i = 0; i <10; i++) {
				if(!object.Equals(table[i],空牌)){
					bin.Push(table[i]);
				}
				//手牌全部弃除
			}
			for (int i = 0; i <10; i++) {
				table[i]=空牌;
			}
			foreach (card c in now) {
				bin.Push(c);
				//牌堆全部弃除
			}
			now.Clear();
		    foreach (card c in bin) {
				now.Push(c);
		    }
			bin.Clear();
			cardload();
			target=ran.Next(41,72);
			targettext.Text=Convert.ToString(target);
			gamesnum.Text=Convert.ToString(Convert.ToInt32(gamesnum.Text)+1);
		}
		int goalcol()//抽牌后判断是否超过目标点进行返回差值。
		{
		 int i=0;
		 foreach (card c in table) {
		 i+=c.cnum;
		 }
		 if (target-i>=0) {
		 	return 0;
		 }else{
		 return target-i;
		 }
		}
		
	
		
		void reset(object sender, MouseEventArgs e)
		{
			DialogResult result=MessageBox.Show("你确定要直接下一局吗？这将被立即扣除50分！","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
		   if (result==DialogResult.Yes) {
		   	goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)-50);
		   	if(isItGameOver()){
			ENDING(true);
		   	}else{
		   		cleartable();
		   	}
			}else{
			return;
			
			
			}
		}
		void cardload()
		{
					p1.Load(table[0].name);
					p2.Load(table[1].name);
					p3.Load(table[2].name);
					p4.Load(table[3].name);
					p5.Load(table[4].name);
					p6.Load(table[5].name);
					p7.Load(table[6].name);
					p8.Load(table[7].name);
					p9.Load(table[8].name);
					p10.Load(table[9].name);
					
		
		}
		bool incard(card c)
		{
		  for (int i = 0; i <10; i++) {
				if (object.Equals(table[i],空牌)) {
					table[i]=c;
					return true;
		  	}
			
		  }
		return false;
		}
		
		void win21(object sender, MouseEventArgs e)
		{
			int i=0;
			foreach (card c in table) {
		 i+=c.cnum;
		 }
		if (i==target) {
				MessageBox.Show("你终于凑够了了需求的点,即将开始下一局","恭喜你");
			for (int j = 0; j <10; j++) {
					if (object.Equals(table[j],小王)) {
					goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)+30);
					}else if (object.Equals(table[j],大王)) {
					goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)+50);
					}
			}
				goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)+Convert.ToInt32(cardsstcknum.Text)+Convert.ToInt32(gamesnum.Text)*10);
				cleartable();
				changecard();
				return;
		}
		MessageBox.Show("牌的总点数不是需求的点数！！！！","鱼唇！！！");
		goal.Text=Convert.ToString(Convert.ToInt32(goal.Text)-10);
		if(isItGameOver()){
			ENDING(true);
		   	}
		return;
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MYform Selfing=new MYform();
			Selfing.ShowDialog();
		}
		
		
		
		void P1bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[0],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[0]);
			table[0]=空牌;
			p1.Load(table[0].name);
			return;
			
		}
		
		void p2bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[1],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[1]);
			table[1]=空牌;
			p2.Load(table[1].name);
			return;
		}
		
		void p3bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[2],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[2]);
			table[2]=空牌;
			p3.Load(table[2].name);
			return;
		}
		
		void p4bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[3],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[3]);
			table[3]=空牌;
			p4.Load(table[3].name);
			return;
		}
		
		void p5bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[4],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[4]);
			table[4]=空牌;
			p5.Load(table[4].name);
			return;
		}
		
		void p6bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[5],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[5]);
			table[5]=空牌;
			p6.Load(table[5].name);
			return;
		}
		
		void p7bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[6],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[6]);
			table[6]=空牌;
			p7.Load(table[6].name);
			return;
		}
		
		void p8bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[7],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[7]);
			table[7]=空牌;
			p8.Load(table[7].name);
			return;
		}
		
		void p9bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[8],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[8]);
			table[8]=空牌;
			p9.Load(table[8].name);
			return;
		}
		
		
		
		void P10bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[9],空牌)) {
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？","呵呵");
				return;
			}
			bin.Push(table[9]);
			table[9]=空牌;
			p10.Load(table[9].name);
			return;
		}
	}
}
