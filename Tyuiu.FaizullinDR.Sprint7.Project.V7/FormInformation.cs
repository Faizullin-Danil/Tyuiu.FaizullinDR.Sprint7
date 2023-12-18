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
            chartInfo_FDR.Series[0].Points.Clear();

            this.chartInfo_FDR.ChartAreas[0].AxisX.Title = "Номер подъезда";
            this.chartInfo_FDR.ChartAreas[0].AxisY.Title = "Количество занятых квартир";

            string[,] DataTable = ds.GetMatrix(path); // матрица данных из файла

            string[] strEntrance = ds.ArrayStrEntrance(DataTable); // номера подъездов

            int[] arraySumPeopleInEntrance = ds.ArraySumPeopleInEntrance(DataTable, strEntrance); // массив количества занятых квартир в каждом подъезде

            for (int i = 0; i < strEntrance.Length; i++)
            {
                chartInfo_FDR.Series[0].Points.AddXY(strEntrance[i], arraySumPeopleInEntrance[i]);
            }                                
        }

        private void buttonBuyOrRent_FDR_Click(object sender, EventArgs e)
        {
            chartInfo_FDR.Series[0].Points.Clear();

            this.chartInfo_FDR.ChartAreas[0].AxisX.Title = "";
            this.chartInfo_FDR.ChartAreas[0].AxisY.Title = "Количество квартир";

            string[,] DataTable = ds.GetMatrix(path);

            int[] ArrayCountBuyOrRent = ds.ArrayCountBuyOrRent(DataTable); // массив кол-во аренды квартиры и кол-во покупки квартиры

            string[] strRentOrBuy = { "аренда", "покупка" };

            for (int i = 0; i < strRentOrBuy.Length; i++)
            {
                chartInfo_FDR.Series[0].Points.AddXY(strRentOrBuy[i], ArrayCountBuyOrRent[i]);
            }
        }

        private void buttonUseFlatAreaAndUseSunRoom_FDR_Click(object sender, EventArgs e)
        {
            chartInfo_FDR.Series[0].Points.Clear();

            this.chartInfo_FDR.ChartAreas[0].AxisX.Title = "";
            this.chartInfo_FDR.ChartAreas[0].AxisY.Title = "Количество занятых комнат и занятой квадратуры(м^2)";

            string[,] DataTable = ds.GetMatrix(path);

            int[] ArrayCountUseFlatAreaAndRooms = ds.ArrayUseFlatAreaAndSumRooms(DataTable); // массив кол-во занятой квадратуры и кол-во занятых комнат

            string[] strUseFlatAreaAndRooms = { "Занятая квадратура", "Занятые комнаты" };

            for (int i = 0; i < strUseFlatAreaAndRooms.Length; i++)
            {
                chartInfo_FDR.Series[0].Points.AddXY(strUseFlatAreaAndRooms[i], ArrayCountUseFlatAreaAndRooms[i]);
            }
        }
    }
}
