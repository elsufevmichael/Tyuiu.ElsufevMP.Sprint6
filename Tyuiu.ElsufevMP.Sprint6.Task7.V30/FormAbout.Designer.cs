
namespace Tyuiu.ElsufevMP.Sprint6.Task7.V30
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_EMP = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_EMP = new System.Windows.Forms.TextBox();
            this.buttonOk_EMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_EMP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_EMP
            // 
            this.pictureBoxAvatar_EMP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_EMP.Image")));
            this.pictureBoxAvatar_EMP.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_EMP.Name = "pictureBoxAvatar_EMP";
            this.pictureBoxAvatar_EMP.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxAvatar_EMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_EMP.TabIndex = 0;
            this.pictureBoxAvatar_EMP.TabStop = false;
            // 
            // textBoxAbout_EMP
            // 
            this.textBoxAbout_EMP.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAbout_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_EMP.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxAbout_EMP.Location = new System.Drawing.Point(323, 12);
            this.textBoxAbout_EMP.Multiline = true;
            this.textBoxAbout_EMP.Name = "textBoxAbout_EMP";
            this.textBoxAbout_EMP.ReadOnly = true;
            this.textBoxAbout_EMP.Size = new System.Drawing.Size(300, 264);
            this.textBoxAbout_EMP.TabIndex = 1;
            this.textBoxAbout_EMP.Text = resources.GetString("textBoxAbout_EMP.Text");
            // 
            // buttonOk_EMP
            // 
            this.buttonOk_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOk_EMP.Location = new System.Drawing.Point(548, 289);
            this.buttonOk_EMP.Name = "buttonOk_EMP";
            this.buttonOk_EMP.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_EMP.TabIndex = 2;
            this.buttonOk_EMP.Text = "OK";
            this.buttonOk_EMP.UseVisualStyleBackColor = false;
            this.buttonOk_EMP.Click += new System.EventHandler(this.buttonOk_EMP_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(634, 321);
            this.Controls.Add(this.buttonOk_EMP);
            this.Controls.Add(this.textBoxAbout_EMP);
            this.Controls.Add(this.pictureBoxAvatar_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_EMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_EMP;
        private System.Windows.Forms.TextBox textBoxAbout_EMP;
        private System.Windows.Forms.Button buttonOk_EMP;
    }
}