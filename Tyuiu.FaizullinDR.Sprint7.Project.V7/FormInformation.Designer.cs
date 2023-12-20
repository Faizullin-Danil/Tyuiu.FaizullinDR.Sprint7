
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
            this.buttonNumberFlatsInEntrance_FDR = new System.Windows.Forms.Button();
            this.buttonBuyOrRent_FDR = new System.Windows.Forms.Button();
            this.buttonUseFlatAreaAndUseSunRoom_FDR = new System.Windows.Forms.Button();
            this.groupBoxButtons_FDR = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_FDR)).BeginInit();
            this.groupBoxButtons_FDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartInfo_FDR
            // 
            this.chartInfo_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartInfo_FDR.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
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
            // buttonNumberFlatsInEntrance_FDR
            // 
            this.buttonNumberFlatsInEntrance_FDR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNumberFlatsInEntrance_FDR.Location = new System.Drawing.Point(6, 63);
            this.buttonNumberFlatsInEntrance_FDR.Name = "buttonNumberFlatsInEntrance_FDR";
            this.buttonNumberFlatsInEntrance_FDR.Size = new System.Drawing.Size(412, 111);
            this.buttonNumberFlatsInEntrance_FDR.TabIndex = 1;
            this.buttonNumberFlatsInEntrance_FDR.Text = "Количество занятых квартир в каждом подъезде";
            this.buttonNumberFlatsInEntrance_FDR.UseVisualStyleBackColor = true;
            this.buttonNumberFlatsInEntrance_FDR.Click += new System.EventHandler(this.buttonNumberResidents_FDR_Click);
            // 
            // buttonBuyOrRent_FDR
            // 
            this.buttonBuyOrRent_FDR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuyOrRent_FDR.Location = new System.Drawing.Point(6, 318);
            this.buttonBuyOrRent_FDR.Name = "buttonBuyOrRent_FDR";
            this.buttonBuyOrRent_FDR.Size = new System.Drawing.Size(412, 111);
            this.buttonBuyOrRent_FDR.TabIndex = 2;
            this.buttonBuyOrRent_FDR.Text = "Количество арендованных/купленных квартир во всем доме";
            this.buttonBuyOrRent_FDR.UseVisualStyleBackColor = true;
            this.buttonBuyOrRent_FDR.Click += new System.EventHandler(this.buttonBuyOrRent_FDR_Click);
            // 
            // buttonUseFlatAreaAndUseSunRoom_FDR
            // 
            this.buttonUseFlatAreaAndUseSunRoom_FDR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUseFlatAreaAndUseSunRoom_FDR.Location = new System.Drawing.Point(6, 190);
            this.buttonUseFlatAreaAndUseSunRoom_FDR.Name = "buttonUseFlatAreaAndUseSunRoom_FDR";
            this.buttonUseFlatAreaAndUseSunRoom_FDR.Size = new System.Drawing.Size(412, 111);
            this.buttonUseFlatAreaAndUseSunRoom_FDR.TabIndex = 3;
            this.buttonUseFlatAreaAndUseSunRoom_FDR.Text = "Количество занятой квадратуры и комнат в доме";
            this.buttonUseFlatAreaAndUseSunRoom_FDR.UseVisualStyleBackColor = true;
            this.buttonUseFlatAreaAndUseSunRoom_FDR.Click += new System.EventHandler(this.buttonUseFlatAreaAndUseSunRoom_FDR_Click);
            // 
            // groupBoxButtons_FDR
            // 
            this.groupBoxButtons_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxButtons_FDR.Controls.Add(this.buttonNumberFlatsInEntrance_FDR);
            this.groupBoxButtons_FDR.Controls.Add(this.buttonUseFlatAreaAndUseSunRoom_FDR);
            this.groupBoxButtons_FDR.Controls.Add(this.buttonBuyOrRent_FDR);
            this.groupBoxButtons_FDR.Location = new System.Drawing.Point(12, 3);
            this.groupBoxButtons_FDR.Name = "groupBoxButtons_FDR";
            this.groupBoxButtons_FDR.Size = new System.Drawing.Size(438, 574);
            this.groupBoxButtons_FDR.TabIndex = 4;
            this.groupBoxButtons_FDR.TabStop = false;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 600);
            this.Controls.Add(this.groupBoxButtons_FDR);
            this.Controls.Add(this.chartInfo_FDR);
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о доме";
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_FDR)).EndInit();
            this.groupBoxButtons_FDR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_FDR;
        private System.Windows.Forms.Button buttonNumberFlatsInEntrance_FDR;
        private System.Windows.Forms.Button buttonBuyOrRent_FDR;
        private System.Windows.Forms.Button buttonUseFlatAreaAndUseSunRoom_FDR;
        private System.Windows.Forms.GroupBox groupBoxButtons_FDR;
    }
}