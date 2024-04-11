using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-I679ENGR;Initial Catalog=helloworld;Integrated Security=True;Trust Server Certificate=True";
            using
            (SqlConnection cnn = new SqlConnection(connectionString))
            {
                selectAll(cnn);
                //insertNew(4, "An Hòa", false, "0911122233", cnn);
            }

        }

        private void selectAll(SqlConnection cnn)
        {
            using (var conn = cnn)
            {
                cnn.Open();
                MessageBox.Show("Connected");
                SqlDataReader reader;
                String query, output = "";
                query = @"SELECT * FROM demoDB;";
                var command = new SqlCommand(query, cnn);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    output += reader.GetValue(0) + " - " + reader.GetValue(1) + " - "
                        + reader.GetValue(2) + " - " + reader.GetValue(3) + "\n";
                }
                MessageBox.Show(output);
                cnn.Close();
            }
        }

        private void insertNew(int stt, String hoten, Boolean gioitinh, String sdt, SqlConnection cnn)
        {

            using (cnn)
            {

                SqlDataReader reader;
                String query, output = "";
                SqlParameter param;

                MessageBox.Show("Connected");
                cnn.Open();


                query = @"INSERT INTO demodb (stt, hoten, gioitinh, sdt)
                       VALUES (@stt, @hoten, @gioitinh, @sdt)";

                var command = new SqlCommand(query, cnn);



                param = new SqlParameter("@stt", SqlDbType.Int);
                param.Value = stt;
                command.Parameters.Add(param);

                param = new SqlParameter("@hoten", SqlDbType.NVarChar, 30);
                param.Value = hoten;
                command.Parameters.Add(param);

                param = new SqlParameter("@gioitinh", SqlDbType.Bit);
                param.Value = gioitinh;
                command.Parameters.Add(param);

                param = new SqlParameter("@sdt", SqlDbType.Char, 10);
                param.Value = sdt;
                command.Parameters.Add(param);

                command.ExecuteScalar();

                output = "Finished";
                MessageBox.Show(output);
                cnn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-I679ENGR;Initial Catalog=helloworld;Integrated Security=True;Trust Server Certificate=True";
            using
                (var cnn = new SqlConnection(connectionString))
            {
                insertNew(4, "An Hòa", false, "0911122233", cnn);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string connectionString = @"Data Source=LAPTOP-I679ENGR;Initial Catalog=helloworld;Integrated Security=True;Trust Server Certificate=True";
            using
                (var cnn = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                cnn.Open();

                String query = @"SELECT * FROM DEMODB";

                SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);

                adapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }*/
        }

        
    }
}
