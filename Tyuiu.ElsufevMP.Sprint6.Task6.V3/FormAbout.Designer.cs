
namespace Tyuiu.ElsufevMP.Sprint6.Task6.V3
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
            this.buttonOk_EMP = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_EMP = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_EMP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_EMP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_EMP
            // 
            this.buttonOk_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOk_EMP.Location = new System.Drawing.Point(548, 283);
            this.buttonOk_EMP.Name = "buttonOk_EMP";
            this.buttonOk_EMP.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_EMP.TabIndex = 0;
            this.buttonOk_EMP.Text = "OK";
            this.buttonOk_EMP.UseVisualStyleBackColor = false;
            this.buttonOk_EMP.Click += new System.EventHandler(this.buttonOk_EMP_Click);
            // 
            // pictureBoxAvatar_EMP
            // 
            this.pictureBoxAvatar_EMP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_EMP.Image")));
            this.pictureBoxAvatar_EMP.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_EMP.Name = "pictureBoxAvatar_EMP";
            this.pictureBoxAvatar_EMP.Size = new System.Drawing.Size(297, 293);
            this.pictureBoxAvatar_EMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_EMP.TabIndex = 1;
            this.pictureBoxAvatar_EMP.TabStop = false;
            // 
            // textBoxInfo_EMP
            // 
            this.textBoxInfo_EMP.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxInfo_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_EMP.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxInfo_EMP.Location = new System.Drawing.Point(315, 12);
            this.textBoxInfo_EMP.Multiline = true;
            this.textBoxInfo_EMP.Name = "textBoxInfo_EMP";
            this.textBoxInfo_EMP.Size = new System.Drawing.Size(308, 265);
            this.textBoxInfo_EMP.TabIndex = 3;
            this.textBoxInfo_EMP.Text = resources.GetString("textBoxInfo_EMP.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(635, 317);
            this.Controls.Add(this.textBoxInfo_EMP);
            this.Controls.Add(this.pictureBoxAvatar_EMP);
            this.Controls.Add(this.buttonOk_EMP);
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

        private System.Windows.Forms.Button buttonOk_EMP;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_EMP;
        private System.Windows.Forms.TextBox textBoxInfo_EMP;
    }
}