namespace WindowsFormsApplication1
{
    partial class Basics_Of_Crystal_Report_Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvDataTable = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crptHelloWorld1 = new WindowsFormsApplication1.crptHelloWorld();
            this.SuspendLayout();
            // 
            // crvDataTable
            // 
            this.crvDataTable.ActiveViewIndex = 0;
            this.crvDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDataTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDataTable.Location = new System.Drawing.Point(0, 0);
            this.crvDataTable.Name = "crvDataTable";
            this.crvDataTable.ReportSource = this.crptHelloWorld1;
            this.crvDataTable.Size = new System.Drawing.Size(1291, 1050);
            this.crvDataTable.TabIndex = 0;
            this.crvDataTable.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvDataTable.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Basics_Of_Crystal_Report_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 1050);
            this.Controls.Add(this.crvDataTable);
            this.Name = "Basics_Of_Crystal_Report_Viewer";
            this.Text = "Basics_Of_Crystal_Report_Viewer";
            this.Load += new System.EventHandler(this.Basics_Of_Crystal_Report_Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDataTable;
        private crptHelloWorld crptHelloWorld1;
        //private crptHelloWorld crptHelloWorld1;
    }
}