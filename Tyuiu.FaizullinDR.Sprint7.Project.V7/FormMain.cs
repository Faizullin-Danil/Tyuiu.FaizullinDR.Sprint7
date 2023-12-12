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
                dataGridViewInfoFlat_FDR.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_FDR_Click(object sender, EventArgs e)
        {
            if ((textBoxFIO_FDR.Text == "")||(textBoxEntrance_FDR.Text == "")||(textBoxFlatArea_FDR.Text == "")||(textBoxFlat_FDR.Text == "")||(textBoxSumPeople_FDR.Text == "")||(textBoxSumRoom_FDR.Text == "")||((radioButtonBuy_FDR.Checked == false)&&(radioButtonRent_FDR.Checked == false)))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //saveFileDialogNewCitizen_FDR.FileName = "Домоуправление.csv";
                //saveFileDialogNewCitizen_FDR.InitialDirectory = Directory.GetCurrentDirectory();
                //saveFileDialogNewCitizen_FDR.ShowDialog();

                string path = @"C:\Project\Домоуправление.csv";
                string str = "";

                /*FileInfo fileInfo = new FileInfo(path);
                bool fileExist = fileInfo.Exists;
                if (fileExist)
                    File.Delete(path);*/


                for (int i = 0; i < 7; i++)
                {
                    if (radioButtonBuy_FDR.Checked == true)
                        str = $"{textBoxEntrance_FDR.Text};{textBoxFlat_FDR.Text};{textBoxFIO_FDR.Text};{textBoxSumPeople_FDR.Text};{textBoxFlatArea_FDR.Text};{textBoxSumRoom_FDR.Text};buy";
                    else
                        str = $"{textBoxEntrance_FDR.Text};{textBoxFlat_FDR.Text};{textBoxFIO_FDR.Text};{textBoxSumPeople_FDR.Text};{textBoxFlatArea_FDR.Text};{textBoxSumRoom_FDR.Text};rent";
                }
                File.AppendAllText(path, str + "\n");

                textBoxFIO_FDR.Text = "";
                textBoxEntrance_FDR.Text = "";
                textBoxFlatArea_FDR.Text = "";
                textBoxFlat_FDR.Text = "";
                textBoxSumPeople_FDR.Text = "";
                textBoxSumRoom_FDR.Text = "";
                radioButtonBuy_FDR.Checked = false;
                radioButtonRent_FDR.Checked = false;

                MessageBox.Show("Новый житель зарегистрирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
         

        }
    }
}
