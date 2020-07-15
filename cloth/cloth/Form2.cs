using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloth
{
    public partial class Form2 : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =LookBook;" + "UID =hayeon; PASSWORD =1234";
        public Form2()
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
                case "반팔":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '반팔';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "후드집업":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '후드집업';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "맨투맨":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '맨투맨';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "블라우스":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '블라우스';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "셔츠":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '셔츠';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "니트":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '니트';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "가디건":
                    //Handle for the first combobox
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom FROM Combi WHERE tc = '가디건';";

                        //SqlDataAdapter 초기화
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    break;
            }
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            switch (comboBox1.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "반팔":
                    //Handle for the first combobox
                    break;
                case "후드집업":
                    //Handle for the second combobox
                    break;
                case "맨투맨":
                    //Handle for the third combobox
                    break;
                case "블라우스":
                    //Handle for the third combobox
                    break;
                case "셔츠":
                    //Handle for the third combobox
                    break;
                case "니트":
                    //Handle for the third combobox
                    break;
            }
        }
    }
}
