using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ElsufevMP.Sprint6.Task6.V3
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOk_EMP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
