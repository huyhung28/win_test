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

namespace win_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            SqlConnection con = new SqlConnection("Server=MSI\\SQLEXPRESS;database=Sachdb;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from sach", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void xoadata()
        {
            txtmas.Text = String.Empty;
            txtgia.Text = String.Empty;
            txtsol.Text = String.Empty;
            txttensach.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=MSI\\SQLEXPRESS;database=Sachdb;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into sach values('" + txtmas.Text + "','" + txttensach.Text + "','" + Convert.ToDouble(txtgia.Text) + "','" + Convert.ToInt16(txtsol.Text) + "')", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("them ok");

            con.Close();
            loaddata();
            xoadata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=MSI\\SQLEXPRESS;database=Sachdb;integrated security=true");
            SqlCommand cmd = new SqlCommand("delete from sach where masach= '" + txtmas.Text + "'", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("da xoa ");
            con.Close();
            loaddata();
            xoadata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=MSI\\SQLEXPRESS;database=Sachdb;integrated security=true");
            SqlCommand cmd = new SqlCommand("update sach set tensach='" + txtmas.Text + "',Gia='" + Convert.ToDouble(txttensach.Text) + "',soluong='" + Convert.ToInt16(txtgia.Text) + "'where Masach='" + txtsol.Text + "'", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show(" da them ");
            con.Close();
        }

        private void timk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-71JUSF8\\SQLEXPRESS;database=SachDB;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from sach where tieude LIKE '%" + timkiem.Text + "%' ", con);
            DataTable dt = new DataTable();
           con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtmas.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttensach.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgia.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsol.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        
    
        }
    }
}
