
namespace Tyuiu.ElsufevMP.Sprint6.Task0.V3
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
            this.groupBoxTerm_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EMP = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_EMP = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_EMP = new System.Windows.Forms.TextBox();
            this.labelInPutDataX_EMP = new System.Windows.Forms.Label();
            this.groupBoxOutPutData_EMP = new System.Windows.Forms.GroupBox();
            this.textBoxResult_EMP = new System.Windows.Forms.TextBox();
            this.labelResult_EMP = new System.Windows.Forms.Label();
            this.buttonDone_EMP = new System.Windows.Forms.Button();
            this.buttonHelp_EMP = new System.Windows.Forms.Button();
            this.groupBoxTerm_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_EMP)).BeginInit();
            this.groupBoxInPutData_EMP.SuspendLayout();
            this.groupBoxOutPutData_EMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTerm_EMP
            // 
            this.groupBoxTerm_EMP.Controls.Add(this.textBoxTask_EMP);
            this.groupBoxTerm_EMP.Controls.Add(this.pictureBoxFormula_EMP);
            this.groupBoxTerm_EMP.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTerm_EMP.Name = "groupBoxTerm_EMP";
            this.groupBoxTerm_EMP.Size = new System.Drawing.Size(457, 152);
            this.groupBoxTerm_EMP.TabIndex = 0;
            this.groupBoxTerm_EMP.TabStop = false;
            this.groupBoxTerm_EMP.Text = "Условие";
            // 
            // textBoxTask_EMP
            // 
            this.textBoxTask_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EMP.Location = new System.Drawing.Point(10, 19);
            this.textBoxTask_EMP.Multiline = true;
            this.textBoxTask_EMP.Name = "textBoxTask_EMP";
            this.textBoxTask_EMP.ReadOnly = true;
            this.textBoxTask_EMP.Size = new System.Drawing.Size(335, 127);
            this.textBoxTask_EMP.TabIndex = 1;
            this.textBoxTask_EMP.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_EMP
            // 
            this.pictureBoxFormula_EMP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_EMP.Image")));
            this.pictureBoxFormula_EMP.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_EMP.InitialImage")));
            this.pictureBoxFormula_EMP.Location = new System.Drawing.Point(351, 19);
            this.pictureBoxFormula_EMP.Name = "pictureBoxFormula_EMP";
            this.pictureBoxFormula_EMP.Size = new System.Drawing.Size(100, 58);
            this.pictureBoxFormula_EMP.TabIndex = 0;
            this.pictureBoxFormula_EMP.TabStop = false;
            // 
            // groupBoxInPutData_EMP
            // 
            this.groupBoxInPutData_EMP.Controls.Add(this.textBoxVarX_EMP);
            this.groupBoxInPutData_EMP.Controls.Add(this.labelInPutDataX_EMP);
            this.groupBoxInPutData_EMP.Location = new System.Drawing.Point(12, 170);
            this.groupBoxInPutData_EMP.Name = "groupBoxInPutData_EMP";
            this.groupBoxInPutData_EMP.Size = new System.Drawing.Size(290, 100);
            this.groupBoxInPutData_EMP.TabIndex = 0;
            this.groupBoxInPutData_EMP.TabStop = false;
            this.groupBoxInPutData_EMP.Text = "Ввод данных";
            // 
            // textBoxVarX_EMP
            // 
            this.textBoxVarX_EMP.Location = new System.Drawing.Point(10, 33);
            this.textBoxVarX_EMP.Name = "textBoxVarX_EMP";
            this.textBoxVarX_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_EMP.TabIndex = 2;
            this.textBoxVarX_EMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // labelInPutDataX_EMP
            // 
            this.labelInPutDataX_EMP.AutoSize = true;
            this.labelInPutDataX_EMP.Location = new System.Drawing.Point(7, 16);
            this.labelInPutDataX_EMP.Name = "labelInPutDataX_EMP";
            this.labelInPutDataX_EMP.Size = new System.Drawing.Size(84, 13);
            this.labelInPutDataX_EMP.TabIndex = 1;
            this.labelInPutDataX_EMP.Text = "Переменная X:";
            // 
            // groupBoxOutPutData_EMP
            // 
            this.groupBoxOutPutData_EMP.Controls.Add(this.textBoxResult_EMP);
            this.groupBoxOutPutData_EMP.Controls.Add(this.labelResult_EMP);
            this.groupBoxOutPutData_EMP.Location = new System.Drawing.Point(308, 170);
            this.groupBoxOutPutData_EMP.Name = "groupBoxOutPutData_EMP";
            this.groupBoxOutPutData_EMP.Size = new System.Drawing.Size(161, 100);
            this.groupBoxOutPutData_EMP.TabIndex = 0;
            this.groupBoxOutPutData_EMP.TabStop = false;
            this.groupBoxOutPutData_EMP.Text = "Вывод данных";
            // 
            // textBoxResult_EMP
            // 
            this.textBoxResult_EMP.Location = new System.Drawing.Point(9, 33);
            this.textBoxResult_EMP.Name = "textBoxResult_EMP";
            this.textBoxResult_EMP.ReadOnly = true;
            this.textBoxResult_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_EMP.TabIndex = 2;
            // 
            // labelResult_EMP
            // 
            this.labelResult_EMP.AutoSize = true;
            this.labelResult_EMP.Location = new System.Drawing.Point(6, 16);
            this.labelResult_EMP.Name = "labelResult_EMP";
            this.labelResult_EMP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_EMP.TabIndex = 1;
            this.labelResult_EMP.Text = "Результат:";
            // 
            // buttonDone_EMP
            // 
            this.buttonDone_EMP.Location = new System.Drawing.Point(363, 276);
            this.buttonDone_EMP.Name = "buttonDone_EMP";
            this.buttonDone_EMP.Size = new System.Drawing.Size(106, 36);
            this.buttonDone_EMP.TabIndex = 1;
            this.buttonDone_EMP.Text = "Выполнить";
            this.buttonDone_EMP.UseVisualStyleBackColor = true;
            this.buttonDone_EMP.Click += new System.EventHandler(this.buttonDone_EMP_Click);
            // 
            // buttonHelp_EMP
            // 
            this.buttonHelp_EMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_EMP.Location = new System.Drawing.Point(323, 277);
            this.buttonHelp_EMP.Name = "buttonHelp_EMP";
            this.buttonHelp_EMP.Size = new System.Drawing.Size(34, 35);
            this.buttonHelp_EMP.TabIndex = 2;
            this.buttonHelp_EMP.Text = "?";
            this.buttonHelp_EMP.UseVisualStyleBackColor = true;
            this.buttonHelp_EMP.Click += new System.EventHandler(this.buttonHelp_EMP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.buttonHelp_EMP);
            this.Controls.Add(this.buttonDone_EMP);
            this.Controls.Add(this.groupBoxOutPutData_EMP);
            this.Controls.Add(this.groupBoxInPutData_EMP);
            this.Controls.Add(this.groupBoxTerm_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Елсуфьев М. П.";
            this.groupBoxTerm_EMP.ResumeLayout(false);
            this.groupBoxTerm_EMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_EMP)).EndInit();
            this.groupBoxInPutData_EMP.ResumeLayout(false);
            this.groupBoxInPutData_EMP.PerformLayout();
            this.groupBoxOutPutData_EMP.ResumeLayout(false);
            this.groupBoxOutPutData_EMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTerm_EMP;
        private System.Windows.Forms.TextBox textBoxTask_EMP;
        private System.Windows.Forms.PictureBox pictureBoxFormula_EMP;
        private System.Windows.Forms.GroupBox groupBoxInPutData_EMP;
        private System.Windows.Forms.Label labelInPutDataX_EMP;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EMP;
        private System.Windows.Forms.Button buttonDone_EMP;
        private System.Windows.Forms.Label labelResult_EMP;
        private System.Windows.Forms.TextBox textBoxVarX_EMP;
        private System.Windows.Forms.TextBox textBoxResult_EMP;
        private System.Windows.Forms.Button buttonHelp_EMP;
    }
}

