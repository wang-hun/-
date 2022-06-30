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
    public partial class Form3 : Form
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
        
        fucard 暗符 = new fucard(@"img\暗符「雾之伦敦人偶」.jpg", 1, "大小王不再增加得分", "暗符「雾之伦敦人偶」");
        fucard 红符 = new fucard(@"img\「Red Magic」.jpg", 2, "本局总时长变成600秒,抽牌不再增加时长", "「Red Magic」");
        fucard 小槌 = new fucard(@"img\小槌「变得更大吧」.jpg", 3, "目标点数变为99点，且优先于点数变成9点增益效果", "小槌「变得更大吧」");
        fucard 转世 = new fucard(@"img\转世「一条归桥」.jpg", 4, "目标点数变为1点，且优先于点数变成9点增益效果", "转世「一条归桥」");
        fucard 夜雀 = new fucard(@"img\夜雀「午夜中的合唱指挥」.jpg", 5, "局不再显示下一张牌", "夜雀「午夜中的合唱指挥」");
        fucard 幻想 = new fucard(@"img\幻想「花鸟风月，啸风弄月」.jpg", 1, "本局抽卡将扣除原先两倍的分数，会受到抽卡不扣除分数的影响", "幻想「花鸟风月，啸风弄月」");


        /// <summary>
        /// 效果表
        /// 1.大小王不再增加得分  √ √
        /// 2.本局总时长变成600秒,抽牌不再增加时长 √ √
        /// 3.目标点数变为99点，且优先于点数变成9点增益效果  √ √
        /// 4.目标点数变为1点，且优先于点数变成9点增益效果  √ √
        /// 5.本局不再显示下一张牌 √ √
        /// 6.本局抽卡将扣除原先两倍的分数，会受到抽卡不扣除分数的影响 √
        /// </summary>
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            card.Add(暗符);
            card.Add(红符);
            card.Add(小槌);
            card.Add(转世);
            card.Add(夜雀);
            card.Add(幻想);
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
            
             AllTheProject.debuff = true;
            
            if (radioButton1.Checked) 
            {
                AllTheProject.dexg[nowcard[0].xg]= true;
            }
            else if (radioButton2.Checked)
            {
                AllTheProject.dexg[nowcard[1].xg] = true;
            }else if (radioButton3.Checked)
            {
                AllTheProject.dexg[nowcard[2].xg] = true;
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
