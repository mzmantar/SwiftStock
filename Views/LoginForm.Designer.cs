namespace SwiftStock.Views
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
            ButtonLogin = new Button();
            RememberCheckBox = new CheckBox();
            UsernameBox = new TextBox();
            label1 = new Label();
            username = new Label();
            password = new Label();
            PasswordBox = new TextBox();
            ForgotPassword = new Label();
            label5 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = SystemColors.ButtonShadow;
            ButtonLogin.FlatAppearance.BorderColor = Color.White;
            ButtonLogin.FlatAppearance.BorderSize = 0;
            ButtonLogin.FlatAppearance.MouseDownBackColor = Color.White;
            ButtonLogin.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonLogin.Font = new Font("Tahoma", 10F);
            ButtonLogin.Location = new Point(93, 443);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(406, 58);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // RememberCheckBox
            // 
            RememberCheckBox.AutoSize = true;
            RememberCheckBox.Location = new Point(93, 346);
            RememberCheckBox.Name = "RememberCheckBox";
            RememberCheckBox.Size = new Size(139, 23);
            RememberCheckBox.TabIndex = 1;
            RememberCheckBox.Text = "Remember me";
            RememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Tahoma", 13F);
            UsernameBox.Location = new Point(93, 203);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(406, 39);
            UsernameBox.TabIndex = 2;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(109, 97);
            label1.Name = "label1";
            label1.Size = new Size(369, 39);
            label1.TabIndex = 3;
            label1.Text = "Login to Your Account";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Tahoma", 9F);
            username.ForeColor = SystemColors.GrayText;
            username.Location = new Point(93, 168);
            username.Name = "username";
            username.Size = new Size(88, 22);
            username.TabIndex = 4;
            username.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Tahoma", 9F);
            password.ForeColor = SystemColors.GrayText;
            password.Location = new Point(93, 258);
            password.Name = "password";
            password.Size = new Size(84, 22);
            password.TabIndex = 6;
            password.Text = "Password";
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Tahoma", 13F);
            PasswordBox.Location = new Point(93, 292);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(406, 39);
            PasswordBox.TabIndex = 5;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // ForgotPassword
            // 
            ForgotPassword.AutoSize = true;
            ForgotPassword.Font = new Font("Tahoma", 9F);
            ForgotPassword.ForeColor = SystemColors.ActiveCaption;
            ForgotPassword.Location = new Point(349, 347);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(150, 22);
            ForgotPassword.TabIndex = 8;
            ForgotPassword.Text = "Forgot password?";
            ForgotPassword.Click += ForgotPassword_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(79, 590);
            label5.Name = "label5";
            label5.Size = new Size(435, 22);
            label5.TabIndex = 9;
            label5.Text = "© Copyright SwiftStock 2025-2026 all rights reserved";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(267, 401);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 10;
            // 
            // LoginForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(596, 621);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(ForgotPassword);
            Controls.Add(password);
            Controls.Add(PasswordBox);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(UsernameBox);
            Controls.Add(RememberCheckBox);
            Controls.Add(ButtonLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLogin;
        private CheckBox RememberCheckBox;
        private TextBox UsernameBox;
        private Label label1;
        private Label username;
        private Label password;
        private TextBox PasswordBox;
        private Label ForgotPassword;
        private Label label5;
        private Label label3;
    }
}