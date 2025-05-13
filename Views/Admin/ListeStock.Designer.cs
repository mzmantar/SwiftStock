namespace SwiftStock.Views.Admin
{
    partial class ListeStock
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantiteEnStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitBindingSource1 = new BindingSource(components);
            produitBindingSource = new BindingSource(components);
            label1 = new Label();
            UsernameBox = new TextBox();
            label5 = new Label();
            produitControllerBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(26, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 464);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, prixDataGridViewTextBoxColumn, quantiteEnStockDataGridViewTextBoxColumn, categorieDataGridViewTextBoxColumn });
            dataGridView1.DataSource = produitBindingSource1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1035, 464);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            prixDataGridViewTextBoxColumn.MinimumWidth = 8;
            prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            prixDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantiteEnStockDataGridViewTextBoxColumn
            // 
            quantiteEnStockDataGridViewTextBoxColumn.DataPropertyName = "QuantiteEnStock";
            quantiteEnStockDataGridViewTextBoxColumn.HeaderText = "QuantiteEnStock";
            quantiteEnStockDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantiteEnStockDataGridViewTextBoxColumn.Name = "quantiteEnStockDataGridViewTextBoxColumn";
            quantiteEnStockDataGridViewTextBoxColumn.Width = 150;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            categorieDataGridViewTextBoxColumn.MinimumWidth = 8;
            categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            categorieDataGridViewTextBoxColumn.Width = 150;
            // 
            // produitBindingSource1
            // 
            produitBindingSource1.DataSource = typeof(Models.Produit);
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(Models.Produit);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 53);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 1;
            label1.Text = "Recherche : ";
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Tahoma", 13F);
            UsernameBox.Location = new Point(167, 48);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(233, 39);
            UsernameBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(310, 618);
            label5.Name = "label5";
            label5.Size = new Size(435, 22);
            label5.TabIndex = 10;
            label5.Text = "© Copyright SwiftStock 2025-2026 all rights reserved";
            // 
            // produitControllerBindingSource
            // 
            produitControllerBindingSource.DataSource = typeof(Controllers.ProduitController);
            // 
            // ListeStock
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 649);
            Controls.Add(label5);
            Controls.Add(UsernameBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ListeStock";
            Text = "ListeStock";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource produitBindingSource;
        private Label label1;
        private TextBox UsernameBox;
        private Label label5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteEnStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private BindingSource produitBindingSource1;
        private BindingSource produitControllerBindingSource;
    }
}