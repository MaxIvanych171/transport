using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form8 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDBDataSet.zakazy". При необходимости она может быть перемещена или удалена.
            this.zakazyTableAdapter.Fill(this.transportDBDataSet.zakazy);
            // Заполнение DataGridView данными из таблицы "заказы"
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            try
            {
                // Открытие соединения с базой данных
                connection.Open();

                // Создание SQL-запроса для выборки данных из таблицы "заказы"
                string query = "SELECT ID_заказа, ID_заказчика, ID_получателя, ID_груза, Дата_заказа, Дата_доставки, Стоимость_доставки, Адрес, Статус_заказа FROM zakazy";

                // Создание объекта команды SQL с заданным запросом и соединением
                SqlCommand command = new SqlCommand(query, connection);

                // Создание объекта адаптера данных SQL для выполнения команды и заполнения DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Создание объекта DataSet для хранения данных
                DataSet dataSet = new DataSet();

                // Заполнение DataSet данными из таблицы "заказы"
                adapter.Fill(dataSet, "zakazy");

                // Закрытие соединения с базой данных
                connection.Close();

                // Привязка данных из DataSet к DataGridView
                dataGridView1.DataSource = dataSet.Tables["zakazy"];
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}