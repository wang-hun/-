using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static 扑克牌游戏.MainForm;

namespace 扑克牌游戏
{
    public partial class Form2 : Form
    {
        private struct fucard 
        {
            public string name;
            public int xg;//效果
            public string text;
            public string cardname;
            public fucard(string v1,int v2,string v3,string v4) 
            {
                name = v1;
                xg = v2;
                text = v3;
                cardname = v4;
            }
            
        }
        private List<fucard> nowcard = new List<fucard>();
        private List<fucard> card = new List<fucard>();
        
        fucard 兔符 = new fucard(@"img\兔「Ancient Duper」.jpg",1,"本局分数翻倍", "兔「Ancient Duper」");
        fucard 幻世 = new fucard(@"img\幻世「The World」.png", 2, "本局不再限时", "幻世「The World」");
        fucard 冻符 = new fucard(@"img\冻符「Perfect Freeze」.png", 3, "目标点数变成9点", "冻符「Perfect Freeze」");
        fucard 奇迹 = new fucard(@"img\奇迹「白昼的客星」.png", 4, "抽牌不再扣除点数", "奇迹「白昼的客星」");
        fucard 埴轮 = new fucard(@"img\埴轮「不败的无尽兵团」.png", 5, "本回合点数不会低于0点", "埴轮「不败的无尽兵团」");
        fucard 未确定 = new fucard(@"img\未确认「幽浮戏画」.png", 1, "显示点数总和", "未确认「幽浮戏画」");


        /// <summary>
        /// 效果表
        /// 1.本局分数将会翻倍 √
        /// 2.本局不再限时     √
        /// 3.目标点数变为9点  √
        /// 4.抽牌不再扣除点数  √
        /// 5.本回合点数不会低于0点 √
        /// 6.显示点数总和 √
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            card.Add(兔符);
            card.Add(幻世);
            card.Add(冻符);
            card.Add(奇迹);
            card.Add(埴轮);
            card.Add(未确定);
            Random ran = new Random();
            PictureBox[] pbox3 = new PictureBox[3] { pictureBox1,pictureBox2,pictureBox3};
            Label[] L3 = new Label[3] { label2,label3,label4};

            for (int i = 0; i < 3; i++)
            {
                int rann;
                rann=ran.Next(card.Count);
                pbox3[i].Load(card[rann].name);
                L3[i].Text = card[rann].cardname;
                nowcard.Add(card[rann]);
                card.RemoveAt(rann);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            AllTheProject.buff = true;
            
            if (radioButton1.Checked) 
            {
                AllTheProject.xg[nowcard[0].xg]= true;
            }
            else if (radioButton2.Checked)
            {
                AllTheProject.xg[nowcard[1].xg] = true;
            }else if (radioButton3.Checked)
            {
                AllTheProject.xg[nowcard[2].xg] = true;
            }
            this.Close();
        }

     
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(nowcard[0].text, this.pictureBox1, 5000);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show(nowcard[1].text, this.pictureBox2, 5000);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show(nowcard[2].text, this.pictureBox3, 5000);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;

        }
    }
}
