
namespace MU0QK3
{
    partial class FormAtlagok
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAtlagok = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOsztalyzatok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAtlagok)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAtlagok
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAtlagok.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAtlagok.Legends.Add(legend2);
            this.chartAtlagok.Location = new System.Drawing.Point(12, 365);
            this.chartAtlagok.Name = "chartAtlagok";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAtlagok.Series.Add(series2);
            this.chartAtlagok.Size = new System.Drawing.Size(845, 300);
            this.chartAtlagok.TabIndex = 0;
            this.chartAtlagok.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(22, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 286);
            this.panel1.TabIndex = 1;
            // 
            // buttonOsztalyzatok
            // 
            this.buttonOsztalyzatok.Location = new System.Drawing.Point(692, 129);
            this.buttonOsztalyzatok.Name = "buttonOsztalyzatok";
            this.buttonOsztalyzatok.Size = new System.Drawing.Size(129, 73);
            this.buttonOsztalyzatok.TabIndex = 2;
            this.buttonOsztalyzatok.Text = "Lezárt osztályzatok megtekintése";
            this.buttonOsztalyzatok.UseVisualStyleBackColor = true;
            this.buttonOsztalyzatok.Click += new System.EventHandler(this.buttonOsztalyzatok_Click);
            // 
            // FormAtlagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 687);
            this.Controls.Add(this.buttonOsztalyzatok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartAtlagok);
            this.MaximumSize = new System.Drawing.Size(938, 731);
            this.MinimumSize = new System.Drawing.Size(938, 726);
            this.Name = "FormAtlagok";
            this.Text = "FormAtlagok";
            ((System.ComponentModel.ISupportInitialize)(this.chartAtlagok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAtlagok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOsztalyzatok;
    }
}