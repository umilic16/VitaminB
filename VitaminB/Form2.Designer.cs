
namespace VitaminB
{
    partial class Form2
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
            this.lbLikedBeers = new System.Windows.Forms.ListBox();
            this.lbLikedPubs = new System.Windows.Forms.ListBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBeers = new System.Windows.Forms.ListBox();
            this.lbPubs = new System.Windows.Forms.ListBox();
            this.tbSearchBeer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchPubs = new System.Windows.Forms.TextBox();
            this.btnSearchBeer = new System.Windows.Forms.Button();
            this.btnSearchPub = new System.Windows.Forms.Button();
            this.btnRateBeer = new System.Windows.Forms.Button();
            this.nUDBeer = new System.Windows.Forms.NumericUpDown();
            this.btnLikeBeer = new System.Windows.Forms.Button();
            this.btnLikePub = new System.Windows.Forms.Button();
            this.nUDBeerPub = new System.Windows.Forms.NumericUpDown();
            this.btnRatePub = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBeerPub)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLikedBeers
            // 
            this.lbLikedBeers.FormattingEnabled = true;
            this.lbLikedBeers.Items.AddRange(new object[] {
            "adada",
            "sda",
            "ds",
            "da",
            "dd",
            "adsad"});
            this.lbLikedBeers.Location = new System.Drawing.Point(511, 61);
            this.lbLikedBeers.Name = "lbLikedBeers";
            this.lbLikedBeers.Size = new System.Drawing.Size(230, 212);
            this.lbLikedBeers.TabIndex = 0;
            this.lbLikedBeers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLikedBeers_MouseDoubleClick);
            // 
            // lbLikedPubs
            // 
            this.lbLikedPubs.FormattingEnabled = true;
            this.lbLikedPubs.Location = new System.Drawing.Point(511, 296);
            this.lbLikedPubs.Name = "lbLikedPubs";
            this.lbLikedPubs.Size = new System.Drawing.Size(230, 212);
            this.lbLikedPubs.TabIndex = 1;
            this.lbLikedPubs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLikedPubs_MouseDoubleClick);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(698, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbUser.Size = new System.Drawing.Size(57, 20);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(510, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(510, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pubs";
            // 
            // lbBeers
            // 
            this.lbBeers.FormattingEnabled = true;
            this.lbBeers.Location = new System.Drawing.Point(19, 61);
            this.lbBeers.Name = "lbBeers";
            this.lbBeers.Size = new System.Drawing.Size(230, 446);
            this.lbBeers.TabIndex = 6;
            this.lbBeers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbBeers_MouseDoubleClick);
            // 
            // lbPubs
            // 
            this.lbPubs.FormattingEnabled = true;
            this.lbPubs.Location = new System.Drawing.Point(255, 61);
            this.lbPubs.Name = "lbPubs";
            this.lbPubs.Size = new System.Drawing.Size(230, 446);
            this.lbPubs.TabIndex = 7;
            this.lbPubs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPubs_MouseDoubleClick);
            // 
            // tbSearchBeer
            // 
            this.tbSearchBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchBeer.Location = new System.Drawing.Point(19, 15);
            this.tbSearchBeer.Name = "tbSearchBeer";
            this.tbSearchBeer.Size = new System.Drawing.Size(173, 23);
            this.tbSearchBeer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Beers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(252, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pubs";
            // 
            // tbSearchPubs
            // 
            this.tbSearchPubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchPubs.Location = new System.Drawing.Point(255, 15);
            this.tbSearchPubs.Name = "tbSearchPubs";
            this.tbSearchPubs.Size = new System.Drawing.Size(173, 23);
            this.tbSearchPubs.TabIndex = 11;
            // 
            // btnSearchBeer
            // 
            this.btnSearchBeer.Location = new System.Drawing.Point(198, 15);
            this.btnSearchBeer.Name = "btnSearchBeer";
            this.btnSearchBeer.Size = new System.Drawing.Size(51, 23);
            this.btnSearchBeer.TabIndex = 12;
            this.btnSearchBeer.Text = "Search";
            this.btnSearchBeer.UseVisualStyleBackColor = true;
            this.btnSearchBeer.Click += new System.EventHandler(this.btnSearchBeer_Click);
            // 
            // btnSearchPub
            // 
            this.btnSearchPub.Location = new System.Drawing.Point(434, 15);
            this.btnSearchPub.Name = "btnSearchPub";
            this.btnSearchPub.Size = new System.Drawing.Size(51, 23);
            this.btnSearchPub.TabIndex = 13;
            this.btnSearchPub.Text = "Search";
            this.btnSearchPub.UseVisualStyleBackColor = true;
            this.btnSearchPub.Click += new System.EventHandler(this.btnSearchPub_Click);
            // 
            // btnRateBeer
            // 
            this.btnRateBeer.Location = new System.Drawing.Point(19, 530);
            this.btnRateBeer.Name = "btnRateBeer";
            this.btnRateBeer.Size = new System.Drawing.Size(56, 24);
            this.btnRateBeer.TabIndex = 14;
            this.btnRateBeer.Text = "Rate";
            this.btnRateBeer.UseVisualStyleBackColor = true;
            this.btnRateBeer.Click += new System.EventHandler(this.btnRateBeer_Click);
            // 
            // nUDBeer
            // 
            this.nUDBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nUDBeer.Location = new System.Drawing.Point(81, 531);
            this.nUDBeer.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDBeer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDBeer.Name = "nUDBeer";
            this.nUDBeer.Size = new System.Drawing.Size(49, 23);
            this.nUDBeer.TabIndex = 16;
            this.nUDBeer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLikeBeer
            // 
            this.btnLikeBeer.Location = new System.Drawing.Point(153, 530);
            this.btnLikeBeer.Name = "btnLikeBeer";
            this.btnLikeBeer.Size = new System.Drawing.Size(96, 24);
            this.btnLikeBeer.TabIndex = 17;
            this.btnLikeBeer.Text = "Like";
            this.btnLikeBeer.UseVisualStyleBackColor = true;
            this.btnLikeBeer.Click += new System.EventHandler(this.btnLikeBeer_Click);
            // 
            // btnLikePub
            // 
            this.btnLikePub.Location = new System.Drawing.Point(389, 530);
            this.btnLikePub.Name = "btnLikePub";
            this.btnLikePub.Size = new System.Drawing.Size(96, 24);
            this.btnLikePub.TabIndex = 20;
            this.btnLikePub.Text = "Like";
            this.btnLikePub.UseVisualStyleBackColor = true;
            this.btnLikePub.Click += new System.EventHandler(this.btnLikePub_Click);
            // 
            // nUDBeerPub
            // 
            this.nUDBeerPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nUDBeerPub.Location = new System.Drawing.Point(317, 531);
            this.nUDBeerPub.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDBeerPub.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDBeerPub.Name = "nUDBeerPub";
            this.nUDBeerPub.Size = new System.Drawing.Size(49, 23);
            this.nUDBeerPub.TabIndex = 19;
            this.nUDBeerPub.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRatePub
            // 
            this.btnRatePub.Location = new System.Drawing.Point(255, 530);
            this.btnRatePub.Name = "btnRatePub";
            this.btnRatePub.Size = new System.Drawing.Size(56, 24);
            this.btnRatePub.TabIndex = 18;
            this.btnRatePub.Text = "Rate";
            this.btnRatePub.UseVisualStyleBackColor = true;
            this.btnRatePub.Click += new System.EventHandler(this.btnRatePub_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(510, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Double click liked item to remove like";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(16, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Double click beer for more info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(252, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Double click pub for more info";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 569);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLikePub);
            this.Controls.Add(this.nUDBeerPub);
            this.Controls.Add(this.btnRatePub);
            this.Controls.Add(this.btnLikeBeer);
            this.Controls.Add(this.nUDBeer);
            this.Controls.Add(this.btnRateBeer);
            this.Controls.Add(this.btnSearchPub);
            this.Controls.Add(this.btnSearchBeer);
            this.Controls.Add(this.tbSearchPubs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSearchBeer);
            this.Controls.Add(this.lbPubs);
            this.Controls.Add(this.lbBeers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbLikedPubs);
            this.Controls.Add(this.lbLikedBeers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBeerPub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLikedBeers;
        private System.Windows.Forms.ListBox lbLikedPubs;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBeers;
        private System.Windows.Forms.ListBox lbPubs;
        private System.Windows.Forms.TextBox tbSearchBeer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearchPubs;
        private System.Windows.Forms.Button btnSearchBeer;
        private System.Windows.Forms.Button btnSearchPub;
        private System.Windows.Forms.Button btnRateBeer;
        private System.Windows.Forms.NumericUpDown nUDBeer;
        private System.Windows.Forms.Button btnLikeBeer;
        private System.Windows.Forms.Button btnLikePub;
        private System.Windows.Forms.NumericUpDown nUDBeerPub;
        private System.Windows.Forms.Button btnRatePub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}