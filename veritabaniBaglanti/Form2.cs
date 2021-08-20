using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Xml;
using System.Data.SqlClient;




namespace _19350034
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bag blt = new bag();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand blut = new SqlCommand();
            blut.Connection = blt.pcbaglanti();
            blut.CommandText = "insert into  Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)values(@CustomerID,@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax)";
            blut.Parameters.AddWithValue("@CustomerID", textBox1.Text);
            blut.Parameters.AddWithValue("@CompanyName", textBox2.Text);
            blut.Parameters.AddWithValue("@ContactName", textBox3.Text);
            blut.Parameters.AddWithValue("@ContactTitle", textBox4.Text);
            blut.Parameters.AddWithValue("@Address", textBox5.Text);
            blut.Parameters.AddWithValue("@City", textBox6.Text);
            blut.Parameters.AddWithValue("@Region", textBox7.Text);
            blut.Parameters.AddWithValue("@PostalCode", textBox8.Text);
            blut.Parameters.AddWithValue("@Country", textBox9.Text);
            blut.Parameters.AddWithValue("@Phone", textBox10.Text);
            blut.Parameters.AddWithValue("@Fax", textBox11.Text);
            blut.ExecuteNonQuery();
            blt.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = refresh();
        }
            DataTable refresh()
            {
                SqlDataAdapter fb = new SqlDataAdapter("select * from Customers ", blt.pcbaglanti());
                DataTable t = new DataTable();
                fb.Fill(t);
                blt.pcbaglanti().Close();
                return t;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ftb = new SqlCommand();
            ftb.Connection = blt.pcbaglanti();
            ftb.CommandText = "DELETE from Customers where CustomerID=@CustomerID";
            ftb.Parameters.AddWithValue("@CustomerID", textBox1.Text);
            ftb.ExecuteNonQuery();
            blt.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand bltft = new SqlCommand();
            bltft.Connection = blt.pcbaglanti();
            bltft.CommandText = "update Customers set CustomerID=@CustomerID,CompanyName=@CompanyName,ContactName=@ContactName,ContactTitle=@ContactTitle,Address=@Address,City=@City,Region=@Region,PostalCode=@PostalCode,Country=@Country,Phone=@Phone,Fax=@Fax where CustomerID=@CustomerID   ";
            bltft.Parameters.AddWithValue("@CustomerID", textBox1.Text);
            bltft.Parameters.AddWithValue("@CompanyName", textBox2.Text);
            bltft.Parameters.AddWithValue("@ContactName", textBox3.Text);
            bltft.Parameters.AddWithValue("@ContactTitle", textBox4.Text);
            bltft.Parameters.AddWithValue("@Address", textBox5.Text);
            bltft.Parameters.AddWithValue("@City", textBox6.Text);
            bltft.Parameters.AddWithValue("@Region", textBox7.Text);
            bltft.Parameters.AddWithValue("@PostalCode", textBox8.Text);
            bltft.Parameters.AddWithValue("@Country", textBox9.Text);
            bltft.Parameters.AddWithValue("@Phone", textBox10.Text);
            bltft.Parameters.AddWithValue("@Fax", textBox11.Text);
            bltft.ExecuteNonQuery();
            blt.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

