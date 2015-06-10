namespace GogoFamis
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
            this.label5 = new System.Windows.Forms.Label();
            this.btRoute = new System.Windows.Forms.Button();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.btDis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCoor = new System.Windows.Forms.Label();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.cbDest = new System.Windows.Forms.ComboBox();
            this.cbStart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Distance in Km";
            // 
            // btRoute
            // 
            this.btRoute.Location = new System.Drawing.Point(34, 384);
            this.btRoute.Margin = new System.Windows.Forms.Padding(2);
            this.btRoute.Name = "btRoute";
            this.btRoute.Size = new System.Drawing.Size(83, 44);
            this.btRoute.TabIndex = 23;
            this.btRoute.Text = "Show Route";
            this.btRoute.UseVisualStyleBackColor = true;
            this.btRoute.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(34, 325);
            this.tbDistance.Margin = new System.Windows.Forms.Padding(2);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(84, 20);
            this.tbDistance.TabIndex = 22;
            // 
            // btDis
            // 
            this.btDis.Location = new System.Drawing.Point(34, 254);
            this.btDis.Margin = new System.Windows.Forms.Padding(2);
            this.btDis.Name = "btDis";
            this.btDis.Size = new System.Drawing.Size(83, 41);
            this.btDis.TabIndex = 21;
            this.btDis.Text = "Calculate Distance";
            this.btDis.UseVisualStyleBackColor = true;
            this.btDis.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Algorithm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Start City";
            // 
            // lblCoor
            // 
            this.lblCoor.AutoSize = true;
            this.lblCoor.Location = new System.Drawing.Point(711, 48);
            this.lblCoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoor.Name = "lblCoor";
            this.lblCoor.Size = new System.Drawing.Size(62, 13);
            this.lblCoor.TabIndex = 14;
            this.lblCoor.Text = "coordinates";
            // 
            // pbMap
            // 
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMap.Location = new System.Drawing.Point(171, 24);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(535, 574);
            this.pbMap.TabIndex = 13;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.pbMap_Click);
            this.pbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseMove);
            this.pbMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMap_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Location = new System.Drawing.Point(34, 204);
            this.cbAlgorithm.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(92, 21);
            this.cbAlgorithm.TabIndex = 19;
            // 
            // cbDest
            // 
            this.cbDest.FormattingEnabled = true;
            this.cbDest.Location = new System.Drawing.Point(34, 125);
            this.cbDest.Margin = new System.Windows.Forms.Padding(2);
            this.cbDest.Name = "cbDest";
            this.cbDest.Size = new System.Drawing.Size(92, 21);
            this.cbDest.TabIndex = 16;
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(34, 48);
            this.cbStart.Margin = new System.Windows.Forms.Padding(2);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(92, 21);
            this.cbStart.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btRoute);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.btDis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAlgorithm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDest);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.lblCoor);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRoute;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Button btDis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCoor;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.ComboBox cbDest;
        private System.Windows.Forms.ComboBox cbStart;
    }
}

