namespace WindowsFormsApplication1
{
    partial class CashInner
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtcashcome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdGV = new System.Windows.Forms.DataGridView();
            this.CashTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashCome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn4 = new System.Windows.Forms.Button();
            this.txtcashtotal = new System.Windows.Forms.TextBox();
            this.txtcashnet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insertinsqltable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepPink;
            this.label11.Location = new System.Drawing.Point(1598, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 39);
            this.label11.TabIndex = 70;
            this.label11.Text = "Product List:";
            // 
            // txtcashcome
            // 
            this.txtcashcome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcashcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashcome.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcashcome.Location = new System.Drawing.Point(572, 228);
            this.txtcashcome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcashcome.Name = "txtcashcome";
            this.txtcashcome.Size = new System.Drawing.Size(210, 32);
            this.txtcashcome.TabIndex = 51;
            this.txtcashcome.TextChanged += new System.EventHandler(this.validateTextDouble);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(382, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(382, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cash Come";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(379, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "Customer Net";
            // 
            // ProdGV
            // 
            this.ProdGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ProdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CashTotal,
            this.CashCome,
            this.CashNet,
            this.MSG});
            this.ProdGV.Location = new System.Drawing.Point(834, 150);
            this.ProdGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdGV.Name = "ProdGV";
            this.ProdGV.RowHeadersWidth = 62;
            this.ProdGV.Size = new System.Drawing.Size(725, 202);
            this.ProdGV.TabIndex = 69;
            // 
            // CashTotal
            // 
            this.CashTotal.HeaderText = "CashTotal";
            this.CashTotal.MinimumWidth = 8;
            this.CashTotal.Name = "CashTotal";
            this.CashTotal.Width = 180;
            // 
            // CashCome
            // 
            this.CashCome.HeaderText = "CashCome";
            this.CashCome.MinimumWidth = 8;
            this.CashCome.Name = "CashCome";
            this.CashCome.Width = 180;
            // 
            // CashNet
            // 
            this.CashNet.HeaderText = "CashNet";
            this.CashNet.MinimumWidth = 8;
            this.CashNet.Name = "CashNet";
            this.CashNet.Width = 180;
            // 
            // MSG
            // 
            this.MSG.HeaderText = "MSG";
            this.MSG.MinimumWidth = 8;
            this.MSG.Name = "MSG";
            this.MSG.Width = 120;
            // 
            // bttn4
            // 
            this.bttn4.BackColor = System.Drawing.Color.Pink;
            this.bttn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn4.ForeColor = System.Drawing.Color.Coral;
            this.bttn4.Location = new System.Drawing.Point(840, 657);
            this.bttn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(110, 45);
            this.bttn4.TabIndex = 67;
            this.bttn4.Text = "DELETE";
            this.bttn4.UseVisualStyleBackColor = false;
            this.bttn4.Click += new System.EventHandler(this.bttn4_Click);
            // 
            // txtcashtotal
            // 
            this.txtcashtotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcashtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashtotal.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcashtotal.Location = new System.Drawing.Point(572, 137);
            this.txtcashtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcashtotal.Name = "txtcashtotal";
            this.txtcashtotal.Size = new System.Drawing.Size(210, 32);
            this.txtcashtotal.TabIndex = 50;
            this.txtcashtotal.TextChanged += new System.EventHandler(this.validateTextDouble);
            // 
            // txtcashnet
            // 
            this.txtcashnet.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcashnet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashnet.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcashnet.Location = new System.Drawing.Point(572, 320);
            this.txtcashnet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcashnet.Name = "txtcashnet";
            this.txtcashnet.Size = new System.Drawing.Size(210, 32);
            this.txtcashnet.TabIndex = 52;
            this.txtcashnet.TextChanged += new System.EventHandler(this.validateTextDouble);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepPink;
            this.label9.Location = new System.Drawing.Point(461, 520);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 55;
            this.label9.Text = "CLEAR";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(459, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cash In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 117);
            this.panel1.TabIndex = 63;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lavender;
            this.button9.Location = new System.Drawing.Point(3, 27);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 54);
            this.button9.TabIndex = 11;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bttn2
            // 
            this.bttn2.BackColor = System.Drawing.Color.Pink;
            this.bttn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn2.ForeColor = System.Drawing.Color.Coral;
            this.bttn2.Location = new System.Drawing.Point(546, 657);
            this.bttn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(110, 45);
            this.bttn2.TabIndex = 65;
            this.bttn2.Text = "ADD";
            this.bttn2.UseVisualStyleBackColor = false;
            this.bttn2.Click += new System.EventHandler(this.bttn2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 933);
            this.panel5.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(-2, 391);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(296, 54);
            this.button5.TabIndex = 11;
            this.button5.Text = "New User";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(-2, 306);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "Record";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Pink;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Lavender;
            this.button8.Location = new System.Drawing.Point(36, 540);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(258, 54);
            this.button8.TabIndex = 9;
            this.button8.Text = "LOGOUT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(-2, 225);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(296, 54);
            this.button7.TabIndex = 9;
            this.button7.Text = "Customer";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(-2, 143);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cash Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(-2, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cash In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 933);
            this.panel4.TabIndex = 64;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(834, 411);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(725, 202);
            this.dataGridView1.TabIndex = 71;
            // 
            // Insertinsqltable
            // 
            this.Insertinsqltable.BackColor = System.Drawing.Color.MediumBlue;
            this.Insertinsqltable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Insertinsqltable.Location = new System.Drawing.Point(701, 443);
            this.Insertinsqltable.Name = "Insertinsqltable";
            this.Insertinsqltable.Size = new System.Drawing.Size(110, 45);
            this.Insertinsqltable.TabIndex = 72;
            this.Insertinsqltable.Text = "Insert in sql table";
            this.Insertinsqltable.UseVisualStyleBackColor = false;
            this.Insertinsqltable.Click += new System.EventHandler(this.Insertinsqltable_Click);
            // 
            // CashInner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.Insertinsqltable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcashcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProdGV);
            this.Controls.Add(this.txtcashtotal);
            this.Controls.Add(this.txtcashnet);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttn2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1946, 1106);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1006);
            this.Name = "CashInner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashInner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcashcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ProdGV;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.TextBox txtcashtotal;
        private System.Windows.Forms.TextBox txtcashnet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insertinsqltable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSG;

    }
}