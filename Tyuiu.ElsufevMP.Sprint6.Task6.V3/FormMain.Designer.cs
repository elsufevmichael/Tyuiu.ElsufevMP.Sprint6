
namespace Tyuiu.ElsufevMP.Sprint6.Task6.V3
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
            this.components = new System.ComponentModel.Container();
            this.panelTop_EMP = new System.Windows.Forms.Panel();
            this.panelLeft_EMP = new System.Windows.Forms.Panel();
            this.panelRight_EMP = new System.Windows.Forms.Panel();
            this.splitterbtwLeftRight_EMP = new System.Windows.Forms.Splitter();
            this.buttonOpenFile_EMP = new System.Windows.Forms.Button();
            this.buttonDone_EMP = new System.Windows.Forms.Button();
            this.buttonHelp_EMP = new System.Windows.Forms.Button();
            this.openFileDialogTask_EMP = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_EMP = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxTask_EMP = new System.Windows.Forms.TextBox();
            this.groupBoxTask_EMP = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_EMP = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_EMP = new System.Windows.Forms.TextBox();
            this.textBoxOutPutData_EMP = new System.Windows.Forms.TextBox();
            this.panelTop_EMP.SuspendLayout();
            this.panelLeft_EMP.SuspendLayout();
            this.panelRight_EMP.SuspendLayout();
            this.groupBoxTask_EMP.SuspendLayout();
            this.groupBoxInPutData_EMP.SuspendLayout();
            this.groupBoxOutPutData_EMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_EMP
            // 
            this.panelTop_EMP.BackColor = System.Drawing.Color.Bisque;
            this.panelTop_EMP.Controls.Add(this.groupBoxTask_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonHelp_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonDone_EMP);
            this.panelTop_EMP.Controls.Add(this.buttonOpenFile_EMP);
            this.panelTop_EMP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_EMP.Location = new System.Drawing.Point(0, 0);
            this.panelTop_EMP.Name = "panelTop_EMP";
            this.panelTop_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop_EMP.Size = new System.Drawing.Size(941, 147);
            this.panelTop_EMP.TabIndex = 0;
            // 
            // panelLeft_EMP
            // 
            this.panelLeft_EMP.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelLeft_EMP.Controls.Add(this.groupBoxInPutData_EMP);
            this.panelLeft_EMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EMP.Location = new System.Drawing.Point(0, 147);
            this.panelLeft_EMP.Name = "panelLeft_EMP";
            this.panelLeft_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_EMP.Size = new System.Drawing.Size(462, 322);
            this.panelLeft_EMP.TabIndex = 1;
            // 
            // panelRight_EMP
            // 
            this.panelRight_EMP.BackColor = System.Drawing.Color.Honeydew;
            this.panelRight_EMP.Controls.Add(this.groupBoxOutPutData_EMP);
            this.panelRight_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EMP.Location = new System.Drawing.Point(462, 147);
            this.panelRight_EMP.Name = "panelRight_EMP";
            this.panelRight_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_EMP.Size = new System.Drawing.Size(479, 322);
            this.panelRight_EMP.TabIndex = 2;
            // 
            // splitterbtwLeftRight_EMP
            // 
            this.splitterbtwLeftRight_EMP.Location = new System.Drawing.Point(462, 147);
            this.splitterbtwLeftRight_EMP.Name = "splitterbtwLeftRight_EMP";
            this.splitterbtwLeftRight_EMP.Size = new System.Drawing.Size(3, 322);
            this.splitterbtwLeftRight_EMP.TabIndex = 3;
            this.splitterbtwLeftRight_EMP.TabStop = false;
            // 
            // buttonOpenFile_EMP
            // 
            this.buttonOpenFile_EMP.BackColor = System.Drawing.Color.Gold;
            this.buttonOpenFile_EMP.Location = new System.Drawing.Point(13, 12);
            this.buttonOpenFile_EMP.Name = "buttonOpenFile_EMP";
            this.buttonOpenFile_EMP.Size = new System.Drawing.Size(75, 57);
            this.buttonOpenFile_EMP.TabIndex = 0;
            this.buttonOpenFile_EMP.Text = "Открыть файл";
            this.toolTip_EMP.SetToolTip(this.buttonOpenFile_EMP, "Открыть файл\r\nВыберите нужный для обработки файл");
            this.buttonOpenFile_EMP.UseVisualStyleBackColor = false;
            this.buttonOpenFile_EMP.Click += new System.EventHandler(this.buttonOpenFile_EMP_Click);
            // 
            // buttonDone_EMP
            // 
            this.buttonDone_EMP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_EMP.Location = new System.Drawing.Point(94, 13);
            this.buttonDone_EMP.Name = "buttonDone_EMP";
            this.buttonDone_EMP.Size = new System.Drawing.Size(75, 57);
            this.buttonDone_EMP.TabIndex = 0;
            this.buttonDone_EMP.Text = "Выполнить";
            this.toolTip_EMP.SetToolTip(this.buttonDone_EMP, "Производит поиск в файле вхождений\r\nсимволов \"r\" и конкатенирует слова в \r\nкоторы" +
        "х находятся эти символы");
            this.buttonDone_EMP.UseVisualStyleBackColor = false;
            this.buttonDone_EMP.Click += new System.EventHandler(this.buttonDone_EMP_Click);
            // 
            // buttonHelp_EMP
            // 
            this.buttonHelp_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EMP.BackColor = System.Drawing.Color.Turquoise;
            this.buttonHelp_EMP.Location = new System.Drawing.Point(854, 12);
            this.buttonHelp_EMP.Name = "buttonHelp_EMP";
            this.buttonHelp_EMP.Size = new System.Drawing.Size(75, 57);
            this.buttonHelp_EMP.TabIndex = 0;
            this.buttonHelp_EMP.Text = "Справка";
            this.toolTip_EMP.SetToolTip(this.buttonHelp_EMP, "Сведения о программе");
            this.buttonHelp_EMP.UseVisualStyleBackColor = false;
            this.buttonHelp_EMP.Click += new System.EventHandler(this.buttonHelp_EMP_Click);
            // 
            // openFileDialogTask_EMP
            // 
            this.openFileDialogTask_EMP.FileName = "openFileDialog1";
            // 
            // toolTip_EMP
            // 
            this.toolTip_EMP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_EMP.ToolTipTitle = "Подсказка";
            // 
            // textBoxTask_EMP
            // 
            this.textBoxTask_EMP.BackColor = System.Drawing.Color.Bisque;
            this.textBoxTask_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_EMP.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_EMP.Multiline = true;
            this.textBoxTask_EMP.Name = "textBoxTask_EMP";
            this.textBoxTask_EMP.ReadOnly = true;
            this.textBoxTask_EMP.Size = new System.Drawing.Size(925, 52);
            this.textBoxTask_EMP.TabIndex = 1;
            this.textBoxTask_EMP.Text = "Дан файл InPutFileTask6V3.txt который может находится в любом месте на диске. Заг" +
    "рузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречаетс" +
    "я r в результирующею строку";
            // 
            // groupBoxTask_EMP
            // 
            this.groupBoxTask_EMP.Controls.Add(this.textBoxTask_EMP);
            this.groupBoxTask_EMP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTask_EMP.Location = new System.Drawing.Point(5, 71);
            this.groupBoxTask_EMP.Name = "groupBoxTask_EMP";
            this.groupBoxTask_EMP.Size = new System.Drawing.Size(931, 71);
            this.groupBoxTask_EMP.TabIndex = 2;
            this.groupBoxTask_EMP.TabStop = false;
            this.groupBoxTask_EMP.Text = "Условие:";
            // 
            // groupBoxInPutData_EMP
            // 
            this.groupBoxInPutData_EMP.Controls.Add(this.textBoxInPutData_EMP);
            this.groupBoxInPutData_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_EMP.Location = new System.Drawing.Point(5, 5);
            this.groupBoxInPutData_EMP.Name = "groupBoxInPutData_EMP";
            this.groupBoxInPutData_EMP.Size = new System.Drawing.Size(452, 312);
            this.groupBoxInPutData_EMP.TabIndex = 0;
            this.groupBoxInPutData_EMP.TabStop = false;
            this.groupBoxInPutData_EMP.Text = "Ввод:";
            // 
            // groupBoxOutPutData_EMP
            // 
            this.groupBoxOutPutData_EMP.Controls.Add(this.textBoxOutPutData_EMP);
            this.groupBoxOutPutData_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_EMP.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPutData_EMP.Name = "groupBoxOutPutData_EMP";
            this.groupBoxOutPutData_EMP.Size = new System.Drawing.Size(469, 312);
            this.groupBoxOutPutData_EMP.TabIndex = 0;
            this.groupBoxOutPutData_EMP.TabStop = false;
            this.groupBoxOutPutData_EMP.Text = "Вывод:";
            // 
            // textBoxInPutData_EMP
            // 
            this.textBoxInPutData_EMP.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxInPutData_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPutData_EMP.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPutData_EMP.Multiline = true;
            this.textBoxInPutData_EMP.Name = "textBoxInPutData_EMP";
            this.textBoxInPutData_EMP.ReadOnly = true;
            this.textBoxInPutData_EMP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_EMP.Size = new System.Drawing.Size(446, 293);
            this.textBoxInPutData_EMP.TabIndex = 0;
            // 
            // textBoxOutPutData_EMP
            // 
            this.textBoxOutPutData_EMP.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxOutPutData_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_EMP.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPutData_EMP.Multiline = true;
            this.textBoxOutPutData_EMP.Name = "textBoxOutPutData_EMP";
            this.textBoxOutPutData_EMP.ReadOnly = true;
            this.textBoxOutPutData_EMP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_EMP.Size = new System.Drawing.Size(463, 293);
            this.textBoxOutPutData_EMP.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 469);
            this.Controls.Add(this.splitterbtwLeftRight_EMP);
            this.Controls.Add(this.panelRight_EMP);
            this.Controls.Add(this.panelLeft_EMP);
            this.Controls.Add(this.panelTop_EMP);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 3 | Елсуфьев М. П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_EMP.ResumeLayout(false);
            this.panelLeft_EMP.ResumeLayout(false);
            this.panelRight_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.PerformLayout();
            this.groupBoxInPutData_EMP.ResumeLayout(false);
            this.groupBoxInPutData_EMP.PerformLayout();
            this.groupBoxOutPutData_EMP.ResumeLayout(false);
            this.groupBoxOutPutData_EMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_EMP;
        private System.Windows.Forms.Button buttonHelp_EMP;
        private System.Windows.Forms.Button buttonDone_EMP;
        private System.Windows.Forms.Button buttonOpenFile_EMP;
        private System.Windows.Forms.Panel panelLeft_EMP;
        private System.Windows.Forms.Panel panelRight_EMP;
        private System.Windows.Forms.Splitter splitterbtwLeftRight_EMP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_EMP;
        private System.Windows.Forms.ToolTip toolTip_EMP;
        private System.Windows.Forms.GroupBox groupBoxTask_EMP;
        private System.Windows.Forms.TextBox textBoxTask_EMP;
        private System.Windows.Forms.GroupBox groupBoxInPutData_EMP;
        private System.Windows.Forms.TextBox textBoxInPutData_EMP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EMP;
        private System.Windows.Forms.TextBox textBoxOutPutData_EMP;
    }
}

