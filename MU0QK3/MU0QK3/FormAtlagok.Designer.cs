
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
            ((System.ComponentModel.ISupportInitialize)(this.chartAtlagok)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAtlagok
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAtlagok.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAtlagok.Legends.Add(legend2);
            this.chartAtlagok.Location = new System.Drawing.Point(12, 70);
            this.chartAtlagok.Name = "chartAtlagok";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAtlagok.Series.Add(series2);
            this.chartAtlagok.Size = new System.Drawing.Size(300, 300);
            this.chartAtlagok.TabIndex = 0;
            this.chartAtlagok.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(385, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 391);
            this.panel1.TabIndex = 1;
            // 
            // FormAtlagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartAtlagok);
            this.Name = "FormAtlagok";
            this.Text = "FormAtlagok";
            ((System.ComponentModel.ISupportInitialize)(this.chartAtlagok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAtlagok;
        private System.Windows.Forms.Panel panel1;
    }
}