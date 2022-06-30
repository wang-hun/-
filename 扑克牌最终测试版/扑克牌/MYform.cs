/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/27
 * 时间: 21:12
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 扑克牌游戏
{
	/// <summary>
	/// Description of MYform.
	/// </summary>
	public partial class MYform : Form
	{
		public MYform()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void HelpquitMouseClick(object sender, MouseEventArgs e)
		{
			Close();
		}

        private void MYform_Load(object sender, EventArgs e)
        {

        }
    }
}
