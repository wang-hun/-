using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static 扑克牌游戏.MainForm;

namespace 扑克牌游戏
{
    public partial class nameInput : Form
    {
        public nameInput()
        {
            InitializeComponent();
        }

        private void nameInput_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;//键盘监听
            MessageBox.Show("如果您是第一次游玩，建议点击游戏窗口左上的帮助按钮，获取游戏规则说明\n关于加强版的说明：你需要更好的心算能力了。因为运算只会变困难。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (File.Exists(@"object\temp.ini") == false)
            {
                File.Create(@"object\temp.ini");//文件缺失将自动补全;;;其实我想直接弹警告然后退出的，尤其是排行榜，我绝对不想每一次都生成一个新的排行榜！还要往里填初始数据！
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          DialogResult re=MessageBox.Show("你确定要用练习模式开始游戏吗？这将无法将您的分数保存到排行榜！","提示",MessageBoxButtons.YesNo);
            if (re==DialogResult.Yes ) 
            {
                File.WriteAllText("object/temp.ini", "练习模式");
                AllTheProject.loadbool = true;
                this.Hide();
               
            }
           
        }

        private void nameInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);//关闭进程，虽然我把关闭按钮关了，但是肯定会有人强制关闭
        }

        private void SubmitButton_Click(object sender, EventArgs e)//按钮事件
        {
            EndThisFrom( );
        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)//键盘监听
        {
            if (e.KeyCode == Keys.Enter) 
            {
                EndThisFrom( );
            }
        }
        private void EndThisFrom() //关闭用户名界面的函数
        {
            if (NameBox.Text == string.Empty)
            {
                MessageBox.Show("用户名不要为空白啊(▼ヘ▼#)", "ヽ(#`Д´)ﾉ┌┛〃你绝对是故意的", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.WriteAllText("object/temp.ini", NameBox.Text);
            AllTheProject.loadbool = true;
            this.Hide();
        }

        private void nameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EndThisFrom();
            }
        }

        private void NameBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("用户名不可以含有 空 格 啊(▼ヘ▼#)", "ヽ(#`Д´)ﾉ┌┛〃你绝对是故意的", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameBox.Text = string.Empty;
                return;
            }
        }
    }
}
