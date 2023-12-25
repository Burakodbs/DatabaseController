using System.Data;
using System;

using System.Data.SqlClient;
using System.Windows.Forms;
using Npgsql;



namespace DatabaseController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        NpgsqlConnection url = new NpgsqlConnection("Server=127.0.0.1; Port=5432;Database=ETRADE;user Id=postgres ; Password=07102002");
        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM db.\"EMPLOYEES\"";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, url);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGrid.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into db.\"EMPLOYEES\" (\"TYPEID\",\"NAMESURNAME\") VALUES(@p1,@p2)", url);
            command.Parameters.AddWithValue("@p1", Int32.Parse(typeText.Text));
            command.Parameters.AddWithValue("@p2", namesurnameText.Text);
            command.ExecuteNonQuery();
            url.Close();
            MessageBox.Show("Ýþlem gerçekleþti...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            url.Open();
            NpgsqlCommand command = new NpgsqlCommand("delete from db.\"EMPLOYEES\" where \"ID\" = @p1 ", url);
            command.Parameters.AddWithValue("@p1", Int32.Parse(typeText.Text));
            command.ExecuteNonQuery();
            url.Close();
            MessageBox.Show("Ýþlem gerçekleþti...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            url.Open();
            NpgsqlCommand command = new NpgsqlCommand("update db.\"EMPLOYEES\" set \"NAMESURNAME\" = @p2 where  \"ID\" = @p1 ", url);
            command.Parameters.AddWithValue("@p1", Int32.Parse(typeText.Text));
            command.Parameters.AddWithValue("@p2", namesurnameText.Text);
            command.ExecuteNonQuery();
            url.Close();
            MessageBox.Show("Ýþlem gerçekleþti...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            url.Open();
            NpgsqlCommand command = new NpgsqlCommand("select * from db.\"EMPLOYEES\" where \"TYPEID\" = @p1", url);
            command.Parameters.AddWithValue("@p1", Int32.Parse(typeText.Text));
            int search = Int32.Parse(typeText.Text);
            string query = "select * from db.\"EMPLOYEES\" where \"TYPEID\" = ";
            query += search;
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, url);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGrid.DataSource = dataSet.Tables[0];
            url.Close();

        }
    }
}
