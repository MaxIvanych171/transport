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
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private int currentRow = 0;

        public Form3()
        {
            InitializeComponent();
            string connectionString = "Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                connection.Open();

                string query = "SELECT Модель, Марка, ГосНомер, Изображение FROM transport";
                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "transport");

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
            if (rowIndex >= 0 && rowIndex < dataSet.Tables["transport"].Rows.Count)
            {
                DataRow row = dataSet.Tables["transport"].Rows[rowIndex];

                string модель = row["Модель"].ToString();
                string марка = row["Марка"].ToString();
                string госНомер = row["ГосНомер"].ToString();
                string изображениеPath = row["Изображение"].ToString();

                // Отображение данных
                label1.Text = модель;
                label2.Text = марка;
                label3.Text = госНомер;

                // Загрузка изображения
                if (File.Exists(изображениеPath))
                {
                    pictureBox1.Image = Image.FromFile(изображениеPath);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                // Обновление информации о текущей записи
                label4.Text = (rowIndex + 1).ToString();
                label5.Text = dataSet.Tables["transport"].Rows.Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentRow > 0)
            {
                currentRow--;
                DisplayData(currentRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentRow < dataSet.Tables["transport"].Rows.Count - 1)
            {
                currentRow++;
                DisplayData(currentRow);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}