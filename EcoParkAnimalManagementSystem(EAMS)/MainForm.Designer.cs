namespace EcoParkAnimalManagementSystem_EAMS_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            grpCreateAnimal = new GroupBox();
            btnCreateAnimal = new Button();
            chkListAllSpecies = new CheckBox();
            lstSpecies = new ListBox();
            lstCategory = new ListBox();
            btnLoadImage = new Button();
            grpGeneralData = new GroupBox();
            btnAdd = new Button();
            cmbGender = new ComboBox();
            lblGender = new Label();
            txtWeight = new TextBox();
            lblWeight = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtName = new TextBox();
            lblName = new Label();
            picAnimal = new PictureBox();
            lblAnimalInfo = new Label();
            menuStrip.SuspendLayout();
            grpCreateAnimal.SuspendLayout();
            grpGeneralData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnimal).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1007, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(116, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(55, 24);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // grpCreateAnimal
            // 
            grpCreateAnimal.Controls.Add(btnCreateAnimal);
            grpCreateAnimal.Controls.Add(chkListAllSpecies);
            grpCreateAnimal.Controls.Add(lstSpecies);
            grpCreateAnimal.Controls.Add(lstCategory);
            grpCreateAnimal.Location = new Point(12, 35);
            grpCreateAnimal.Name = "grpCreateAnimal";
            grpCreateAnimal.Size = new Size(315, 202);
            grpCreateAnimal.TabIndex = 1;
            grpCreateAnimal.TabStop = false;
            grpCreateAnimal.Text = "Create Animal";
            // 
            // btnCreateAnimal
            // 
            btnCreateAnimal.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateAnimal.Location = new Point(50, 165);
            btnCreateAnimal.Name = "btnCreateAnimal";
            btnCreateAnimal.Size = new Size(183, 29);
            btnCreateAnimal.TabIndex = 3;
            btnCreateAnimal.Text = "Create Animal";
            btnCreateAnimal.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCreateAnimal.UseVisualStyleBackColor = true;
            btnCreateAnimal.Click += btnCreateAnimal_Click;
            // 
            // chkListAllSpecies
            // 
            chkListAllSpecies.AutoSize = true;
            chkListAllSpecies.Location = new Point(121, 26);
            chkListAllSpecies.Name = "chkListAllSpecies";
            chkListAllSpecies.Size = new Size(174, 24);
            chkListAllSpecies.TabIndex = 2;
            chkListAllSpecies.Text = "List all animal species";
            chkListAllSpecies.UseVisualStyleBackColor = true;
            chkListAllSpecies.CheckedChanged += chkListAllSpecies_CheckedChanged;
            // 
            // lstSpecies
            // 
            lstSpecies.FormattingEnabled = true;
            lstSpecies.Location = new Point(160, 57);
            lstSpecies.Name = "lstSpecies";
            lstSpecies.Size = new Size(135, 104);
            lstSpecies.TabIndex = 1;
            lstSpecies.SelectedIndexChanged += lstSpecies_SelectedIndexChanged;
            // 
            // lstCategory
            // 
            lstCategory.FormattingEnabled = true;
            lstCategory.Location = new Point(6, 54);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new Size(133, 104);
            lstCategory.TabIndex = 0;
            lstCategory.SelectedIndexChanged += lstCategory_SelectedIndexChanged;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(828, 235);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(109, 29);
            btnLoadImage.TabIndex = 4;
            btnLoadImage.Text = "Load Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // grpGeneralData
            // 
            grpGeneralData.Controls.Add(btnAdd);
            grpGeneralData.Controls.Add(cmbGender);
            grpGeneralData.Controls.Add(lblGender);
            grpGeneralData.Controls.Add(txtWeight);
            grpGeneralData.Controls.Add(lblWeight);
            grpGeneralData.Controls.Add(txtAge);
            grpGeneralData.Controls.Add(lblAge);
            grpGeneralData.Controls.Add(txtName);
            grpGeneralData.Controls.Add(lblName);
            grpGeneralData.Location = new Point(376, 35);
            grpGeneralData.Name = "grpGeneralData";
            grpGeneralData.Size = new Size(309, 212);
            grpGeneralData.TabIndex = 2;
            grpGeneralData.TabStop = false;
            grpGeneralData.Text = "General Data";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(95, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(77, 130);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(15, 133);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(77, 88);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(15, 91);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(56, 20);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Weight";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(77, 58);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(18, 58);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // txtName
            // 
            txtName.Location = new Point(77, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(9, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // picAnimal
            // 
            picAnimal.BorderStyle = BorderStyle.FixedSingle;
            picAnimal.Location = new Point(719, 35);
            picAnimal.Name = "picAnimal";
            picAnimal.Size = new Size(346, 194);
            picAnimal.SizeMode = PictureBoxSizeMode.Zoom;
            picAnimal.TabIndex = 3;
            picAnimal.TabStop = false;
            // 
            // lblAnimalInfo
            // 
            lblAnimalInfo.Location = new Point(453, 321);
            lblAnimalInfo.Name = "lblAnimalInfo";
            lblAnimalInfo.Size = new Size(268, 278);
            lblAnimalInfo.TabIndex = 4;
            lblAnimalInfo.Text = ".";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1007, 576);
            Controls.Add(picAnimal);
            Controls.Add(btnLoadImage);
            Controls.Add(lblAnimalInfo);
            Controls.Add(grpGeneralData);
            Controls.Add(grpCreateAnimal);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoPark Animal Management System";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            grpCreateAnimal.ResumeLayout(false);
            grpCreateAnimal.PerformLayout();
            grpGeneralData.ResumeLayout(false);
            grpGeneralData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnimal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox grpCreateAnimal;
        private ListBox lstSpecies;
        private ListBox lstCategory;
        private Button btnCreateAnimal;
        private CheckBox chkListAllSpecies;
        private Button btnLoadImage;
        private GroupBox grpGeneralData;
        private Label lblAge;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtAge;
        private TextBox txtWeight;
        private Label lblWeight;
        private Label lblGender;
        private Button btnAdd;
        private ComboBox cmbGender;
        private PictureBox picAnimal;
        private Label lblAnimalInfo;
    }
}
