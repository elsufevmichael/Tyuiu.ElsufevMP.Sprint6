using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.ElsufevMP.Sprint6.Task6.V3.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task6.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_EMP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_EMP.ShowDialog();
            openFilePath = openFileDialogTask_EMP.FileName;
            textBoxInPutData_EMP.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_EMP.Text = groupBoxInPutData_EMP.Text + " " + openFileDialogTask_EMP.FileName;

            buttonDone_EMP.Enabled = true;
            buttonDone_EMP.BackColor = Color.LimeGreen;
        }

        private void buttonHelp_EMP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_EMP_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_EMP.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonDone_EMP.Enabled = false;
        }
    }
}
