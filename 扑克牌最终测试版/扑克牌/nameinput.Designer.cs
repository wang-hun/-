
namespace 扑克牌游戏
{
    partial class nameInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.CausesValidation = false;
            this.SubmitButton.Font = new System.Drawing.Font("幼圆", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Blue;
            this.SubmitButton.Location = new System.Drawing.Point(281, 163);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(214, 73);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "让我们开始吧";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(123, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的姓名";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Magenta;
            this.linkLabel1.Location = new System.Drawing.Point(501, 212);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "练习模式";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameBox.Location = new System.Drawing.Point(235, 87);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(335, 37);
            this.NameBox.TabIndex = 3;
            this.NameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameBox_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(277, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "该名字将用于保存排行榜";
            // 
            // nameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 298);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nameInput";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入用户名";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nameInput_FormClosed);
            this.Load += new System.EventHandler(this.nameInput_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
    }
}