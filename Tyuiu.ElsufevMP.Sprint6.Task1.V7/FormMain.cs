using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ElsufevMP.Sprint6.Task1.V7.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task1.V7
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_EMP.Text = "";
                textBoxResult_EMP.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_EMP.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
                textBoxResult_EMP.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}    |  {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_EMP.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_EMP.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_EMP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Елсуфьев Михаил Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
