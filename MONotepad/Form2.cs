using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONotepad
{
    public partial class findForm : Form
    {
        private string WhatToFind;
        private bool SearchDown;
        private bool MatchCase;
        public findForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhatToFind = textBox1.Text;
            SearchDown = rdoDown.Checked;
            MatchCase = checkBox1.Checked;

            fmMain parentForm = (fmMain)Owner;
            parentForm.Find(WhatToFind, MatchCase, SearchDown);
            Close();    
        }
    }
}
