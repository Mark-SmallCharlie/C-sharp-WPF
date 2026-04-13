namespace StudentGradeSystem
{
    partial class TeachClassAdd
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            button1Add = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1686643113970738;
            pictureBox1.Location = new System.Drawing.Point(-4, -7);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(783, 707);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(165, 166);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 28);
            label1.TabIndex = 1;
            label1.Text = "课程号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(165, 255);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "科目名：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(165, 329);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 28);
            label3.TabIndex = 3;
            label3.Text = "授课教师：";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(165, 420);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 28);
            label4.TabIndex = 4;
            label4.Text = "成绩：";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            linkLabel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            linkLabel1.Location = new System.Drawing.Point(245, 69);
            linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(231, 35);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "教师课程添加";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(312, 156);
            textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(257, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(312, 245);
            textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(257, 34);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(312, 320);
            textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(257, 34);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(312, 410);
            textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(257, 34);
            textBox4.TabIndex = 9;
            // 
            // button1Add
            // 
            button1Add.Location = new System.Drawing.Point(165, 508);
            button1Add.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            button1Add.Name = "button1Add";
            button1Add.Size = new System.Drawing.Size(139, 38);
            button1Add.TabIndex = 10;
            button1Add.Text = "添加";
            button1Add.UseVisualStyleBackColor = true;
            button1Add.Click += button1Add_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(430, 508);
            button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(139, 38);
            button2.TabIndex = 11;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(165, 508);
            button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(139, 38);
            button3.TabIndex = 12;
            button3.Text = "修改";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TeachClassAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(761, 569);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1Add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "TeachClassAdd";
            Text = "TeachClassAdd";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}