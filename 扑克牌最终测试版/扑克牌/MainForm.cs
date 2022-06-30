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
using System.IO;
using System.Windows.Forms;


namespace 扑克牌游戏
{
	public struct user
	{
		public string datalevel;
		public string dataname;
	}

	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

		public int target = 42;
		public bool sw = false;//判断是不是无尽模式
		public bool js = false;//计时模式开启
		public bool xs = false;//限时模式开启



		public struct card
		{
			public string name;
			public int cnum;

			public card(string c, int n)
			{
				this.name = c;
				this.cnum = n;
			}
		}


		public card[] table = new card[10];
		card 空牌 = new card("img/卡背.png", 0);
		card 黑桃A = new card("img/黑桃A.png", 1);
		card 黑桃2 = new card("img/黑桃2.png", 2);
		card 黑桃3 = new card("img/黑桃3.png", 3);
		card 黑桃4 = new card("img/黑桃4.png", 4);
		card 黑桃5 = new card("img/黑桃5.png", 5);
		card 黑桃6 = new card("img/黑桃6.png", 6);
		card 黑桃7 = new card("img/黑桃7.png", 7);
		card 黑桃8 = new card("img/黑桃8.png", 8);
		card 黑桃9 = new card("img/黑桃9.png", 9);
		card 黑桃10 = new card("img/黑桃10.png", 10);
		card 黑桃J = new card("img/黑桃J.png", 11);
		card 黑桃Q = new card("img/黑桃Q.png", 12);
		card 黑桃K = new card("img/黑桃K.png", 13);
		card 红桃A = new card("img/红桃A.png", 1);
		card 红桃2 = new card("img/红桃2.png", 2);
		card 红桃3 = new card("img/红桃3.png", 3);
		card 红桃4 = new card("img/红桃4.png", 4);
		card 红桃5 = new card("img/红桃5.png", 5);
		card 红桃6 = new card("img/红桃6.png", 6);
		card 红桃7 = new card("img/红桃7.png", 7);
		card 红桃8 = new card("img/红桃8.png", 8);
		card 红桃9 = new card("img/红桃9.png", 9);
		card 红桃10 = new card("img/红桃10.png", 10);
		card 红桃J = new card("img/红桃J.png", 11);
		card 红桃Q = new card("img/红桃Q.png", 12);
		card 红桃K = new card("img/红桃K.png", 13);
		card 方片A = new card("img/方片A.png", 1);
		card 方片2 = new card("img/方片2.png", 2);
		card 方片3 = new card("img/方片3.png", 3);
		card 方片4 = new card("img/方片4.png", 4);
		card 方片5 = new card("img/方片5.png", 5);
		card 方片6 = new card("img/方片6.png", 6);
		card 方片7 = new card("img/方片7.png", 7);
		card 方片8 = new card("img/方片8.png", 8);
		card 方片9 = new card("img/方片9.png", 9);
		card 方片10 = new card("img/方片10.png", 10);
		card 方片J = new card("img/方片J.png", 11);
		card 方片Q = new card("img/方片Q.png", 12);
		card 方片K = new card("img/方片K.png", 13);
		card 梅花A = new card("img/梅花A.png", 1);
		card 梅花2 = new card("img/梅花2.png", 2);
		card 梅花3 = new card("img/梅花3.png", 3);
		card 梅花4 = new card("img/梅花4.png", 4);
		card 梅花5 = new card("img/梅花5.png", 5);
		card 梅花6 = new card("img/梅花6.png", 6);
		card 梅花7 = new card("img/梅花7.png", 7);
		card 梅花8 = new card("img/梅花8.png", 8);
		card 梅花9 = new card("img/梅花9.png", 9);
		card 梅花10 = new card("img/梅花10.png", 10);
		card 梅花J = new card("img/梅花J.png", 11);
		card 梅花Q = new card("img/梅花Q.png", 12);
		card 梅花K = new card("img/梅花K.png", 13);
		card 大王 = new card("img/大王.png", 0);
		card 小王 = new card("img/小王.png", 0);
		private Stack<card> bin = new Stack<card>();
		private Stack<card> now = new Stack<card>();
		private Stack<card> tem1 = new Stack<card>();
		private Stack<card> tem2 = new Stack<card>();
		Random ran = new Random();

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
			this.BeginInvoke(new Action(() =>
			{
				this.Hide();
				this.Opacity = 1;
				new nameInput().Show();//用户名界面，详情见相应文件
			}));//隐藏主窗口为了调出用户名界面

			loading_instack();
			changecard();

			for (int i = 0; i < 10; i++)
			{
				table[i] = 空牌;
			}
			cardload();
			target = 21;
			targettext.Text = Convert.ToString(target);
			pictureBox1.Load(空牌.name);
			/*
			 *target =ran.Next(41,72);
			 *targettext.Text=Convert.ToString(target);
			 */
		}
		private void changecard()
		{
			/* 洗牌函数，该程序的核心。
			 * 交替打乱然后进行堆叠。
			 * 之后进行任意的切牌。
			 */
			for (int i = 0; i < 2; i++)
			{
				randwash();
			}

			for (int i = 0; i < 3; i++)
			{
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
			for (int i = 0; i < 27; i++)
			{
				tem1.Push(now.Pop());
			}
			for (int i = 0; i < 27; i++)
			{
				tem2.Push(now.Pop());
			}

		}
		private void wash()
		{//实现交叉洗牌。
			for (int i = 0; i < 54; i++)
			{
				switch (i % 2)
				{
					case 1:
						now.Push(tem1.Pop());
						break;
					case 0:
						now.Push(tem2.Pop());
						break;
				}
			}

		}
		private void randwash()
		{//模拟切牌的过程。
			for (int i = 0; i < ran.Next(1, 20); i++)
			{
				tem1.Push(now.Pop());
			}
			for (int i = 0; i < ran.Next(1, 20); i++)
			{
				tem2.Push(now.Pop());
			}
			foreach (var a in tem1)
			{
				now.Push(a);
			}
			tem1.Clear();
			foreach (var a in tem2)
			{
				now.Push(a);
			}
			tem2.Clear();
		}

		void helpclick(object sender, MouseEventArgs e)
		{
			helpform helping = new helpform();
			helping.ShowDialog();

		}

		void incard(object sender, MouseEventArgs e)
		{
			if (AllTheProject.level >= 4 && !AllTheProject.buff)
			{
				MessageBox.Show("你还没有选增益效果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
			}
			if (AllTheProject.level >= 5 && !AllTheProject.debuff)
			{
				MessageBox.Show("你还没有选减益效果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (js&& !AllTheProject.xg[1]) 
			{
				timelabel.Text = "30";
				timer2.Start( );
			}
            if (!xs&& AllTheProject.dexg[1]) 
			{
				xs = true;
				timer3.Start();
				timelabel.Text = "600";


			}
			if (incard(空牌))
			{
				if (now.Count == 0)
				{
					if (sw)
					{
						MessageBox.Show("没牌了！！进行下一局游戏。");
						if (AllTheProject.maxgoal < Convert.ToInt32(goal.Text))
						{
							AllTheProject.maxgoal = Convert.ToInt32(goal.Text);
							MessageBox.Show("当前分数已更新", "恭喜你");
						}
						regame();
						return;

						
					}
					MessageBox.Show("没牌了！！！游戏结束", "GameOver");
					if (AllTheProject.maxgoal < Convert.ToInt32(goal.Text))
					{
						AllTheProject.maxgoal = Convert.ToInt32(goal.Text);
						MessageBox.Show("当前分数已更新", "恭喜你");
					}
					ENDING(true);
					return;
				}
				incard(now.Pop());
				cardload();
				cardsstcknum.Text = Convert.ToString(now.Count);
				if (!AllTheProject.xg[3])
                {
					if (AllTheProject.dexg[5])
					{
						goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + goalcol() * 4);
					}
					else
					{
						goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + goalcol() * 2);
					}
				}
				if (AllTheProject.xg[4] && Convert.ToInt32(goal.Text) < 0)
				{
					goal.Text = "0";
				}
				
				if (AllTheProject.level >= 3 && !AllTheProject.dexg[4])
				{
					if (now.Count != 0)
					{
						pictureBox1.Load(now.Peek().name);
					}
					else
					{
						pictureBox1.Load(空牌.name);
					}

				}
                if (AllTheProject.xg[5]) 
				{
					int i = 0;
					foreach (card c in table)
					{
						i += c.cnum;
					}
					psum.Text = i.ToString();
				}
				if (isItGameOver())
				{ ENDING(true); }

				return;

			}
			MessageBox.Show("你的手牌满了！！！！", "魂淡，看看手牌", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;

		}

		bool isItGameOver()
		{
			return Convert.ToInt32(goal.Text) <= -250;

		}
		void ENDING(bool b)
		{
			if (b == true)
			{
				timer2.Stop();
				if (Namelabel.Text != "练习模式")
				{
					DialogResult re = MessageBox.Show("你输了！！是否上传分数？", "gameover", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (re == DialogResult.Yes)
					{

						user[] users = new user[11];
						int[] datagoal = new int[11];
						users[10].dataname = File.ReadAllLines(@"object\temp.ini")[0];
						users[10].datalevel = AllTheProject.level.ToString();
						datagoal[10] = AllTheProject.maxgoal;




						string[] inp = new string[3];
						for (int i = 0; i < 10; i++)
						{
							inp = File.ReadAllLines(@"object\goal.ini")[i].Split(' ');
							users[i].dataname = inp[0];//name
							users[i].datalevel = inp[1];//level
							datagoal[i] = Convert.ToInt32(inp[2]);//goal


						}
						Array.Sort(datagoal, users);//降序排列
						Array.Reverse(datagoal);//调成升序
						Array.Reverse(users);//调成升序
						File.WriteAllText(@"object\goal.ini", string.Empty);
						for (int i = 0; i < 10; i++)
						{
							File.AppendAllText(@"object\goal.ini", users[i].dataname + " " + users[i].datalevel + " " + datagoal[i].ToString() + "\n");
						}
						new From1().Show();
					}
				}
				DialogResult result = MessageBox.Show("你输了！！是否重新开始新一轮游戏？", "gameover", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (result == DialogResult.Yes)
				{
					regame();
					return;
				}
				else
				{
					Close();
				}
			}
			return;
		}
		void cleartable()
		{
			for (int i = 0; i < 10; i++)
			{
				if (!object.Equals(table[i], 空牌))
				{
					bin.Push(table[i]);
				}
				//手牌全部弃除
			}
			for (int i = 0; i < 10; i++)
			{
				table[i] = 空牌;
			}
			foreach (card c in now)
			{
				bin.Push(c);
				//牌堆全部弃除
			}
			now.Clear();
			foreach (card c in bin)
			{
				now.Push(c);
			}
			bin.Clear();
			cardload();
			if (AllTheProject.level > 2)
			{
				target = ran.Next(41, 72);
				targettext.Text = Convert.ToString(target);
			}
			else
			{
				target = 21;
				targettext.Text = Convert.ToString(target);
			}
		}
		int goalcol()//抽牌后判断是否超过目标点进行返回差值。
		{
			int i = 0;
			foreach (card c in table)
			{
				i += c.cnum;
			}
			if (target - i >= 0)
			{
				return 0;
			}
			else
			{
				return target - i;
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
			for (int i = 0; i < 10; i++)
			{
				if (object.Equals(table[i], 空牌))
				{
					table[i] = c;
					return true;
				}

			}
			return false;
		}

		void win21(object sender, MouseEventArgs e)
		{
			if (cardsstcknum.Text=="54") 
			{
				MessageBox.Show("你还没抽牌呢！！！");
				return;
			}
			int i = 0;
			foreach (card c in table)
			{
				i += c.cnum;
			}
			if (i == target)
			{
				timer2.Stop();
				timer3.Stop();
				MessageBox.Show("你终于凑够了了需求的点,即将开始下一局", "恭喜你");
				if (AllTheProject.dexg[0])
				{
					for (int j = 0; j < 10; j++)
					{
						if (object.Equals(table[j], 小王))
						{
							goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + 30);
						}
						else if (object.Equals(table[j], 大王))
						{
							goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + 50);
						}
					}
				}
					goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + Convert.ToInt32(cardsstcknum.Text));
					if (AllTheProject.xg[0]) //翻倍效果
					{
						goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + Convert.ToInt32(cardsstcknum.Text));
					if (AllTheProject.dexg[0])
					{
						for (int j = 0; j < 10; j++)
						{
							if (object.Equals(table[j], 小王))
							{
								goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + 30);
							}
							else if (object.Equals(table[j], 大王))
							{
								goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) + 50);
							}
						}
					}
						
					}
				
				if (AllTheProject.maxgoal < Convert.ToInt32(goal.Text))
				{
					AllTheProject.maxgoal = Convert.ToInt32(goal.Text);
					MessageBox.Show("当前分数已更新", "恭喜你");
				}
				levelUp();
				if (AllTheProject.level >= 2) 
				{
					js = true;
				
				}
				AllTheProject.buff = false;
				for (int j = 0; j < 6; j++)
				{
					AllTheProject.xg[j] = false;
				}
				psum.Text = string.Empty;
				cardsstcknum.Text = "54";
				cleartable();
				changecard();
				pictureBox1.Load(空牌.name);
				
				AllTheProject.buff = false;
				AllTheProject.debuff = false;
				timelabel.Text = "∞";
				for (int p = 0; p < 6; p++)
				{
					AllTheProject.dexg[p] = false;
				}
				xs = false;
				return;
			}
			MessageBox.Show("牌的总点数不是需求的点数！！！！", "鱼唇！！！");
			goal.Text = Convert.ToString(Convert.ToInt32(goal.Text) - 10);
			if (AllTheProject.xg[4] && Convert.ToInt32(goal.Text) < 0)
			{
				goal.Text = "0";
			}
			if (isItGameOver())
			{
				ENDING(true);
			}
			return;
		}

		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MYform Selfing = new MYform();
			Selfing.ShowDialog();
		}



		void P1bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[0], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[0]);
			table[0] = 空牌;
			p1.Load(table[0].name);
			return;

		}

		void p2bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[1], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[1]);
			table[1] = 空牌;
			p2.Load(table[1].name);
			return;
		}

		void p3bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[2], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[2]);
			table[2] = 空牌;
			p3.Load(table[2].name);
			return;
		}

		void p4bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[3], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[3]);
			table[3] = 空牌;
			p4.Load(table[3].name);
			return;
		}

		void p5bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[4], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[4]);
			table[4] = 空牌;
			p5.Load(table[4].name);
			return;
		}

		void p6bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[5], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[5]);
			table[5] = 空牌;
			p6.Load(table[5].name);
			return;
		}

		void p7bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[6], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[6]);
			table[6] = 空牌;
			p7.Load(table[6].name);
			return;
		}

		void p8bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[7], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[7]);
			table[7] = 空牌;
			p8.Load(table[7].name);
			return;
		}

		void p9bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[8], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[8]);
			table[8] = 空牌;
			p9.Load(table[8].name);
			return;
		}



		void P10bin(object sender, MouseEventArgs e)
		{
			if (object.Equals(table[9], 空牌))
			{
				MessageBox.Show("然鹅，这里没有牌，你想弃什么？", "呵呵");
				return;
			}
			bin.Push(table[9]);
			table[9] = 空牌;
			p10.Load(table[9].name);
			return;
		}

		private void incardbutton_Click(object sender, EventArgs e)
		{

		}
		private void userLoad()
		{
			this.Hide();
			new nameInput().Show();

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (AllTheProject.loadbool)
			{
				string[] lines = File.ReadAllLines(@"object\temp.ini");
				if (lines[0] != "练习模式")
				{
					Namelabel.Text = lines[0] + "的游戏";
				}
				this.Show();
				timer1.Stop();

			}
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new From1().ShowDialog();
		}
		private void levelUp()//游戏轮数增加判断
		{
			if (AllTheProject.levelnum[0])
			{
				AllTheProject.level = 1;
				label3.Text = "第" + Convert.ToString(AllTheProject.level) + "轮";
				AllTheProject.levelnum[0] = false;
				AllTheProject.levelnum[1] = true;
			}
			else if (Convert.ToInt32(goal.Text) > 100 && AllTheProject.levelnum[1])
			{
				AllTheProject.level = 2;
				label3.Text = "第" + Convert.ToString(AllTheProject.level) + "轮";
				AllTheProject.levelnum[1] = false;
				AllTheProject.levelnum[2] = true;

			}
			else if (Convert.ToInt32(goal.Text) > 200 && AllTheProject.levelnum[2])
			{
				AllTheProject.level = 3;
				label3.Text = "第" + Convert.ToString(AllTheProject.level) + "轮";
				AllTheProject.levelnum[2] = false;
				AllTheProject.levelnum[3] = true;
			}
			else if (Convert.ToInt32(goal.Text) > 300 && AllTheProject.levelnum[3])
			{
				AllTheProject.level = 4;
				label3.Text = "第" + Convert.ToString(AllTheProject.level) + "轮";
				AllTheProject.levelnum[3] = false;
				AllTheProject.levelnum[4] = true;
			}
			else if (Convert.ToInt32(goal.Text) >= 400 && AllTheProject.levelnum[4])
			{
				AllTheProject.level = 5;
				label3.Text = "第" + Convert.ToString(AllTheProject.level) + "轮";
				sw = true;//无尽模式开启
				AllTheProject.levelnum[4] = false;

			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult re = MessageBox.Show("你确定关闭游戏吗？这将无法保存您的游戏！", "提示", MessageBoxButtons.YesNo);
			if (re == DialogResult.No)
			{
				e.Cancel = true;
			}
			if (re == DialogResult.Yes)
			{
				if (Namelabel.Text != "练习模式")
				{
					DialogResult res = MessageBox.Show("是否上传分数？", "gameover", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (res == DialogResult.Yes)
					{

						user[] users = new user[11];
						int[] datagoal = new int[11];
						users[10].dataname = File.ReadAllLines(@"object\temp.ini")[0];
						users[10].datalevel = AllTheProject.level.ToString();
						datagoal[10] = AllTheProject.maxgoal;




						string[] inp = new string[3];
						for (int i = 0; i < 10; i++)
						{
							inp = File.ReadAllLines(@"object\goal.ini")[i].Split(' ');
							users[i].dataname = inp[0];//name
							users[i].datalevel = inp[1];//level
							datagoal[i] = Convert.ToInt32(inp[2]);//goal


						}
						Array.Sort(datagoal, users);//降序排列
						Array.Reverse(datagoal);//调成升序
						Array.Reverse(users);//调成升序
						File.WriteAllText(@"object\goal.ini", string.Empty);
						for (int i = 0; i < 10; i++)
						{
							File.AppendAllText(@"object\goal.ini", users[i].dataname + " " + users[i].datalevel + " " + datagoal[i].ToString() + "\n");
						}
						MessageBox.Show("分数已上传！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					}
				}
				System.Environment.Exit(0);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult re = MessageBox.Show("你确定要重新开始吗？", "提示", MessageBoxButtons.YesNo);
			if (re == DialogResult.No)
			{
				return;
			}
			if (re == DialogResult.Yes)
			{
				if (Namelabel.Text != "练习模式")
				{
					DialogResult res = MessageBox.Show("是否上传分数？", "gameover", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (res == DialogResult.Yes)
					{

						user[] users = new user[11];
						int[] datagoal = new int[11];
						users[10].dataname = File.ReadAllLines(@"object\temp.ini")[0];
						users[10].datalevel = AllTheProject.level.ToString();
						datagoal[10] = AllTheProject.maxgoal;




						string[] inp = new string[3];
						for (int i = 0; i < 10; i++)
						{
							inp = File.ReadAllLines(@"object\goal.ini")[i].Split(' ');
							users[i].dataname = inp[0];//name
							users[i].datalevel = inp[1];//level
							datagoal[i] = Convert.ToInt32(inp[2]);//goal


						}
						Array.Sort(datagoal, users);//降序排列
						Array.Reverse(datagoal);//调成升序
						Array.Reverse(users);//调成升序
						File.WriteAllText(@"object\goal.ini", string.Empty);
						for (int i = 0; i < 10; i++)
						{
							File.AppendAllText(@"object\goal.ini", users[i].dataname + " " + users[i].datalevel + " " + datagoal[i].ToString() + "\n");
						}
						MessageBox.Show("分数已上传！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					}
				}
				regame();
				return;
			}
		}
		public class AllTheProject//全局变量声明处
		{
			public static bool loadbool = false; //想从子菜单调用回主窗口可不容易，需要一个开关
			public static int level = 1;//游戏轮数
			public static int maxgoal = 0;//分数等级
			public static bool[] levelnum = new bool[5] { false, true, false, false, false };//阶段开关
			public static bool buff = false;
			public static bool[] xg = new bool[6] { false, false , false , false , false , false };
			public static bool debuff = false;
			public static bool[] dexg = new bool[6] { false, false, false, false, false, false };
		}

        private void timer2_Tick(object sender, EventArgs e)
        {
			if (Convert.ToInt32(timelabel.Text) == 0)
			{
				ENDING(true);
				timer2.Stop();
				return;
			}
			else 
			{
				int num;
				num=Convert.ToInt32(timelabel.Text);
				num--;
				timelabel.Text = num.ToString();
				return;

			}
        }
		private void regame() 
		{
			cleartable();
			changecard();
			timer2.Stop();
			timer3.Stop();
			cardsstcknum.Text = "54";
			AllTheProject.levelnum[0] = false;
			AllTheProject.levelnum[1] = true;
			AllTheProject.levelnum[2] = false;
			AllTheProject.levelnum[3] = false;
			AllTheProject.levelnum[4] = false;
			AllTheProject.level = 1;
			AllTheProject.buff = false;
			AllTheProject.debuff = false;
			goal.Text = "0";
			AllTheProject.maxgoal = 0;
			timelabel.Text = "∞";
			sw = false;
			js = false;
			psum.Text = string.Empty;
			pictureBox1.Load(空牌.name);
			for (int i = 0; i < 6; i++)
            {
				AllTheProject.xg[i] = false;
            }
			for (int i = 0; i < 6; i++)
			{
				AllTheProject.dexg[i] = false;
			}
			xs = false;

		}

        private void button2_MouseClick(object sender, MouseEventArgs e)//增益效果
        {
			if (AllTheProject.level>=4 && !AllTheProject.buff) {
				new Form2().ShowDialog();
				pandaun();
			}
        }
		private void pandaun() 
		{
			if (AllTheProject.xg[2] && !AllTheProject.dexg[2] && !AllTheProject.dexg[3] ) 
			{
				target = 9;
				targettext.Text = "9";

			}
			if (AllTheProject.xg[4] && Convert.ToInt32(goal.Text) < 0)
			{
				goal.Text = "0";
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
			if (AllTheProject.level >= 5 && !AllTheProject.debuff)
			{
				new Form3().ShowDialog();
				depandaun();
			}
		}
		private void depandaun()
		{
			if (AllTheProject.dexg[2])
			{
				target = 99;
				targettext.Text = "99";

			}
			if (AllTheProject.dexg[3])
			{
				target = 1;
				targettext.Text = "1";
			}
		}

        private void timer3_Tick(object sender, EventArgs e)
        {
			if (Convert.ToInt32(timelabel.Text) == 0)
			{
				ENDING(true);
				timer3.Stop();
				return;
			}
			else
			{
				int num;
				num = Convert.ToInt32(timelabel.Text);
				num--;
				timelabel.Text = num.ToString();
				return;

			}
		}
    }
}
