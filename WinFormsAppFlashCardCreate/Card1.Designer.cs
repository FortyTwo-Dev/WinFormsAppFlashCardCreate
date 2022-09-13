namespace WinFormsAppFlashCardCreate
{
    partial class Card1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonResultCard1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCard1 = new System.Windows.Forms.Label();
            this.buttonCancelCard2 = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clueToolStripMenuItem
            // 
            this.clueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.clueToolStripMenuItem.Name = "clueToolStripMenuItem";
            this.clueToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.clueToolStripMenuItem.Text = "Clue";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem1.Text = "1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // buttonResultCard1
            // 
            this.buttonResultCard1.Location = new System.Drawing.Point(360, 286);
            this.buttonResultCard1.Name = "buttonResultCard1";
            this.buttonResultCard1.Size = new System.Drawing.Size(81, 27);
            this.buttonResultCard1.TabIndex = 7;
            this.buttonResultCard1.Text = "Result";
            this.buttonResultCard1.UseVisualStyleBackColor = true;
            this.buttonResultCard1.Click += new System.EventHandler(this.buttonResultCard2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCard1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 253);
            this.panel1.TabIndex = 6;
            // 
            // labelCard1
            // 
            this.labelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCard1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCard1.Location = new System.Drawing.Point(0, 0);
            this.labelCard1.Name = "labelCard1";
            this.labelCard1.Size = new System.Drawing.Size(516, 253);
            this.labelCard1.TabIndex = 1;
            this.labelCard1.Text = "Card1";
            this.labelCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelCard2
            // 
            this.buttonCancelCard2.Location = new System.Drawing.Point(12, 286);
            this.buttonCancelCard2.Name = "buttonCancelCard2";
            this.buttonCancelCard2.Size = new System.Drawing.Size(81, 27);
            this.buttonCancelCard2.TabIndex = 5;
            this.buttonCancelCard2.Text = "Cancel";
            this.buttonCancelCard2.UseVisualStyleBackColor = true;
            this.buttonCancelCard2.Click += new System.EventHandler(this.buttonCancelCard2_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Location = new System.Drawing.Point(447, 286);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(81, 27);
            this.buttonRestart.TabIndex = 8;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(99, 289);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(255, 23);
            this.textBoxAnswer.TabIndex = 9;
            // 
            // Card1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 322);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonResultCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelCard2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Card1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card1";
            this.Load += new System.EventHandler(this.Card1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clueToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button buttonResultCard1;
        private Panel panel1;
        private Button buttonCancelCard2;
        private Label labelCard1;
        private Button buttonRestart;
        private TextBox textBoxAnswer;
    }
}