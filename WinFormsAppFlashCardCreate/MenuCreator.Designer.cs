namespace WinFormsAppFlashCardCreate
{
    partial class MenuCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCreator));
            this.textBoxCard1 = new System.Windows.Forms.TextBox();
            this.labelCard1 = new System.Windows.Forms.Label();
            this.labelCard2 = new System.Windows.Forms.Label();
            this.textBoxCard2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aléaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxCategory = new System.Windows.Forms.ToolStripComboBox();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxClue1Card1 = new System.Windows.Forms.TextBox();
            this.textBoxClue2Card1 = new System.Windows.Forms.TextBox();
            this.textBoxClue3Card1 = new System.Windows.Forms.TextBox();
            this.textBoxClue1Card2 = new System.Windows.Forms.TextBox();
            this.textBoxClue2Card2 = new System.Windows.Forms.TextBox();
            this.textBoxClue3Card2 = new System.Windows.Forms.TextBox();
            this.checkBoxClue1Card1 = new System.Windows.Forms.CheckBox();
            this.checkBoxClue2Card1 = new System.Windows.Forms.CheckBox();
            this.checkBoxClue3Card1 = new System.Windows.Forms.CheckBox();
            this.checkBoxClue1Card2 = new System.Windows.Forms.CheckBox();
            this.checkBoxClue2Card2 = new System.Windows.Forms.CheckBox();
            this.checkBoxClue3Card2 = new System.Windows.Forms.CheckBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategoryScore = new System.Windows.Forms.ComboBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonResetScore = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCard1
            // 
            resources.ApplyResources(this.textBoxCard1, "textBoxCard1");
            this.textBoxCard1.Name = "textBoxCard1";
            // 
            // labelCard1
            // 
            resources.ApplyResources(this.labelCard1, "labelCard1");
            this.labelCard1.Name = "labelCard1";
            // 
            // labelCard2
            // 
            resources.ApplyResources(this.labelCard2, "labelCard2");
            this.labelCard2.Name = "labelCard2";
            // 
            // textBoxCard2
            // 
            resources.ApplyResources(this.textBoxCard2, "textBoxCard2");
            this.textBoxCard2.Name = "textBoxCard2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.flashCardToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // flashCardToolStripMenuItem
            // 
            this.flashCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem,
            this.toolStripSeparator1,
            this.aléaToolStripMenuItem1});
            this.flashCardToolStripMenuItem.Name = "flashCardToolStripMenuItem";
            resources.ApplyResources(this.flashCardToolStripMenuItem, "flashCardToolStripMenuItem");
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            resources.ApplyResources(this.chooseToolStripMenuItem, "chooseToolStripMenuItem");
            this.chooseToolStripMenuItem.Click += new System.EventHandler(this.chooseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // aléaToolStripMenuItem1
            // 
            this.aléaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCategoryToolStripMenuItem1,
            this.toolStripSeparator2,
            this.toolStripComboBoxCategory,
            this.validateToolStripMenuItem});
            this.aléaToolStripMenuItem1.Name = "aléaToolStripMenuItem1";
            resources.ApplyResources(this.aléaToolStripMenuItem1, "aléaToolStripMenuItem1");
            // 
            // allCategoryToolStripMenuItem1
            // 
            this.allCategoryToolStripMenuItem1.Name = "allCategoryToolStripMenuItem1";
            resources.ApplyResources(this.allCategoryToolStripMenuItem1, "allCategoryToolStripMenuItem1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripComboBoxCategory
            // 
            this.toolStripComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCategory.Name = "toolStripComboBoxCategory";
            resources.ApplyResources(this.toolStripComboBoxCategory, "toolStripComboBoxCategory");
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            resources.ApplyResources(this.validateToolStripMenuItem, "validateToolStripMenuItem");
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.validateToolStripMenuItem_Click);
            // 
            // buttonGenerate
            // 
            resources.ApplyResources(this.buttonGenerate, "buttonGenerate");
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxClue1Card1
            // 
            resources.ApplyResources(this.textBoxClue1Card1, "textBoxClue1Card1");
            this.textBoxClue1Card1.Name = "textBoxClue1Card1";
            // 
            // textBoxClue2Card1
            // 
            resources.ApplyResources(this.textBoxClue2Card1, "textBoxClue2Card1");
            this.textBoxClue2Card1.Name = "textBoxClue2Card1";
            // 
            // textBoxClue3Card1
            // 
            resources.ApplyResources(this.textBoxClue3Card1, "textBoxClue3Card1");
            this.textBoxClue3Card1.Name = "textBoxClue3Card1";
            // 
            // textBoxClue1Card2
            // 
            resources.ApplyResources(this.textBoxClue1Card2, "textBoxClue1Card2");
            this.textBoxClue1Card2.Name = "textBoxClue1Card2";
            // 
            // textBoxClue2Card2
            // 
            resources.ApplyResources(this.textBoxClue2Card2, "textBoxClue2Card2");
            this.textBoxClue2Card2.Name = "textBoxClue2Card2";
            // 
            // textBoxClue3Card2
            // 
            resources.ApplyResources(this.textBoxClue3Card2, "textBoxClue3Card2");
            this.textBoxClue3Card2.Name = "textBoxClue3Card2";
            // 
            // checkBoxClue1Card1
            // 
            resources.ApplyResources(this.checkBoxClue1Card1, "checkBoxClue1Card1");
            this.checkBoxClue1Card1.Name = "checkBoxClue1Card1";
            this.checkBoxClue1Card1.UseVisualStyleBackColor = true;
            this.checkBoxClue1Card1.CheckedChanged += new System.EventHandler(this.checkBoxClue1Card1_CheckedChanged);
            // 
            // checkBoxClue2Card1
            // 
            resources.ApplyResources(this.checkBoxClue2Card1, "checkBoxClue2Card1");
            this.checkBoxClue2Card1.Name = "checkBoxClue2Card1";
            this.checkBoxClue2Card1.UseVisualStyleBackColor = true;
            this.checkBoxClue2Card1.CheckedChanged += new System.EventHandler(this.checkBoxClue2Card1_CheckedChanged);
            // 
            // checkBoxClue3Card1
            // 
            resources.ApplyResources(this.checkBoxClue3Card1, "checkBoxClue3Card1");
            this.checkBoxClue3Card1.Name = "checkBoxClue3Card1";
            this.checkBoxClue3Card1.UseVisualStyleBackColor = true;
            this.checkBoxClue3Card1.CheckedChanged += new System.EventHandler(this.checkBoxClue3Card1_CheckedChanged);
            // 
            // checkBoxClue1Card2
            // 
            resources.ApplyResources(this.checkBoxClue1Card2, "checkBoxClue1Card2");
            this.checkBoxClue1Card2.Name = "checkBoxClue1Card2";
            this.checkBoxClue1Card2.UseVisualStyleBackColor = true;
            this.checkBoxClue1Card2.CheckedChanged += new System.EventHandler(this.checkBoxClue1Card2_CheckedChanged);
            // 
            // checkBoxClue2Card2
            // 
            resources.ApplyResources(this.checkBoxClue2Card2, "checkBoxClue2Card2");
            this.checkBoxClue2Card2.Name = "checkBoxClue2Card2";
            this.checkBoxClue2Card2.UseVisualStyleBackColor = true;
            this.checkBoxClue2Card2.CheckedChanged += new System.EventHandler(this.checkBoxClue2Card2_CheckedChanged);
            // 
            // checkBoxClue3Card2
            // 
            resources.ApplyResources(this.checkBoxClue3Card2, "checkBoxClue3Card2");
            this.checkBoxClue3Card2.Name = "checkBoxClue3Card2";
            this.checkBoxClue3Card2.UseVisualStyleBackColor = true;
            this.checkBoxClue3Card2.CheckedChanged += new System.EventHandler(this.checkBoxClue3Card2_CheckedChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.Name = "comboBoxCategory";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxCategory
            // 
            resources.ApplyResources(this.textBoxCategory, "textBoxCategory");
            this.textBoxCategory.Name = "textBoxCategory";
            // 
            // buttonAddCategory
            // 
            resources.ApplyResources(this.buttonAddCategory, "buttonAddCategory");
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            resources.ApplyResources(this.buttonDeleteCategory, "buttonDeleteCategory");
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBoxCategoryScore
            // 
            this.comboBoxCategoryScore.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCategoryScore, "comboBoxCategoryScore");
            this.comboBoxCategoryScore.Name = "comboBoxCategoryScore";
            this.comboBoxCategoryScore.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryScore_SelectedIndexChanged);
            // 
            // labelScore
            // 
            resources.ApplyResources(this.labelScore, "labelScore");
            this.labelScore.Name = "labelScore";
            // 
            // buttonResetScore
            // 
            resources.ApplyResources(this.buttonResetScore, "buttonResetScore");
            this.buttonResetScore.Name = "buttonResetScore";
            this.buttonResetScore.UseVisualStyleBackColor = true;
            this.buttonResetScore.Click += new System.EventHandler(this.buttonResetScore_Click);
            // 
            // MenuCreator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonResetScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.comboBoxCategoryScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.checkBoxClue3Card2);
            this.Controls.Add(this.checkBoxClue2Card2);
            this.Controls.Add(this.checkBoxClue1Card2);
            this.Controls.Add(this.checkBoxClue3Card1);
            this.Controls.Add(this.checkBoxClue2Card1);
            this.Controls.Add(this.checkBoxClue1Card1);
            this.Controls.Add(this.textBoxClue3Card2);
            this.Controls.Add(this.textBoxClue2Card2);
            this.Controls.Add(this.textBoxClue1Card2);
            this.Controls.Add(this.textBoxClue3Card1);
            this.Controls.Add(this.textBoxClue2Card1);
            this.Controls.Add(this.textBoxClue1Card1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxCard2);
            this.Controls.Add(this.labelCard2);
            this.Controls.Add(this.labelCard1);
            this.Controls.Add(this.textBoxCard1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuCreator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCard1;
        private Label labelCard1;
        private Label labelCard2;
        private TextBox textBoxCard2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem flashCardToolStripMenuItem;
        private Button buttonGenerate;
        private TextBox textBoxClue1Card1;
        private TextBox textBoxClue2Card1;
        private TextBox textBoxClue3Card1;
        private TextBox textBoxClue1Card2;
        private TextBox textBoxClue2Card2;
        private TextBox textBoxClue3Card2;
        private CheckBox checkBoxClue1Card1;
        private CheckBox checkBoxClue2Card1;
        private CheckBox checkBoxClue3Card1;
        private CheckBox checkBoxClue1Card2;
        private CheckBox checkBoxClue2Card2;
        private CheckBox checkBoxClue3Card2;
        private ComboBox comboBoxCategory;
        private Label label1;
        private TextBox textBoxCategory;
        private Button buttonAddCategory;
        private Button buttonDeleteCategory;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem aléaToolStripMenuItem1;
        private ToolStripMenuItem allCategoryToolStripMenuItem1;
        private ToolStripComboBox toolStripComboBoxCategory;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem validateToolStripMenuItem;
        private ToolStripMenuItem chooseToolStripMenuItem;
        private Label label2;
        private ComboBox comboBoxCategoryScore;
        private Label labelScore;
        private Button buttonResetScore;
    }
}