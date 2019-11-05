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
            dsXML.ReadXml("UserKey.xml");
            dgUserKey.DataSource = dsXML.Tables["UserKey"];
            dgUserKey.Columns[0].HeaderText = "���";
            dgUserKey.Columns[1].HeaderText = "����";
            dgUserKey.Columns[2].HeaderText = "��ַ";
            dgUserKey.Columns[3].HeaderText = "�û���";
            dgUserKey.Columns[4].HeaderText = "����";
            dgUserKey.Columns[5].HeaderText = "��������";
            dgUserKey.Columns[0].Width = 52;
            dgUserKey.Columns[1].Width = 85;
            dgUserKey.Columns[2].Width = 155;
            dgUserKey.Columns[3].Width = 75;
            dgUserKey.Columns[4].Width = 75;
            dgUserKey.Columns[5].Width = 120;

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