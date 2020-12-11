
namespace MU0QK3
{
    partial class FormUjTanulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUjTanulo));
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzulDat = new System.Windows.Forms.Label();
            this.lblSNI = new System.Windows.Forms.Label();
            this.dateTimeSzuldat = new System.Windows.Forms.DateTimePicker();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.chbSNI = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelKereses = new System.Windows.Forms.Label();
            this.listBoxTanulok = new System.Windows.Forms.ListBox();
            this.textBoxKereses = new System.Windows.Forms.TextBox();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.checkBoxSNIKijelez = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNevKijelez = new System.Windows.Forms.Label();
            this.labelSzuldatKijelez = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(36, 49);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(30, 13);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név:";
            // 
            // lblSzulDat
            // 
            this.lblSzulDat.AutoSize = true;
            this.lblSzulDat.Location = new System.Drawing.Point(36, 83);
            this.lblSzulDat.Name = "lblSzulDat";
            this.lblSzulDat.Size = new System.Drawing.Size(65, 13);
            this.lblSzulDat.TabIndex = 1;
            this.lblSzulDat.Text = "Szül. dátum:";
            // 
            // lblSNI
            // 
            this.lblSNI.AutoSize = true;
            this.lblSNI.Location = new System.Drawing.Point(36, 124);
            this.lblSNI.Name = "lblSNI";
            this.lblSNI.Size = new System.Drawing.Size(28, 13);
            this.lblSNI.TabIndex = 2;
            this.lblSNI.Text = "SNI:";
            // 
            // dateTimeSzuldat
            // 
            this.dateTimeSzuldat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSzuldat.Location = new System.Drawing.Point(107, 83);
            this.dateTimeSzuldat.Name = "dateTimeSzuldat";
            this.dateTimeSzuldat.Size = new System.Drawing.Size(200, 20);
            this.dateTimeSzuldat.TabIndex = 3;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(107, 42);
            this.txtNev.MaxLength = 25;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(200, 20);
            this.txtNev.TabIndex = 4;
            // 
            // chbSNI
            // 
            this.chbSNI.AutoSize = true;
            this.chbSNI.Location = new System.Drawing.Point(107, 124);
            this.chbSNI.Name = "chbSNI";
            this.chbSNI.Size = new System.Drawing.Size(15, 14);
            this.chbSNI.TabIndex = 5;
            this.chbSNI.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(107, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Felvitel";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelKereses
            // 
            this.labelKereses.AutoSize = true;
            this.labelKereses.Location = new System.Drawing.Point(412, 61);
            this.labelKereses.Name = "labelKereses";
            this.labelKereses.Size = new System.Drawing.Size(0, 13);
            this.labelKereses.TabIndex = 10;
            // 
            // listBoxTanulok
            // 
            this.listBoxTanulok.FormattingEnabled = true;
            this.listBoxTanulok.Location = new System.Drawing.Point(346, 42);
            this.listBoxTanulok.Name = "listBoxTanulok";
            this.listBoxTanulok.Size = new System.Drawing.Size(207, 277);
            this.listBoxTanulok.TabIndex = 11;
            this.listBoxTanulok.SelectedIndexChanged += new System.EventHandler(this.listBoxTanulok_SelectedIndexChanged);
            // 
            // textBoxKereses
            // 
            this.textBoxKereses.Location = new System.Drawing.Point(393, 16);
            this.textBoxKereses.Name = "textBoxKereses";
            this.textBoxKereses.Size = new System.Drawing.Size(160, 20);
            this.textBoxKereses.TabIndex = 12;
            this.textBoxKereses.TextChanged += new System.EventHandler(this.textBoxKereses_TextChanged);
            // 
            // buttonTorles
            // 
            this.buttonTorles.BackColor = System.Drawing.Color.Tomato;
            this.buttonTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorles.Location = new System.Drawing.Point(565, 174);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 14;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = false;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // checkBoxSNIKijelez
            // 
            this.checkBoxSNIKijelez.AutoSize = true;
            this.checkBoxSNIKijelez.Location = new System.Drawing.Point(678, 138);
            this.checkBoxSNIKijelez.Name = "checkBoxSNIKijelez";
            this.checkBoxSNIKijelez.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSNIKijelez.TabIndex = 17;
            this.checkBoxSNIKijelez.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Név:";
            // 
            // labelNevKijelez
            // 
            this.labelNevKijelez.AutoSize = true;
            this.labelNevKijelez.Location = new System.Drawing.Point(657, 62);
            this.labelNevKijelez.Name = "labelNevKijelez";
            this.labelNevKijelez.Size = new System.Drawing.Size(35, 13);
            this.labelNevKijelez.TabIndex = 21;
            this.labelNevKijelez.Text = "label4";
            // 
            // labelSzuldatKijelez
            // 
            this.labelSzuldatKijelez.AutoSize = true;
            this.labelSzuldatKijelez.Location = new System.Drawing.Point(658, 96);
            this.labelSzuldatKijelez.Name = "labelSzuldatKijelez";
            this.labelSzuldatKijelez.Size = new System.Drawing.Size(35, 13);
            this.labelSzuldatKijelez.TabIndex = 22;
            this.labelSzuldatKijelez.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Keresés:";
            // 
            // FormUjTanulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSzuldatKijelez);
            this.Controls.Add(this.labelNevKijelez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxSNIKijelez);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.textBoxKereses);
            this.Controls.Add(this.listBoxTanulok);
            this.Controls.Add(this.labelKereses);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbSNI);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.dateTimeSzuldat);
            this.Controls.Add(this.lblSNI);
            this.Controls.Add(this.lblSzulDat);
            this.Controls.Add(this.lblNev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormUjTanulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tanulók kezelése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblSzulDat;
        private System.Windows.Forms.Label lblSNI;
        private System.Windows.Forms.DateTimePicker dateTimeSzuldat;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.CheckBox chbSNI;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelKereses;
        private System.Windows.Forms.ListBox listBoxTanulok;
        private System.Windows.Forms.TextBox textBoxKereses;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.CheckBox checkBoxSNIKijelez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNevKijelez;
        private System.Windows.Forms.Label labelSzuldatKijelez;
        private System.Windows.Forms.Label label4;
    }
}