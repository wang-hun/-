/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/23
 * 时间: 18:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 扑克牌游戏
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class helpform : Form
	{
		public helpform()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void helpquiting(object sender, MouseEventArgs e)
		{
			this.Close();
		}

        private void helpform_Load(object sender, EventArgs e)
        {

        }
    }
}
