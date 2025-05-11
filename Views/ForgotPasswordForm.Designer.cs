namespace SwiftStock.Views
{
    partial class ForgotPasswordForm
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
            username = new Label();
            label1 = new Label();
            UsernameBox = new TextBox();
            label2 = new Label();
            ResetPass = new Button();
            BackLogin = new Label();
            label5 = new Label();
            labelAlert = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Tahoma", 10F);
            username.ForeColor = SystemColors.GrayText;
            username.Location = new Point(129, 155);
            username.Name = "username";
            username.Size = new Size(341, 48);
            username.TabIndex = 7;
            username.Text = "Enter your username and we will you\r\n instructions to reset your password.";
            username.Click += username_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(108, 98);
            label1.Name = "label1";
            label1.Size = new Size(388, 39);
            label1.TabIndex = 6;
            label1.Text = "Forgot Your Password?";
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Tahoma", 13F);
            UsernameBox.Location = new Point(90, 253);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(406, 39);
            UsernameBox.TabIndex = 5;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(90, 218);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // ResetPass
            // 
            ResetPass.BackColor = SystemColors.ButtonShadow;
            ResetPass.FlatAppearance.BorderColor = Color.White;
            ResetPass.FlatAppearance.BorderSize = 0;
            ResetPass.FlatAppearance.MouseDownBackColor = Color.White;
            ResetPass.FlatAppearance.MouseOverBackColor = Color.White;
            ResetPass.Font = new Font("Tahoma", 10F);
            ResetPass.Location = new Point(90, 352);
            ResetPass.Name = "ResetPass";
            ResetPass.Size = new Size(406, 58);
            ResetPass.TabIndex = 9;
            ResetPass.Text = "Send";
            ResetPass.UseVisualStyleBackColor = false;
            ResetPass.Click += ResetPass_Click;
            // 
            // BackLogin
            // 
            BackLogin.AutoSize = true;
            BackLogin.BackColor = Color.Transparent;
            BackLogin.Font = new Font("Tahoma", 9F);
            BackLogin.ForeColor = SystemColors.ActiveCaption;
            BackLogin.Location = new Point(193, 446);
            BackLogin.Name = "BackLogin";
            BackLogin.Size = new Size(194, 22);
            BackLogin.TabIndex = 10;
            BackLogin.Text = " Back to the login Page";
            BackLogin.Click += BackLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(76, 590);
            label5.Name = "label5";
            label5.Size = new Size(435, 22);
            label5.TabIndex = 11;
            label5.Text = "© Copyright SwiftStock 2025-2026 all rights reserved";
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.BackColor = Color.Transparent;
            labelAlert.Font = new Font("Tahoma", 9F);
            labelAlert.ForeColor = Color.FromArgb(255, 128, 128);
            labelAlert.Location = new Point(90, 309);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(0, 22);
            labelAlert.TabIndex = 12;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 621);
            Controls.Add(labelAlert);
            Controls.Add(label5);
            Controls.Add(BackLogin);
            Controls.Add(ResetPass);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(UsernameBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label label1;
        private TextBox UsernameBox;
        private Label label2;
        private Button ResetPass;
        private Label BackLogin;
        private Label label5;
        private Label labelAlert;
    }
}