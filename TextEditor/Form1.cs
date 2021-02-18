using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }
        int fontSize = 8;
        string fontName = "Ms Sans Serif";

        public void ChangeFont()
        {
            FontStyle fntstyle;
            fntstyle = FontStyle.Regular;

            if( mnuItalic.Checked)
            {
                fntstyle = fntstyle | FontStyle.Italic;
            }

            if (mnuUnderline.Checked)
            {
                fntstyle = fntstyle | FontStyle.Underline;
            }

            if (mnuBold.Checked)
            {
                fntstyle = fntstyle | FontStyle.Bold;
            }
            txtEditor.Font = new Font(fontName, fontSize, fntstyle);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit the current thread?", "ExitApplication", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes){

                Close();
            }
            else
            {
                return;
            }
        }

        private void texteditior_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the current thread?", "NewFile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtEditor.Text = "";
            }
         
        }

        private void mnuBold_Click(object sender, EventArgs e)
        {
            mnuBold.Checked = !mnuBold.Checked;
            ChangeFont();
        }

        private void mnuItalic_Click(object sender, EventArgs e)
        {
            mnuItalic.Checked = !mnuItalic.Checked;
            ChangeFont();

        }

        private void mnuUnderline_Click(object sender, EventArgs e)
        {
            mnuUnderline.Checked = !mnuUnderline.Checked;
            ChangeFont();
        }

        private void mnuSizeClick(object sender, EventArgs e)
        {
            string mnusizeclicked = ((ToolStripMenuItem)sender).Text;
            mnuSmall.Checked = false;
            mnuMedium.Checked = false;
            mnuLarge.Checked = false;

            switch (mnusizeclicked)
            {
                case "Sma&ll":
                    fontSize = 8;
                    mnuSmall.Checked = true;
                    break;

                case "&Medium":
                    fontSize = 12;
                    mnuMedium.Checked = true;
                    break;

                case "La&rge":
                    fontSize = 16;
                    mnuLarge.Checked = true;
                    break;
            }
            ChangeFont();
        }
    }
}
