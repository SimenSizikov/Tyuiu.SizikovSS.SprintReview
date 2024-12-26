namespace Tyuiu.SizikovSS.SprintReview.Sprint6.V7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_SSS = new DataGridView();
            groupBox_GenMassive_SSS = new GroupBox();
            button_Generate_SSS = new Button();
            textBox_StopValue_SSS = new TextBox();
            textBox_StartValue_SSS = new TextBox();
            textBox5 = new TextBox();
            textBox_Start = new TextBox();
            textBox_MValue_SSS = new TextBox();
            textBox_NValue_SSS = new TextBox();
            textBox_M_SSS = new TextBox();
            textBox_N_SSS = new TextBox();
            groupBox_Convert_SSS = new GroupBox();
            button_Info_SSS = new Button();
            textBox_Res_SSS = new TextBox();
            textBox_ResValue_SSS = new TextBox();
            button_Convert_SSS = new Button();
            textBox_L_SSS = new TextBox();
            textBox_K_SSS = new TextBox();
            textBox_C_SSS = new TextBox();
            textBox_CValue_SSS = new TextBox();
            textBox_LValue_SSS = new TextBox();
            textBox_KValue_SSS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SSS).BeginInit();
            groupBox_GenMassive_SSS.SuspendLayout();
            groupBox_Convert_SSS.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_SSS
            // 
            dataGridView_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SSS.Location = new Point(483, 12);
            dataGridView_SSS.Name = "dataGridView_SSS";
            dataGridView_SSS.RowHeadersWidth = 51;
            dataGridView_SSS.Size = new Size(538, 614);
            dataGridView_SSS.TabIndex = 0;
            // 
            // groupBox_GenMassive_SSS
            // 
            groupBox_GenMassive_SSS.Controls.Add(button_Generate_SSS);
            groupBox_GenMassive_SSS.Controls.Add(textBox_StopValue_SSS);
            groupBox_GenMassive_SSS.Controls.Add(textBox_StartValue_SSS);
            groupBox_GenMassive_SSS.Controls.Add(textBox5);
            groupBox_GenMassive_SSS.Controls.Add(textBox_Start);
            groupBox_GenMassive_SSS.Controls.Add(textBox_MValue_SSS);
            groupBox_GenMassive_SSS.Controls.Add(textBox_NValue_SSS);
            groupBox_GenMassive_SSS.Controls.Add(textBox_M_SSS);
            groupBox_GenMassive_SSS.Controls.Add(textBox_N_SSS);
            groupBox_GenMassive_SSS.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_GenMassive_SSS.Location = new Point(1, 12);
            groupBox_GenMassive_SSS.Name = "groupBox_GenMassive_SSS";
            groupBox_GenMassive_SSS.Size = new Size(476, 306);
            groupBox_GenMassive_SSS.TabIndex = 1;
            groupBox_GenMassive_SSS.TabStop = false;
            groupBox_GenMassive_SSS.Text = "Генерация массива";
            // 
            // button_Generate_SSS
            // 
            button_Generate_SSS.BackColor = Color.FromArgb(192, 255, 192);
            button_Generate_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Generate_SSS.Location = new Point(6, 208);
            button_Generate_SSS.Name = "button_Generate_SSS";
            button_Generate_SSS.Size = new Size(464, 51);
            button_Generate_SSS.TabIndex = 10;
            button_Generate_SSS.Text = "Сгенерировать массив";
            button_Generate_SSS.UseVisualStyleBackColor = false;
            button_Generate_SSS.Click += button_Generate_SSS_Click;
            // 
            // textBox_StopValue_SSS
            // 
            textBox_StopValue_SSS.Location = new Point(251, 150);
            textBox_StopValue_SSS.Name = "textBox_StopValue_SSS";
            textBox_StopValue_SSS.Size = new Size(219, 30);
            textBox_StopValue_SSS.TabIndex = 9;
            // 
            // textBox_StartValue_SSS
            // 
            textBox_StartValue_SSS.Location = new Point(6, 150);
            textBox_StartValue_SSS.Name = "textBox_StartValue_SSS";
            textBox_StartValue_SSS.Size = new Size(219, 30);
            textBox_StartValue_SSS.TabIndex = 8;
            textBox_StartValue_SSS.TextChanged += textBoxStartValue_SSS_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(251, 117);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(219, 27);
            textBox5.TabIndex = 7;
            textBox5.Text = "Конечное значение";
            // 
            // textBox_Start
            // 
            textBox_Start.BackColor = SystemColors.Control;
            textBox_Start.BorderStyle = BorderStyle.None;
            textBox_Start.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Start.Location = new Point(6, 117);
            textBox_Start.Name = "textBox_Start";
            textBox_Start.ReadOnly = true;
            textBox_Start.Size = new Size(219, 27);
            textBox_Start.TabIndex = 6;
            textBox_Start.Text = "Начальное значение";
            // 
            // textBox_MValue_SSS
            // 
            textBox_MValue_SSS.Location = new Point(251, 74);
            textBox_MValue_SSS.Name = "textBox_MValue_SSS";
            textBox_MValue_SSS.Size = new Size(219, 30);
            textBox_MValue_SSS.TabIndex = 5;
            // 
            // textBox_NValue_SSS
            // 
            textBox_NValue_SSS.Location = new Point(6, 74);
            textBox_NValue_SSS.Name = "textBox_NValue_SSS";
            textBox_NValue_SSS.Size = new Size(219, 30);
            textBox_NValue_SSS.TabIndex = 4;
            // 
            // textBox_M_SSS
            // 
            textBox_M_SSS.BackColor = SystemColors.Control;
            textBox_M_SSS.BorderStyle = BorderStyle.None;
            textBox_M_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_M_SSS.Location = new Point(251, 41);
            textBox_M_SSS.Name = "textBox_M_SSS";
            textBox_M_SSS.ReadOnly = true;
            textBox_M_SSS.Size = new Size(219, 27);
            textBox_M_SSS.TabIndex = 3;
            textBox_M_SSS.Text = "Количество столбцов:";
            // 
            // textBox_N_SSS
            // 
            textBox_N_SSS.BackColor = SystemColors.Control;
            textBox_N_SSS.BorderStyle = BorderStyle.None;
            textBox_N_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_N_SSS.Location = new Point(6, 41);
            textBox_N_SSS.Name = "textBox_N_SSS";
            textBox_N_SSS.ReadOnly = true;
            textBox_N_SSS.Size = new Size(219, 27);
            textBox_N_SSS.TabIndex = 2;
            textBox_N_SSS.Text = "Количество строк: ";
            // 
            // groupBox_Convert_SSS
            // 
            groupBox_Convert_SSS.Controls.Add(button_Info_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_Res_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_ResValue_SSS);
            groupBox_Convert_SSS.Controls.Add(button_Convert_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_L_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_K_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_C_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_CValue_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_LValue_SSS);
            groupBox_Convert_SSS.Controls.Add(textBox_KValue_SSS);
            groupBox_Convert_SSS.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Convert_SSS.Location = new Point(7, 324);
            groupBox_Convert_SSS.Name = "groupBox_Convert_SSS";
            groupBox_Convert_SSS.Size = new Size(470, 302);
            groupBox_Convert_SSS.TabIndex = 10;
            groupBox_Convert_SSS.TabStop = false;
            groupBox_Convert_SSS.Text = "Обработка массива";
            // 
            // button_Info_SSS
            // 
            button_Info_SSS.BackColor = SystemColors.Info;
            button_Info_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Info_SSS.Location = new Point(325, 166);
            button_Info_SSS.Name = "button_Info_SSS";
            button_Info_SSS.Size = new Size(139, 63);
            button_Info_SSS.TabIndex = 19;
            button_Info_SSS.Text = "Справка";
            button_Info_SSS.UseVisualStyleBackColor = false;
            button_Info_SSS.Click += button_Info_SSS_Click;
            // 
            // textBox_Res_SSS
            // 
            textBox_Res_SSS.BackColor = SystemColors.Control;
            textBox_Res_SSS.BorderStyle = BorderStyle.None;
            textBox_Res_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Res_SSS.Location = new Point(6, 166);
            textBox_Res_SSS.Name = "textBox_Res_SSS";
            textBox_Res_SSS.ReadOnly = true;
            textBox_Res_SSS.Size = new Size(296, 27);
            textBox_Res_SSS.TabIndex = 18;
            textBox_Res_SSS.Text = "Результат обработки\r\n";
            // 
            // textBox_ResValue_SSS
            // 
            textBox_ResValue_SSS.BackColor = SystemColors.InactiveBorder;
            textBox_ResValue_SSS.Location = new Point(6, 199);
            textBox_ResValue_SSS.Name = "textBox_ResValue_SSS";
            textBox_ResValue_SSS.ReadOnly = true;
            textBox_ResValue_SSS.Size = new Size(296, 30);
            textBox_ResValue_SSS.TabIndex = 17;
            // 
            // button_Convert_SSS
            // 
            button_Convert_SSS.BackColor = SystemColors.ActiveCaption;
            button_Convert_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Convert_SSS.Location = new Point(6, 244);
            button_Convert_SSS.Name = "button_Convert_SSS";
            button_Convert_SSS.Size = new Size(458, 51);
            button_Convert_SSS.TabIndex = 16;
            button_Convert_SSS.Text = "Обработать массив";
            button_Convert_SSS.UseVisualStyleBackColor = false;
            button_Convert_SSS.Click += button_Convert_SSS_Click;
            // 
            // textBox_L_SSS
            // 
            textBox_L_SSS.BackColor = SystemColors.Control;
            textBox_L_SSS.BorderStyle = BorderStyle.None;
            textBox_L_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_L_SSS.Location = new Point(332, 41);
            textBox_L_SSS.Multiline = true;
            textBox_L_SSS.Name = "textBox_L_SSS";
            textBox_L_SSS.ReadOnly = true;
            textBox_L_SSS.Size = new Size(132, 55);
            textBox_L_SSS.TabIndex = 15;
            textBox_L_SSS.Text = "Конечная строка";
            textBox_L_SSS.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_K_SSS
            // 
            textBox_K_SSS.BackColor = SystemColors.Control;
            textBox_K_SSS.BorderStyle = BorderStyle.None;
            textBox_K_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_K_SSS.Location = new Point(170, 41);
            textBox_K_SSS.Multiline = true;
            textBox_K_SSS.Name = "textBox_K_SSS";
            textBox_K_SSS.ReadOnly = true;
            textBox_K_SSS.Size = new Size(132, 55);
            textBox_K_SSS.TabIndex = 14;
            textBox_K_SSS.Text = "Начальная строка";
            textBox_K_SSS.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_C_SSS
            // 
            textBox_C_SSS.BackColor = SystemColors.Control;
            textBox_C_SSS.BorderStyle = BorderStyle.None;
            textBox_C_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_C_SSS.Location = new Point(6, 41);
            textBox_C_SSS.Multiline = true;
            textBox_C_SSS.Name = "textBox_C_SSS";
            textBox_C_SSS.ReadOnly = true;
            textBox_C_SSS.Size = new Size(132, 55);
            textBox_C_SSS.TabIndex = 13;
            textBox_C_SSS.Text = "Номер столбца";
            textBox_C_SSS.TextAlign = HorizontalAlignment.Center;
            textBox_C_SSS.TextChanged += textBox2_TextChanged;
            // 
            // textBox_CValue_SSS
            // 
            textBox_CValue_SSS.Location = new Point(6, 102);
            textBox_CValue_SSS.Name = "textBox_CValue_SSS";
            textBox_CValue_SSS.Size = new Size(132, 30);
            textBox_CValue_SSS.TabIndex = 12;
            // 
            // textBox_LValue_SSS
            // 
            textBox_LValue_SSS.Location = new Point(332, 102);
            textBox_LValue_SSS.Name = "textBox_LValue_SSS";
            textBox_LValue_SSS.Size = new Size(132, 30);
            textBox_LValue_SSS.TabIndex = 11;
            // 
            // textBox_KValue_SSS
            // 
            textBox_KValue_SSS.Location = new Point(170, 102);
            textBox_KValue_SSS.Name = "textBox_KValue_SSS";
            textBox_KValue_SSS.Size = new Size(132, 30);
            textBox_KValue_SSS.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 638);
            Controls.Add(groupBox_Convert_SSS);
            Controls.Add(groupBox_GenMassive_SSS);
            Controls.Add(dataGridView_SSS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт Ревью 6 | Вариант 7 | РППб-24-1 |  Сизиков С. С.";
            ((System.ComponentModel.ISupportInitialize)dataGridView_SSS).EndInit();
            groupBox_GenMassive_SSS.ResumeLayout(false);
            groupBox_GenMassive_SSS.PerformLayout();
            groupBox_Convert_SSS.ResumeLayout(false);
            groupBox_Convert_SSS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_SSS;
        private GroupBox groupBox_GenMassive_SSS;
        private TextBox textBox_MValue_SSS;
        private TextBox textBox_NValue_SSS;
        private TextBox textBox_M_SSS;
        private TextBox textBox_N_SSS;
        private TextBox textBox_StopValue_SSS;
        private TextBox textBox_StartValue_SSS;
        private TextBox textBox5;
        private TextBox textBox_Start;
        private GroupBox groupBox_Convert_SSS;
        private Button button_Generate_SSS;
        private TextBox textBox_LValue_SSS;
        private TextBox textBox_KValue_SSS;
        private TextBox textBox_C_SSS;
        private TextBox textBox_CValue_SSS;
        private TextBox textBox_L_SSS;
        private TextBox textBox_K_SSS;
        private Button button_Convert_SSS;
        private TextBox textBox_Res_SSS;
        private TextBox textBox_ResValue_SSS;
        private Button button_Info_SSS;
    }
}
