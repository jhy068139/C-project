using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloth
{
    public partial class Delete : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =LookBook;" + "UID =hayeon; PASSWORD =1234";
        public Delete()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string colorid = textBox4.Text;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "DELETE FROM Color WHERE colorid=" + colorid;
                command.ExecuteNonQuery(); // sql 실행

                button8_Click(null, null); // 다시 전체 조회 ㄱ
            }//conn,Close 자동으로 해줌
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //data를 조회해 와서 저장 
            DataSet ds = new DataSet();

            // using 을 사용하면 알아서 닫아줌
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                string sql = "SELECT * FROM Color";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "Color");
            } // conn.Close(); 를 자동으로 해준다

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            // using 을 사용하면 알아서 닫아줌
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                string sql = "SELECT * FROM Combi";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "Combi");
            } // conn.Close(); 를 자동으로 해준다

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string combiid = textBox1.Text;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "DELETE FROM Combi WHERE combiid=" + combiid;
                command.ExecuteNonQuery(); // sql 실행

                button10_Click(null, null); // 다시 전체 조회 ㄱ
            }//conn,Close 자동으로 해줌
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form2 colortop = new Form2();

            colortop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Bottom bottom = new Bottom();

            bottom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Shoes shoes = new Shoes();

            shoes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            HAT hat = new HAT();

            hat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            ADD add = new ADD();

            add.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            Delete add = new Delete();

            add.Show();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();

            HOME home = new HOME();

            home.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();

            COORDI coordl = new COORDI();

            coordl.Show();
        }
    }
}
