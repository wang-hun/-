/*
 * 由SharpDevelop创建。
 * 用户： WH
 * 日期: 2021/12/22
 * 时间: 19:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 扑克牌游戏
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cardsstcknum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incardbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p10 = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.saywin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.targettext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.psum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("黑体", 10F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "剩余牌数：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cardsstcknum
            // 
            this.cardsstcknum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cardsstcknum.Font = new System.Drawing.Font("宋体", 30F);
            this.cardsstcknum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cardsstcknum.Location = new System.Drawing.Point(124, 0);
            this.cardsstcknum.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cardsstcknum.Name = "cardsstcknum";
            this.cardsstcknum.Size = new System.Drawing.Size(128, 63);
            this.cardsstcknum.TabIndex = 1;
            this.cardsstcknum.Text = "54";
            this.cardsstcknum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cardsstcknum);
            this.panel1.Location = new System.Drawing.Point(79, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 65);
            this.panel1.TabIndex = 2;
            // 
            // incardbutton
            // 
            this.incardbutton.BackColor = System.Drawing.Color.LightGray;
            this.incardbutton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.incardbutton.Font = new System.Drawing.Font("宋体", 20F);
            this.incardbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.incardbutton.Location = new System.Drawing.Point(607, 104);
            this.incardbutton.Name = "incardbutton";
            this.incardbutton.Size = new System.Drawing.Size(202, 80);
            this.incardbutton.TabIndex = 4;
            this.incardbutton.Text = "抽牌";
            this.incardbutton.UseVisualStyleBackColor = false;
            this.incardbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.incard);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.p7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 204);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 147);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p7.Location = new System.Drawing.Point(555, 3);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(82, 140);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p7.TabIndex = 9;
            this.p7.TabStop = false;
            this.p7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p7bin);
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p6.Location = new System.Drawing.Point(463, 3);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(82, 140);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p6.TabIndex = 8;
            this.p6.TabStop = false;
            this.p6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p6bin);
            // 
            // p8
            // 
            this.p8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p8.Location = new System.Drawing.Point(647, 3);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(82, 140);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p8.TabIndex = 7;
            this.p8.TabStop = false;
            this.p8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p8bin);
            // 
            // p10
            // 
            this.p10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p10.Location = new System.Drawing.Point(831, 3);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(82, 140);
            this.p10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p10.TabIndex = 6;
            this.p10.TabStop = false;
            this.p10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.P10bin);
            // 
            // p9
            // 
            this.p9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p9.Location = new System.Drawing.Point(739, 3);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(82, 140);
            this.p9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p9.TabIndex = 5;
            this.p9.TabStop = false;
            this.p9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p9bin);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2.Location = new System.Drawing.Point(95, 3);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(82, 140);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2.TabIndex = 4;
            this.p2.TabStop = false;
            this.p2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p2bin);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Location = new System.Drawing.Point(3, 3);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(82, 140);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 3;
            this.p1.TabStop = false;
            this.p1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.P1bin);
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3.Location = new System.Drawing.Point(187, 3);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(82, 140);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p3.TabIndex = 2;
            this.p3.TabStop = false;
            this.p3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p3bin);
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p5.Location = new System.Drawing.Point(371, 3);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(82, 140);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p5.TabIndex = 1;
            this.p5.TabStop = false;
            this.p5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p5bin);
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4.Location = new System.Drawing.Point(279, 3);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(82, 140);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p4.TabIndex = 0;
            this.p4.TabStop = false;
            this.p4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p4bin);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.goal);
            this.panel2.Location = new System.Drawing.Point(568, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 65);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("黑体", 10F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "分数：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goal
            // 
            this.goal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.goal.Font = new System.Drawing.Font("宋体", 30F);
            this.goal.ForeColor = System.Drawing.Color.Teal;
            this.goal.Location = new System.Drawing.Point(125, 0);
            this.goal.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(128, 63);
            this.goal.TabIndex = 1;
            this.goal.Text = "0";
            this.goal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saywin
            // 
            this.saywin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saywin.Font = new System.Drawing.Font("华文琥珀", 36.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saywin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saywin.Location = new System.Drawing.Point(342, 104);
            this.saywin.Name = "saywin";
            this.saywin.Size = new System.Drawing.Size(211, 79);
            this.saywin.TabIndex = 8;
            this.saywin.Text = "OH!YE!";
            this.saywin.UseVisualStyleBackColor = true;
            this.saywin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.win21);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 18F);
            this.linkLabel1.Location = new System.Drawing.Point(780, 391);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 44);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "关于作者";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // targettext
            // 
            this.targettext.Font = new System.Drawing.Font("宋体", 39F);
            this.targettext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.targettext.Location = new System.Drawing.Point(372, 17);
            this.targettext.Name = "targettext";
            this.targettext.Size = new System.Drawing.Size(159, 56);
            this.targettext.TabIndex = 10;
            this.targettext.Text = "21";
            this.targettext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Font = new System.Drawing.Font("宋体", 18F);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(35, 388);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(169, 44);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "排行榜";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Namelabel
            // 
            this.Namelabel.Font = new System.Drawing.Font("宋体", 16.27826F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Namelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Namelabel.Location = new System.Drawing.Point(35, 104);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(278, 78);
            this.Namelabel.TabIndex = 12;
            this.Namelabel.Text = "练习模式";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(359, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 68);
            this.label3.TabIndex = 13;
            this.label3.Text = "第1轮";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1222, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 68);
            this.label4.TabIndex = 15;
            this.label4.Text = "下一张";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1235, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "将于第三轮后解锁";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1254, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "重新开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(869, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "将于第二轮后解锁";
            // 
            // timelabel
            // 
            this.timelabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timelabel.Font = new System.Drawing.Font("宋体", 39F);
            this.timelabel.ForeColor = System.Drawing.Color.Red;
            this.timelabel.Location = new System.Drawing.Point(905, 46);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(159, 56);
            this.timelabel.TabIndex = 19;
            this.timelabel.Text = "∞";
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 16.27826F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(909, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 54);
            this.label7.TabIndex = 20;
            this.label7.Text = "剩余时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1008, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "将于第四轮后解锁";
            // 
            // psum
            // 
            this.psum.Font = new System.Drawing.Font("宋体", 16.27826F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.psum.Location = new System.Drawing.Point(826, 147);
            this.psum.Name = "psum";
            this.psum.Size = new System.Drawing.Size(110, 54);
            this.psum.TabIndex = 23;
            this.psum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1008, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "将于第五轮后解锁";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::扑克牌游戏.Resource1.down;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(1053, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 117);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::扑克牌游戏.Resource1.R_C1;
            this.button2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1053, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 117);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1258, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Help;
            this.help.Font = new System.Drawing.Font("宋体", 20F);
            this.help.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(14, 10);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(58, 58);
            this.help.TabIndex = 6;
            this.help.UseVisualStyleBackColor = true;
            this.help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.helpclick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 441);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.psum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.targettext);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.saywin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.help);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.incardbutton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "心算小游戏加强版";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label targettext;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button saywin;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p9;
        private System.Windows.Forms.PictureBox p10;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button incardbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cardsstcknum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label psum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer3;
    }
}
