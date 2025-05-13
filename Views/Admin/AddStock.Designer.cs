namespace SwiftStock.Views.Admin
{
    partial class AddStock
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
            NomBox = new TextBox();
            label2 = new Label();
            PrixBox = new TextBox();
            label3 = new Label();
            QuantiteBox1 = new TextBox();
            label4 = new Label();
            CategorieBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DescriptionBox1 = new TextBox();
            label7 = new Label();
            ButtonValider = new Button();
            ButtonAnnuler = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Tahoma", 9F);
            username.ForeColor = SystemColors.GrayText;
            username.Location = new Point(199, 98);
            username.Name = "username";
            username.Size = new Size(47, 22);
            username.TabIndex = 7;
            username.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(248, 29);
            label1.Name = "label1";
            label1.Size = new Size(313, 39);
            label1.TabIndex = 6;
            label1.Text = "Ajouter un Produit";
            // 
            // NomBox
            // 
            NomBox.Font = new Font("Tahoma", 13F);
            NomBox.Location = new Point(199, 133);
            NomBox.Name = "NomBox";
            NomBox.Size = new Size(406, 39);
            NomBox.TabIndex = 5;
            NomBox.TextChanged += NomBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(199, 189);
            label2.Name = "label2";
            label2.Size = new Size(39, 22);
            label2.TabIndex = 9;
            label2.Text = "Prix";
            // 
            // PrixBox
            // 
            PrixBox.Font = new Font("Tahoma", 13F);
            PrixBox.Location = new Point(199, 224);
            PrixBox.Name = "PrixBox";
            PrixBox.Size = new Size(152, 39);
            PrixBox.TabIndex = 8;
            PrixBox.TextChanged += PrixBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(199, 282);
            label3.Name = "label3";
            label3.Size = new Size(152, 22);
            label3.TabIndex = 11;
            label3.Text = "Quantite En Stock";
            // 
            // QuantiteBox1
            // 
            QuantiteBox1.Font = new Font("Tahoma", 13F);
            QuantiteBox1.Location = new Point(199, 317);
            QuantiteBox1.Name = "QuantiteBox1";
            QuantiteBox1.Size = new Size(152, 39);
            QuantiteBox1.TabIndex = 10;
            QuantiteBox1.TextChanged += QuantiteBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(199, 383);
            label4.Name = "label4";
            label4.Size = new Size(84, 22);
            label4.TabIndex = 13;
            label4.Text = "Categorie";
            // 
            // CategorieBox1
            // 
            CategorieBox1.Font = new Font("Tahoma", 13F);
            CategorieBox1.Location = new Point(199, 418);
            CategorieBox1.Name = "CategorieBox1";
            CategorieBox1.Size = new Size(406, 39);
            CategorieBox1.TabIndex = 12;
            CategorieBox1.TextChanged += CategorieBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(357, 235);
            label5.Name = "label5";
            label5.Size = new Size(44, 22);
            label5.TabIndex = 14;
            label5.Text = "DTT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(199, 473);
            label6.Name = "label6";
            label6.Size = new Size(97, 22);
            label6.TabIndex = 16;
            label6.Text = "Description";
            // 
            // DescriptionBox1
            // 
            DescriptionBox1.Font = new Font("Tahoma", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionBox1.Location = new Point(199, 508);
            DescriptionBox1.Name = "DescriptionBox1";
            DescriptionBox1.Size = new Size(406, 123);
            DescriptionBox1.TabIndex = 15;
            DescriptionBox1.TextChanged += DescriptionBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(170, 787);
            label7.Name = "label7";
            label7.Size = new Size(435, 22);
            label7.TabIndex = 18;
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
            ButtonValider.Location = new Point(199, 669);
            ButtonValider.Name = "ButtonValider";
            ButtonValider.Size = new Size(177, 58);
            ButtonValider.TabIndex = 17;
            ButtonValider.Text = "Valider";
            ButtonValider.UseVisualStyleBackColor = false;
            ButtonValider.Click += ButtonValider_Click;
            // 
            // ButtonAnnuler
            // 
            ButtonAnnuler.BackColor = SystemColors.ButtonHighlight;
            ButtonAnnuler.FlatAppearance.BorderColor = Color.White;
            ButtonAnnuler.FlatAppearance.BorderSize = 0;
            ButtonAnnuler.FlatAppearance.MouseDownBackColor = Color.White;
            ButtonAnnuler.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonAnnuler.Font = new Font("Tahoma", 10F);
            ButtonAnnuler.Location = new Point(428, 669);
            ButtonAnnuler.Name = "ButtonAnnuler";
            ButtonAnnuler.Size = new Size(177, 58);
            ButtonAnnuler.TabIndex = 19;
            ButtonAnnuler.Text = "Annuler";
            ButtonAnnuler.UseVisualStyleBackColor = false;
            ButtonAnnuler.Click += ButtonAnnuler_Click;
            // 
            // AddStock
            // 
            Appearance.BackColor = Color.FromArgb(224, 224, 224);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 818);
            Controls.Add(ButtonAnnuler);
            Controls.Add(label7);
            Controls.Add(ButtonValider);
            Controls.Add(label6);
            Controls.Add(DescriptionBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CategorieBox1);
            Controls.Add(label3);
            Controls.Add(QuantiteBox1);
            Controls.Add(label2);
            Controls.Add(PrixBox);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(NomBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStock";
            Load += AddStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label label1;
        private TextBox NomBox;
        private Label label2;
        private TextBox PrixBox;
        private Label label3;
        private TextBox QuantiteBox1;
        private Label label4;
        private TextBox CategorieBox1;
        private Label label5;
        private Label label6;
        private TextBox DescriptionBox1;
        private Label label7;
        private Button ButtonValider;
        private Button ButtonAnnuler;
    }
}