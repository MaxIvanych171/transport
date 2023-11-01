using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form6 : Form
    {
        private SqlConnection connection;
        public Form6()
        {
            InitializeComponent();
            // Инициализация строки подключения
            string connectionString = "Data Source=LAPTOP-R6G3FU54;Initial Catalog=transportDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDBDataSet.sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.transportDBDataSet.sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDBDataSet.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.transportDBDataSet.transport);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
