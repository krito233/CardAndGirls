namespace CardAndGirls
{
    partial class CardGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardGroupForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.GetCard = new System.Windows.Forms.Button();
            this.GetOne = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(271, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 124);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "手牌";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "卡组";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(12, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(216, 124);
            this.listBox2.TabIndex = 3;
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox2_MouseClick);
            // 
            // GetCard
            // 
            this.GetCard.Location = new System.Drawing.Point(12, 167);
            this.GetCard.Name = "GetCard";
            this.GetCard.Size = new System.Drawing.Size(95, 42);
            this.GetCard.TabIndex = 4;
            this.GetCard.Text = "抽五张";
            this.GetCard.UseVisualStyleBackColor = true;
            this.GetCard.Click += new System.EventHandler(this.GetCard_Click);
            // 
            // GetOne
            // 
            this.GetOne.Location = new System.Drawing.Point(140, 167);
            this.GetOne.Name = "GetOne";
            this.GetOne.Size = new System.Drawing.Size(88, 42);
            this.GetOne.TabIndex = 5;
            this.GetOne.Text = "抽牌";
            this.GetOne.UseVisualStyleBackColor = true;
            this.GetOne.Click += new System.EventHandler(this.GetOne_Click);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(141, 215);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(88, 43);
            this.Random.TabIndex = 6;
            this.Random.Text = "洗牌";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // CardGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(241, 275);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.GetOne);
            this.Controls.Add(this.GetCard);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CardGroupForm";
            this.Load += new System.EventHandler(this.CardGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button GetCard;
        private System.Windows.Forms.Button GetOne;
        private System.Windows.Forms.Button Random;
    }
}