namespace StudentGradeSystem
{
    partial class StuCtrl
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            我的成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            开始选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            修改学生密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView2 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 系统ToolStripMenuItem, 信息管理ToolStripMenuItem, 我的成绩ToolStripMenuItem, 开始选课ToolStripMenuItem, 修改学生密码ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 系统ToolStripMenuItem
            // 
            系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 退出ToolStripMenuItem });
            系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 信息管理ToolStripMenuItem
            // 
            信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 添加学生信息ToolStripMenuItem, 删除学生信息ToolStripMenuItem, 修改学生信息ToolStripMenuItem });
            信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            信息管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            信息管理ToolStripMenuItem.Text = "信息管理";
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            添加学生信息ToolStripMenuItem.Click += 添加学生信息ToolStripMenuItem_Click;
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            删除学生信息ToolStripMenuItem.Click += 删除学生信息ToolStripMenuItem_Click;
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            修改学生信息ToolStripMenuItem.Click += 修改学生信息ToolStripMenuItem_Click;
            // 
            // 我的成绩ToolStripMenuItem
            // 
            我的成绩ToolStripMenuItem.Name = "我的成绩ToolStripMenuItem";
            我的成绩ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            我的成绩ToolStripMenuItem.Text = "我的成绩";
            我的成绩ToolStripMenuItem.Click += 我的成绩ToolStripMenuItem_Click;
            // 
            // 开始选课ToolStripMenuItem
            // 
            开始选课ToolStripMenuItem.Name = "开始选课ToolStripMenuItem";
            开始选课ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            开始选课ToolStripMenuItem.Text = "开始选课";
            开始选课ToolStripMenuItem.Click += 开始选课ToolStripMenuItem_Click;
            // 
            // 修改学生密码ToolStripMenuItem
            // 
            修改学生密码ToolStripMenuItem.Name = "修改学生密码ToolStripMenuItem";
            修改学生密码ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            修改学生密码ToolStripMenuItem.Text = "修改学生密码";
            修改学生密码ToolStripMenuItem.Click += 修改学生密码ToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new System.Drawing.Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.ADD2;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "添加学生信息";
            toolStripButton1.Click += 添加学生信息ToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.DEL1;
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "删除学生信息";
            toolStripButton2.Click += 删除学生信息ToolStripMenuItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Fix3;
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "修改学生信息";
            toolStripButton3.Click += 修改学生信息ToolStripMenuItem_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.OIP_C;
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new System.Drawing.Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.ToolTipText = "刷新";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new System.Drawing.Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            toolStripStatusLabel1.Text = "成功登录管理系统！";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(633, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            toolStripStatusLabel3.Text = "Time";
            toolStripStatusLabel3.Click += toolStripStatusLabel3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView2.Location = new System.Drawing.Point(0, 50);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new System.Drawing.Size(800, 378);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "学号";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "姓名";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "班级";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "出生日期";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "籍贯";
            Column5.Name = "Column5";
            // 
            // StuCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StuCtrl";
            Text = "学生信息管理";
            FormClosed += StuCtrl_FormClosed;
            Load += StuCtrl_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem 我的成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem 开始选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生密码ToolStripMenuItem;
    }
}