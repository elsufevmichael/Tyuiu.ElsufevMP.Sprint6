
namespace Tyuiu.ElsufevMP.Sprint6.Task4.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EMP = new System.Windows.Forms.TextBox();
            this.groupBoxImPutData_EMP = new System.Windows.Forms.GroupBox();
            this.labelStopStep_EMP = new System.Windows.Forms.Label();
            this.labelStartStep_EMP = new System.Windows.Forms.Label();
            this.textBoxStopStep_EMP = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_EMP = new System.Windows.Forms.TextBox();
            this.buttonDone_EMP = new System.Windows.Forms.Button();
            this.buttonSave_EMP = new System.Windows.Forms.Button();
            this.buttonHelp_EMP = new System.Windows.Forms.Button();
            this.groupBoxResult_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxResult_EMP = new System.Windows.Forms.TextBox();
            this.chartFunction_EMP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_EMP = new System.Windows.Forms.Panel();
            this.panelLeft_EMP = new System.Windows.Forms.Panel();
            this.panelRight_EMP = new System.Windows.Forms.Panel();
            this.splitterbtwLeftRight_EMP = new System.Windows.Forms.Splitter();
            this.groupBoxTask_EMP.SuspendLayout();
            this.groupBoxImPutData_EMP.SuspendLayout();
            this.groupBoxResult_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EMP)).BeginInit();
            this.panelTop_EMP.SuspendLayout();
            this.panelLeft_EMP.SuspendLayout();
            this.panelRight_EMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_EMP
            // 
            this.groupBoxTask_EMP.Controls.Add(this.textBoxTask_EMP);
            this.groupBoxTask_EMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTask_EMP.Location = new System.Drawing.Point(7, 11);
            this.groupBoxTask_EMP.Name = "groupBoxTask_EMP";
            this.groupBoxTask_EMP.Size = new System.Drawing.Size(441, 66);
            this.groupBoxTask_EMP.TabIndex = 0;
            this.groupBoxTask_EMP.TabStop = false;
            this.groupBoxTask_EMP.Text = "Условие:";
            // 
            // textBoxTask_EMP
            // 
            this.textBoxTask_EMP.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxTask_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EMP.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_EMP.Multiline = true;
            this.textBoxTask_EMP.Name = "textBoxTask_EMP";
            this.textBoxTask_EMP.ReadOnly = true;
            this.textBoxTask_EMP.Size = new System.Drawing.Size(428, 40);
            this.textBoxTask_EMP.TabIndex = 0;
            this.textBoxTask_EMP.Text = "Протабулировать функцию f(x) на заданном диапазоне [-5; 5] с шагом 1.\r\nРезультат " +
    "вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V2" +
    "9.txt по нажатию кнопки\r\n";
            // 
            // groupBoxImPutData_EMP
            // 
            this.groupBoxImPutData_EMP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxImPutData_EMP.Controls.Add(this.labelStopStep_EMP);
            this.groupBoxImPutData_EMP.Controls.Add(this.labelStartStep_EMP);
            this.groupBoxImPutData_EMP.Controls.Add(this.textBoxStopStep_EMP);
            this.groupBoxImPutData_EMP.Controls.Add(this.textBoxStartStep_EMP);
            this.groupBoxImPutData_EMP.Location = new System.Drawing.Point(454, 11);
            this.groupBoxImPutData_EMP.Name = "groupBoxImPutData_EMP";
            this.groupBoxImPutData_EMP.Size = new System.Drawing.Size(218, 66);
            this.groupBoxImPutData_EMP.TabIndex = 0;
            this.groupBoxImPutData_EMP.TabStop = false;
            this.groupBoxImPutData_EMP.Text = "Ввод данных:";
            // 
            // labelStopStep_EMP
            // 
            this.labelStopStep_EMP.AutoSize = true;
            this.labelStopStep_EMP.Location = new System.Drawing.Point(109, 20);
            this.labelStopStep_EMP.Name = "labelStopStep_EMP";
            this.labelStopStep_EMP.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_EMP.TabIndex = 1;
            this.labelStopStep_EMP.Text = "Конец шага:";
            // 
            // labelStartStep_EMP
            // 
            this.labelStartStep_EMP.AutoSize = true;
            this.labelStartStep_EMP.Location = new System.Drawing.Point(7, 20);
            this.labelStartStep_EMP.Name = "labelStartStep_EMP";
            this.labelStartStep_EMP.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_EMP.TabIndex = 1;
            this.labelStartStep_EMP.Text = "Старт шага:";
            // 
            // textBoxStopStep_EMP
            // 
            this.textBoxStopStep_EMP.Location = new System.Drawing.Point(112, 36);
            this.textBoxStopStep_EMP.Name = "textBoxStopStep_EMP";
            this.textBoxStopStep_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_EMP.TabIndex = 0;
            // 
            // textBoxStartStep_EMP
            // 
            this.textBoxStartStep_EMP.Location = new System.Drawing.Point(6, 36);
            this.textBoxStartStep_EMP.Name = "textBoxStartStep_EMP";
            this.textBoxStartStep_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_EMP.TabIndex = 0;
            // 
            // buttonDone_EMP
            // 
            this.buttonDone_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_EMP.BackColor = System.Drawing.Color.Gold;
            this.buttonDone_EMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_EMP.Location = new System.Drawing.Point(683, 11);
            this.buttonDone_EMP.Name = "buttonDone_EMP";
            this.buttonDone_EMP.Size = new System.Drawing.Size(83, 66);
            this.buttonDone_EMP.TabIndex = 1;
            this.buttonDone_EMP.Text = "Выполнить";
            this.buttonDone_EMP.UseVisualStyleBackColor = false;
            this.buttonDone_EMP.Click += new System.EventHandler(this.buttonDone_EMP_Click);
            // 
            // buttonSave_EMP
            // 
            this.buttonSave_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_EMP.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonSave_EMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_EMP.Location = new System.Drawing.Point(772, 11);
            this.buttonSave_EMP.Name = "buttonSave_EMP";
            this.buttonSave_EMP.Size = new System.Drawing.Size(83, 66);
            this.buttonSave_EMP.TabIndex = 1;
            this.buttonSave_EMP.Text = "Сохранить";
            this.buttonSave_EMP.UseVisualStyleBackColor = false;
            this.buttonSave_EMP.Click += new System.EventHandler(this.buttonSave_EMP_Click);
            // 
            // buttonHelp_EMP
            // 
            this.buttonHelp_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EMP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_EMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_EMP.Location = new System.Drawing.Point(861, 11);
            this.buttonHelp_EMP.Name = "buttonHelp_EMP";
            this.buttonHelp_EMP.Size = new System.Drawing.Size(83, 66);
            this.buttonHelp_EMP.TabIndex = 1;
            this.buttonHelp_EMP.Text = "Справка";
            this.buttonHelp_EMP.UseVisualStyleBackColor = false;
            this.buttonHelp_EMP.Click += new System.EventHandler(this.buttonHelp_EMP_Click);
            // 
            // groupBoxResult_EMP
            // 
            this.groupBoxResult_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxResult_EMP.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxResult_EMP.Controls.Add(this.textBoxResult_EMP);
            this.groupBoxResult_EMP.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_EMP.Name = "groupBoxResult_EMP";
            this.groupBoxResult_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxResult_EMP.Size = new System.Drawing.Size(221, 591);
            this.groupBoxResult_EMP.TabIndex = 2;
            this.groupBoxResult_EMP.TabStop = false;
            this.groupBoxResult_EMP.Text = "Вывод:";
            // 
            // textBoxResult_EMP
            // 
            this.textBoxResult_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_EMP.Location = new System.Drawing.Point(5, 18);
            this.textBoxResult_EMP.Multiline = true;
            this.textBoxResult_EMP.Name = "textBoxResult_EMP";
            this.textBoxResult_EMP.ReadOnly = true;
            this.textBoxResult_EMP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_EMP.Size = new System.Drawing.Size(211, 568);
            this.textBoxResult_EMP.TabIndex = 0;
            // 
            // chartFunction_EMP
            // 
            this.chartFunction_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunction_EMP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_EMP.Legends.Add(legend2);
            this.chartFunction_EMP.Location = new System.Drawing.Point(5, 5);
            this.chartFunction_EMP.Name = "chartFunction_EMP";
            this.chartFunction_EMP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_EMP.Series.Add(series2);
            this.chartFunction_EMP.Size = new System.Drawing.Size(715, 591);
            this.chartFunction_EMP.TabIndex = 4;
            this.chartFunction_EMP.Text = "chartFunction_EMP";
            title2.Name = "TitleFunction_EMP";
            title2.Text = "График функции f(x)";
            this.chartFunction_EMP.Titles.Add(title2);
            // 
            // panelTop_EMP
            // 
            this.panelTop_EMP.Controls.Add(this.groupBoxTask_EMP);
            this.panelTop_EMP.Controls.Add(this.groupBoxImPutData_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonDone_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonSave_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonHelp_EMP);
            this.panelTop_EMP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_EMP.Location = new System.Drawing.Point(0, 0);
            this.panelTop_EMP.Name = "panelTop_EMP";
            this.panelTop_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop_EMP.Size = new System.Drawing.Size(956, 80);
            this.panelTop_EMP.TabIndex = 1;
            // 
            // panelLeft_EMP
            // 
            this.panelLeft_EMP.BackColor = System.Drawing.Color.LightCyan;
            this.panelLeft_EMP.Controls.Add(this.groupBoxResult_EMP);
            this.panelLeft_EMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EMP.Location = new System.Drawing.Point(0, 80);
            this.panelLeft_EMP.Name = "panelLeft_EMP";
            this.panelLeft_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_EMP.Size = new System.Drawing.Size(231, 601);
            this.panelLeft_EMP.TabIndex = 5;
            // 
            // panelRight_EMP
            // 
            this.panelRight_EMP.BackColor = System.Drawing.Color.LightCyan;
            this.panelRight_EMP.Controls.Add(this.chartFunction_EMP);
            this.panelRight_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EMP.Location = new System.Drawing.Point(231, 80);
            this.panelRight_EMP.Name = "panelRight_EMP";
            this.panelRight_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_EMP.Size = new System.Drawing.Size(725, 601);
            this.panelRight_EMP.TabIndex = 6;
            // 
            // splitterbtwLeftRight_EMP
            // 
            this.splitterbtwLeftRight_EMP.Location = new System.Drawing.Point(231, 80);
            this.splitterbtwLeftRight_EMP.Name = "splitterbtwLeftRight_EMP";
            this.splitterbtwLeftRight_EMP.Size = new System.Drawing.Size(3, 601);
            this.splitterbtwLeftRight_EMP.TabIndex = 7;
            this.splitterbtwLeftRight_EMP.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(956, 681);
            this.Controls.Add(this.splitterbtwLeftRight_EMP);
            this.Controls.Add(this.panelRight_EMP);
            this.Controls.Add(this.panelLeft_EMP);
            this.Controls.Add(this.panelTop_EMP);
            this.MinimumSize = new System.Drawing.Size(972, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 29 | Елсуфьев М. П.";
            this.groupBoxTask_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.PerformLayout();
            this.groupBoxImPutData_EMP.ResumeLayout(false);
            this.groupBoxImPutData_EMP.PerformLayout();
            this.groupBoxResult_EMP.ResumeLayout(false);
            this.groupBoxResult_EMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EMP)).EndInit();
            this.panelTop_EMP.ResumeLayout(false);
            this.panelLeft_EMP.ResumeLayout(false);
            this.panelRight_EMP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_EMP;
        private System.Windows.Forms.Panel panelLeft_EMP;
        private System.Windows.Forms.Panel panelRight_EMP;
        private System.Windows.Forms.Splitter splitterbtwLeftRight_EMP;
        private System.Windows.Forms.GroupBox groupBoxTask_EMP;
        private System.Windows.Forms.TextBox textBoxTask_EMP;
        private System.Windows.Forms.GroupBox groupBoxImPutData_EMP;
        private System.Windows.Forms.Label labelStopStep_EMP;
        private System.Windows.Forms.Label labelStartStep_EMP;
        private System.Windows.Forms.TextBox textBoxStopStep_EMP;
        private System.Windows.Forms.TextBox textBoxStartStep_EMP;
        private System.Windows.Forms.Button buttonDone_EMP;
        private System.Windows.Forms.Button buttonSave_EMP;
        private System.Windows.Forms.Button buttonHelp_EMP;
        private System.Windows.Forms.GroupBox groupBoxResult_EMP;
        private System.Windows.Forms.TextBox textBoxResult_EMP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_EMP;
    }
}

