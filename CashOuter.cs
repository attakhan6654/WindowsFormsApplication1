using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CashOuter : Form
    {
        public CashOuter()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF1H18L\;Initial Catalog=abc;Integrated Security=True");
        DataClasses1DataContext db = new DataClasses1DataContext();
        //integer validations
        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        //double validation
        private void validateTextDouble(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains(','))
                        throw X;
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        //charactor validation
        private void validateTextCharacter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {
                //Not Allowing Numbers
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }

        //integer customization x<0
        private void validateTextIntegerCustomized(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                int x = int.Parse(T.Text);

                //Customizing Condition
                if (x <= 0)
                    throw X;
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }

            }
        }

        //double customization x<0
        private void validateTextDoubleCustomized(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                double x = double.Parse(T.Text);

                //Customizing Condition (Only numbers larger than or 
                //equal to zero are permitted)
                if (x < 0 || T.Text.Contains(','))
                    throw X;
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        //chractor customization
        private void validateTextCharacterCustomized(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;

            try
            {
                //Not Allowing Numbers, Underscore or Hash
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9','_','#'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin a_p = new Admin();
            this.Hide();
            a_p.Show();
        }

        private void bttn3_Click(object sender, EventArgs e)
        {

        }

        private void bttn2_Click(object sender, EventArgs e)
        {

        }

        private void bttn2_Click_1(object sender, EventArgs e)
        {
            //for Insert// button code
            var st = new CashOut
            {
                CashTotal = int.Parse(txtcashtotal.Text),
                CashGo = txtcashgo.Text,
                CashNet = txtcashnet.Text,


            };
            db.CashOuts.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Data Inserted");
            loaddata();


            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into CashOut values('" + txtcashtotal.Text + "', '" + txtcashgo.Text + "', '" + txtcashnet.Text + "')", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data Inserted Successfully.");
            //con.Close();
            //for Insert// button code
            //var st = new CashOut
            //{
            //    //CashTotal = int.Parse(txtcashtotal.Text),
            //    //CashGo = txtcashgo.Text,
            //    //CashNet = txtcashnet.Text,

            //};
            //db.CashOut.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Data Inserted");
            loaddata();
        }

        private void loaddata()
        {
            var st = from s in db.CashOuts select s;
            ProdGV.DataSource = st;
        }

        private void bttn3_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF1H18L;Initial Catalog=abc;Integrated Security=True");
            //con.Open();
            //if (txtcashtotal.Text != "")
            //{
            //    SqlCommand cmd = new SqlCommand("Select Cashgo, CashNet from CashOut where CashTotal=@CashTotal", con);
            //    cmd.Parameters.AddWithValue("@CashTotal", int.Parse(txtcashtotal.Text));
            //    SqlDataReader da = cmd.ExecuteReader();
            //    while (da.Read())
            //    {
            //        txtcashgo.Text = da.GetValue(0).ToString();
            //        txtcashnet.Text = da.GetValue(1).ToString();

            //    }
            //}
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashInner ci = new CashInner();
            this.Hide();
            ci.Show();
        }

        private void CashOuter_Load(object sender, EventArgs e)
        {
            ProdGV.AutoGenerateColumns = false;
            loadData();
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            var st = (from s in db.CashOuts where s.CashTotal == int.Parse(txtcashtotal.Text) select s).First();
            db.CashOuts.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Deleted...");
            loaddata();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewCoutomer NC = new NewCoutomer();
            this.Hide();
            NC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Record R = new Record();
            this.Hide();
            R.Show();
        }

        private void Insertinsqltable_Click(object sender, EventArgs e)
        {
            int ctot = 0; string cgo = "", cnet = "";
            for (int i = 0; i < ProdGV.Rows.Count - 1; i++)
            {

                ctot = Convert.ToInt32(ProdGV.Rows[i].Cells[0].Value.ToString());
                cgo = ProdGV.Rows[i].Cells[1].Value.ToString();
                cnet = ProdGV.Rows[i].Cells[2].Value.ToString();


                var st = new CashOut
                {
                    CashTotal = ctot,
                    CashGo = cgo,
                    CashNet = cnet,

                };
                db.CashOuts.InsertOnSubmit(st);
                db.SubmitChanges();
                ProdGV.Rows[i].Cells[3].Value = "Success";
                loadData();
            }
        }

        private void loadData()
        {
            var st = from s in db.CashOuts select s;
            dataGridView1.DataSource = st;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewCoutomer NC = new NewCoutomer();
            this.Hide();
            NC.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            this.Close();
            i.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            txtcashtotal.Clear();
            txtcashgo.Clear();
            txtcashnet.Clear();
        }
    }
}
