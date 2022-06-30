using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static 扑克牌游戏.MainForm;

namespace 扑克牌游戏
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"object\goal.ini") == false)
            {
                DialogResult bu;
                bu = MessageBox.Show("goal.ini文件缺失，请联系管理员！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (bu == DialogResult.OK)
                {
                    //窗体关闭，关掉线程
                    System.Environment.Exit(0);
                }
            }
            if (File.Exists(@"object\temp.ini") == false)
            {
                DialogResult bu;
                bu = MessageBox.Show("temp.ini文件缺失，请联系管理员！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (bu == DialogResult.OK)
                {
                    //窗体关闭，关掉线程
                    System.Environment.Exit(0);
                }
            }
            Label[] namel = new Label[10] { name1, name2, name3, name4, name5, name6, name7, name8, name9, name10 };
            Label[] levell = new Label[10] { level1, level2, level3, level4, level5, level6, level7, level8, level9, level10 };
            Label[] goall = new Label[10] { goaln1, goaln2, goaln3, goaln4, goaln5, goaln6, goaln7, goaln8, goaln9, goaln10 };
            //万物皆可对象,这就方便了
            string[] data = new string[3];
            string Filename = @"object\goal.ini";
            for (int i = 0; i < 10; i++)
            {
                data = File.ReadAllLines(Filename)[i].Split(' ');
                namel[i].Text = data[0].ToString();
                levell[i].Text = data[1].ToString();
                goall[i].Text = data[2].ToString();
            }
            nameu.Text = File.ReadAllLines(@"object\temp.ini")[0];
            levelu.Text = AllTheProject.level.ToString();
            goalnu.Text = AllTheProject.maxgoal.ToString();
        }
    }
}
