namespace MONotepad
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
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
    }
}
