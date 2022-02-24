
using System;

namespace Notepad
{
    partial class SearchForm 
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.RichTextBox();
            this.tbReplace = new System.Windows.Forms.RichTextBox();
            this.cbReg = new System.Windows.Forms.CheckBox();
            this.btFind = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btReplaceAll = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заменить на:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(166, 47);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(281, 27);
            this.tbFind.TabIndex = 2;
            this.tbFind.Text = "";
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(166, 79);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(281, 26);
            this.tbReplace.TabIndex = 3;
            this.tbReplace.Text = "";
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Location = new System.Drawing.Point(67, 111);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(156, 21);
            this.cbReg.TabIndex = 4;
            this.cbReg.Text = "Учитывать регистр";
            this.cbReg.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(67, 138);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(101, 23);
            this.btFind.TabIndex = 5;
            this.btFind.Text = "Найти далее";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(174, 138);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(80, 23);
            this.btReplace.TabIndex = 6;
            this.btReplace.Text = "Заменить";
            this.btReplace.UseVisualStyleBackColor = true;
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Location = new System.Drawing.Point(260, 138);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Size = new System.Drawing.Size(106, 23);
            this.btReplaceAll.TabIndex = 7;
            this.btReplaceAll.Text = "Заменить всё";
            this.btReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(372, 138);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Найти и заменить";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbFind;
        private System.Windows.Forms.RichTextBox tbReplace;
        private System.Windows.Forms.CheckBox cbReg;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReplaceAll;
        private System.Windows.Forms.Button btCancel;
    }
}