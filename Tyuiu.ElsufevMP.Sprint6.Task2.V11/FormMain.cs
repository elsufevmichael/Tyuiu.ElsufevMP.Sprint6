using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ElsufevMP.Sprint6.Task2.V11.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

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

                this.chartFunction_EMP.Titles.Add("График функции f(x)");
                this.chartFunction_EMP.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_EMP.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_EMP.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_EMP.Series[0].Points.AddXY(startStep, valueArray[i]);

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
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Елсуфьев Михаил Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_EMP_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_EMP.BackColor = Color.LawnGreen;
        }

        private void buttonDone_EMP_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_EMP.BackColor = Color.Green;
        }

        private void buttonDone_EMP_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_EMP.BackColor = Color.SpringGreen;
        }
    }
}
