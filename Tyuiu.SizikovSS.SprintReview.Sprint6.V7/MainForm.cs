using System.Drawing.Drawing2D;
using Tyuiu.SizikovSS.SprintReview.Sprint6.V7.Lib;

namespace Tyuiu.SizikovSS.SprintReview.Sprint6.V7
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        private int[,] matrix;
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Generate_SSS_Click(object sender, EventArgs e)
        {       //�������� �� ������������ �����
            if (!int.TryParse(textBox_NValue_SSS.Text, out int N) || N <= 1 ||
                !int.TryParse(textBox_MValue_SSS.Text, out int M) || M <= 1 ||
                !int.TryParse(textBox_StartValue_SSS.Text, out int n1) ||
                !int.TryParse(textBox_StopValue_SSS.Text, out int n2) || n1 >= n2)
            {
                MessageBox.Show("������������ ���� ������. ���������, ��� ���������� ����� � �������� ������ 1 � ��������� �������� ������ ���������.", "������");
                return;
            }
            matrix = ds.GenMatrix(N, M, n1, n2);

            int rows = matrix.GetUpperBound(0) + 1; //���������� �����
            int columns = matrix.Length / rows; //���������� ��������

            dataGridView_SSS.Rows.Clear();
            dataGridView_SSS.Columns.Clear();

            dataGridView_SSS.RowCount = rows;
            dataGridView_SSS.ColumnCount = columns;

            dataGridView_SSS.Refresh();

            //dataGridView ��������� �������� �������
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i < dataGridView_SSS.Rows.Count && j < dataGridView_SSS.Columns.Count)
                    {
                        dataGridView_SSS.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                    }
                }
            }
            //�������������� ������ �����
            foreach (DataGridViewColumn column in dataGridView_SSS.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_SSS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void textBoxStartValue_SSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Convert_SSS_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("������ �� ������������", "������");
                return;
            }

            if (!int.TryParse(textBox_CValue_SSS.Text, out int c) || c < 0 || c >= matrix.GetLength(0) ||
                !int.TryParse(textBox_KValue_SSS.Text, out int k) || k < 0 ||
                !int.TryParse(textBox_LValue_SSS.Text, out int l) || l < k || l >= matrix.GetLength(1))
            {
                MessageBox.Show("������������ ���� ������. ���������, ��� ����� ������� ������������� � ����� ��������� ������ ������, ��� ����� �������� ������", "������");
                return;
            }
            int count = ds.GetMatrix(matrix, c, k, l);
            textBox_ResValue_SSS.Text = Convert.ToString(count);
        }

        private void button_Info_SSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ����� 6 ������� 7 �������� ������� ���� ��� ������ ����-24-1 ������� ���� �������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
