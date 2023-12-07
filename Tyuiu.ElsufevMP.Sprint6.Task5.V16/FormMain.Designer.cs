
namespace Tyuiu.ElsufevMP.Sprint6.Task5.V16
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_EMP = new System.Windows.Forms.Panel();
            this.buttonDone_EMP = new System.Windows.Forms.Button();
            this.buttonOpenFile_EMP = new System.Windows.Forms.Button();
            this.buttonHelp_EMP = new System.Windows.Forms.Button();
            this.groupBoxTask_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EMP = new System.Windows.Forms.TextBox();
            this.panelLeft_EMP = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_EMP = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_EMP = new System.Windows.Forms.DataGridView();
            this.panelRight_EMP = new System.Windows.Forms.Panel();
            this.chartDiag_EMP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterbtwLeftRight_EMP = new System.Windows.Forms.Splitter();
            this.panelTop_EMP.SuspendLayout();
            this.groupBoxTask_EMP.SuspendLayout();
            this.panelLeft_EMP.SuspendLayout();
            this.groupBoxOutPutData_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_EMP)).BeginInit();
            this.panelRight_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_EMP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_EMP
            // 
            this.panelTop_EMP.Controls.Add(this.buttonDone_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonOpenFile_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonHelp_EMP);
            this.panelTop_EMP.Controls.Add(this.groupBoxTask_EMP);
            this.panelTop_EMP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_EMP.Location = new System.Drawing.Point(0, 0);
            this.panelTop_EMP.Name = "panelTop_EMP";
            this.panelTop_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop_EMP.Size = new System.Drawing.Size(800, 100);
            this.panelTop_EMP.TabIndex = 0;
            // 
            // buttonDone_EMP
            // 
            this.buttonDone_EMP.BackColor = System.Drawing.Color.Gold;
            this.buttonDone_EMP.Location = new System.Drawing.Point(512, 8);
            this.buttonDone_EMP.Name = "buttonDone_EMP";
            this.buttonDone_EMP.Size = new System.Drawing.Size(88, 84);
            this.buttonDone_EMP.TabIndex = 1;
            this.buttonDone_EMP.Text = "Выполнить";
            this.buttonDone_EMP.UseVisualStyleBackColor = false;
            this.buttonDone_EMP.Click += new System.EventHandler(this.buttonDone_EMP_Click);
            // 
            // buttonOpenFile_EMP
            // 
            this.buttonOpenFile_EMP.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonOpenFile_EMP.Location = new System.Drawing.Point(606, 8);
            this.buttonOpenFile_EMP.Name = "buttonOpenFile_EMP";
            this.buttonOpenFile_EMP.Size = new System.Drawing.Size(88, 84);
            this.buttonOpenFile_EMP.TabIndex = 1;
            this.buttonOpenFile_EMP.Text = "Открыть файл";
            this.buttonOpenFile_EMP.UseVisualStyleBackColor = false;
            this.buttonOpenFile_EMP.Click += new System.EventHandler(this.buttonOpenFile_EMP_Click);
            // 
            // buttonHelp_EMP
            // 
            this.buttonHelp_EMP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_EMP.Location = new System.Drawing.Point(700, 8);
            this.buttonHelp_EMP.Name = "buttonHelp_EMP";
            this.buttonHelp_EMP.Size = new System.Drawing.Size(88, 84);
            this.buttonHelp_EMP.TabIndex = 1;
            this.buttonHelp_EMP.Text = "Справка";
            this.buttonHelp_EMP.UseVisualStyleBackColor = false;
            this.buttonHelp_EMP.Click += new System.EventHandler(this.buttonHelp_EMP_Click);
            // 
            // groupBoxTask_EMP
            // 
            this.groupBoxTask_EMP.Controls.Add(this.textBoxTask_EMP);
            this.groupBoxTask_EMP.Location = new System.Drawing.Point(5, 8);
            this.groupBoxTask_EMP.Name = "groupBoxTask_EMP";
            this.groupBoxTask_EMP.Size = new System.Drawing.Size(501, 84);
            this.groupBoxTask_EMP.TabIndex = 0;
            this.groupBoxTask_EMP.TabStop = false;
            this.groupBoxTask_EMP.Text = "Условие:";
            // 
            // textBoxTask_EMP
            // 
            this.textBoxTask_EMP.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxTask_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_EMP.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_EMP.Multiline = true;
            this.textBoxTask_EMP.Name = "textBoxTask_EMP";
            this.textBoxTask_EMP.ReadOnly = true;
            this.textBoxTask_EMP.Size = new System.Drawing.Size(495, 65);
            this.textBoxTask_EMP.TabIndex = 0;
            this.textBoxTask_EMP.Text = "Прочитать данные из файла InPutFileTask5V16.txt. Вывести в dataGridViewResult_EMP" +
    " положительные значения и построить диаграмму по этим значениям.";
            // 
            // panelLeft_EMP
            // 
            this.panelLeft_EMP.Controls.Add(this.groupBoxOutPutData_EMP);
            this.panelLeft_EMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EMP.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_EMP.Name = "panelLeft_EMP";
            this.panelLeft_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_EMP.Size = new System.Drawing.Size(200, 350);
            this.panelLeft_EMP.TabIndex = 1;
            // 
            // groupBoxOutPutData_EMP
            // 
            this.groupBoxOutPutData_EMP.Controls.Add(this.dataGridViewResult_EMP);
            this.groupBoxOutPutData_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_EMP.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPutData_EMP.Name = "groupBoxOutPutData_EMP";
            this.groupBoxOutPutData_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxOutPutData_EMP.Size = new System.Drawing.Size(190, 340);
            this.groupBoxOutPutData_EMP.TabIndex = 0;
            this.groupBoxOutPutData_EMP.TabStop = false;
            this.groupBoxOutPutData_EMP.Text = "Вывод данных:";
            // 
            // dataGridViewResult_EMP
            // 
            this.dataGridViewResult_EMP.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewResult_EMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_EMP.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewResult_EMP.Name = "dataGridViewResult_EMP";
            this.dataGridViewResult_EMP.Size = new System.Drawing.Size(180, 317);
            this.dataGridViewResult_EMP.TabIndex = 0;
            // 
            // panelRight_EMP
            // 
            this.panelRight_EMP.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelRight_EMP.Controls.Add(this.chartDiag_EMP);
            this.panelRight_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EMP.Location = new System.Drawing.Point(200, 100);
            this.panelRight_EMP.Name = "panelRight_EMP";
            this.panelRight_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_EMP.Size = new System.Drawing.Size(600, 350);
            this.panelRight_EMP.TabIndex = 2;
            // 
            // chartDiag_EMP
            // 
            this.chartDiag_EMP.BackColor = System.Drawing.Color.AntiqueWhite;
            chartArea1.Name = "ChartArea1";
            this.chartDiag_EMP.ChartAreas.Add(chartArea1);
            this.chartDiag_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_EMP.Legends.Add(legend1);
            this.chartDiag_EMP.Location = new System.Drawing.Point(5, 5);
            this.chartDiag_EMP.Name = "chartDiag_EMP";
            this.chartDiag_EMP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_EMP.Series.Add(series1);
            this.chartDiag_EMP.Size = new System.Drawing.Size(590, 340);
            this.chartDiag_EMP.TabIndex = 0;
            this.chartDiag_EMP.Text = "chart1";
            // 
            // splitterbtwLeftRight_EMP
            // 
            this.splitterbtwLeftRight_EMP.Location = new System.Drawing.Point(200, 100);
            this.splitterbtwLeftRight_EMP.Name = "splitterbtwLeftRight_EMP";
            this.splitterbtwLeftRight_EMP.Size = new System.Drawing.Size(3, 350);
            this.splitterbtwLeftRight_EMP.TabIndex = 3;
            this.splitterbtwLeftRight_EMP.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitterbtwLeftRight_EMP);
            this.Controls.Add(this.panelRight_EMP);
            this.Controls.Add(this.panelLeft_EMP);
            this.Controls.Add(this.panelTop_EMP);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Елсуфьев М. П.";
            this.panelTop_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.PerformLayout();
            this.panelLeft_EMP.ResumeLayout(false);
            this.groupBoxOutPutData_EMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_EMP)).EndInit();
            this.panelRight_EMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_EMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_EMP;
        private System.Windows.Forms.GroupBox groupBoxTask_EMP;
        private System.Windows.Forms.Panel panelLeft_EMP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EMP;
        private System.Windows.Forms.Panel panelRight_EMP;
        private System.Windows.Forms.Splitter splitterbtwLeftRight_EMP;
        private System.Windows.Forms.Button buttonDone_EMP;
        private System.Windows.Forms.Button buttonOpenFile_EMP;
        private System.Windows.Forms.Button buttonHelp_EMP;
        private System.Windows.Forms.TextBox textBoxTask_EMP;
        private System.Windows.Forms.DataGridView dataGridViewResult_EMP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_EMP;
    }
}

