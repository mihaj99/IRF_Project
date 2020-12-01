
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
            this.labelJegy = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelTema = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOsztalyzat = new System.Windows.Forms.ComboBox();
            this.comboBoxTema = new System.Windows.Forms.ComboBox();
            this.listBoxTanulok = new System.Windows.Forms.ListBox();
            this.textBoxKereses = new System.Windows.Forms.TextBox();
            this.labelKereses = new System.Windows.Forms.Label();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // comboBoxOsztalyzat
            // 
            this.comboBoxOsztalyzat.FormattingEnabled = true;
            this.comboBoxOsztalyzat.Location = new System.Drawing.Point(588, 111);
            this.comboBoxOsztalyzat.Name = "comboBoxOsztalyzat";
            this.comboBoxOsztalyzat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOsztalyzat.TabIndex = 7;
            // 
            // comboBoxTema
            // 
            this.comboBoxTema.FormattingEnabled = true;
            this.comboBoxTema.Location = new System.Drawing.Point(588, 179);
            this.comboBoxTema.Name = "comboBoxTema";
            this.comboBoxTema.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTema.TabIndex = 8;
            // 
            // listBoxTanulok
            // 
            this.listBoxTanulok.FormattingEnabled = true;
            this.listBoxTanulok.Location = new System.Drawing.Point(12, 63);
            this.listBoxTanulok.Name = "listBoxTanulok";
            this.listBoxTanulok.Size = new System.Drawing.Size(223, 355);
            this.listBoxTanulok.TabIndex = 9;
            // 
            // textBoxKereses
            // 
            this.textBoxKereses.Location = new System.Drawing.Point(63, 34);
            this.textBoxKereses.Name = "textBoxKereses";
            this.textBoxKereses.Size = new System.Drawing.Size(172, 20);
            this.textBoxKereses.TabIndex = 10;
            // 
            // labelKereses
            // 
            this.labelKereses.AutoSize = true;
            this.labelKereses.Location = new System.Drawing.Point(12, 37);
            this.labelKereses.Name = "labelKereses";
            this.labelKereses.Size = new System.Drawing.Size(45, 13);
            this.labelKereses.TabIndex = 11;
            this.labelKereses.Text = "Keresés";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(634, 227);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(75, 23);
            this.btnFelvitel.TabIndex = 12;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            // 
            // FormUjJegy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.labelKereses);
            this.Controls.Add(this.textBoxKereses);
            this.Controls.Add(this.listBoxTanulok);
            this.Controls.Add(this.comboBoxTema);
            this.Controls.Add(this.comboBoxOsztalyzat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelJegy);
            this.Name = "FormUjJegy";
            this.Text = "FormUjJegy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelJegy;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelTema;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxOsztalyzat;
        private System.Windows.Forms.ComboBox comboBoxTema;
        private System.Windows.Forms.ListBox listBoxTanulok;
        private System.Windows.Forms.TextBox textBoxKereses;
        private System.Windows.Forms.Label labelKereses;
        private System.Windows.Forms.Button btnFelvitel;
    }
}