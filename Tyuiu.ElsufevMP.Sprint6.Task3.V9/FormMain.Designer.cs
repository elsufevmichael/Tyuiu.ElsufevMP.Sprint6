
namespace Tyuiu.ElsufevMP.Sprint6.Task3.V9
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
            this.groupBoxTask_EMP = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_EMP = new System.Windows.Forms.DataGridView();
            this.textBoxTask_EMP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelResult_EMP = new System.Windows.Forms.Label();
            this.textBoxResult_EMP = new System.Windows.Forms.TextBox();
            this.buttonHelp_EMP = new System.Windows.Forms.Button();
            this.buttonDone_EMP = new System.Windows.Forms.Button();
            this.groupBoxTask_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_EMP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_EMP
            // 
            this.groupBoxTask_EMP.Controls.Add(this.dataGridViewMatrix_EMP);
            this.groupBoxTask_EMP.Controls.Add(this.textBoxTask_EMP);
            this.groupBoxTask_EMP.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_EMP.Name = "groupBoxTask_EMP";
            this.groupBoxTask_EMP.Size = new System.Drawing.Size(569, 293);
            this.groupBoxTask_EMP.TabIndex = 0;
            this.groupBoxTask_EMP.TabStop = false;
            this.groupBoxTask_EMP.Text = "Условие:";
            // 
            // dataGridViewMatrix_EMP
            // 
            this.dataGridViewMatrix_EMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_EMP.Location = new System.Drawing.Point(274, 20);
            this.dataGridViewMatrix_EMP.Name = "dataGridViewMatrix_EMP";
            this.dataGridViewMatrix_EMP.Size = new System.Drawing.Size(289, 267);
            this.dataGridViewMatrix_EMP.TabIndex = 1;
            // 
            // textBoxTask_EMP
            // 
            this.textBoxTask_EMP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EMP.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_EMP.Multiline = true;
            this.textBoxTask_EMP.Name = "textBoxTask_EMP";
            this.textBoxTask_EMP.ReadOnly = true;
            this.textBoxTask_EMP.Size = new System.Drawing.Size(261, 268);
            this.textBoxTask_EMP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResult_EMP);
            this.groupBox2.Controls.Add(this.textBoxResult_EMP);
            this.groupBox2.Location = new System.Drawing.Point(588, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // labelResult_EMP
            // 
            this.labelResult_EMP.AutoSize = true;
            this.labelResult_EMP.Location = new System.Drawing.Point(6, 19);
            this.labelResult_EMP.Name = "labelResult_EMP";
            this.labelResult_EMP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_EMP.TabIndex = 1;
            this.labelResult_EMP.Text = "Результат:";
            // 
            // textBoxResult_EMP
            // 
            this.textBoxResult_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_EMP.Location = new System.Drawing.Point(6, 35);
            this.textBoxResult_EMP.Name = "textBoxResult_EMP";
            this.textBoxResult_EMP.ReadOnly = true;
            this.textBoxResult_EMP.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_EMP.TabIndex = 0;
            // 
            // buttonHelp_EMP
            // 
            this.buttonHelp_EMP.Location = new System.Drawing.Point(589, 283);
            this.buttonHelp_EMP.Name = "buttonHelp_EMP";
            this.buttonHelp_EMP.Size = new System.Drawing.Size(25, 23);
            this.buttonHelp_EMP.TabIndex = 1;
            this.buttonHelp_EMP.Text = "?";
            this.buttonHelp_EMP.UseVisualStyleBackColor = true;
            this.buttonHelp_EMP.Click += new System.EventHandler(this.buttonHelp_EMP_Click);
            // 
            // buttonDone_EMP
            // 
            this.buttonDone_EMP.Location = new System.Drawing.Point(620, 283);
            this.buttonDone_EMP.Name = "buttonDone_EMP";
            this.buttonDone_EMP.Size = new System.Drawing.Size(83, 23);
            this.buttonDone_EMP.TabIndex = 1;
            this.buttonDone_EMP.Text = "Выполнить";
            this.buttonDone_EMP.UseVisualStyleBackColor = true;
            this.buttonDone_EMP.Click += new System.EventHandler(this.buttonDone_EMP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 318);
            this.Controls.Add(this.buttonDone_EMP);
            this.Controls.Add(this.buttonHelp_EMP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTask_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Елсуфьев М. П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_EMP.ResumeLayout(false);
            this.groupBoxTask_EMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_EMP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_EMP;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_EMP;
        private System.Windows.Forms.TextBox textBoxTask_EMP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelResult_EMP;
        private System.Windows.Forms.TextBox textBoxResult_EMP;
        private System.Windows.Forms.Button buttonHelp_EMP;
        private System.Windows.Forms.Button buttonDone_EMP;
    }
}

