
namespace Tyuiu.FaizullinDR.Sprint7.Project.V7
{
    partial class FormMain_FDR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_FDR));
            this.groupBoxInfoFlat_FDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInfoFlat_FDR = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_FDR = new System.Windows.Forms.Button();
            this.groupBoxReg_FDR = new System.Windows.Forms.GroupBox();
            this.labelBuyOrRent_FDR = new System.Windows.Forms.Label();
            this.buttonSaveFile_FDR = new System.Windows.Forms.Button();
            this.labelSumRoom_FDR = new System.Windows.Forms.Label();
            this.labelFlatArea_FDR = new System.Windows.Forms.Label();
            this.labelSumPeople_FDR = new System.Windows.Forms.Label();
            this.labelAddFlat_FDR = new System.Windows.Forms.Label();
            this.labelAddEntrance_FDR = new System.Windows.Forms.Label();
            this.labelFIO_FDR = new System.Windows.Forms.Label();
            this.radioButtonRent_FDR = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy_FDR = new System.Windows.Forms.RadioButton();
            this.textBoxSumPeople_FDR = new System.Windows.Forms.TextBox();
            this.textBoxFlatArea_FDR = new System.Windows.Forms.TextBox();
            this.textBoxSumRoom_FDR = new System.Windows.Forms.TextBox();
            this.textBoxAddEntrance_FDR = new System.Windows.Forms.TextBox();
            this.textBoxAddFlat_FDR = new System.Windows.Forms.TextBox();
            this.textBoxFIO_FDR = new System.Windows.Forms.TextBox();
            this.buttonInfo_FDR = new System.Windows.Forms.Button();
            this.openFileDialogInfoFlat_FDR = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxEvection_FDR = new System.Windows.Forms.GroupBox();
            this.buttonDeletePeople_FDR = new System.Windows.Forms.Button();
            this.labelDeleteEntrance_FDR = new System.Windows.Forms.Label();
            this.labelDeleteFlat_FDR = new System.Windows.Forms.Label();
            this.textBoxDeleteFlat_FDR = new System.Windows.Forms.TextBox();
            this.textBoxDeleteEntrance_FDR = new System.Windows.Forms.TextBox();
            this.saveFileDialogInfoFlat_FDR = new System.Windows.Forms.SaveFileDialog();
            this.buttonQuickGuide_FDR = new System.Windows.Forms.Button();
            this.buttonStatistic_FDR = new System.Windows.Forms.Button();
            this.toolTipHelp_FDR = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInfoFlat_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoFlat_FDR)).BeginInit();
            this.groupBoxReg_FDR.SuspendLayout();
            this.groupBoxEvection_FDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfoFlat_FDR
            // 
            this.groupBoxInfoFlat_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfoFlat_FDR.Controls.Add(this.dataGridViewInfoFlat_FDR);
            this.groupBoxInfoFlat_FDR.Location = new System.Drawing.Point(12, 103);
            this.groupBoxInfoFlat_FDR.Name = "groupBoxInfoFlat_FDR";
            this.groupBoxInfoFlat_FDR.Size = new System.Drawing.Size(570, 548);
            this.groupBoxInfoFlat_FDR.TabIndex = 0;
            this.groupBoxInfoFlat_FDR.TabStop = false;
            this.groupBoxInfoFlat_FDR.Text = "Информация о квартирах:";
            // 
            // dataGridViewInfoFlat_FDR
            // 
            this.dataGridViewInfoFlat_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfoFlat_FDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoFlat_FDR.ColumnHeadersVisible = false;
            this.dataGridViewInfoFlat_FDR.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewInfoFlat_FDR.Name = "dataGridViewInfoFlat_FDR";
            this.dataGridViewInfoFlat_FDR.RowHeadersVisible = false;
            this.dataGridViewInfoFlat_FDR.RowHeadersWidth = 51;
            this.dataGridViewInfoFlat_FDR.RowTemplate.Height = 24;
            this.dataGridViewInfoFlat_FDR.Size = new System.Drawing.Size(558, 521);
            this.dataGridViewInfoFlat_FDR.TabIndex = 0;
            // 
            // buttonOpenFile_FDR
            // 
            this.buttonOpenFile_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_FDR.Image")));
            this.buttonOpenFile_FDR.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_FDR.Name = "buttonOpenFile_FDR";
            this.buttonOpenFile_FDR.Size = new System.Drawing.Size(570, 73);
            this.buttonOpenFile_FDR.TabIndex = 0;
            this.toolTipHelp_FDR.SetToolTip(this.buttonOpenFile_FDR, "Загрузить базу данных дома");
            this.buttonOpenFile_FDR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_FDR.Click += new System.EventHandler(this.buttonOpenFile_FDR_Click);
            // 
            // groupBoxReg_FDR
            // 
            this.groupBoxReg_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReg_FDR.Controls.Add(this.labelBuyOrRent_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.buttonSaveFile_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.labelSumRoom_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.labelFlatArea_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.labelSumPeople_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.labelAddFlat_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.labelAddEntrance_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.labelFIO_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.radioButtonRent_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.radioButtonBuy_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.textBoxSumPeople_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.textBoxFlatArea_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.textBoxSumRoom_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.textBoxAddEntrance_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.textBoxAddFlat_FDR);
            this.groupBoxReg_FDR.Controls.Add(this.textBoxFIO_FDR);
            this.groupBoxReg_FDR.Location = new System.Drawing.Point(621, 103);
            this.groupBoxReg_FDR.Name = "groupBoxReg_FDR";
            this.groupBoxReg_FDR.Size = new System.Drawing.Size(709, 262);
            this.groupBoxReg_FDR.TabIndex = 1;
            this.groupBoxReg_FDR.TabStop = false;
            this.groupBoxReg_FDR.Text = "Регистрация новых жильцов:";
            // 
            // labelBuyOrRent_FDR
            // 
            this.labelBuyOrRent_FDR.AutoSize = true;
            this.labelBuyOrRent_FDR.Location = new System.Drawing.Point(6, 126);
            this.labelBuyOrRent_FDR.Name = "labelBuyOrRent_FDR";
            this.labelBuyOrRent_FDR.Size = new System.Drawing.Size(119, 17);
            this.labelBuyOrRent_FDR.TabIndex = 14;
            this.labelBuyOrRent_FDR.Text = "Покупка/аренда:";
            // 
            // buttonSaveFile_FDR
            // 
            this.buttonSaveFile_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_FDR.Image")));
            this.buttonSaveFile_FDR.Location = new System.Drawing.Point(582, 126);
            this.buttonSaveFile_FDR.Name = "buttonSaveFile_FDR";
            this.buttonSaveFile_FDR.Size = new System.Drawing.Size(121, 73);
            this.buttonSaveFile_FDR.TabIndex = 2;
            this.toolTipHelp_FDR.SetToolTip(this.buttonSaveFile_FDR, "Зарегистрировать нового жильца");
            this.buttonSaveFile_FDR.UseVisualStyleBackColor = true;
            this.buttonSaveFile_FDR.Click += new System.EventHandler(this.buttonSaveFile_FDR_Click);
            // 
            // labelSumRoom_FDR
            // 
            this.labelSumRoom_FDR.AutoSize = true;
            this.labelSumRoom_FDR.Location = new System.Drawing.Point(477, 64);
            this.labelSumRoom_FDR.Name = "labelSumRoom_FDR";
            this.labelSumRoom_FDR.Size = new System.Drawing.Size(108, 17);
            this.labelSumRoom_FDR.TabIndex = 13;
            this.labelSumRoom_FDR.Text = "Кол-во комнат:";
            // 
            // labelFlatArea_FDR
            // 
            this.labelFlatArea_FDR.AutoSize = true;
            this.labelFlatArea_FDR.Location = new System.Drawing.Point(250, 64);
            this.labelFlatArea_FDR.Name = "labelFlatArea_FDR";
            this.labelFlatArea_FDR.Size = new System.Drawing.Size(124, 17);
            this.labelFlatArea_FDR.TabIndex = 12;
            this.labelFlatArea_FDR.Text = "Квадратура(м^2):";
            // 
            // labelSumPeople_FDR
            // 
            this.labelSumPeople_FDR.AutoSize = true;
            this.labelSumPeople_FDR.Location = new System.Drawing.Point(6, 64);
            this.labelSumPeople_FDR.Name = "labelSumPeople_FDR";
            this.labelSumPeople_FDR.Size = new System.Drawing.Size(157, 17);
            this.labelSumPeople_FDR.TabIndex = 11;
            this.labelSumPeople_FDR.Text = "Кол-во заселяющихся:";
            // 
            // labelAddFlat_FDR
            // 
            this.labelAddFlat_FDR.AutoSize = true;
            this.labelAddFlat_FDR.Location = new System.Drawing.Point(477, 21);
            this.labelAddFlat_FDR.Name = "labelAddFlat_FDR";
            this.labelAddFlat_FDR.Size = new System.Drawing.Size(122, 17);
            this.labelAddFlat_FDR.TabIndex = 10;
            this.labelAddFlat_FDR.Text = "Номер квартиры:";
            // 
            // labelAddEntrance_FDR
            // 
            this.labelAddEntrance_FDR.AutoSize = true;
            this.labelAddEntrance_FDR.Location = new System.Drawing.Point(250, 21);
            this.labelAddEntrance_FDR.Name = "labelAddEntrance_FDR";
            this.labelAddEntrance_FDR.Size = new System.Drawing.Size(123, 17);
            this.labelAddEntrance_FDR.TabIndex = 9;
            this.labelAddEntrance_FDR.Text = "Номер подъезда:";
            // 
            // labelFIO_FDR
            // 
            this.labelFIO_FDR.AutoSize = true;
            this.labelFIO_FDR.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelFIO_FDR.Location = new System.Drawing.Point(6, 21);
            this.labelFIO_FDR.Name = "labelFIO_FDR";
            this.labelFIO_FDR.Size = new System.Drawing.Size(153, 17);
            this.labelFIO_FDR.TabIndex = 8;
            this.labelFIO_FDR.Text = "ФИО заселяющегося:";
            // 
            // radioButtonRent_FDR
            // 
            this.radioButtonRent_FDR.AutoSize = true;
            this.radioButtonRent_FDR.Location = new System.Drawing.Point(9, 171);
            this.radioButtonRent_FDR.Name = "radioButtonRent_FDR";
            this.radioButtonRent_FDR.Size = new System.Drawing.Size(77, 21);
            this.radioButtonRent_FDR.TabIndex = 7;
            this.radioButtonRent_FDR.TabStop = true;
            this.radioButtonRent_FDR.Text = "аренда";
            this.radioButtonRent_FDR.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuy_FDR
            // 
            this.radioButtonBuy_FDR.AutoSize = true;
            this.radioButtonBuy_FDR.Location = new System.Drawing.Point(9, 144);
            this.radioButtonBuy_FDR.Name = "radioButtonBuy_FDR";
            this.radioButtonBuy_FDR.Size = new System.Drawing.Size(82, 21);
            this.radioButtonBuy_FDR.TabIndex = 6;
            this.radioButtonBuy_FDR.TabStop = true;
            this.radioButtonBuy_FDR.Text = "покупка";
            this.radioButtonBuy_FDR.UseVisualStyleBackColor = true;
            // 
            // textBoxSumPeople_FDR
            // 
            this.textBoxSumPeople_FDR.Location = new System.Drawing.Point(6, 84);
            this.textBoxSumPeople_FDR.Name = "textBoxSumPeople_FDR";
            this.textBoxSumPeople_FDR.Size = new System.Drawing.Size(238, 22);
            this.textBoxSumPeople_FDR.TabIndex = 5;
            // 
            // textBoxFlatArea_FDR
            // 
            this.textBoxFlatArea_FDR.Location = new System.Drawing.Point(250, 84);
            this.textBoxFlatArea_FDR.Name = "textBoxFlatArea_FDR";
            this.textBoxFlatArea_FDR.Size = new System.Drawing.Size(221, 22);
            this.textBoxFlatArea_FDR.TabIndex = 4;
            // 
            // textBoxSumRoom_FDR
            // 
            this.textBoxSumRoom_FDR.Location = new System.Drawing.Point(477, 84);
            this.textBoxSumRoom_FDR.Name = "textBoxSumRoom_FDR";
            this.textBoxSumRoom_FDR.Size = new System.Drawing.Size(122, 22);
            this.textBoxSumRoom_FDR.TabIndex = 3;
            // 
            // textBoxAddEntrance_FDR
            // 
            this.textBoxAddEntrance_FDR.Location = new System.Drawing.Point(250, 39);
            this.textBoxAddEntrance_FDR.Name = "textBoxAddEntrance_FDR";
            this.textBoxAddEntrance_FDR.Size = new System.Drawing.Size(221, 22);
            this.textBoxAddEntrance_FDR.TabIndex = 2;
            // 
            // textBoxAddFlat_FDR
            // 
            this.textBoxAddFlat_FDR.Location = new System.Drawing.Point(477, 39);
            this.textBoxAddFlat_FDR.Name = "textBoxAddFlat_FDR";
            this.textBoxAddFlat_FDR.Size = new System.Drawing.Size(122, 22);
            this.textBoxAddFlat_FDR.TabIndex = 1;
            // 
            // textBoxFIO_FDR
            // 
            this.textBoxFIO_FDR.Location = new System.Drawing.Point(6, 39);
            this.textBoxFIO_FDR.Name = "textBoxFIO_FDR";
            this.textBoxFIO_FDR.Size = new System.Drawing.Size(238, 22);
            this.textBoxFIO_FDR.TabIndex = 0;
            // 
            // buttonInfo_FDR
            // 
            this.buttonInfo_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_FDR.Image")));
            this.buttonInfo_FDR.Location = new System.Drawing.Point(1203, 12);
            this.buttonInfo_FDR.Name = "buttonInfo_FDR";
            this.buttonInfo_FDR.Size = new System.Drawing.Size(121, 73);
            this.buttonInfo_FDR.TabIndex = 3;
            this.toolTipHelp_FDR.SetToolTip(this.buttonInfo_FDR, "Справка");
            this.buttonInfo_FDR.UseVisualStyleBackColor = true;
            this.buttonInfo_FDR.Click += new System.EventHandler(this.buttonInfo_FDR_Click);
            // 
            // openFileDialogInfoFlat_FDR
            // 
            this.openFileDialogInfoFlat_FDR.FileName = "openFileDialog1";
            // 
            // groupBoxEvection_FDR
            // 
            this.groupBoxEvection_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEvection_FDR.Controls.Add(this.buttonDeletePeople_FDR);
            this.groupBoxEvection_FDR.Controls.Add(this.labelDeleteEntrance_FDR);
            this.groupBoxEvection_FDR.Controls.Add(this.labelDeleteFlat_FDR);
            this.groupBoxEvection_FDR.Controls.Add(this.textBoxDeleteFlat_FDR);
            this.groupBoxEvection_FDR.Controls.Add(this.textBoxDeleteEntrance_FDR);
            this.groupBoxEvection_FDR.Location = new System.Drawing.Point(621, 371);
            this.groupBoxEvection_FDR.Name = "groupBoxEvection_FDR";
            this.groupBoxEvection_FDR.Size = new System.Drawing.Size(709, 280);
            this.groupBoxEvection_FDR.TabIndex = 5;
            this.groupBoxEvection_FDR.TabStop = false;
            this.groupBoxEvection_FDR.Text = "Выселение жильцов:";
            // 
            // buttonDeletePeople_FDR
            // 
            this.buttonDeletePeople_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePeople_FDR.Image")));
            this.buttonDeletePeople_FDR.Location = new System.Drawing.Point(582, 14);
            this.buttonDeletePeople_FDR.Name = "buttonDeletePeople_FDR";
            this.buttonDeletePeople_FDR.Size = new System.Drawing.Size(121, 73);
            this.buttonDeletePeople_FDR.TabIndex = 11;
            this.toolTipHelp_FDR.SetToolTip(this.buttonDeletePeople_FDR, "Выселить жильца");
            this.buttonDeletePeople_FDR.UseVisualStyleBackColor = true;
            this.buttonDeletePeople_FDR.Click += new System.EventHandler(this.buttonDeletePeople_FDR_Click);
            // 
            // labelDeleteEntrance_FDR
            // 
            this.labelDeleteEntrance_FDR.AutoSize = true;
            this.labelDeleteEntrance_FDR.Location = new System.Drawing.Point(322, 18);
            this.labelDeleteEntrance_FDR.Name = "labelDeleteEntrance_FDR";
            this.labelDeleteEntrance_FDR.Size = new System.Drawing.Size(123, 17);
            this.labelDeleteEntrance_FDR.TabIndex = 10;
            this.labelDeleteEntrance_FDR.Text = "Номер подъезда:";
            // 
            // labelDeleteFlat_FDR
            // 
            this.labelDeleteFlat_FDR.AutoSize = true;
            this.labelDeleteFlat_FDR.Location = new System.Drawing.Point(6, 19);
            this.labelDeleteFlat_FDR.Name = "labelDeleteFlat_FDR";
            this.labelDeleteFlat_FDR.Size = new System.Drawing.Size(268, 17);
            this.labelDeleteFlat_FDR.TabIndex = 9;
            this.labelDeleteFlat_FDR.Text = "Номер квартиры из которой выселяют:";
            // 
            // textBoxDeleteFlat_FDR
            // 
            this.textBoxDeleteFlat_FDR.Location = new System.Drawing.Point(6, 39);
            this.textBoxDeleteFlat_FDR.Name = "textBoxDeleteFlat_FDR";
            this.textBoxDeleteFlat_FDR.Size = new System.Drawing.Size(268, 22);
            this.textBoxDeleteFlat_FDR.TabIndex = 2;
            // 
            // textBoxDeleteEntrance_FDR
            // 
            this.textBoxDeleteEntrance_FDR.Location = new System.Drawing.Point(322, 38);
            this.textBoxDeleteEntrance_FDR.Name = "textBoxDeleteEntrance_FDR";
            this.textBoxDeleteEntrance_FDR.Size = new System.Drawing.Size(122, 22);
            this.textBoxDeleteEntrance_FDR.TabIndex = 1;
            // 
            // buttonQuickGuide_FDR
            // 
            this.buttonQuickGuide_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuickGuide_FDR.Location = new System.Drawing.Point(1076, 12);
            this.buttonQuickGuide_FDR.Name = "buttonQuickGuide_FDR";
            this.buttonQuickGuide_FDR.Size = new System.Drawing.Size(121, 73);
            this.buttonQuickGuide_FDR.TabIndex = 6;
            this.buttonQuickGuide_FDR.Text = "Руководство пользователя";
            this.buttonQuickGuide_FDR.UseVisualStyleBackColor = true;
            // 
            // buttonStatistic_FDR
            // 
            this.buttonStatistic_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStatistic_FDR.Location = new System.Drawing.Point(621, 12);
            this.buttonStatistic_FDR.Name = "buttonStatistic_FDR";
            this.buttonStatistic_FDR.Size = new System.Drawing.Size(121, 73);
            this.buttonStatistic_FDR.TabIndex = 7;
            this.buttonStatistic_FDR.Text = "Общая информация";
            this.toolTipHelp_FDR.SetToolTip(this.buttonStatistic_FDR, "Графики с информацией о доме");
            this.buttonStatistic_FDR.UseVisualStyleBackColor = true;
            this.buttonStatistic_FDR.Click += new System.EventHandler(this.buttonStatistic_FDR_Click);
            // 
            // toolTipHelp_FDR
            // 
            this.toolTipHelp_FDR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_FDR.ToolTipTitle = "Подсказка";
            // 
            // FormMain_FDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 663);
            this.Controls.Add(this.buttonStatistic_FDR);
            this.Controls.Add(this.buttonQuickGuide_FDR);
            this.Controls.Add(this.groupBoxEvection_FDR);
            this.Controls.Add(this.buttonInfo_FDR);
            this.Controls.Add(this.groupBoxReg_FDR);
            this.Controls.Add(this.buttonOpenFile_FDR);
            this.Controls.Add(this.groupBoxInfoFlat_FDR);
            this.Name = "FormMain_FDR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домоуправление";
            this.groupBoxInfoFlat_FDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoFlat_FDR)).EndInit();
            this.groupBoxReg_FDR.ResumeLayout(false);
            this.groupBoxReg_FDR.PerformLayout();
            this.groupBoxEvection_FDR.ResumeLayout(false);
            this.groupBoxEvection_FDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfoFlat_FDR;
        private System.Windows.Forms.DataGridView dataGridViewInfoFlat_FDR;
        private System.Windows.Forms.Button buttonOpenFile_FDR;
        private System.Windows.Forms.GroupBox groupBoxReg_FDR;
        private System.Windows.Forms.RadioButton radioButtonBuy_FDR;
        private System.Windows.Forms.TextBox textBoxSumPeople_FDR;
        private System.Windows.Forms.TextBox textBoxFlatArea_FDR;
        private System.Windows.Forms.TextBox textBoxSumRoom_FDR;
        private System.Windows.Forms.TextBox textBoxAddEntrance_FDR;
        private System.Windows.Forms.TextBox textBoxAddFlat_FDR;
        private System.Windows.Forms.TextBox textBoxFIO_FDR;
        private System.Windows.Forms.RadioButton radioButtonRent_FDR;
        private System.Windows.Forms.Label labelBuyOrRent_FDR;
        private System.Windows.Forms.Button buttonSaveFile_FDR;
        private System.Windows.Forms.Label labelSumRoom_FDR;
        private System.Windows.Forms.Label labelFlatArea_FDR;
        private System.Windows.Forms.Label labelSumPeople_FDR;
        private System.Windows.Forms.Label labelAddFlat_FDR;
        private System.Windows.Forms.Label labelAddEntrance_FDR;
        private System.Windows.Forms.Label labelFIO_FDR;
        private System.Windows.Forms.Button buttonInfo_FDR;
        private System.Windows.Forms.OpenFileDialog openFileDialogInfoFlat_FDR;
        private System.Windows.Forms.GroupBox groupBoxEvection_FDR;
        private System.Windows.Forms.Label labelDeleteEntrance_FDR;
        private System.Windows.Forms.Label labelDeleteFlat_FDR;
        private System.Windows.Forms.TextBox textBoxDeleteFlat_FDR;
        private System.Windows.Forms.TextBox textBoxDeleteEntrance_FDR;
        private System.Windows.Forms.Button buttonDeletePeople_FDR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogInfoFlat_FDR;
        private System.Windows.Forms.Button buttonQuickGuide_FDR;
        private System.Windows.Forms.Button buttonStatistic_FDR;
        private System.Windows.Forms.ToolTip toolTipHelp_FDR;
    }
}

