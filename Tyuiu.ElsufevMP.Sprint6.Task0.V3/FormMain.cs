using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ElsufevMP.Sprint5.Task0.V3.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonDone_EMP_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_EMP.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_EMP.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_EMP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 0 выполнил студент группы ИИПб-23-2 Елсуфьев Михаил Павлович", "Сообщение");
        }
    }
}
