namespace WindowsFormsApplication1
{
    partial class AccountProfile
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
            this.Search = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateJoined = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(365, 442);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(105, 36);
            this.Search.TabIndex = 12;
            this.Search.Text = "search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(248, 562);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 36);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(442, 562);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 36);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(653, 562);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 36);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Show";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(322, 359);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 452);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(322, 26);
            this.textBoxSearch.TabIndex = 4;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(798, 15);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(322, 26);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(398, 200);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(322, 26);
            this.textBoxMobile.TabIndex = 2;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(398, 106);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(322, 26);
            this.textBoxLName.TabIndex = 1;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(398, 21);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(322, 26);
            this.textBoxFname.TabIndex = 0;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(798, 407);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(322, 26);
            this.textBoxPost.TabIndex = 6;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(798, 348);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(322, 26);
            this.textBoxSalary.TabIndex = 5;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(398, 247);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(322, 26);
            this.textBoxMail.TabIndex = 3;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(798, 111);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(994, 110);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 6;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(920, 442);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateOfBirth.TabIndex = 7;
            // 
            // dateTimePickerDateJoined
            // 
            this.dateTimePickerDateJoined.Location = new System.Drawing.Point(920, 515);
            this.dateTimePickerDateJoined.Name = "dateTimePickerDateJoined";
            this.dateTimePickerDateJoined.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateJoined.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enter Id For Search ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "FName";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "LNAme";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(731, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(331, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Mobile";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(731, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 22;
            this.label17.Text = "Post";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(726, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Gender";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(337, 250);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "Mail";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(737, 351);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Salary";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(742, 447);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "dob";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(742, 520);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 20);
            this.label22.TabIndex = 24;
            this.label22.Text = "Register Date";
            // 
            // AccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 665);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDateJoined);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Search);
            this.Name = "AccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.Load += new System.EventHandler(this.AccountProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.Button buttonSearch;
        //private System.Windows.Forms.TreeView treeView1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox textBoxFname;
        //private System.Windows.Forms.TextBox textBoxLName;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.TextBox textBoxMobile;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.TextBox textBoxMail;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.TextBox textBoxSearch;
        //private System.Windows.Forms.TextBox textBoxCity;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.TextBox textBoxPost;
        //private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.TextBox textBoxSalary;
        //private System.Windows.Forms.Label label9;
        //private System.Windows.Forms.RadioButton radioButtonMale;
        //private System.Windows.Forms.RadioButton radioButtonFemale;
        //private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        //private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.DateTimePicker dateTimePickerDateJoined;
        //private System.Windows.Forms.Button buttonUpdate;
        //private System.Windows.Forms.Button buttonDelete;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button buttonInsertIntoMSSQLDb;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateJoined;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}