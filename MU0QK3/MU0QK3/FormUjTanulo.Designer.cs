
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
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzulDat = new System.Windows.Forms.Label();
            this.lblSNI = new System.Windows.Forms.Label();
            this.dateTimeSzuldat = new System.Windows.Forms.DateTimePicker();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.chbSNI = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.btnSave.Location = new System.Drawing.Point(107, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Felvitel";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormUjTanulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbSNI);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.dateTimeSzuldat);
            this.Controls.Add(this.lblSNI);
            this.Controls.Add(this.lblSzulDat);
            this.Controls.Add(this.lblNev);
            this.Name = "FormUjTanulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUjTanulo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUjTanulo_FormClosed);
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
        private System.Windows.Forms.Button btnCancel;
    }
}