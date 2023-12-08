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
using Tyuiu.ElsufevMP.Sprint6.Task7.V30.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_EMP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMartix_EMP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(openFilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_EMP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_EMP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_EMP.ShowDialog();
            openFilePath = openFileDialogTask_EMP.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_EMP.ColumnCount = columns;
            dataGridViewIn_EMP.RowCount = rows;
            dataGridViewOut_EMP.ColumnCount = columns;
            dataGridViewOut_EMP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_EMP.Columns[i].Width = 25;
                dataGridViewOut_EMP.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_EMP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_EMP.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_EMP.ColumnCount = 50;
            dataGridViewOut_EMP.ColumnCount = 50;

            dataGridViewOut_EMP.RowCount = 50;
            dataGridViewIn_EMP.RowCount = 50;

            panelLeft_EMP.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_EMP.Columns[i].Width = 25;
                dataGridViewOut_EMP.Columns[i].Width = 25;
            }
        }

        private void buttonDone_EMP_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_EMP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_EMP.Enabled = true;
        }

        private void buttonSave_EMP_Click(object sender, EventArgs e)
        {
            saveFileDialogMartix_EMP.FileName = "OutPutFileTask7.csv";
            saveFileDialogMartix_EMP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMartix_EMP.ShowDialog();

            string path = saveFileDialogMartix_EMP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_EMP.RowCount;
            int columns = dataGridViewOut_EMP.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_EMP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_EMP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_EMP_MouseEnter(object sender, EventArgs e)
        {
            toolTip_EMP.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_EMP_MouseEnter(object sender, EventArgs e)
        {
            toolTip_EMP.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_EMP_MouseEnter(object sender, EventArgs e)
        {
            toolTip_EMP.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_EMP_MouseEnter(object sender, EventArgs e)
        {
            toolTip_EMP.ToolTipTitle = "Справка";
        }
    }
}
