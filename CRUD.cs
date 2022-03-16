using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button3_Click(object sender, EventArgs e)
        {
            //for Insert// button code
            var st = new MyinfoTab
            {
                ID=int.Parse(textBox1.Text),
                Name=textBox2.Text,
                Address=textBox3.Text,
                Age=double.Parse(textBox4.Text),
            
            };
            db.MyinfoTabs.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Data Inserted");
            loaddata();

        }
        void loaddata()
        {//for load data to grid vied on update insert or search//button,form code
            var st = from s in db.MyinfoTabs select s;
            dataGridView1.DataSource = st;
        }
        
        private void CRUD_Load(object sender, EventArgs e)
        {
            //call this methiod of header checkbox mouse click...'
            //first add header checkbox then moue click.without checkbox what ill you click
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);


            
            loaddata();
        }

        //now i am going to add headercheckbox
        CheckBox HeaderCheckBox = null;
        //bool IsHeaderCheckBoxClicked = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);

            //Add CheckBox in to dataGridview
            this.dataGridView1.Controls.Add(HeaderCheckBox);

        
        }
        //Now header  checkbox clickevent
        private void HeadedrCheckBoxClick(CheckBox HCheckBox) {

            //IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;

            dataGridView1.RefreshEdit();
            //TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            //IsHeaderCheckBoxClicked = false;

        }
        //Now i am going to a mouseclick event
        private void HeaderCheckBox_MouseClick(object sender,MouseEventArgs e){
        
        
        HeadedrCheckBoxClick((CheckBox)sender);
        
        
        
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //for Update// button code
            var st = (from s in db.MyinfoTabs where s.ID == int.Parse(textBox1.Text) select s).First();

            st.Name = textBox2.Text;
            st.Address = textBox3.Text;
            st.Age = double.Parse(textBox4.Text);
            db.SubmitChanges();
            MessageBox.Show("Successfully Updated");
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //for Search// button code
            var st = (from s in db.MyinfoTabs where s.ID == int.Parse(textBox1.Text) select s).First();

            textBox2.Text = st.Name;
            textBox3.Text = st.Address;
            textBox4.Text = st.Age.ToString();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var st = (from s in db.MyinfoTabs where s.ID == int.Parse(textBox1.Text) select s).First();
            db.MyinfoTabs.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Deleted...");
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MessageBox.Show("Are sure to Delete ?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;

                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    var st = (from s in db.MyinfoTabs where s.ID == int.Parse(id) select s).First();
                    db.MyinfoTabs.DeleteOnSubmit(st);
                    db.SubmitChanges();
                    MessageBox.Show("Successfully Deleted...");
                    loaddata();
                    //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    //textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    //textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Now i an going to show you the details of selected CheckBox
            string name = "", address = "", msg = "";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++) {

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true) {
                    name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    address = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                  
                }
                msg += " Name : " + name + " address : " + address + " . . . . . . ";

                lblmsg.Text = msg;
            }
            MessageBox.Show(msg);

        }

    }
}
