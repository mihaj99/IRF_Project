
namespace MU0QK3
{
    partial class FormFo
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
            this.btnUjTanulo = new System.Windows.Forms.Button();
            this.btnJegyek = new System.Windows.Forms.Button();
            this.buttonAtlagok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUjTanulo
            // 
            this.btnUjTanulo.Location = new System.Drawing.Point(174, 117);
            this.btnUjTanulo.Name = "btnUjTanulo";
            this.btnUjTanulo.Size = new System.Drawing.Size(147, 23);
            this.btnUjTanulo.TabIndex = 0;
            this.btnUjTanulo.Text = "Tanulók kezelése";
            this.btnUjTanulo.UseVisualStyleBackColor = true;
            this.btnUjTanulo.Click += new System.EventHandler(this.btnUjTanulo_Click);
            // 
            // btnJegyek
            // 
            this.btnJegyek.Location = new System.Drawing.Point(174, 146);
            this.btnJegyek.Name = "btnJegyek";
            this.btnJegyek.Size = new System.Drawing.Size(147, 23);
            this.btnJegyek.TabIndex = 1;
            this.btnJegyek.Text = "Jegyek kezelése";
            this.btnJegyek.UseVisualStyleBackColor = true;
            this.btnJegyek.Click += new System.EventHandler(this.btnJegyek_Click);
            // 
            // buttonAtlagok
            // 
            this.buttonAtlagok.Location = new System.Drawing.Point(174, 175);
            this.buttonAtlagok.Name = "buttonAtlagok";
            this.buttonAtlagok.Size = new System.Drawing.Size(147, 23);
            this.buttonAtlagok.TabIndex = 2;
            this.buttonAtlagok.Text = "Átlagok megtekintése";
            this.buttonAtlagok.UseVisualStyleBackColor = true;
            this.buttonAtlagok.Click += new System.EventHandler(this.buttonAtlagok_Click);
            // 
            // FormFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 338);
            this.Controls.Add(this.buttonAtlagok);
            this.Controls.Add(this.btnJegyek);
            this.Controls.Add(this.btnUjTanulo);
            this.MaximumSize = new System.Drawing.Size(520, 377);
            this.MinimumSize = new System.Drawing.Size(520, 377);
            this.Name = "FormFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUjTanulo;
        private System.Windows.Forms.Button btnJegyek;
        private System.Windows.Forms.Button buttonAtlagok;
    }
}

