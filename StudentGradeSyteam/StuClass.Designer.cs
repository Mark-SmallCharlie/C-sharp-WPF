namespace StudentGradeSystem
{
    partial class StuClass
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
            menuStrip2 = new System.Windows.Forms.MenuStrip();
            系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            选择该课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            我的课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            修改学生个人密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 系统ToolStripMenuItem, 选择该课程ToolStripMenuItem, 我的课表ToolStripMenuItem, 修改学生个人密码ToolStripMenuItem });
            menuStrip2.Location = new System.Drawing.Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new System.Drawing.Size(800, 25);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
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
            // 选择该课程ToolStripMenuItem
            // 
            选择该课程ToolStripMenuItem.Name = "选择该课程ToolStripMenuItem";
            选择该课程ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            选择该课程ToolStripMenuItem.Text = "选择该课程";
            选择该课程ToolStripMenuItem.Click += 选择该课程ToolStripMenuItem_Click;
            // 
            // 我的课表ToolStripMenuItem
            // 
            我的课表ToolStripMenuItem.Name = "我的课表ToolStripMenuItem";
            我的课表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            我的课表ToolStripMenuItem.Text = "我的课表";
            我的课表ToolStripMenuItem.Click += 我的课表ToolStripMenuItem_Click;
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
            toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            toolStripStatusLabel1.Text = "开始选课！";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(681, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            toolStripStatusLabel3.Text = "Time";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(800, 403);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "课程编号";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "课程名称";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "课程学分";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "授课教师";
            Column4.Name = "Column4";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // 修改学生个人密码ToolStripMenuItem
            // 
            修改学生个人密码ToolStripMenuItem.Name = "修改学生个人密码ToolStripMenuItem";
            修改学生个人密码ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            修改学生个人密码ToolStripMenuItem.Text = "修改学生个人密码";
            // 
            // StuClass
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip2);
            Name = "StuClass";
            Text = "学生选课界面";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择该课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的课表ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 修改学生个人密码ToolStripMenuItem;
    }
}