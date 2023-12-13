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
            dataGridViewInfoFlat_FDR.Columns[2].Width = 150;
        }
        DataService ds = new DataService();

        private void buttonSaveFile_FDR_Click(object sender, EventArgs e)
        {
            if ((textBoxFIO_FDR.Text == "")||(textBoxAddEntrance_FDR.Text == "")||(textBoxFlatArea_FDR.Text == "")||(textBoxAddFlat_FDR.Text == "")||(textBoxSumPeople_FDR.Text == "")||(textBoxSumRoom_FDR.Text == "")||((radioButtonBuy_FDR.Checked == false)&&(radioButtonRent_FDR.Checked == false)))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string path = @"C:\Project\Домоуправление.csv";
                string str = "";


                string[] strLines = File.ReadAllLines(path);
                bool FlatBusy = false;
                for (int i = 0; i < strLines.Length; i++)
                {
                    string[] strBox = strLines[i].Split(';');
                    if ((strBox[0] == textBoxAddEntrance_FDR.Text) && (strBox[1] == textBoxAddFlat_FDR.Text))
                        FlatBusy = true;
                }

                if (FlatBusy)
                    MessageBox.Show("Данная квартира занята", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (radioButtonBuy_FDR.Checked == true)
                            str = $"{textBoxAddEntrance_FDR.Text};{textBoxAddFlat_FDR.Text};{textBoxFIO_FDR.Text};{textBoxSumPeople_FDR.Text};{textBoxFlatArea_FDR.Text};{textBoxSumRoom_FDR.Text};buy";
                        else
                            str = $"{textBoxAddEntrance_FDR.Text};{textBoxAddFlat_FDR.Text};{textBoxFIO_FDR.Text};{textBoxSumPeople_FDR.Text};{textBoxFlatArea_FDR.Text};{textBoxSumRoom_FDR.Text};rent";
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

                    MessageBox.Show("Новый житель зарегистрирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                


            }
        }

        private void buttonOpenFile_FDR_Click(object sender, EventArgs e)
        {
            openFileDialogInfoFlat_FDR.ShowDialog();
            string FileName = openFileDialogInfoFlat_FDR.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            dataGridViewInfoFlat_FDR.Rows[0].Cells[0].Value = "Номер подъезда";
            dataGridViewInfoFlat_FDR.Rows[0].Cells[1].Value = "Номер квартиры";
            dataGridViewInfoFlat_FDR.Rows[0].Cells[2].Value = "ФИО покупателя/арендатора";
            dataGridViewInfoFlat_FDR.Rows[0].Cells[3].Value = "Кол-во заселяющихся";
            dataGridViewInfoFlat_FDR.Rows[0].Cells[4].Value = "Квадратура";
            dataGridViewInfoFlat_FDR.Rows[0].Cells[5].Value = "Кол-во комнат";
            dataGridViewInfoFlat_FDR.Rows[0].Cells[6].Value = "покупка/съем";

            for (int r = 1; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInfoFlat_FDR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }



        }

        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
