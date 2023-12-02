
namespace Tyuiu.ElsufevMP.Sprint6.Task2.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_EMP = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_EMP = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_EMP = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_EMP = new System.Windows.Forms.DataGridView();
            this.chartFunction_EMP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_EMP = new System.Windows.Forms.Label();
            this.groupBoxInPutData_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_EMP = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_EMP = new System.Windows.Forms.TextBox();
            this.labelStopStep_EMP = new System.Windows.Forms.Label();
            this.labelStartStep_EMP = new System.Windows.Forms.Label();
            this.buttonDone_EMP = new System.Windows.Forms.Button();
            this.buttonHelp_EMP = new System.Windows.Forms.Button();
            this.ColumnVarX_EMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVarY_EMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOutPutData_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_EMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EMP)).BeginInit();
            this.groupBoxInPutData_EMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_EMP
            // 
            this.groupBoxTask_EMP.Controls.Add(this.pictureBox1);
            this.groupBoxTask_EMP.Controls.Add(this.textBoxTask_EMP);
            this.groupBoxTask_EMP.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_EMP.Name = "groupBoxTask_EMP";
            this.groupBoxTask_EMP.Size = new System.Drawing.Size(524, 354);
            this.groupBoxTask_EMP.TabIndex = 0;
            this.groupBoxTask_EMP.TabStop = false;
            this.groupBoxTask_EMP.Text = "Условие:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_EMP
            // 
            this.textBoxTask_EMP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EMP.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_EMP.Multiline = true;
            this.textBoxTask_EMP.Name = "textBoxTask_EMP";
            this.textBoxTask_EMP.Size = new System.Drawing.Size(508, 328);
            this.textBoxTask_EMP.TabIndex = 0;
            this.textBoxTask_EMP.Text = resources.GetString("textBoxTask_EMP.Text");
            // 
            // groupBoxOutPutData_EMP
            // 
            this.groupBoxOutPutData_EMP.Controls.Add(this.dataGridViewFunction_EMP);
            this.groupBoxOutPutData_EMP.Controls.Add(this.chartFunction_EMP);
            this.groupBoxOutPutData_EMP.Controls.Add(this.labelResult_EMP);
            this.groupBoxOutPutData_EMP.Location = new System.Drawing.Point(543, 12);
            this.groupBoxOutPutData_EMP.Name = "groupBoxOutPutData_EMP";
            this.groupBoxOutPutData_EMP.Size = new System.Drawing.Size(592, 426);
            this.groupBoxOutPutData_EMP.TabIndex = 0;
            this.groupBoxOutPutData_EMP.TabStop = false;
            this.groupBoxOutPutData_EMP.Text = "Вывод данных";
            // 
            // dataGridViewFunction_EMP
            // 
            this.dataGridViewFunction_EMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_EMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVarX_EMP,
            this.ColumnVarY_EMP});
            this.dataGridViewFunction_EMP.Location = new System.Drawing.Point(10, 37);
            this.dataGridViewFunction_EMP.Name = "dataGridViewFunction_EMP";
            this.dataGridViewFunction_EMP.ReadOnly = true;
            this.dataGridViewFunction_EMP.RowHeadersVisible = false;
            this.dataGridViewFunction_EMP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunction_EMP.Size = new System.Drawing.Size(126, 381);
            this.dataGridViewFunction_EMP.TabIndex = 2;
            // 
            // chartFunction_EMP
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_EMP.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_EMP.Legends.Add(legend5);
            this.chartFunction_EMP.Location = new System.Drawing.Point(149, 37);
            this.chartFunction_EMP.Name = "chartFunction_EMP";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_EMP.Series.Add(series5);
            this.chartFunction_EMP.Size = new System.Drawing.Size(437, 381);
            this.chartFunction_EMP.TabIndex = 1;
            this.chartFunction_EMP.Text = "chartFunction_EMP";
            // 
            // labelResult_EMP
            // 
            this.labelResult_EMP.AutoSize = true;
            this.labelResult_EMP.Location = new System.Drawing.Point(7, 20);
            this.labelResult_EMP.Name = "labelResult_EMP";
            this.labelResult_EMP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_EMP.TabIndex = 0;
            this.labelResult_EMP.Text = "Результат:";
            // 
            // groupBoxInPutData_EMP
            // 
            this.groupBoxInPutData_EMP.Controls.Add(this.textBoxStopStep_EMP);
            this.groupBoxInPutData_EMP.Controls.Add(this.textBoxStartStep_EMP);
            this.groupBoxInPutData_EMP.Controls.Add(this.labelStopStep_EMP);
            this.groupBoxInPutData_EMP.Controls.Add(this.labelStartStep_EMP);
            this.groupBoxInPutData_EMP.Location = new System.Drawing.Point(13, 373);
            this.groupBoxInPutData_EMP.Name = "groupBoxInPutData_EMP";
            this.groupBoxInPutData_EMP.Size = new System.Drawing.Size(221, 65);
            this.groupBoxInPutData_EMP.TabIndex = 0;
            this.groupBoxInPutData_EMP.TabStop = false;
            this.groupBoxInPutData_EMP.Text = "Ввод данных";
            // 
            // textBoxStopStep_EMP
            // 
            this.textBoxStopStep_EMP.Location = new System.Drawing.Point(113, 37);
            this.textBoxStopStep_EMP.Name = "textBoxStopStep_EMP";
            this.textBoxStopStep_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_EMP.TabIndex = 1;
            // 
            // textBoxStartStep_EMP
            // 
            this.textBoxStartStep_EMP.Location = new System.Drawing.Point(7, 37);
            this.textBoxStartStep_EMP.Name = "textBoxStartStep_EMP";
            this.textBoxStartStep_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_EMP.TabIndex = 1;
            // 
            // labelStopStep_EMP
            // 
            this.labelStopStep_EMP.AutoSize = true;
            this.labelStopStep_EMP.Location = new System.Drawing.Point(110, 20);
            this.labelStopStep_EMP.Name = "labelStopStep_EMP";
            this.labelStopStep_EMP.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_EMP.TabIndex = 0;
            this.labelStopStep_EMP.Text = "Конец шага:";
            // 
            // labelStartStep_EMP
            // 
            this.labelStartStep_EMP.AutoSize = true;
            this.labelStartStep_EMP.Location = new System.Drawing.Point(7, 20);
            this.labelStartStep_EMP.Name = "labelStartStep_EMP";
            this.labelStartStep_EMP.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_EMP.TabIndex = 0;
            this.labelStartStep_EMP.Text = "Старт шага:";
            // 
            // buttonDone_EMP
            // 
            this.buttonDone_EMP.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_EMP.Location = new System.Drawing.Point(370, 373);
            this.buttonDone_EMP.Name = "buttonDone_EMP";
            this.buttonDone_EMP.Size = new System.Drawing.Size(167, 65);
            this.buttonDone_EMP.TabIndex = 1;
            this.buttonDone_EMP.Text = "Выполнить";
            this.buttonDone_EMP.UseVisualStyleBackColor = false;
            this.buttonDone_EMP.Click += new System.EventHandler(this.buttonDone_EMP_Click);
            this.buttonDone_EMP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_EMP_MouseDown);
            this.buttonDone_EMP.MouseEnter += new System.EventHandler(this.buttonDone_EMP_MouseEnter);
            this.buttonDone_EMP.MouseLeave += new System.EventHandler(this.buttonDone_EMP_MouseLeave);
            // 
            // buttonHelp_EMP
            // 
            this.buttonHelp_EMP.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_EMP.Location = new System.Drawing.Point(240, 373);
            this.buttonHelp_EMP.Name = "buttonHelp_EMP";
            this.buttonHelp_EMP.Size = new System.Drawing.Size(124, 65);
            this.buttonHelp_EMP.TabIndex = 1;
            this.buttonHelp_EMP.Text = "Справка";
            this.buttonHelp_EMP.UseVisualStyleBackColor = false;
            this.buttonHelp_EMP.Click += new System.EventHandler(this.buttonHelp_EMP_Click);
            // 
            // ColumnVarX_EMP
            // 
            this.ColumnVarX_EMP.HeaderText = "X";
            this.ColumnVarX_EMP.Name = "ColumnVarX_EMP";
            this.ColumnVarX_EMP.ReadOnly = true;
            this.ColumnVarX_EMP.Width = 50;
            // 
            // ColumnVarY_EMP
            // 
            this.ColumnVarY_EMP.HeaderText = "F(x)";
            this.ColumnVarY_EMP.Name = "ColumnVarY_EMP";
            this.ColumnVarY_EMP.ReadOnly = true;
            this.ColumnVarY_EMP.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.buttonHelp_EMP);
            this.Controls.Add(this.buttonDone_EMP);
            this.Controls.Add(this.groupBoxInPutData_EMP);
            this.Controls.Add(this.groupBoxOutPutData_EMP);
            this.Controls.Add(this.groupBoxTask_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 11 | Елсуфьев М. П.";
            this.groupBoxTask_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOutPutData_EMP.ResumeLayout(false);
            this.groupBoxOutPutData_EMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_EMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EMP)).EndInit();
            this.groupBoxInPutData_EMP.ResumeLayout(false);
            this.groupBoxInPutData_EMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_EMP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTask_EMP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EMP;
        private System.Windows.Forms.GroupBox groupBoxInPutData_EMP;
        private System.Windows.Forms.TextBox textBoxStopStep_EMP;
        private System.Windows.Forms.TextBox textBoxStartStep_EMP;
        private System.Windows.Forms.Label labelStopStep_EMP;
        private System.Windows.Forms.Label labelStartStep_EMP;
        private System.Windows.Forms.Button buttonDone_EMP;
        private System.Windows.Forms.Button buttonHelp_EMP;
        private System.Windows.Forms.Label labelResult_EMP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_EMP;
        private System.Windows.Forms.DataGridView dataGridViewFunction_EMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVarX_EMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVarY_EMP;
    }
}

