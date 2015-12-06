using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaFindReplaceControl;

namespace ScintillaFindReplace
{
    public partial class Demo : Form
    {

        private FindReplace findReplace;

        public Demo()
        {
            InitializeComponent();
            findReplace = new FindReplace();
            findReplace.SetTarget(scintilla1);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (radioButtonScintilla1.Checked)
            {
                findReplace.SetFind(scintilla1);
            }
            else
            {
                findReplace.SetFind(scintilla2);
            }
            findReplace.Show();
        }

        private void radioButtonScintilla1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScintilla1.Checked)
                findReplace.SetTarget(scintilla1);
        }

        private void radioButtonScintilla2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScintilla2.Checked)
                findReplace.SetTarget(scintilla2);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (radioButtonScintilla1.Checked)
            {
                findReplace.SetReplace(scintilla1);
            }
            else
            {
                findReplace.SetReplace(scintilla2);
            }
            findReplace.Show();
        }
    }
}
