using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        DataClasses1DataContext db = new DataClasses1DataContext();



        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashInner CI = new CashInner();
            this.Hide();
            CI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashOuter CO = new CashOuter();
            this.Hide();
            CO.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewCoutomer NC = new NewCoutomer();
            this.Hide();
            NC.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewCoutomer NC = new NewCoutomer();
            this.Hide();
            NC.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Investers I = new Investers();
            //this.Hide();
            //I.Show();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpg;*.pmp) | *.jpg; *jpeg; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    MessageBox.Show(open.FileName);

                }
            }

            //var st = from s in db.Tables select s;
            //dataGridView1.DataSource = st;
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {
            label3.Text = Index.SetValueForText1;
            
            //ProdGV.AutoGenerateColumns = false;
            ////loadData();
            //loadData();


        }

        private void label3_Click(object sender, EventArgs e)
        {
           

            
        }

        //private void loadData()
        //{
        //    var st = from s in db.Tables select s;
        //    dataGridView1.DataSource = st;
        //}

    }
}
