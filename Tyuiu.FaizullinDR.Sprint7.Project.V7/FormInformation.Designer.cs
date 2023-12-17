
namespace Tyuiu.FaizullinDR.Sprint7.Project.V7
{
    partial class FormInformation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInfo_FDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonNumberResidents_FDR = new System.Windows.Forms.Button();
            this.buttonBuyOrRent_FDR = new System.Windows.Forms.Button();
            this.buttonUseFlatArea_FDR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_FDR)).BeginInit();
            this.SuspendLayout();
            // 
            // chartInfo_FDR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo_FDR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo_FDR.Legends.Add(legend1);
            this.chartInfo_FDR.Location = new System.Drawing.Point(456, 12);
            this.chartInfo_FDR.Name = "chartInfo_FDR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo_FDR.Series.Add(series1);
            this.chartInfo_FDR.Size = new System.Drawing.Size(605, 565);
            this.chartInfo_FDR.TabIndex = 0;
            this.chartInfo_FDR.Text = "chart1";
            // 
            // buttonNumberResidents_FDR
            // 
            this.buttonNumberResidents_FDR.Location = new System.Drawing.Point(27, 113);
            this.buttonNumberResidents_FDR.Name = "buttonNumberResidents_FDR";
            this.buttonNumberResidents_FDR.Size = new System.Drawing.Size(412, 89);
            this.buttonNumberResidents_FDR.TabIndex = 1;
            this.buttonNumberResidents_FDR.Text = "Количество жильцов в каждом подъезде";
            this.buttonNumberResidents_FDR.UseVisualStyleBackColor = true;
            this.buttonNumberResidents_FDR.Click += new System.EventHandler(this.buttonNumberResidents_FDR_Click);
            // 
            // buttonBuyOrRent_FDR
            // 
            this.buttonBuyOrRent_FDR.Location = new System.Drawing.Point(27, 384);
            this.buttonBuyOrRent_FDR.Name = "buttonBuyOrRent_FDR";
            this.buttonBuyOrRent_FDR.Size = new System.Drawing.Size(412, 89);
            this.buttonBuyOrRent_FDR.TabIndex = 2;
            this.buttonBuyOrRent_FDR.Text = "button2";
            this.buttonBuyOrRent_FDR.UseVisualStyleBackColor = true;
            // 
            // buttonUseFlatArea_FDR
            // 
            this.buttonUseFlatArea_FDR.Location = new System.Drawing.Point(27, 248);
            this.buttonUseFlatArea_FDR.Name = "buttonUseFlatArea_FDR";
            this.buttonUseFlatArea_FDR.Size = new System.Drawing.Size(412, 89);
            this.buttonUseFlatArea_FDR.TabIndex = 3;
            this.buttonUseFlatArea_FDR.Text = "button3";
            this.buttonUseFlatArea_FDR.UseVisualStyleBackColor = true;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 600);
            this.Controls.Add(this.buttonUseFlatArea_FDR);
            this.Controls.Add(this.buttonBuyOrRent_FDR);
            this.Controls.Add(this.buttonNumberResidents_FDR);
            this.Controls.Add(this.chartInfo_FDR);
            this.Name = "FormInformation";
            this.Text = "Информация о доме";
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_FDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_FDR;
        private System.Windows.Forms.Button buttonNumberResidents_FDR;
        private System.Windows.Forms.Button buttonBuyOrRent_FDR;
        private System.Windows.Forms.Button buttonUseFlatArea_FDR;
    }
}