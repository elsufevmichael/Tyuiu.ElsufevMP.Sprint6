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
using Tyuiu.ElsufevMP.Sprint6.Task4.V29.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_EMP_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_EMP.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_EMP.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_EMP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_EMP.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_EMP.Text = "";

                chartFunction_EMP.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_EMP.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_EMP.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_EMP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-2 Елсуфьев Михаил Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_EMP_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V29.txt";
                File.WriteAllText(path, textBoxResult_EMP.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
