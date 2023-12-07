using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ElsufevMP.Sprint6.Task5.V16.Lib;
using System.IO;

namespace Tyuiu.ElsufevMP.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V16.txt";

        private void buttonDone_EMP_Click(object sender, EventArgs e)
        {
            dataGridViewResult_EMP.ColumnCount = 2;
            dataGridViewResult_EMP.Columns[0].Width = 20;
            dataGridViewResult_EMP.Columns[1].Width = 50;
            this.chartDiag_EMP.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiag_EMP.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_EMP.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_EMP.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_EMP.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_EMP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Елсуфьев Михаил Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_EMP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
