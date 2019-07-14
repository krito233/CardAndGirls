namespace CardAndGirls
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.MonPicBox = new System.Windows.Forms.PictureBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AttLabel = new System.Windows.Forms.Label();
            this.DefLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MonPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel1.Font = new System.Drawing.Font("宋体", 15F);
            this.NameLabel1.Location = new System.Drawing.Point(10, 9);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(64, 25);
            this.NameLabel1.TabIndex = 1;
            this.NameLabel1.Text = "Name";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Location = new System.Drawing.Point(12, 34);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(22, 15);
            this.LevelLabel.TabIndex = 2;
            this.LevelLabel.Text = "★";
            this.LevelLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // MonPicBox
            // 
            this.MonPicBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MonPicBox.Location = new System.Drawing.Point(12, 33);
            this.MonPicBox.Name = "MonPicBox";
            this.MonPicBox.Size = new System.Drawing.Size(253, 296);
            this.MonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonPicBox.TabIndex = 3;
            this.MonPicBox.TabStop = false;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 335);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(253, 82);
            this.DescriptionTextBox.TabIndex = 4;
            this.DescriptionTextBox.Text = "描述";
            // 
            // AttLabel
            // 
            this.AttLabel.AutoSize = true;
            this.AttLabel.Location = new System.Drawing.Point(79, 420);
            this.AttLabel.Name = "AttLabel";
            this.AttLabel.Size = new System.Drawing.Size(54, 15);
            this.AttLabel.TabIndex = 5;
            this.AttLabel.Text = "Att： ";
            // 
            // DefLabel
            // 
            this.DefLabel.AutoSize = true;
            this.DefLabel.Location = new System.Drawing.Point(186, 420);
            this.DefLabel.Name = "DefLabel";
            this.DefLabel.Size = new System.Drawing.Size(54, 15);
            this.DefLabel.TabIndex = 6;
            this.DefLabel.Text = "Def： ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "召唤";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "攻击";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "改变状态";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 535);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.NameLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DefLabel);
            this.Controls.Add(this.AttLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.MonPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "信息";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.PictureBox MonPicBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label AttLabel;
        private System.Windows.Forms.Label DefLabel;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}