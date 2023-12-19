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

namespace Form_Connect_DB
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_name_pc.Text) ||
                    string.IsNullOrWhiteSpace(tb_name_db.Text) ||
                    string.IsNullOrWhiteSpace(tb_user.Text) ||
                    string.IsNullOrWhiteSpace(tb_pass.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin kết nối.");
                    return;
                }
                string cnString = $"Data Source={tb_name_pc.Text};Initial Catalog={tb_name_db.Text};User Id={tb_user.Text};Password={tb_pass.Text};";
                ConnectionString = cnString;
                MessageBox.Show("Kết nối dữ liệu thành công");
                Show_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want Exit ?", "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None) == DialogResult.Yes)
                Application.Exit();
        }

        private void Show_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(ConnectionString))
                {
                    MessageBox.Show("ConnectionString không tồn tại.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM THUC_DON";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu");
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



    }
}
