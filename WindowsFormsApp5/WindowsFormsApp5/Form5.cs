using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private int currentRow = 0;
        private string connectionString = "Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM gruzy";
                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "gruzy");

                DisplayData(currentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DisplayData(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataSet.Tables["gruzy"].Rows.Count)
            {
                DataRow row = dataSet.Tables["gruzy"].Rows[rowIndex];

                string column1Value = row["ID_груза"].ToString();
                string column2Value = row["ID_заказчика"].ToString();
                string column3Value = row["Название_груза"].ToString();
                string column4Value = row["Высота"].ToString();
                string column5Value = row["Вес"].ToString();
                string column6Value = row["Ширина"].ToString();

                // Отображение данных
                label1.Text = column1Value;
                label2.Text = column2Value;
                label3.Text = column3Value;
                label4.Text = column4Value;
                label5.Text = column5Value;
                label6.Text = column6Value;
            }
        }

        // Методы для листания между записями

        private void button1_Click(object sender, EventArgs e)
        {
            currentRow++;
            if (currentRow >= dataSet.Tables["gruzy"].Rows.Count)
                currentRow = 0;
            DisplayData(currentRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentRow--;
            if (currentRow < 0)
                currentRow = dataSet.Tables["gruzy"].Rows.Count - 1;
            DisplayData(currentRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}