namespace FUTUREhub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(603, 42);
            label1.Name = "label1";
            label1.Size = new Size(216, 65);
            label1.TabIndex = 1;
            label1.Text = "FUTURE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(800, 46);
            label2.Name = "label2";
            label2.Size = new Size(108, 60);
            label2.TabIndex = 2;
            label2.Text = "hub";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(483, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 210);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 31);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(64, 131);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 1;
            label4.Text = "Passowrd";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(64, 66);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.door_open;
            button1.Location = new Point(477, 379);
            button1.Name = "button1";
            button1.Size = new Size(101, 44);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = Properties.Resources.eraser;
            button2.Location = new Point(685, 379);
            button2.Name = "button2";
            button2.Size = new Size(101, 44);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = Properties.Resources.log_in;
            button3.Location = new Point(897, 379);
            button3.Name = "button3";
            button3.Size = new Size(101, 44);
            button3.TabIndex = 6;
            button3.Text = "Login";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.GrayText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Future Lighting & Engineering (PVT) Ltd.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
