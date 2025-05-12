namespace SwiftStock.Views
{
    partial class Sidebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sidebar));
            SidebarContaine = new FlowLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            LabSwiftStock = new Label();
            panel2 = new Panel();
            HomeButton = new Button();
            panel3 = new Panel();
            UserMangement = new Button();
            panel4 = new Panel();
            PasswordRestButton = new Button();
            panel5 = new Panel();
            SatisticsButton = new Button();
            panel6 = new Panel();
            SystemlogsButton = new Button();
            panel7 = new Panel();
            SettingsButton = new Button();
            panel8 = new Panel();
            panel13 = new Panel();
            label2 = new Label();
            Exit = new PictureBox();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            PanelContent = new DevExpress.XtraEditors.PanelControl();
            SidebarContaine.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelContent).BeginInit();
            SuspendLayout();
            // 
            // SidebarContaine
            // 
            SidebarContaine.BackColor = Color.FromArgb(35, 40, 45);
            SidebarContaine.Controls.Add(panel1);
            SidebarContaine.Controls.Add(panel2);
            SidebarContaine.Controls.Add(panel3);
            SidebarContaine.Controls.Add(panel4);
            SidebarContaine.Controls.Add(panel5);
            SidebarContaine.Controls.Add(panel6);
            SidebarContaine.Controls.Add(panel7);
            SidebarContaine.Controls.Add(panel8);
            SidebarContaine.Controls.Add(panel13);
            SidebarContaine.Dock = DockStyle.Left;
            SidebarContaine.Location = new Point(0, 0);
            SidebarContaine.Name = "SidebarContaine";
            SidebarContaine.Size = new Size(388, 1211);
            SidebarContaine.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LabSwiftStock);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 257);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 91);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 4;
            label4.Text = "User Management";
            // 
            // LabSwiftStock
            // 
            LabSwiftStock.AutoSize = true;
            LabSwiftStock.BackColor = Color.Transparent;
            LabSwiftStock.Cursor = Cursors.Hand;
            LabSwiftStock.Font = new Font("Adobe Gothic Std B", 22F, FontStyle.Bold, GraphicsUnit.Point, 128);
            LabSwiftStock.ForeColor = Color.White;
            LabSwiftStock.Location = new Point(70, 45);
            LabSwiftStock.Name = "LabSwiftStock";
            LabSwiftStock.Size = new Size(240, 55);
            LabSwiftStock.TabIndex = 3;
            LabSwiftStock.Text = "SwiftStock";
            LabSwiftStock.Click += LabSwiftStock_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(HomeButton);
            panel2.Location = new Point(3, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 75);
            panel2.TabIndex = 1;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.FromArgb(35, 40, 45);
            HomeButton.Cursor = Cursors.Hand;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.White;
            HomeButton.Image = Properties.Resources.house__2_;
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(-16, -10);
            HomeButton.Name = "HomeButton";
            HomeButton.Padding = new Padding(50, 0, 0, 0);
            HomeButton.Size = new Size(472, 99);
            HomeButton.TabIndex = 3;
            HomeButton.Text = "          Home ";
            HomeButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(UserMangement);
            panel3.Location = new Point(3, 347);
            panel3.Name = "panel3";
            panel3.Size = new Size(385, 75);
            panel3.TabIndex = 2;
            // 
            // UserMangement
            // 
            UserMangement.BackColor = Color.FromArgb(35, 40, 45);
            UserMangement.FlatStyle = FlatStyle.Flat;
            UserMangement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserMangement.ForeColor = Color.White;
            UserMangement.Image = (Image)resources.GetObject("UserMangement.Image");
            UserMangement.ImageAlign = ContentAlignment.MiddleLeft;
            UserMangement.Location = new Point(-16, -15);
            UserMangement.Name = "UserMangement";
            UserMangement.Padding = new Padding(50, 0, 0, 0);
            UserMangement.Size = new Size(472, 99);
            UserMangement.TabIndex = 4;
            UserMangement.Text = "          User Management";
            UserMangement.TextAlign = ContentAlignment.MiddleLeft;
            UserMangement.UseVisualStyleBackColor = false;
            UserMangement.Click += UserMangement_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(PasswordRestButton);
            panel4.Location = new Point(3, 428);
            panel4.Name = "panel4";
            panel4.Size = new Size(385, 75);
            panel4.TabIndex = 3;
            // 
            // PasswordRestButton
            // 
            PasswordRestButton.BackColor = Color.FromArgb(35, 40, 45);
            PasswordRestButton.FlatStyle = FlatStyle.Flat;
            PasswordRestButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordRestButton.ForeColor = Color.White;
            PasswordRestButton.Image = (Image)resources.GetObject("PasswordRestButton.Image");
            PasswordRestButton.ImageAlign = ContentAlignment.MiddleLeft;
            PasswordRestButton.Location = new Point(-16, -13);
            PasswordRestButton.Name = "PasswordRestButton";
            PasswordRestButton.Padding = new Padding(50, 0, 0, 0);
            PasswordRestButton.Size = new Size(472, 99);
            PasswordRestButton.TabIndex = 5;
            PasswordRestButton.Text = "          Password Reset";
            PasswordRestButton.TextAlign = ContentAlignment.MiddleLeft;
            PasswordRestButton.UseVisualStyleBackColor = false;
            PasswordRestButton.Click += PasswordRestButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(SatisticsButton);
            panel5.Location = new Point(3, 509);
            panel5.Name = "panel5";
            panel5.Size = new Size(385, 75);
            panel5.TabIndex = 4;
            // 
            // SatisticsButton
            // 
            SatisticsButton.BackColor = Color.FromArgb(35, 40, 45);
            SatisticsButton.FlatStyle = FlatStyle.Flat;
            SatisticsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SatisticsButton.ForeColor = Color.White;
            SatisticsButton.Image = (Image)resources.GetObject("SatisticsButton.Image");
            SatisticsButton.ImageAlign = ContentAlignment.MiddleLeft;
            SatisticsButton.Location = new Point(-16, -11);
            SatisticsButton.Name = "SatisticsButton";
            SatisticsButton.Padding = new Padding(50, 0, 0, 0);
            SatisticsButton.Size = new Size(472, 99);
            SatisticsButton.TabIndex = 6;
            SatisticsButton.Text = "          Statistics";
            SatisticsButton.TextAlign = ContentAlignment.MiddleLeft;
            SatisticsButton.UseVisualStyleBackColor = false;
            SatisticsButton.Click += SatisticsButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(SystemlogsButton);
            panel6.Location = new Point(3, 590);
            panel6.Name = "panel6";
            panel6.Size = new Size(385, 75);
            panel6.TabIndex = 5;
            // 
            // SystemlogsButton
            // 
            SystemlogsButton.BackColor = Color.FromArgb(35, 40, 45);
            SystemlogsButton.FlatStyle = FlatStyle.Flat;
            SystemlogsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SystemlogsButton.ForeColor = Color.White;
            SystemlogsButton.Image = (Image)resources.GetObject("SystemlogsButton.Image");
            SystemlogsButton.ImageAlign = ContentAlignment.MiddleLeft;
            SystemlogsButton.Location = new Point(-16, -9);
            SystemlogsButton.Name = "SystemlogsButton";
            SystemlogsButton.Padding = new Padding(50, 0, 0, 0);
            SystemlogsButton.Size = new Size(472, 99);
            SystemlogsButton.TabIndex = 7;
            SystemlogsButton.Text = "          System Logs";
            SystemlogsButton.TextAlign = ContentAlignment.MiddleLeft;
            SystemlogsButton.UseVisualStyleBackColor = false;
            SystemlogsButton.Click += SystemlogsButton_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(SettingsButton);
            panel7.Location = new Point(3, 671);
            panel7.Name = "panel7";
            panel7.Size = new Size(385, 75);
            panel7.TabIndex = 6;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(35, 40, 45);
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsButton.ForeColor = Color.White;
            SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
            SettingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsButton.Location = new Point(-16, -10);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Padding = new Padding(50, 0, 0, 0);
            SettingsButton.Size = new Size(472, 99);
            SettingsButton.TabIndex = 8;
            SettingsButton.Text = "          Settings";
            SettingsButton.TextAlign = ContentAlignment.MiddleLeft;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // panel8
            // 
            panel8.Location = new Point(3, 752);
            panel8.Name = "panel8";
            panel8.Size = new Size(386, 278);
            panel8.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.Controls.Add(label2);
            panel13.Controls.Add(Exit);
            panel13.Location = new Point(3, 1036);
            panel13.Name = "panel13";
            panel13.Size = new Size(386, 127);
            panel13.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 38);
            label2.TabIndex = 3;
            label2.Text = "Exit";
            // 
            // Exit
            // 
            Exit.Image = Properties.Resources.sign_out;
            Exit.Location = new Point(40, 52);
            Exit.Name = "Exit";
            Exit.Size = new Size(45, 43);
            Exit.SizeMode = PictureBoxSizeMode.StretchImage;
            Exit.TabIndex = 0;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // PanelContent
            // 
            PanelContent.Location = new Point(389, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1613, 1211);
            PanelContent.TabIndex = 1;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(2000, 1211);
            Controls.Add(PanelContent);
            Controls.Add(SidebarContaine);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sidebar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardSuperAdminForm";
            WindowState = FormWindowState.Minimized;
            SidebarContaine.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelContent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SidebarContaine;
        private Panel panel1;
        private Panel panel2;
        private Button HomeButton;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button UserMangement;
        private Button PasswordRestButton;
        private Button SatisticsButton;
        private Button SystemlogsButton;
        private Button SettingsButton;
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel panel8;
        private Panel panel13;
        private Label label2;
        private PictureBox Exit;
        private Label LabSwiftStock;
        private Label label4;
        private DevExpress.XtraEditors.PanelControl PanelContent;
    }
}