using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LangKeyExpert
{
    public partial class PersonalEdition : Form
    {
        public PersonalEdition()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "DiamondGreen.ssk";
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void �༭ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ˮ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "DiamondGreen.ssk";
        }

        private void ˮ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "DiamondBlue.ssk";
        }
    }
}