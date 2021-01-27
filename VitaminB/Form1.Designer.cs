
namespace VitaminB
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbSignUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSignPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSignRepPass = new System.Windows.Forms.TextBox();
            this.lbUsernameError = new System.Windows.Forms.Label();
            this.lbPasswordError = new System.Windows.Forms.Label();
            this.lbLoginError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLogPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLogUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSignUp.Location = new System.Drawing.Point(19, 259);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(178, 37);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogin.Location = new System.Drawing.Point(297, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(178, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbSignUser
            // 
            this.tbSignUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSignUser.Location = new System.Drawing.Point(19, 77);
            this.tbSignUser.Name = "tbSignUser";
            this.tbSignUser.Size = new System.Drawing.Size(178, 23);
            this.tbSignUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(309, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter password";
            // 
            // tbSignPass
            // 
            this.tbSignPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSignPass.Location = new System.Drawing.Point(19, 157);
            this.tbSignPass.Name = "tbSignPass";
            this.tbSignPass.Size = new System.Drawing.Size(178, 23);
            this.tbSignPass.TabIndex = 15;
            this.tbSignPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Repeat password";
            // 
            // tbSignRepPass
            // 
            this.tbSignRepPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSignRepPass.Location = new System.Drawing.Point(19, 203);
            this.tbSignRepPass.Name = "tbSignRepPass";
            this.tbSignRepPass.Size = new System.Drawing.Size(178, 23);
            this.tbSignRepPass.TabIndex = 17;
            this.tbSignRepPass.UseSystemPasswordChar = true;
            // 
            // lbUsernameError
            // 
            this.lbUsernameError.AutoSize = true;
            this.lbUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lbUsernameError.Location = new System.Drawing.Point(16, 103);
            this.lbUsernameError.Name = "lbUsernameError";
            this.lbUsernameError.Size = new System.Drawing.Size(186, 17);
            this.lbUsernameError.TabIndex = 19;
            this.lbUsernameError.Text = "Username already exists";
            this.lbUsernameError.Visible = false;
            // 
            // lbPasswordError
            // 
            this.lbPasswordError.AutoSize = true;
            this.lbPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordError.Location = new System.Drawing.Point(16, 229);
            this.lbPasswordError.Name = "lbPasswordError";
            this.lbPasswordError.Size = new System.Drawing.Size(162, 17);
            this.lbPasswordError.TabIndex = 20;
            this.lbPasswordError.Text = "Password dont match";
            this.lbPasswordError.Visible = false;
            // 
            // lbLoginError
            // 
            this.lbLoginError.AutoSize = true;
            this.lbLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbLoginError.ForeColor = System.Drawing.Color.Red;
            this.lbLoginError.Location = new System.Drawing.Point(294, 149);
            this.lbLoginError.Name = "lbLoginError";
            this.lbLoginError.Size = new System.Drawing.Size(156, 34);
            this.lbLoginError.TabIndex = 28;
            this.lbLoginError.Text = "Invalid username or \r\npassword";
            this.lbLoginError.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(294, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Password";
            // 
            // tbLogPass
            // 
            this.tbLogPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbLogPass.Location = new System.Drawing.Point(297, 123);
            this.tbLogPass.Name = "tbLogPass";
            this.tbLogPass.Size = new System.Drawing.Size(178, 23);
            this.tbLogPass.TabIndex = 23;
            this.tbLogPass.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(294, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Username";
            // 
            // tbLogUser
            // 
            this.tbLogUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbLogUser.Location = new System.Drawing.Point(297, 77);
            this.tbLogUser.Name = "tbLogUser";
            this.tbLogUser.Size = new System.Drawing.Size(178, 23);
            this.tbLogUser.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 314);
            this.Controls.Add(this.lbLoginError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLogPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbLogUser);
            this.Controls.Add(this.lbPasswordError);
            this.Controls.Add(this.lbUsernameError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSignRepPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSignPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSignUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbSignUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSignPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSignRepPass;
        private System.Windows.Forms.Label lbUsernameError;
        private System.Windows.Forms.Label lbPasswordError;
        private System.Windows.Forms.Label lbLoginError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLogPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLogUser;
    }
}

