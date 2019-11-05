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
            this.Hide();
            if(diaFile.ShowDialog()==DialogResult.OK)
            {
                if(diaFile.OpenFile()!=null)
                {
                    twoXML.ReadXml(@diaFile.FileName);
                    foreach(DataRow twoRow in twoXML.Tables["UserKey"].Rows)
                    {
                        DataRow newRow = dsXML.Tables["UserKey"].NewRow();
                        newRow["Number"] = twoRow["Number"];
                        newRow["Title"] = twoRow["Title"];
                        newRow["NetAdd"] = twoRow["NetAdd"];
                        newRow["Name"] = twoRow["Name"];
                        newRow["Key"] = twoRow["Key"];
                        newRow["UpdateTime"] = twoRow["UpdateTime"];
                        dsXML.Tables["UserKey"].Rows.Add(newRow);
                    }
                    int n = dsXML.Tables["UserKey"].Rows.Count;
                    for (int i = 0; i < n; i++)
                    {
                        dsXML.Tables["UserKey"].Rows[i]["Number"] = i + 1;
                    }
                    dsXML.WriteXml(@"UserKey.xml");
                    this.Visible = true;
                    MessageBox.Show("�ļ�����ɹ���", "��������");                    
                }
            }
            else
            {
                this.Visible=true;
            }
        }

        private void ˮ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "DiamondGreen.ssk";
        }

        private void ˮ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "DiamondBlue.ssk";
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (diaSaveFile.ShowDialog() == DialogResult.OK)
            {
                dsXML.WriteXml(@diaSaveFile.FileName);
                this.Visible = true;
                MessageBox.Show("�ļ������ɹ���", "��������");
            }
            else
            {
                this.Visible = true;
            }
        }

        private void PersonalEdition_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //this.Close();
            //this.Dispose();
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyAdd keyAdd = new KeyAdd(dsXML);
            keyAdd.ShowDialog();
        }
    }
}