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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Xml.Linq;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение данных из TextBox
            string ФИО = textBox3.Text;
            string Паспортные_данные = textBox4.Text;
            string Должность = textBox5.Text;
            string Телефон = textBox6.Text;
            string Адрес = textBox7.Text;

            // Проверка наличия данных в TextBox
            if (string.IsNullOrEmpty(ФИО) || 
                string.IsNullOrEmpty(Паспортные_данные) || string.IsNullOrEmpty(Должность) || string.IsNullOrEmpty(Телефон) || string.IsNullOrEmpty(Адрес))
            {
                MessageBox.Show("Пожалуйста, введите имя и возраст.");
                return;
            }

            // Создание соединения с базой данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Создание команды для вставки данных
                    string query = "INSERT INTO sotrudniki (ФИО, Паспортные_данные, Должность, Телефон, Адрес) VALUES (@ФИО, @Паспортные_данные, @Должность, @Телефон, @Адрес)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Параметризация команды
                    command.Parameters.AddWithValue("@ФИО", ФИО);
                    command.Parameters.AddWithValue("@Паспортные_данные", Паспортные_данные);
                    command.Parameters.AddWithValue("@Должность", Должность);
                    command.Parameters.AddWithValue("@Телефон", Телефон);
                    command.Parameters.AddWithValue("@Адрес", Адрес);

                    // Выполнение команды
                    command.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно добавлены в базу данных.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при добавлении данных: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}