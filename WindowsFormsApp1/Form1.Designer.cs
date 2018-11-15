namespace WindowsFormsApp1
{
    partial class Form1
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton2.Location = new System.Drawing.Point(6, 10);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(92, 24);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Add wrestler";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 463);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton3.Location = new System.Drawing.Point(104, 10);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(100, 24);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Remove wrestler";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(312, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(23, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 90);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(246, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "City";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(120, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Surname";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Name";
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton4.Location = new System.Drawing.Point(210, 10);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(127, 24);
            this.metroButton4.TabIndex = 19;
            this.metroButton4.Text = "Print table";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.MetroButton4_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton1.Location = new System.Drawing.Point(373, 40);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(147, 24);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Print";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "Count of wrestlers:0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "Count of wrestlers:0";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton5.Location = new System.Drawing.Point(373, 74);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(147, 19);
            this.metroButton5.TabIndex = 23;
            this.metroButton5.Text = "Save table";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.MetroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton6.Location = new System.Drawing.Point(373, 99);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(147, 21);
            this.metroButton6.TabIndex = 24;
            this.metroButton6.Text = "Load table";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.MetroButton6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(52, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(312, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Lot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 631);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

