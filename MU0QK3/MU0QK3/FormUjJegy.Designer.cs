﻿
namespace MU0QK3
{
    partial class FormUjJegy
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
            this.listBoxNev = new System.Windows.Forms.ListBox();
            this.textBoxKereses = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.labelJegy = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelTema = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxNev
            // 
            this.listBoxNev.FormattingEnabled = true;
            this.listBoxNev.Location = new System.Drawing.Point(12, 35);
            this.listBoxNev.Name = "listBoxNev";
            this.listBoxNev.Size = new System.Drawing.Size(182, 368);
            this.listBoxNev.TabIndex = 0;
            // 
            // textBoxKereses
            // 
            this.textBoxKereses.Location = new System.Drawing.Point(54, 9);
            this.textBoxKereses.Name = "textBoxKereses";
            this.textBoxKereses.Size = new System.Drawing.Size(140, 20);
            this.textBoxKereses.TabIndex = 1;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(9, 12);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(45, 13);
            this.lblNev.TabIndex = 2;
            this.lblNev.Text = "Keresés";
            // 
            // labelJegy
            // 
            this.labelJegy.AutoSize = true;
            this.labelJegy.Location = new System.Drawing.Point(515, 114);
            this.labelJegy.Name = "labelJegy";
            this.labelJegy.Size = new System.Drawing.Size(58, 13);
            this.labelJegy.TabIndex = 3;
            this.labelJegy.Text = "Osztályzat:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(515, 148);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(38, 13);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "Dátum";
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Location = new System.Drawing.Point(515, 182);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(34, 13);
            this.labelTema.TabIndex = 5;
            this.labelTema.Text = "Téma";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(588, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(588, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // FormUjJegy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelJegy);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.textBoxKereses);
            this.Controls.Add(this.listBoxNev);
            this.Name = "FormUjJegy";
            this.Text = "FormUjJegy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNev;
        private System.Windows.Forms.TextBox textBoxKereses;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label labelJegy;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelTema;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}