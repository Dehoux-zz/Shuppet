namespace ShopClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lUsernameText = new System.Windows.Forms.TextBox();
            this.lPasswordText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rUsernameText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.registerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lUsernameText
            // 
            this.lUsernameText.Location = new System.Drawing.Point(110, 21);
            this.lUsernameText.Name = "lUsernameText";
            this.lUsernameText.Size = new System.Drawing.Size(100, 20);
            this.lUsernameText.TabIndex = 2;
            // 
            // lPasswordText
            // 
            this.lPasswordText.Location = new System.Drawing.Point(110, 49);
            this.lPasswordText.Name = "lPasswordText";
            this.lPasswordText.PasswordChar = '*';
            this.lPasswordText.Size = new System.Drawing.Size(100, 20);
            this.lPasswordText.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(135, 86);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button_Click);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.loginTab);
            this.Login.Controls.Add(this.registerTab);
            this.Login.Location = new System.Drawing.Point(4, 6);
            this.Login.Name = "Login";
            this.Login.SelectedIndex = 0;
            this.Login.Size = new System.Drawing.Size(263, 162);
            this.Login.TabIndex = 5;
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginTab.Controls.Add(this.label1);
            this.loginTab.Controls.Add(this.loginButton);
            this.loginTab.Controls.Add(this.label2);
            this.loginTab.Controls.Add(this.lPasswordText);
            this.loginTab.Controls.Add(this.lUsernameText);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(255, 136);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.SystemColors.Highlight;
            this.registerTab.Controls.Add(this.newPass);
            this.registerTab.Controls.Add(this.label4);
            this.registerTab.Controls.Add(this.registerButton);
            this.registerTab.Controls.Add(this.rUsernameText);
            this.registerTab.Controls.Add(this.label3);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(255, 136);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // rUsernameText
            // 
            this.rUsernameText.Location = new System.Drawing.Point(110, 21);
            this.rUsernameText.Name = "rUsernameText";
            this.rUsernameText.Size = new System.Drawing.Size(100, 20);
            this.rUsernameText.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(135, 86);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your new password is: ";
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Location = new System.Drawing.Point(132, 53);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(10, 13);
            this.newPass.TabIndex = 4;
            this.newPass.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(275, 174);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lUsernameText;
        private System.Windows.Forms.TextBox lPasswordText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TabControl Login;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox rUsernameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newPass;
    }
}

