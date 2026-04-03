namespace FUTUREhub
{
    partial class Mainboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainboard));
            toolTip = new ToolTip(components);
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(0, 0, 3, 0);
            toolStrip.Size = new Size(1053, 30);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = Properties.Resources.log_out;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(93, 25);
            toolStripLabel1.Text = "Logout";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.users1;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(41, 73);
            button1.Name = "button1";
            button1.Size = new Size(234, 121);
            button1.TabIndex = 4;
            button1.Text = "Human Resource Management";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.file_chart_line;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(41, 231);
            button2.Name = "button2";
            button2.Size = new Size(234, 121);
            button2.TabIndex = 5;
            button2.Text = "Accounts Management";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.warehouse;
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(41, 392);
            button3.Name = "button3";
            button3.Size = new Size(234, 121);
            button3.TabIndex = 6;
            button3.Text = "Stock Management";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.hand_helping;
            button4.ImageAlign = ContentAlignment.BottomCenter;
            button4.Location = new Point(41, 556);
            button4.Name = "button4";
            button4.Size = new Size(234, 121);
            button4.TabIndex = 7;
            button4.Text = "Clientele";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.handshake;
            button5.ImageAlign = ContentAlignment.BottomCenter;
            button5.Location = new Point(41, 716);
            button5.Name = "button5";
            button5.Size = new Size(234, 121);
            button5.TabIndex = 8;
            button5.Text = "Vendor Base";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // Mainboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 871);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(toolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Mainboard";
            Text = "Mainboard";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}



