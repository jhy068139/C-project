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

namespace cloth
{
    public partial class HAT : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =LookBook;" + "UID =hayeon; PASSWORD =1234";

        public HAT()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 colortop = new Form2();

            colortop.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            //data를 조회해 와서 저장 
            DataSet ds = new DataSet();


            switch (comboBox1.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "볼캡":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT shoes FROM Acc WHERE hat = '볼캡';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Acc");
                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "비니":
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT shoes FROM Acc WHERE hat = '비니';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Acc");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "빵모자":
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT shoes FROM Acc WHERE hat = '빵모자';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Acc");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            switch (comboBox1.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "볼캡":
                    //Handle for the first combobox
                    break;
                case "비니":
                    //Handle for the second combobox
                    break;
                case "빵모자":
                    //Handle for the third combobox
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ADD add = new ADD();

            add.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            Delete delete = new Delete();

            delete.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
