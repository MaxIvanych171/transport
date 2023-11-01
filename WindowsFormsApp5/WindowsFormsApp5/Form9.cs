using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form9 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private int currentRow = 0;
        private string connectionString = "Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True";

        public Form9()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM zakazchik";
                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "zakazchik");

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
            if (rowIndex >= 0 && rowIndex < dataSet.Tables["zakazchik"].Rows.Count)
            {
                DataRow row = dataSet.Tables["zakazchik"].Rows[rowIndex];

                string column1Value = row["ID_заказчика"].ToString();
                string column2Value = row["Ответственное_лицо"].ToString();
                string column3Value = row["Название_компании"].ToString();
                string column4Value = row["Телефон"].ToString();
                string column5Value = row["Адрес"].ToString();

                // Отображение данных
                label1.Text = column1Value;
                label2.Text = column2Value;
                label3.Text = column3Value;
                label4.Text = column4Value;
                label5.Text = column5Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentRow++;
            if (currentRow >= dataSet.Tables["zakazchik"].Rows.Count)
                currentRow = 0;
            DisplayData(currentRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentRow--;
            if (currentRow < 0)
                currentRow = dataSet.Tables["zakazchik"].Rows.Count - 1;
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