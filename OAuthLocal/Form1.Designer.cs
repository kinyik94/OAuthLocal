namespace OAuthLocal
{
    partial class Oauth_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oauth_Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResponseBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.login_password_label = new System.Windows.Forms.Label();
            this.login_password_textbox = new System.Windows.Forms.TextBox();
            this.login_username_label = new System.Windows.Forms.Label();
            this.login_username_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.signup_confirm_label = new System.Windows.Forms.Label();
            this.signup_confirm_textbox = new System.Windows.Forms.TextBox();
            this.signup_username_label = new System.Windows.Forms.Label();
            this.signup_username_textbox = new System.Windows.Forms.TextBox();
            this.signup_password_label = new System.Windows.Forms.Label();
            this.signup_password_textbox = new System.Windows.Forms.TextBox();
            this.signup_label = new System.Windows.Forms.Label();
            this.Token = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Token);
            this.splitContainer1.Panel1.Controls.Add(this.UserName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ResponseBox);
            this.splitContainer1.Panel1.Controls.Add(this.login_button);
            this.splitContainer1.Panel1.Controls.Add(this.login_password_label);
            this.splitContainer1.Panel1.Controls.Add(this.login_password_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.login_username_label);
            this.splitContainer1.Panel1.Controls.Add(this.login_username_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.login_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.signup_button);
            this.splitContainer1.Panel2.Controls.Add(this.signup_confirm_label);
            this.splitContainer1.Panel2.Controls.Add(this.signup_confirm_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.signup_username_label);
            this.splitContainer1.Panel2.Controls.Add(this.signup_username_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.signup_password_label);
            this.splitContainer1.Panel2.Controls.Add(this.signup_password_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.signup_label);
            this.splitContainer1.Size = new System.Drawing.Size(899, 518);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(119, 395);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 13);
            this.UserName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Token :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserName:";
            // 
            // ResponseBox
            // 
            this.ResponseBox.Location = new System.Drawing.Point(48, 224);
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResponseBox.Size = new System.Drawing.Size(342, 82);
            this.ResponseBox.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.Location = new System.Drawing.Point(132, 312);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(159, 42);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_password_label
            // 
            this.login_password_label.AutoSize = true;
            this.login_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_password_label.Location = new System.Drawing.Point(44, 178);
            this.login_password_label.Name = "login_password_label";
            this.login_password_label.Size = new System.Drawing.Size(82, 20);
            this.login_password_label.TabIndex = 4;
            this.login_password_label.Text = "Password:";
            // 
            // login_password_textbox
            // 
            this.login_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_password_textbox.Location = new System.Drawing.Point(160, 178);
            this.login_password_textbox.Name = "login_password_textbox";
            this.login_password_textbox.Size = new System.Drawing.Size(230, 26);
            this.login_password_textbox.TabIndex = 3;
            // 
            // login_username_label
            // 
            this.login_username_label.AutoSize = true;
            this.login_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_username_label.Location = new System.Drawing.Point(39, 121);
            this.login_username_label.Name = "login_username_label";
            this.login_username_label.Size = new System.Drawing.Size(87, 20);
            this.login_username_label.TabIndex = 2;
            this.login_username_label.Text = "Username:";
            // 
            // login_username_textbox
            // 
            this.login_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_username_textbox.Location = new System.Drawing.Point(160, 118);
            this.login_username_textbox.Name = "login_username_textbox";
            this.login_username_textbox.Size = new System.Drawing.Size(230, 26);
            this.login_username_textbox.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_label.Location = new System.Drawing.Point(115, 34);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(190, 39);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login Page";
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_button.Location = new System.Drawing.Point(163, 312);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(150, 42);
            this.signup_button.TabIndex = 9;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // signup_confirm_label
            // 
            this.signup_confirm_label.AutoSize = true;
            this.signup_confirm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_confirm_label.Location = new System.Drawing.Point(27, 244);
            this.signup_confirm_label.Name = "signup_confirm_label";
            this.signup_confirm_label.Size = new System.Drawing.Size(140, 20);
            this.signup_confirm_label.TabIndex = 8;
            this.signup_confirm_label.Text = "Confirm password:";
            // 
            // signup_confirm_textbox
            // 
            this.signup_confirm_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_confirm_textbox.Location = new System.Drawing.Point(173, 241);
            this.signup_confirm_textbox.Name = "signup_confirm_textbox";
            this.signup_confirm_textbox.Size = new System.Drawing.Size(268, 26);
            this.signup_confirm_textbox.TabIndex = 7;
            // 
            // signup_username_label
            // 
            this.signup_username_label.AutoSize = true;
            this.signup_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_username_label.Location = new System.Drawing.Point(80, 121);
            this.signup_username_label.Name = "signup_username_label";
            this.signup_username_label.Size = new System.Drawing.Size(87, 20);
            this.signup_username_label.TabIndex = 6;
            this.signup_username_label.Text = "Username:";
            // 
            // signup_username_textbox
            // 
            this.signup_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_username_textbox.Location = new System.Drawing.Point(173, 118);
            this.signup_username_textbox.Name = "signup_username_textbox";
            this.signup_username_textbox.Size = new System.Drawing.Size(268, 26);
            this.signup_username_textbox.TabIndex = 5;
            // 
            // signup_password_label
            // 
            this.signup_password_label.AutoSize = true;
            this.signup_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_password_label.Location = new System.Drawing.Point(85, 184);
            this.signup_password_label.Name = "signup_password_label";
            this.signup_password_label.Size = new System.Drawing.Size(82, 20);
            this.signup_password_label.TabIndex = 4;
            this.signup_password_label.Text = "Password:";
            // 
            // signup_password_textbox
            // 
            this.signup_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_password_textbox.Location = new System.Drawing.Point(173, 178);
            this.signup_password_textbox.Name = "signup_password_textbox";
            this.signup_password_textbox.Size = new System.Drawing.Size(268, 26);
            this.signup_password_textbox.TabIndex = 3;
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_label.Location = new System.Drawing.Point(128, 34);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(219, 39);
            this.signup_label.TabIndex = 1;
            this.signup_label.Text = "SignUp Page";
            // 
            // Token
            // 
            this.Token.Location = new System.Drawing.Point(93, 430);
            this.Token.Multiline = true;
            this.Token.Name = "Token";
            this.Token.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Token.Size = new System.Drawing.Size(319, 68);
            this.Token.TabIndex = 11;
            // 
            // Oauth_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 518);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oauth_Form";
            this.Text = "OAuth App";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label login_password_label;
        private System.Windows.Forms.TextBox login_password_textbox;
        private System.Windows.Forms.Label login_username_label;
        private System.Windows.Forms.TextBox login_username_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label signup_confirm_label;
        private System.Windows.Forms.TextBox signup_confirm_textbox;
        private System.Windows.Forms.Label signup_username_label;
        private System.Windows.Forms.TextBox signup_username_textbox;
        private System.Windows.Forms.Label signup_password_label;
        private System.Windows.Forms.TextBox signup_password_textbox;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Token;
    }
}

