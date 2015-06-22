namespace TheMapProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nederlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.method_cbx = new System.Windows.Forms.ComboBox();
            this.CalBT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destination_x = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.origin_x = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nederlandToolStripMenuItem,
            this.welcomeToUsToolStripMenuItem,
            this.friendsToolStripMenuItem});
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadMapToolStripMenuItem.Text = "Load Map";
            // 
            // nederlandToolStripMenuItem
            // 
            this.nederlandToolStripMenuItem.Name = "nederlandToolStripMenuItem";
            this.nederlandToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.nederlandToolStripMenuItem.Text = "Nederland";
            this.nederlandToolStripMenuItem.Click += new System.EventHandler(this.nederlandToolStripMenuItem_Click);
            // 
            // welcomeToUsToolStripMenuItem
            // 
            this.welcomeToUsToolStripMenuItem.Name = "welcomeToUsToolStripMenuItem";
            this.welcomeToUsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.welcomeToUsToolStripMenuItem.Text = "WelcomeToUs";
            this.welcomeToUsToolStripMenuItem.Click += new System.EventHandler(this.welcomeToUsToolStripMenuItem_Click_1);
            // 
            // friendsToolStripMenuItem
            // 
            this.friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            this.friendsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.friendsToolStripMenuItem.Text = "Friends";
            this.friendsToolStripMenuItem.Click += new System.EventHandler(this.friendsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 532);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.method_cbx);
            this.groupBox3.Controls.Add(this.CalBT);
            this.groupBox3.Location = new System.Drawing.Point(16, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(241, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear Route";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // method_cbx
            // 
            this.method_cbx.BackColor = System.Drawing.Color.LightSteelBlue;
            this.method_cbx.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method_cbx.FormattingEnabled = true;
            this.method_cbx.Location = new System.Drawing.Point(6, 19);
            this.method_cbx.Name = "method_cbx";
            this.method_cbx.Size = new System.Drawing.Size(426, 45);
            this.method_cbx.Sorted = true;
            this.method_cbx.TabIndex = 0;
            this.method_cbx.Text = "                      Method";
            this.method_cbx.SelectedIndexChanged += new System.EventHandler(this.method_cbx_SelectedIndexChanged);
            // 
            // CalBT
            // 
            this.CalBT.BackColor = System.Drawing.Color.MidnightBlue;
            this.CalBT.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalBT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CalBT.Location = new System.Drawing.Point(8, 77);
            this.CalBT.Name = "CalBT";
            this.CalBT.Size = new System.Drawing.Size(191, 47);
            this.CalBT.TabIndex = 1;
            this.CalBT.Text = "Calculate";
            this.CalBT.UseVisualStyleBackColor = false;
            this.CalBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.destination_x);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // destination_x
            // 
            this.destination_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_x.Location = new System.Drawing.Point(194, 31);
            this.destination_x.Margin = new System.Windows.Forms.Padding(0);
            this.destination_x.Name = "destination_x";
            this.destination_x.Size = new System.Drawing.Size(45, 41);
            this.destination_x.TabIndex = 2;
            this.destination_x.UseVisualStyleBackColor = true;
            this.destination_x.Click += new System.EventHandler(this.destination_x_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Ctiy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eindhoven";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.origin_x);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // origin_x
            // 
            this.origin_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin_x.Location = new System.Drawing.Point(194, 31);
            this.origin_x.Margin = new System.Windows.Forms.Padding(0);
            this.origin_x.Name = "origin_x";
            this.origin_x.Size = new System.Drawing.Size(45, 41);
            this.origin_x.TabIndex = 0;
            this.origin_x.UseVisualStyleBackColor = true;
            this.origin_x.Click += new System.EventHandler(this.origin_x_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "Eindhoven";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start City";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(528, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 532);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1202, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "The Map Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox method_cbx;
        private System.Windows.Forms.Button CalBT;
        private System.Windows.Forms.Button destination_x;
        private System.Windows.Forms.Button origin_x;
        private System.Windows.Forms.ToolStripMenuItem nederlandToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem welcomeToUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem;
    }
}

