namespace OAuthLocal
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.signup_button = new System.Windows.Forms.Button();
            this.signup_confirm_label = new System.Windows.Forms.Label();
            this.signup_confirm_textbox = new System.Windows.Forms.TextBox();
            this.signup_username_label = new System.Windows.Forms.Label();
            this.signup_username_textbox = new System.Windows.Forms.TextBox();
            this.signup_password_label = new System.Windows.Forms.Label();
            this.signup_password_textbox = new System.Windows.Forms.TextBox();
            this.signup_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResponseBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_button.Location = new System.Drawing.Point(242, 468);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(150, 42);
            this.signup_button.TabIndex = 25;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // signup_confirm_label
            // 
            this.signup_confirm_label.AutoSize = true;
            this.signup_confirm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_confirm_label.Location = new System.Drawing.Point(19, 270);
            this.signup_confirm_label.Name = "signup_confirm_label";
            this.signup_confirm_label.Size = new System.Drawing.Size(140, 20);
            this.signup_confirm_label.TabIndex = 24;
            this.signup_confirm_label.Text = "Confirm password:";
            // 
            // signup_confirm_textbox
            // 
            this.signup_confirm_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_confirm_textbox.Location = new System.Drawing.Point(165, 267);
            this.signup_confirm_textbox.Name = "signup_confirm_textbox";
            this.signup_confirm_textbox.PasswordChar = '*';
            this.signup_confirm_textbox.Size = new System.Drawing.Size(268, 26);
            this.signup_confirm_textbox.TabIndex = 23;
            // 
            // signup_username_label
            // 
            this.signup_username_label.AutoSize = true;
            this.signup_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_username_label.Location = new System.Drawing.Point(72, 147);
            this.signup_username_label.Name = "signup_username_label";
            this.signup_username_label.Size = new System.Drawing.Size(87, 20);
            this.signup_username_label.TabIndex = 22;
            this.signup_username_label.Text = "Username:";
            // 
            // signup_username_textbox
            // 
            this.signup_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_username_textbox.Location = new System.Drawing.Point(165, 144);
            this.signup_username_textbox.Name = "signup_username_textbox";
            this.signup_username_textbox.Size = new System.Drawing.Size(268, 26);
            this.signup_username_textbox.TabIndex = 21;
            // 
            // signup_password_label
            // 
            this.signup_password_label.AutoSize = true;
            this.signup_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_password_label.Location = new System.Drawing.Point(77, 210);
            this.signup_password_label.Name = "signup_password_label";
            this.signup_password_label.Size = new System.Drawing.Size(82, 20);
            this.signup_password_label.TabIndex = 20;
            this.signup_password_label.Text = "Password:";
            // 
            // signup_password_textbox
            // 
            this.signup_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_password_textbox.Location = new System.Drawing.Point(165, 204);
            this.signup_password_textbox.Name = "signup_password_textbox";
            this.signup_password_textbox.PasswordChar = '*';
            this.signup_password_textbox.Size = new System.Drawing.Size(268, 26);
            this.signup_password_textbox.TabIndex = 19;
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_label.Location = new System.Drawing.Point(120, 60);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(219, 39);
            this.signup_label.TabIndex = 18;
            this.signup_label.Text = "SignUp Page";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back_button.Location = new System.Drawing.Point(57, 468);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(143, 42);
            this.back_button.TabIndex = 26;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(34, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Error Response:";
            // 
            // ResponseBox
            // 
            this.ResponseBox.Location = new System.Drawing.Point(50, 364);
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResponseBox.Size = new System.Drawing.Size(342, 82);
            this.ResponseBox.TabIndex = 28;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 555);
            this.Controls.Add(this.ResponseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.signup_confirm_label);
            this.Controls.Add(this.signup_confirm_textbox);
            this.Controls.Add(this.signup_username_label);
            this.Controls.Add(this.signup_username_textbox);
            this.Controls.Add(this.signup_password_label);
            this.Controls.Add(this.signup_password_textbox);
            this.Controls.Add(this.signup_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Label signup_confirm_label;
        private System.Windows.Forms.TextBox signup_confirm_textbox;
        private System.Windows.Forms.Label signup_username_label;
        private System.Windows.Forms.TextBox signup_username_textbox;
        private System.Windows.Forms.Label signup_password_label;
        private System.Windows.Forms.TextBox signup_password_textbox;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResponseBox;

    }
}