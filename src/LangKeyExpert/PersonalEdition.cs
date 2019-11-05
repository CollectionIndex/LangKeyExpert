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
            dgUserKey.Columns[0].HeaderText = "序号";
            dgUserKey.Columns[1].HeaderText = "标题";
            dgUserKey.Columns[2].HeaderText = "网址";
            dgUserKey.Columns[3].HeaderText = "用户名";
            dgUserKey.Columns[4].HeaderText = "密码";
            dgUserKey.Columns[5].HeaderText = "更新日期";
            dgUserKey.Columns[0].Width = 52;
            dgUserKey.Columns[1].Width = 85;
            dgUserKey.Columns[2].Width = 155;
            dgUserKey.Columns[3].Width = 75;
            dgUserKey.Columns[4].Width = 75;
            dgUserKey.Columns[5].Width = 120;

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 水晶绿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "DiamondGreen.ssk";
        }

        private void 水晶蓝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "DiamondBlue.ssk";
        }
    }
}