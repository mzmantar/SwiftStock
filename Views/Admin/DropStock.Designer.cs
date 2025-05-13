namespace SwiftStock.Views.Admin
{
    partial class DropStock
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
            IDBox = new TextBox();
            ButtonAnnuler = new Button();
            label7 = new Label();
            ButtonValider = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Tahoma", 9F);
            username.ForeColor = SystemColors.GrayText;
            username.Location = new Point(111, 77);
            username.Name = "username";
            username.Size = new Size(29, 22);
            username.TabIndex = 6;
            username.Text = "ID";
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Tahoma", 13F);
            IDBox.Location = new Point(111, 113);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(153, 39);
            IDBox.TabIndex = 5;
            IDBox.TextChanged += IDBox_TextChanged;
            // 
            // ButtonAnnuler
            // 
            ButtonAnnuler.BackColor = SystemColors.ButtonHighlight;
            ButtonAnnuler.FlatAppearance.BorderColor = Color.White;
            ButtonAnnuler.FlatAppearance.BorderSize = 0;
            ButtonAnnuler.FlatAppearance.MouseDownBackColor = Color.White;
            ButtonAnnuler.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonAnnuler.Font = new Font("Tahoma", 10F);
            ButtonAnnuler.Location = new Point(340, 190);
            ButtonAnnuler.Name = "ButtonAnnuler";
            ButtonAnnuler.Size = new Size(177, 58);
            ButtonAnnuler.TabIndex = 37;
            ButtonAnnuler.Text = "Annuler";
            ButtonAnnuler.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(100, 322);
            label7.Name = "label7";
            label7.Size = new Size(435, 22);
            label7.TabIndex = 36;
            label7.Text = "© Copyright SwiftStock 2025-2026 all rights reserved";
            // 
            // ButtonValider
            // 
            ButtonValider.BackColor = SystemColors.ButtonShadow;
            ButtonValider.FlatAppearance.BorderColor = Color.White;
            ButtonValider.FlatAppearance.BorderSize = 0;
            ButtonValider.FlatAppearance.MouseDownBackColor = Color.White;
            ButtonValider.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonValider.Font = new Font("Tahoma", 10F);
            ButtonValider.Location = new Point(111, 190);
            ButtonValider.Name = "ButtonValider";
            ButtonValider.Size = new Size(177, 58);
            ButtonValider.TabIndex = 35;
            ButtonValider.Text = "Valider";
            ButtonValider.UseVisualStyleBackColor = false;
            ButtonValider.Click += ButtonValider_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 39);
            label1.TabIndex = 38;
            label1.Text = "Supprimer un produit";
            // 
            // DropStock
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 353);
            Controls.Add(label1);
            Controls.Add(ButtonAnnuler);
            Controls.Add(label7);
            Controls.Add(ButtonValider);
            Controls.Add(username);
            Controls.Add(IDBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DropStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DropStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox IDBox;
        private Button ButtonAnnuler;
        private Label label7;
        private Button ButtonValider;
        private Label label1;
    }
}