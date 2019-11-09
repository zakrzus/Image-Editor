namespace WindowsFormsApp2.AdditionalForms
{
    partial class OpenedPicture
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
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjePunktoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posteryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.operacjePunktoweToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // operacjePunktoweToolStripMenuItem
            // 
            this.operacjePunktoweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negacjaToolStripMenuItem,
            this.progowanieToolStripMenuItem,
            this.posteryzacjaToolStripMenuItem});
            this.operacjePunktoweToolStripMenuItem.Name = "operacjePunktoweToolStripMenuItem";
            this.operacjePunktoweToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.operacjePunktoweToolStripMenuItem.Text = "Point operations";
            // 
            // negacjaToolStripMenuItem
            // 
            this.negacjaToolStripMenuItem.Name = "negacjaToolStripMenuItem";
            this.negacjaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.negacjaToolStripMenuItem.Text = "Negation";
            this.negacjaToolStripMenuItem.Click += new System.EventHandler(this.negacjaToolStripMenuItem_Click);
            // 
            // progowanieToolStripMenuItem
            // 
            this.progowanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usualToolStripMenuItem,
            this.grayScaleToolStripMenuItem});
            this.progowanieToolStripMenuItem.Name = "progowanieToolStripMenuItem";
            this.progowanieToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.progowanieToolStripMenuItem.Text = "Threshold";
            // 
            // usualToolStripMenuItem
            // 
            this.usualToolStripMenuItem.Name = "usualToolStripMenuItem";
            this.usualToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.usualToolStripMenuItem.Text = "Usual";
            this.usualToolStripMenuItem.Click += new System.EventHandler(this.usualToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // posteryzacjaToolStripMenuItem
            // 
            this.posteryzacjaToolStripMenuItem.Name = "posteryzacjaToolStripMenuItem";
            this.posteryzacjaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.posteryzacjaToolStripMenuItem.Text = "Posterisation";
            this.posteryzacjaToolStripMenuItem.Click += new System.EventHandler(this.posteryzacjaToolStripMenuItem_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Control;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 24);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(800, 426);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeModeToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // sizeModeToolStripMenuItem
            // 
            this.sizeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem,
            this.fitContentToolStripMenuItem});
            this.sizeModeToolStripMenuItem.Name = "sizeModeToolStripMenuItem";
            this.sizeModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeModeToolStripMenuItem.Text = "Size Mode";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // fitContentToolStripMenuItem
            // 
            this.fitContentToolStripMenuItem.Name = "fitContentToolStripMenuItem";
            this.fitContentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fitContentToolStripMenuItem.Text = "Fit Content";
            this.fitContentToolStripMenuItem.Click += new System.EventHandler(this.fitContentToolStripMenuItem_Click);
            // 
            // OpenedPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OpenedPicture";
            this.Text = "OpenedPicture";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjePunktoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posteryzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitContentToolStripMenuItem;
    }
}