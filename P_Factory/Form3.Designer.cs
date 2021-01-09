namespace P_Factory
{
    partial class Form3
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
            this.M_K1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RC3 = new System.Windows.Forms.RadioButton();
            this.RC2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RR1 = new System.Windows.Forms.RadioButton();
            this.RK1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // M_K1
            // 
            this.M_K1.Location = new System.Drawing.Point(40, 304);
            this.M_K1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.M_K1.Name = "M_K1";
            this.M_K1.Size = new System.Drawing.Size(256, 21);
            this.M_K1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F);
            this.button1.Location = new System.Drawing.Point(312, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Make";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RC3);
            this.groupBox1.Controls.Add(this.RC2);
            this.groupBox1.Controls.Add(this.RB1);
            this.groupBox1.Controls.Add(this.RR1);
            this.groupBox1.Controls.Add(this.RK1);
            this.groupBox1.Location = new System.Drawing.Point(42, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(414, 288);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make";
            // 
            // RC3
            // 
            this.RC3.AutoSize = true;
            this.RC3.Font = new System.Drawing.Font("굴림", 12F);
            this.RC3.Location = new System.Drawing.Point(32, 224);
            this.RC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RC3.Name = "RC3";
            this.RC3.Size = new System.Drawing.Size(81, 20);
            this.RC3.TabIndex = 14;
            this.RC3.TabStop = true;
            this.RC3.Text = "Color_3";
            this.RC3.UseVisualStyleBackColor = true;
            this.RC3.CheckedChanged += new System.EventHandler(this.RC3_CheckedChanged);
            // 
            // RC2
            // 
            this.RC2.AutoSize = true;
            this.RC2.Font = new System.Drawing.Font("굴림", 12F);
            this.RC2.Location = new System.Drawing.Point(32, 180);
            this.RC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RC2.Name = "RC2";
            this.RC2.Size = new System.Drawing.Size(81, 20);
            this.RC2.TabIndex = 13;
            this.RC2.TabStop = true;
            this.RC2.Text = "Color_2";
            this.RC2.UseVisualStyleBackColor = true;
            this.RC2.CheckedChanged += new System.EventHandler(this.RC2_CheckedChanged);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("굴림", 12F);
            this.RB1.Location = new System.Drawing.Point(32, 92);
            this.RB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(73, 20);
            this.RB1.TabIndex = 12;
            this.RB1.TabStop = true;
            this.RB1.Text = "Blue_1";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // RR1
            // 
            this.RR1.AutoSize = true;
            this.RR1.Font = new System.Drawing.Font("굴림", 12F);
            this.RR1.Location = new System.Drawing.Point(32, 136);
            this.RR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RR1.Name = "RR1";
            this.RR1.Size = new System.Drawing.Size(70, 20);
            this.RR1.TabIndex = 11;
            this.RR1.TabStop = true;
            this.RR1.Text = "Red_1";
            this.RR1.UseVisualStyleBackColor = true;
            this.RR1.CheckedChanged += new System.EventHandler(this.RR1_CheckedChanged);
            // 
            // RK1
            // 
            this.RK1.AutoSize = true;
            this.RK1.Font = new System.Drawing.Font("굴림", 12F);
            this.RK1.Location = new System.Drawing.Point(32, 48);
            this.RK1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RK1.Name = "RK1";
            this.RK1.Size = new System.Drawing.Size(81, 20);
            this.RK1.TabIndex = 10;
            this.RK1.TabStop = true;
            this.RK1.Text = "Black_1";
            this.RK1.UseVisualStyleBackColor = true;
            this.RK1.CheckedChanged += new System.EventHandler(this.RK1_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.M_K1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox M_K1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RK1;
        private System.Windows.Forms.RadioButton RC3;
        private System.Windows.Forms.RadioButton RC2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RR1;
    }
}