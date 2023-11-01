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
using WindowsFormsApp5;

namespace matches
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // Создание соединения с базой данных SQL
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True");

            try
            {
                // Открытие соединения
                con.Open();

                // Написание запроса на выборку данных администратора
                SqlCommand cmd = new SqlCommand("SELECT * FROM admin WHERE admin_name = @admin_name AND admin_password = @admin_password", con);
                cmd.Parameters.AddWithValue("@admin_name", textBox1.Text);
                 cmd.Parameters.AddWithValue("@admin_password", textBox2.Text);

                // Выполнение запроса
                SqlDataReader reader = cmd.ExecuteReader();

                // Проверка наличия результатов запроса
                if (reader.HasRows)
                {
                    // Открытие формы для редактирования данных администратора
                    Form7 form = new Form7();
                    form.Show();
                    this.Hide();
    }
                else
                {
                    // Вывод сообщения об ошибке
                    MessageBox.Show("Неправильное имя пользователя или пароль!");
                }
            }
            catch (Exception ex)
{
    // Вывод сообщения об ошибке
    MessageBox.Show("Ошибка: " + ex.Message);
}
finally
{
    // Закрытие соединения
    con.Close();
}
        }
    }
}