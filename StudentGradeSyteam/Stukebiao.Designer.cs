namespace StudentGradeSystem
{
    partial class Stukebiao
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            取消这门课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 取消这门课ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 取消这门课ToolStripMenuItem
            // 
            取消这门课ToolStripMenuItem.Image = Properties.Resources.DEL1;
            取消这门课ToolStripMenuItem.Name = "取消这门课ToolStripMenuItem";
            取消这门课ToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            取消这门课ToolStripMenuItem.Text = "取消这门课";
            取消这门课ToolStripMenuItem.Click += 取消这门课ToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(800, 425);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "课程名称";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "课程介绍";
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
            // Stukebiao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "Stukebiao";
            Text = "我的选课";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 取消这门课ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}