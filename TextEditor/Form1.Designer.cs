
namespace TextEditor
{
    partial class frmEditor
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFormat});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewFile,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuNewFile
            // 
            this.mnuNewFile.Name = "mnuNewFile";
            this.mnuNewFile.Size = new System.Drawing.Size(180, 22);
            this.mnuNewFile.Text = "&New";
            this.mnuNewFile.Click += new System.EventHandler(this.mnuNewFile_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBold,
            this.mnuItalic,
            this.mnuUnderline,
            this.mnuSize});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(57, 20);
            this.mnuFormat.Text = "F&ormat";
            // 
            // mnuBold
            // 
            this.mnuBold.Name = "mnuBold";
            this.mnuBold.Size = new System.Drawing.Size(180, 22);
            this.mnuBold.Text = "&Bold";
            // 
            // mnuItalic
            // 
            this.mnuItalic.Name = "mnuItalic";
            this.mnuItalic.Size = new System.Drawing.Size(180, 22);
            this.mnuItalic.Text = "&Italic";
            // 
            // mnuUnderline
            // 
            this.mnuUnderline.Name = "mnuUnderline";
            this.mnuUnderline.Size = new System.Drawing.Size(180, 22);
            this.mnuUnderline.Text = "&UnderLine";
            // 
            // mnuSize
            // 
            this.mnuSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSmall,
            this.mnuMedium,
            this.mnuLarge});
            this.mnuSize.Name = "mnuSize";
            this.mnuSize.Size = new System.Drawing.Size(180, 22);
            this.mnuSize.Text = "&Size";
            // 
            // mnuSmall
            // 
            this.mnuSmall.Checked = true;
            this.mnuSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSmall.Name = "mnuSmall";
            this.mnuSmall.Size = new System.Drawing.Size(180, 22);
            this.mnuSmall.Text = "Sma&ll";
            // 
            // mnuMedium
            // 
            this.mnuMedium.Name = "mnuMedium";
            this.mnuMedium.Size = new System.Drawing.Size(180, 22);
            this.mnuMedium.Text = "&Medium";
            // 
            // mnuLarge
            // 
            this.mnuLarge.Name = "mnuLarge";
            this.mnuLarge.Size = new System.Drawing.Size(180, 22);
            this.mnuLarge.Text = "La&rge";
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(0, 167);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(800, 289);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.TextChanged += new System.EventHandler(this.texteditior_TextChanged);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuBold;
        private System.Windows.Forms.ToolStripMenuItem mnuItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuUnderline;
        private System.Windows.Forms.ToolStripMenuItem mnuSize;
        private System.Windows.Forms.ToolStripMenuItem mnuSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuMedium;
        private System.Windows.Forms.ToolStripMenuItem mnuLarge;
        private System.Windows.Forms.TextBox txtEditor;
    }
}

