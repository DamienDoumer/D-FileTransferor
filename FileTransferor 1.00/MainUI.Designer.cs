namespace FileTransferor_1._00
{
    partial class FileTransferorUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTransferorUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToUseItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetDirectoriesButton = new System.Windows.Forms.Button();
            this.ResetAppButton = new System.Windows.Forms.Button();
            this.ViewHistoryButton = new System.Windows.Forms.Button();
            this.CloudCopyButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToUseItToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // HowToUseItToolStripMenuItem
            // 
            this.HowToUseItToolStripMenuItem.Name = "HowToUseItToolStripMenuItem";
            this.HowToUseItToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.HowToUseItToolStripMenuItem.Text = "&How to use it";
            this.HowToUseItToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSoundToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "&Option";
            // 
            // changeSoundToolStripMenuItem
            // 
            this.changeSoundToolStripMenuItem.Name = "changeSoundToolStripMenuItem";
            this.changeSoundToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.changeSoundToolStripMenuItem.Text = "Change sound";
            this.changeSoundToolStripMenuItem.Click += new System.EventHandler(this.changeSoundToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automatic File Transferor ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetDirectoriesButton);
            this.groupBox1.Controls.Add(this.ResetAppButton);
            this.groupBox1.Controls.Add(this.ViewHistoryButton);
            this.groupBox1.Controls.Add(this.CloudCopyButton);
            this.groupBox1.Controls.Add(this.CopyButton);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 497);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // SetDirectoriesButton
            // 
            this.SetDirectoriesButton.BackColor = System.Drawing.Color.White;
            this.SetDirectoriesButton.Font = new System.Drawing.Font("Mistral", 19.25F, System.Drawing.FontStyle.Italic);
            this.SetDirectoriesButton.Location = new System.Drawing.Point(7, 422);
            this.SetDirectoriesButton.Name = "SetDirectoriesButton";
            this.SetDirectoriesButton.Size = new System.Drawing.Size(143, 63);
            this.SetDirectoriesButton.TabIndex = 5;
            this.SetDirectoriesButton.Text = "Set Directories";
            this.SetDirectoriesButton.UseVisualStyleBackColor = false;
            this.SetDirectoriesButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // ResetAppButton
            // 
            this.ResetAppButton.BackColor = System.Drawing.Color.White;
            this.ResetAppButton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic);
            this.ResetAppButton.Location = new System.Drawing.Point(6, 341);
            this.ResetAppButton.Name = "ResetAppButton";
            this.ResetAppButton.Size = new System.Drawing.Size(143, 63);
            this.ResetAppButton.TabIndex = 4;
            this.ResetAppButton.Text = "Reset App";
            this.ResetAppButton.UseVisualStyleBackColor = false;
            this.ResetAppButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ViewHistoryButton
            // 
            this.ViewHistoryButton.BackColor = System.Drawing.Color.White;
            this.ViewHistoryButton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic);
            this.ViewHistoryButton.Location = new System.Drawing.Point(7, 263);
            this.ViewHistoryButton.Name = "ViewHistoryButton";
            this.ViewHistoryButton.Size = new System.Drawing.Size(143, 63);
            this.ViewHistoryButton.TabIndex = 3;
            this.ViewHistoryButton.Text = "View HIstory";
            this.ViewHistoryButton.UseVisualStyleBackColor = false;
            this.ViewHistoryButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // CloudCopyButton
            // 
            this.CloudCopyButton.BackColor = System.Drawing.Color.White;
            this.CloudCopyButton.Font = new System.Drawing.Font("Mistral", 19.25F, System.Drawing.FontStyle.Italic);
            this.CloudCopyButton.Location = new System.Drawing.Point(6, 183);
            this.CloudCopyButton.Name = "CloudCopyButton";
            this.CloudCopyButton.Size = new System.Drawing.Size(143, 63);
            this.CloudCopyButton.TabIndex = 2;
            this.CloudCopyButton.Text = "Copy To Cloud";
            this.CloudCopyButton.UseVisualStyleBackColor = false;
            this.CloudCopyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.White;
            this.CopyButton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic);
            this.CopyButton.Location = new System.Drawing.Point(7, 101);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(143, 63);
            this.CopyButton.TabIndex = 1;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.White;
            this.SendButton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic);
            this.SendButton.Location = new System.Drawing.Point(6, 19);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(143, 63);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(186, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 497);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(10, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 466);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drop your Files here";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 592);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 27);
            this.progressBar1.TabIndex = 4;
            // 
            // FileTransferorUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 633);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FileTransferorUI";
            this.Opacity = 0.95D;
            this.Text = "Doumera File Transferor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileTransferorUI_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowToUseItToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CloudCopyButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ResetAppButton;
        private System.Windows.Forms.Button ViewHistoryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetDirectoriesButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeSoundToolStripMenuItem;


    }
}

