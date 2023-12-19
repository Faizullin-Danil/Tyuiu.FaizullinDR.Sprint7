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

namespace Tyuiu.FaizullinDR.Sprint7.Project.V7
{
    public partial class FormMain_FDR : Form
    {
        public FormMain_FDR()
        {
            InitializeComponent();
            dataGridViewInfoFlat_FDR.RowCount = 100;
            dataGridViewInfoFlat_FDR.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewInfoFlat_FDR.Columns[i].Width = 130;
            }
            dataGridViewInfoFlat_FDR.Columns[2].Width = 180;
        }
        DataService ds = new DataService();
        public static string path = @"C:\Project\Домоуправление.csv";

        private void buttonSaveFile_FDR_Click(object sender, EventArgs e) // Регистрирует новых жильцов
        {
            if ((textBoxFIO_FDR.Text == "")||(textBoxAddEntrance_FDR.Text == "")||(textBoxFlatArea_FDR.Text == "")||(textBoxAddFlat_FDR.Text == "")||(textBoxSumPeople_FDR.Text == "")||(textBoxSumRoom_FDR.Text == "")||((radioButtonBuy_FDR.Checked == false)&&(radioButtonRent_FDR.Checked == false)))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxAddEntrance_FDR.Text), Convert.ToInt32(textBoxAddFlat_FDR.Text));

                if (FlatBusy)
                    MessageBox.Show("Данная квартира занята", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (radioButtonBuy_FDR.Checked == true)
                            str = $"{textBoxAddEntrance_FDR.Text};{textBoxAddFlat_FDR.Text};{textBoxFIO_FDR.Text};{textBoxSumPeople_FDR.Text};{textBoxFlatArea_FDR.Text};{textBoxSumRoom_FDR.Text};покупка";
                        else
                            str = $"{textBoxAddEntrance_FDR.Text};{textBoxAddFlat_FDR.Text};{textBoxFIO_FDR.Text};{textBoxSumPeople_FDR.Text};{textBoxFlatArea_FDR.Text};{textBoxSumRoom_FDR.Text};аренда";
                    }
                    File.AppendAllText(path, str + "\n");


                    textBoxFIO_FDR.Text = "";
                    textBoxAddEntrance_FDR.Text = "";
                    textBoxFlatArea_FDR.Text = "";
                    textBoxAddFlat_FDR.Text = "";
                    textBoxSumPeople_FDR.Text = "";
                    textBoxSumRoom_FDR.Text = "";
                    radioButtonBuy_FDR.Checked = false;
                    radioButtonRent_FDR.Checked = false; 

                    ////////
                    string[,] DataMatrix = ds.GetMatrix(path); // данные из excel

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    /////////

                    MessageBox.Show("Новый житель зарегистрирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonOpenFile_FDR_Click(object sender, EventArgs e) // Выводит базу данных в DataGrid
        {
            openFileDialogInfoFlat_FDR.ShowDialog();
            string FileName = openFileDialogInfoFlat_FDR.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName); // данные из excel

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
        }

        

        private void buttonDeletePeople_FDR_Click(object sender, EventArgs e) // Выселяет жильцов
        {
            if ((textBoxDeleteEntrance_FDR.Text == "") || (textBoxDeleteFlat_FDR.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxDeleteEntrance_FDR.Text), Convert.ToInt32(textBoxDeleteFlat_FDR.Text));

                if (FlatBusy == false)
                    MessageBox.Show("Такой квартиры нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string[] strRows = File.ReadAllLines(path);

                    for (int i = 0; i < strRows.Length; i++)
                    {
                        string[] strIndex = strRows[i].Split(';');
                        if ((strIndex[0] == textBoxDeleteEntrance_FDR.Text) && (strIndex[1] == textBoxDeleteFlat_FDR.Text))
                            strRows[i] = "";
                    }
                    strRows = strRows.Where(i => i != "").ToArray();

                    File.Delete("Домоуправление.csv");

                    saveFileDialogInfoFlat_FDR.FileName = "Домоуправление.csv";
                    saveFileDialogInfoFlat_FDR.ShowDialog();

                    path = saveFileDialogInfoFlat_FDR.FileName;

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path); // данные из excel

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Квартирант выселен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
            textBoxDeleteEntrance_FDR.Text = "";
            textBoxDeleteFlat_FDR.Text = "";
            }

        private void buttonStatistic_FDR_Click(object sender, EventArgs e)
        {
            FormInformation FormInfo = new FormInformation();
            FormInfo.ShowDialog();
        }

        private void buttonQuickGuide_FDR_Click(object sender, EventArgs e)
        {
            FormQuickGuide quickGuide = new FormQuickGuide();
            quickGuide.ShowDialog();
        }
        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix,0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 4);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 4);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }
    }
}
