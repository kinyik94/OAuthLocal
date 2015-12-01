namespace OAuthLocal
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ResponseBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.login_password_label = new System.Windows.Forms.Label();
            this.login_password_textbox = new System.Windows.Forms.TextBox();
            this.login_username_label = new System.Windows.Forms.Label();
            this.login_username_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // ResponseBox
            // 
            this.ResponseBox.Location = new System.Drawing.Point(32, 240);
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResponseBox.Size = new System.Drawing.Size(342, 82);
            this.ResponseBox.TabIndex = 18;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.Location = new System.Drawing.Point(228, 345);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(141, 42);
            this.login_button.TabIndex = 17;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_password_label
            // 
            this.login_password_label.AutoSize = true;
            this.login_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_password_label.Location = new System.Drawing.Point(28, 194);
            this.login_password_label.Name = "login_password_label";
            this.login_password_label.Size = new System.Drawing.Size(82, 20);
            this.login_password_label.TabIndex = 16;
            this.login_password_label.Text = "Password:";
            // 
            // login_password_textbox
            // 
            this.login_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_password_textbox.Location = new System.Drawing.Point(144, 194);
            this.login_password_textbox.Name = "login_password_textbox";
            this.login_password_textbox.PasswordChar = '*';
            this.login_password_textbox.Size = new System.Drawing.Size(230, 26);
            this.login_password_textbox.TabIndex = 15;
            // 
            // login_username_label
            // 
            this.login_username_label.AutoSize = true;
            this.login_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_username_label.Location = new System.Drawing.Point(23, 137);
            this.login_username_label.Name = "login_username_label";
            this.login_username_label.Size = new System.Drawing.Size(87, 20);
            this.login_username_label.TabIndex = 14;
            this.login_username_label.Text = "Username:";
            // 
            // login_username_textbox
            // 
            this.login_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_username_textbox.Location = new System.Drawing.Point(144, 134);
            this.login_username_textbox.Name = "login_username_textbox";
            this.login_username_textbox.Size = new System.Drawing.Size(230, 26);
            this.login_username_textbox.TabIndex = 13;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_label.Location = new System.Drawing.Point(99, 50);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(190, 39);
            this.login_label.TabIndex = 12;
            this.login_label.Text = "Login Page";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back_button.Location = new System.Drawing.Point(42, 345);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(152, 42);
            this.back_button.TabIndex = 19;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 410);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.ResponseBox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_password_label);
            this.Controls.Add(this.login_password_textbox);
            this.Controls.Add(this.login_username_label);
            this.Controls.Add(this.login_username_textbox);
            this.Controls.Add(this.login_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label login_password_label;
        private System.Windows.Forms.TextBox login_password_textbox;
        private System.Windows.Forms.Label login_username_label;
        private System.Windows.Forms.TextBox login_username_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}