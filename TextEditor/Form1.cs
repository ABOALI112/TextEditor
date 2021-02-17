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
            Application.Exit();
        }

        private void texteditior_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
