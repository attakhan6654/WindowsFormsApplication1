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
    public partial class Basics_Of_Crystal_Report_Viewer : Form
    {
        public Basics_Of_Crystal_Report_Viewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Basics_Of_Crystal_Report_Viewer_Load(object sender, EventArgs e)
        {
            //crptHelloWorld crpt = new crptHelloWorld();
            DataTable CashIn = new DataTable();
            CashIn.Columns.Add("CashTotal", typeof(int));
            CashIn.Columns.Add("CashCome", typeof(string));
            CashIn.Columns.Add("CashNet", typeof(double));

            CashIn.Rows.Add(100, "50", 50);
            CashIn.Rows.Add(50, "25", 25);
            CashIn.Rows.Add(200, "100", 100);

            crptHelloWorld crpthw = new crptHelloWorld();
            crpthw.Database.Tables["CashIn"].SetDataSource(CashIn);
            crvDataTable.ReportSource = crpthw;
        }
    }
}
