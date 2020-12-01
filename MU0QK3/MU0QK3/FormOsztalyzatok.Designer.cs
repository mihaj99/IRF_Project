
namespace MU0QK3
{
    partial class FormOsztalyzatok
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
            this.listBoxJegyek = new System.Windows.Forms.ListBox();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxJegyek
            // 
            this.listBoxJegyek.FormattingEnabled = true;
            this.listBoxJegyek.Location = new System.Drawing.Point(12, 12);
            this.listBoxJegyek.Name = "listBoxJegyek";
            this.listBoxJegyek.Size = new System.Drawing.Size(231, 394);
            this.listBoxJegyek.TabIndex = 0;
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(496, 12);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(35, 13);
            this.labelNev.TabIndex = 1;
            this.labelNev.Text = "label1";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(283, 69);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(60, 13);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "labelDatum";
            // 
            // FormOsztalyzatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.listBoxJegyek);
            this.Name = "FormOsztalyzatok";
            this.Text = "FormOsztalyzatok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxJegyek;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelDatum;
    }
}