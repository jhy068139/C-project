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
    public partial class Bottom : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =LookBook;" + "UID =hayeon; PASSWORD =1234";

        public Bottom()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Bottom bottom = new Bottom();

            bottom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 colortop = new Form2();

            colortop.Show();
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

            switch (cmd.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "":
                    // using 을 사용하면 알아서 닫아줌
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT * FROM Combi;";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    break;
                case "반바지":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '반바지';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "긴바지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '긴바지';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "치마":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '치마';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "롱 치마":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '롱 치마';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "멜빵바지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '멜빵바지';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "트레이닝팬츠":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '트레이닝팬츠';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "뷔스티에 원피스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '뷔스티에 원피스';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "슬랙스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT tc FROM Combi WHERE bottom = '슬랙스';";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Combi");
                    } // conn.Close(); 를 자동으로 해준다
                      //Handle for the third combobox
                    break;
            }
                   
        dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                        ComboBox cmb = sender as ComboBox;

            switch (cmd.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "":
                    //Handle for the first combobox
                    break;
                case "긴바지":
                    //Handle for the first combobox
                    break;
                case "반바지":
                    //Handle for the second combobox
                    break;
                case "스커트":
                    //Handle for the third combobox
                    break;
                case "롱스커트":
                    //Handle for the third combobox
                    break;
                case "멜빵바지":
                    //Handle for the third combobox
                    break;
                case "뷔스티에 원피스":
                    //Handle for the third combobox
                    break;
                case "트레이닝팬츠":
                    //Handle for the third combobox
                    break;
                case "슬랙스":
                    //Handle for the third combobox
                    break;
            }
        }
    }
}
