namespace FUTUREhub
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 26);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F);
            label2.Location = new Point(76, 55);
            label2.Name = "label2";
            label2.Size = new Size(100, 27);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F);
            label3.Location = new Point(81, 107);
            label3.Name = "label3";
            label3.Size = new Size(95, 27);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F);
            label4.Location = new Point(83, 104);
            label4.Name = "label4";
            label4.Size = new Size(614, 27);
            label4.TabIndex = 3;
            label4.Text = "This section canbe used to change your username and the password.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10F);
            label5.Location = new Point(83, 131);
            label5.Name = "label5";
            label5.Size = new Size(594, 27);
            label5.TabIndex = 4;
            label5.Text = "Enter your new user credentials below. It is advised to change your";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 10F);
            label6.Location = new Point(83, 158);
            label6.Name = "label6";
            label6.Size = new Size(327, 27);
            label6.TabIndex = 5;
            label6.Text = "password once, every three months.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(83, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 231);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Credentials";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.OrangeRed;
            button2.Image = Properties.Resources.delete;
            button2.Location = new Point(81, 162);
            button2.Name = "button2";
            button2.Size = new Size(128, 48);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.ForestGreen;
            button1.Image = Properties.Resources.spell_check;
            button1.Location = new Point(386, 162);
            button1.Name = "button1";
            button1.Size = new Size(128, 48);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 31);
            textBox1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 10F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(296, 494);
            label7.Name = "label7";
            label7.Size = new Size(221, 27);
            label7.TabIndex = 7;
            label7.Text = "* Use 8 to 12 characters.";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display", 10F);
            label8.Location = new Point(83, 494);
            label8.Name = "label8";
            label8.Size = new Size(207, 27);
            label8.TabIndex = 8;
            label8.Text = "Password Instructions:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 10F);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(296, 521);
            label9.Name = "label9";
            label9.Size = new Size(314, 27);
            label9.TabIndex = 9;
            label9.Text = "* Do not enter the same password.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display", 10F);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(296, 548);
            label10.Name = "label10";
            label10.Size = new Size(319, 27);
            label10.TabIndex = 10;
            label10.Text = "* Use ALPHA-NUMERIC characters.";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Variable Display", 9F);
            button3.ForeColor = SystemColors.ControlText;
            button3.Image = Properties.Resources.arrow_left_from_line;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(128, 48);
            button3.TabIndex = 11;
            button3.Text = "Back";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI Variable Display", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Settings";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button3;
    }
}