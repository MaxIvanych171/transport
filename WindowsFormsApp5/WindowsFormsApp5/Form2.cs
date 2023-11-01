using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using WindowsFormsApp5.transportDBDataSetTableAdapters;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        private SqlConnection connection;

        public Form2()
        {
            InitializeComponent();
            // Инициализация строки подключения
            string connectionString = "Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
    }


private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDBDataSet.sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.transportDBDataSet.sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDBDataSet.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.transportDBDataSet.transport);

        }

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Открытие подключения к базе данных
                connection.Open();

                // Получение значения выбранной строки
                string selectedValue = dataGridView1.SelectedCells[0].Value.ToString();

                // Создание SQL-запроса для удаления строки
                string query = $"DELETE FROM sotrudniki WHERE ID_сотрудника = '{selectedValue}'";

                // Создание команды для выполнения запроса
                SqlCommand command = new SqlCommand(query, connection);

                // Выполнение запроса
                command.ExecuteNonQuery();

                // Обновление данных в таблице
                RefreshData();

                MessageBox.Show("Строка успешно удалена из таблицы sotrudniki.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении строки: " + ex.Message);
            }
            finally
            {
                // Закрытие подключения к базе данных
                connection.Close();
            }
        }

        private void RefreshData()
        {
            // Создание SQL-запроса для получения данных из таблицы
            string query = "SELECT * FROM sotrudniki";

            // Создание адаптера данных
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            // Создание нового набора данных
            DataSet dataSet = new DataSet();

            // Заполнение набора данных
            adapter.Fill(dataSet, "sotrudniki");

            // Установка источника данных для DataGridView
            dataGridView1.DataSource = dataSet.Tables["sotrudniki"];
        }
        private void button4_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}