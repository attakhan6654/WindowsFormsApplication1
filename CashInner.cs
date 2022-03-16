using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CashInner : Form
    {
        public CashInner()
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

        private void bttn2_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into CashIn values('" + txtcashtotal.Text + "', '" + txtcashcome.Text + "', '" + txtcashnet.Text + "')", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data Inserted Successfully.");
            //con.Close();
            ////loaddata();
            //loadData();

            //for Insert// button code
            var st = new CashIn
            {
                CashTotal = int.Parse(txtcashtotal.Text),
                CashCome = txtcashcome.Text,
                CashNet = double.Parse(txtcashnet.Text),


            };
            db.CashIns.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Data Inserted");
            loaddata();

            db.SubmitChanges();
            MessageBox.Show("Data Inserted");
            loaddata();
        }

        private void loaddata()
        {
            throw new NotImplementedException();
        }

        //this is for search button frim textbox
        //private void bttn3_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF1H18L;Initial Catalog=abc;Integrated Security=True");
        //    con.Open();
        //    if (txtcashtotal.Text != "")
        //    {
        //        SqlCommand cmd = new SqlCommand("Select CashTotal, CashNet from CashIn where CashTotal=@CashTotal", con);
        //        cmd.Parameters.AddWithValue("@CashTotal", int.Parse(txtcashtotal.Text));
        //        SqlDataReader da = cmd.ExecuteReader();
        //        while (da.Read())
        //        {
        //            txtcashcome.Text = da.GetValue(0).ToString();
        //            txtcashnet.Text = da.GetValue(1).ToString();

        //        }
        //    }
        //    con.Close();
        //    //loaddata();
        //    loadData();
        //}


        private void button9_Click(object sender, EventArgs e)
        {
            Admin a_p = new Admin();
            this.Hide();
            a_p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashOuter CO = new CashOuter();
            this.Hide();
            CO.Show();
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            var st = (from s in db.CashIns where s.CashTotal == int.Parse(txtcashtotal.Text) select s).First();
            db.CashIns.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Deleted...");
            //loaddata();
            loadData();


            //int ct = 0; string ccome = "";double cashnet = 0;
            //for (int i = 0; i < ProdGV.Rows.Count - 1; i++)
            //{

            //    ct = Convert.ToInt32(ProdGV.Rows[i].Cells[0].Value.ToString());
            //    ccome = ProdGV.Rows[i].Cells[1].Value.ToString();
            //    cashnet = Convert.ToDouble(ProdGV.Rows[i].Cells[2].Value.ToString());


            //    var st = new CashIn
            //    {
            //        CashTotal = ct,
            //        CashCome = ccome,
            //        CashNet = cashnet,
            //    };
            //    db.CashIns.InsertOnSubmit(st);
            //    db.SubmitChanges();
            //    ProdGV.Rows[i].Cells[3].Value = "Success";
            //    loadData();
            //}
        }

        //private void loaddata()
        //{
        //    var st = from s in db.CashIns select s;
        //    dataGridView1.DataSource = st;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Insertinsqltable_Click(object sender, EventArgs e)
        {
            int ctotal = 0; string ccome = ""; double cnet = 0;
            for (int i = 0; i < ProdGV.Rows.Count - 1; i++)
            {

                ctotal = Convert.ToInt32(ProdGV.Rows[i].Cells[0].Value.ToString());
                ccome = ProdGV.Rows[i].Cells[1].Value.ToString();
                cnet = cnet = Convert.ToDouble(ProdGV.Rows[i].Cells[2].Value.ToString());


                var st = new CashIn
                {
                    CashTotal = ctotal,
                    CashCome = ccome,
                    CashNet = cnet,

                };
                db.CashIns.InsertOnSubmit(st);
                db.SubmitChanges();
                ProdGV.Rows[i].Cells[3].Value = "Success";
                loadData();
                //
            }
        }

        private void loadData()
        {
            var st = from s in db.CashIns select s;
            dataGridView1.DataSource = st;
        }

        private void CashInner_Load(object sender, EventArgs e)
        {
            ProdGV.AutoGenerateColumns = false;
            //loadData();
            loadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewCoutomer NC = new NewCoutomer();
            this.Hide();
            NC.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            this.Close();
            i.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            txtcashtotal.Clear();
            txtcashcome.Clear();
            txtcashnet.Clear();
        }
    }
}
