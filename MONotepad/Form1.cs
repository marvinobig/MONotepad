namespace MONotepad
{
    public partial class fmMain : Form
    {
        private string TextFileName;
        public fmMain()
        {
            InitializeComponent();
        }

        private void SaveFile(string FileName)
        {
            TextFileName = FileName;
            TextBox.SaveFile(FileName);
        }

        private void SaveFileAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        private bool CheckChange()
        {
            return true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChange())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextBox.LoadFile(openFileDialog1.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextFileName))
            {
                SaveFileAs();
            }
            else
            {
                SaveFile(TextFileName);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm find = new findForm();
            find.Show(this);
        }

        public void Find(string text, bool downChecked, bool matchChecked) 
        {
            if (downChecked)
            {
                if (matchChecked)
                {
                    TextBox.Find(text, TextBox.SelectionStart + 1, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    TextBox.Find(text, TextBox.SelectionStart + 1, RichTextBoxFinds.None);
                }
            }
        }
    }
}
