using System;
using System.Windows.Forms;
using ScintillaFindReplaceControl;

namespace ScintillaFindReplace
{
    public partial class Demo : Form
    {

        private readonly FindReplace _findReplace;

        public Demo()
        {
            InitializeComponent();
            _findReplace = new FindReplace();
            _findReplace.SetTarget(scintilla1);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            _findReplace.SetFind(radioButtonScintilla1.Checked ? scintilla1 : scintilla2);
            _findReplace.Show();
        }

        private void radioButtonScintilla1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScintilla1.Checked)
                _findReplace.SetTarget(scintilla1);
        }

        private void radioButtonScintilla2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScintilla2.Checked)
                _findReplace.SetTarget(scintilla2);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            _findReplace.SetReplace(radioButtonScintilla1.Checked ? scintilla1 : scintilla2);
            _findReplace.Show();
        }
    }
}
