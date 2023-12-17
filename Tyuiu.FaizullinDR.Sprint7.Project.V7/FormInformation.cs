using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.FaizullinDR.Sprint7.Project.V7.Lib;
using System.Windows.Forms.DataVisualization.Charting;


namespace Tyuiu.FaizullinDR.Sprint7.Project.V7
{
    public partial class FormInformation : Form
    {
        
        public FormInformation()
        {
            InitializeComponent();
        }
        public static string path = @"C:\Project\Домоуправление.csv";
        DataService ds = new DataService();

        private void buttonNumberResidents_FDR_Click(object sender, EventArgs e)
        {
            this.chartInfo_FDR.ChartAreas[0].AxisX.Title = "Номер подъезда";
            this.chartInfo_FDR.ChartAreas[0].AxisY.Title = "Количество";

            object[,] DataTable = ds.DataTable(path);

            string[] strEntrance = ds.ArrayStrEntrance(DataTable);

            int startOffset = -2;
            int endOffset = 2;

            foreach (string numberIntrance in strEntrance)
            {
                CustomLabel autoLabel = new CustomLabel(startOffset, endOffset, numberIntrance, 0, LabelMarkStyle.None);
                chartInfo_FDR.ChartAreas[0].AxisX.CustomLabels.Add(autoLabel);
                startOffset = startOffset + 1;
                endOffset = endOffset + 1;
            }
            chartInfo_FDR.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
        }
    }
}
