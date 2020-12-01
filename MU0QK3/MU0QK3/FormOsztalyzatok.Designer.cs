
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelJegy = new System.Windows.Forms.Label();
            this.labelTema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 394);
            this.listBox1.TabIndex = 0;
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(472, 18);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(35, 13);
            this.labelNev.TabIndex = 1;
            this.labelNev.Text = "label1";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(253, 67);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(35, 13);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "label1";
            // 
            // labelJegy
            // 
            this.labelJegy.AutoSize = true;
            this.labelJegy.Location = new System.Drawing.Point(472, 67);
            this.labelJegy.Name = "labelJegy";
            this.labelJegy.Size = new System.Drawing.Size(35, 13);
            this.labelJegy.TabIndex = 3;
            this.labelJegy.Text = "label2";
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Location = new System.Drawing.Point(654, 67);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(35, 13);
            this.labelTema.TabIndex = 4;
            this.labelTema.Text = "label3";
            // 
            // FormOsztalyzatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.labelJegy);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.listBox1);
            this.Name = "FormOsztalyzatok";
            this.Text = "FormOsztalyzatok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelJegy;
        private System.Windows.Forms.Label labelTema;
    }
}