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


namespace BTVN._28._03._2019
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();

		}
		// tao ket noi den SQL sever
		SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QuanLySinhVien;Integrated Security=True");
	
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// khoi tao doi tuong doc du lieu
			 SqlDataAdapter da = new SqlDataAdapter(" Select * from MonHoc", conn);
			//conn.Open();
			// khai bao doi tuong chua du lieu
			DataTable dt = new DataTable();
			// dien du lieu vao doi tuong
			da.Fill(dt);
			// giai phong doi tuong da
			da.Dispose();
			// gan du lieu nguon
			//gan truong hien thi tren combox
			comboBox1.DisplayMember = "MaMH";
			comboBox1.ValueMember = "MaMH";
            comboBox1.DataSource = dt;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            string x = comboBox1.SelectedValue.ToString();
            x = x.Trim();

			SqlDataAdapter da = new SqlDataAdapter(" Select * from SINHVIEN where MAMH=" + x, conn);
			
			// khai bao doi tuong chua du lieu
			DataTable dt = new DataTable();
			// dien du lieu vao doi tuong
			da.Fill(dt);
			//giai phong doi tuong
			da.Dispose();
			//gan du lieu nguon
			dataGridViewSV.DataSource = dt;

           
            da = new SqlDataAdapter(" Select * from MonHoc where MAMH=" + x, conn);
            DataTable data = new DataTable();
            da.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dta = data.Rows[i];
                txtSoTiet.Text = dta["SoTiet"].ToString();
            }


        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (tb == DialogResult.OK)
				Application.Exit();
		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTongSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
