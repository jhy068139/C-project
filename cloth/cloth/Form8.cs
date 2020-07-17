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
    public partial class COORDI : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =LookBook;" + "UID =hayeon; PASSWORD =1234";

        public COORDI()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
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
                case "긴바지":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='긴바지'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "반바지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='반바지'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "멜빵바지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='멜빵바지'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "치마":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='치마'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "트레이닝 팬츠":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='트레이닝 팬츠'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "롱 치마":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='롱 치마'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "슬랙스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='슬랙스'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "뷔스티에 원피스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.bottom_color,Color.top_color,Combi.tc From Color CROSS JOIN Combi WHERE bottom='뷔스티에 원피스'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
            
            }
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void button8_Click(object sender, EventArgs e)
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
                case "반팔":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Combi.bottom,Color.bottom_color,Color.top_color From Color CROSS JOIN Combi WHERE bottom='반팔'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "후드집업":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.top_color, Combi.bottom,Color.bottom_color From Color CROSS JOIN Combi WHERE tc='후드집업'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "맨투맨":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.top_color, Combi.bottom,Color.bottom_color From Color CROSS JOIN Combi WHERE tc='맨투맨'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "블라우스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.top_color, Combi.bottom,Color.bottom_color From Color CROSS JOIN Combi WHERE tc='블라우스'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "셔츠":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.top_color, Combi.bottom,Color.bottom_color From Color CROSS JOIN Combi WHERE tc='셔츠'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "니트":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT Color.top_color, Combi.bottom,Color.bottom_color From Color CROSS JOIN Combi WHERE tc='니트'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "Color,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
            
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();

            HOME home = new HOME();

            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            COORDI coordl = new COORDI();

            coordl.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Delete coordl = new Delete();

            coordl.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            ADD coordl = new ADD();

            coordl.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            switch (comboBox3.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
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
                case "긴바지":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='긴바지'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "반바지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='반바지'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "멜빵바지":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='멜빵바지'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "치마":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='치마'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "트레이닝 팬츠":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='트레이닝 팬츠'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "롱 치마":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='롱 치마'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "슬랙스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='슬랙스'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "뷔스티에 원피스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.tc From ACC CROSS JOIN Combi WHERE bottom='뷔스티에 원피스'"; 
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;

            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();




            switch (comboBox4.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
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
                case "반팔":
                    //Handle for the first combobox
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.bottom From ACC CROSS JOIN Combi WHERE tc='반팔'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다

                    break;
                case "후드집업":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.bottom From ACC CROSS JOIN Combi WHERE tc='후드집업'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");
                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the second combobox
                    break;
                case "맨투맨":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.bottom From ACC CROSS JOIN Combi WHERE tc='맨투맨'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "블라우스":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.bottom From ACC CROSS JOIN Combi WHERE tc='블라우스'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "셔츠":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.bottom From ACC CROSS JOIN Combi WHERE tc='셔츠'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;
                case "니트":
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        //연결이 안되어 있어도 자동적으로 연결하고 연결을 끊는다.
                        string sql = "SELECT ACC.hat,ACC.shoes,Combi.bottom From ACC CROSS JOIN Combi WHERE tc='니트'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, "ACC,Combi");

                    } // conn.Close(); 를 자동으로 해준다
                    //Handle for the third combobox
                    break;

            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
