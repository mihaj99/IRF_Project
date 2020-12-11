
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFo));
            this.btnUjTanulo = new System.Windows.Forms.Button();
            this.btnJegyek = new System.Windows.Forms.Button();
            this.buttonAtlagok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUjTanulo
            // 
            this.btnUjTanulo.Location = new System.Drawing.Point(173, 220);
            this.btnUjTanulo.Name = "btnUjTanulo";
            this.btnUjTanulo.Size = new System.Drawing.Size(147, 23);
            this.btnUjTanulo.TabIndex = 0;
            this.btnUjTanulo.Text = "Tanulók kezelése";
            this.btnUjTanulo.UseVisualStyleBackColor = true;
            this.btnUjTanulo.Click += new System.EventHandler(this.btnUjTanulo_Click);
            // 
            // btnJegyek
            // 
            this.btnJegyek.Location = new System.Drawing.Point(173, 249);
            this.btnJegyek.Name = "btnJegyek";
            this.btnJegyek.Size = new System.Drawing.Size(147, 23);
            this.btnJegyek.TabIndex = 1;
            this.btnJegyek.Text = "Jegyek kezelése";
            this.btnJegyek.UseVisualStyleBackColor = true;
            this.btnJegyek.Click += new System.EventHandler(this.btnJegyek_Click);
            // 
            // buttonAtlagok
            // 
            this.buttonAtlagok.Location = new System.Drawing.Point(173, 278);
            this.buttonAtlagok.Name = "buttonAtlagok";
            this.buttonAtlagok.Size = new System.Drawing.Size(147, 23);
            this.buttonAtlagok.TabIndex = 2;
            this.buttonAtlagok.Text = "Átlagok megtekintése";
            this.buttonAtlagok.UseVisualStyleBackColor = true;
            this.buttonAtlagok.Click += new System.EventHandler(this.buttonAtlagok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 166);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAtlagok);
            this.Controls.Add(this.btnJegyek);
            this.Controls.Add(this.btnUjTanulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 377);
            this.MinimumSize = new System.Drawing.Size(520, 377);
            this.Name = "FormFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Napló";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUjTanulo;
        private System.Windows.Forms.Button btnJegyek;
        private System.Windows.Forms.Button buttonAtlagok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

