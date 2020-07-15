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
    public partial class HOME : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =LookBook;" + "UID =hayeon; PASSWORD =1234";

        public HOME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button9_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            switch (comboBox1.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "":

                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT * FROM Color";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "비건디":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '버건디';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "핑크":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '핑크';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "노랑":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '노랑';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "파랑":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '파랑';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "네이비":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '네이비';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "화이트":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '화이트';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "블랙":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '블랙';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "그레이":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '그레이';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "그린":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT bottom_color FROM Color WHERE top_color = '그린';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            switch (comboBox2.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "":

                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT * FROM Color";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "진청":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT top_color FROM Color WHERE bottom_color = '진청';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "블랙":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT top_color FROM Color WHERE bottom_color = '블랙';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "연청":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT top_color FROM Color WHERE bottom_color = '연청';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "화이트":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT top_color FROM Color WHERE bottom_color = '화이트';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "베이지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT top_color FROM Color WHERE bottom_color = '베이지';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "그레이":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT top_color FROM Color WHERE bottom_color = '그레이';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
             
            }
            dataGridView1.DataSource = ds.Tables[0];
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
    }
}
