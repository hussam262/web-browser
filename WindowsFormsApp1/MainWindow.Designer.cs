
namespace WindowsFormsApp1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.bulkButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(693, 38);
            this.textBox1.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(909, 61);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(93, 55);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1346, 734);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(1025, 61);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(69, 69);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Location = new System.Drawing.Point(1113, 61);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(76, 69);
            this.homeButton.TabIndex = 4;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.favoriteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favoriteButton.BackgroundImage")));
            this.favoriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favoriteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.favoriteButton.Location = new System.Drawing.Point(1218, 61);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(64, 69);
            this.favoriteButton.TabIndex = 5;
            this.favoriteButton.UseVisualStyleBackColor = false;
            this.favoriteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyButton.BackgroundImage")));
            this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyButton.Location = new System.Drawing.Point(1302, 61);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(73, 69);
            this.historyButton.TabIndex = 6;
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // bulkButton
            // 
            this.bulkButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bulkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulkButton.BackgroundImage")));
            this.bulkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bulkButton.Location = new System.Drawing.Point(1392, 61);
            this.bulkButton.Name = "bulkButton";
            this.bulkButton.Size = new System.Drawing.Size(74, 69);
            this.bulkButton.TabIndex = 7;
            this.bulkButton.UseVisualStyleBackColor = false;
            this.bulkButton.Click += new System.EventHandler(this.bulkButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1027);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1510, 48);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 32);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(56, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 68);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(56, 946);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Set Current Page as Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1510, 1075);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bulkButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.textBox1);
            this.Name = "MainWindow";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button bulkButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

