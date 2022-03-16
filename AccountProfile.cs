using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class AccountProfile : Form
    {

        //Creating DatabaseConnection Object
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public AccountProfile()
        {   //populating treeView From SQL Server
            populatetreeViewFromSQLServer();
            InitializeComponent();
        }

        //Search button click event.
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff WHERE SID = " + textBoxSearch.Text;
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxSearch.Text = dataReader.GetInt32(0).ToString();
                    textBoxFname.Text = (string)dataReader["Fname"];
                    textBoxLName.Text = (string)dataReader["lname"];
                    textBoxMobile.Text = dataReader.GetInt64(5).ToString();
                    if ((string)dataReader["gender"] == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if ((string)dataReader["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    dateTimePickerDateOfBirth.Text = (string)dataReader["dob"];
                    dateTimePickerDateJoined.Text = (string)dataReader["joindate"];
                    textBoxMail.Text = (string)dataReader["email"];
                    textBoxCity.Text = (string)dataReader["city"];
                    textBoxSalary.Text = dataReader.GetDecimal(9).ToString();
                    textBoxPost.Text = (string)dataReader["post"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();

                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection = After Select ");
                    connection.Close();
                }
            }

        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff WHERE SID = " + treeView1.SelectedNode.Text;
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxSearch.Text = dataReader.GetInt32(0).ToString();
                    textBoxFname.Text = (string)dataReader["Fname"];
                    textBoxLName.Text = (string)dataReader["lname"];
                    textBoxMobile.Text = dataReader["mobile"].ToString();
                    if ((string)dataReader["gender"] == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if ((string)dataReader["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    dateTimePickerDateOfBirth.Text = (string)dataReader["dob"];
                    dateTimePickerDateJoined.Text = (string)dataReader["joindate"];
                    textBoxMail.Text = (string)dataReader["email"];
                    textBoxCity.Text = (string)dataReader["city"];
                    textBoxSalary.Text = dataReader["basicSalary"].ToString();
                    textBoxPost.Text = (string)dataReader["post"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();

                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection = After Select ");
                    connection.Close();
                }
            }

        }

        private void populatetreeViewFromSQLServer()
        {
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff";
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    treeView1.BeginUpdate();
                    TreeNode node = new TreeNode(dataReader.GetInt32(0).ToString());
                    node.Nodes.Add((string)dataReader["Fname"]);
                    node.Nodes.Add((string)dataReader["lname"]);
                    node.Nodes.Add((string)dataReader["gender"]);
                    node.Nodes.Add((string)dataReader["dob"]);
                    node.Nodes.Add(dataReader.GetInt64(5).ToString());
                    node.Nodes.Add((string)dataReader["email"]);
                    node.Nodes.Add((string)dataReader["joindate"]);
                    node.Nodes.Add((string)dataReader["city"]);
                    node.Nodes.Add(dataReader.GetDecimal(9).ToString());

                    treeView1.Nodes.Add(node);
                    treeView1.EndUpdate();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection");
                    connection.Close();
                }

            }
        }
        private void clearAllFields()
        {
            textBoxSearch.Text = "";
            textBoxFname.Text = "";
            textBoxLName.Text = "";
            textBoxFname.Text = "";
            textBoxMobile.Text = "";
            if (radioButtonMale.Checked)
            {
                radioButtonMale.Checked = false;
            }
            else if (radioButtonFemale.Checked)
            {
                radioButtonFemale.Checked = false;
            }
            dateTimePickerDateOfBirth.Text = "";
            dateTimePickerDateJoined.Text = "";
            textBoxMail.Text = "";
            textBoxCity.Text = "";
            textBoxSalary.Text = "";
            textBoxPost.Text = "";
        }

        //Clear button click event.
        private void button1_Click_1(object sender, EventArgs e)
        {
            clearAllFields();
        }

        //Delete button click event.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This Data", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(textBoxSearch.Text))
                {
                    MessageBox.Show("Text Box Search Is Empty");
                }
                else
                {
                    SqlConnection connection = databaseConnection.getConn();
                    SqlCommand command = null;
                    string sql = "DELETE FROM Newstaff WHERE SID = " + textBoxSearch.Text;
                    try
                    {

                        connection.Open();
                        command = new SqlCommand(sql, connection);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("DELETED");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ! " + ex.Message);
                    }
                    finally
                    {
                        //Clear All Fields.
                        clearAllFields();
                        command.Dispose();
                        connection.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Data Not Removed", "Remove Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //Insert button click event.
        private void buttonInsertIntoMSSQLDb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFname.Text))
            {
                MessageBox.Show("There is one or more empty input field");
            }
            else
            {
                SqlConnection connection = databaseConnection.getConn();
                SqlCommand command = null;
                string sql = "INSERT INTO newstaff(Fname, lname, gender, dob, mobile, email, joindate, city, basicSalary, post) VALUES (@Fname, @lname, @gender, @dob, @mobile, @email, @joindate, @city, @basicSalary, @post )";
                try
                {
                    string gend = "";
                    if (radioButtonMale.Checked == true)
                    {
                        gend = "Male";
                    }
                    else
                        if (radioButtonFemale.Checked == true)
                        {
                            gend = "Female";
                        }
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = textBoxFname.Text;
                    command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = textBoxLName.Text;
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gend;
                    command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dateTimePickerDateOfBirth.Text;
                    command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = textBoxMobile.Text;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxMail.Text;
                    command.Parameters.Add("@joindate", SqlDbType.NVarChar).Value = dateTimePickerDateJoined.Text;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text;
                    command.Parameters.Add("@basicSalary", SqlDbType.NVarChar).Value = textBoxSalary.Text;
                    command.Parameters.Add("@post", SqlDbType.NVarChar).Value = textBoxPost.Text;

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Into Microsoft SQL Server Database Successfully");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ! " + ex.Message);
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFname.Text))
            {
                MessageBox.Show("There is one or more empty input field");
            }
            else {
                SqlConnection connection = databaseConnection.getConn();
                SqlCommand command = null;
                string sql = "INSERT INTO NeWStaff(Fname, lname, gender, dob, mobile, email, joindate, city, basicSalary, post) VALUES (@Fname, @lname, @gender, @dob, @mobile, @email, @joindate, @city, @basicSalary, @post )";
                try
                {
                    string gend = "";
                    if (radioButtonMale.Checked == true)
                    {
                        gend = "Male";
                    }
                    else
                        if (radioButtonFemale.Checked == true)
                    {
                        gend = "Female";
                    }
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    
                    command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = textBoxFname.Text;
                    command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = textBoxLName.Text;
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gend;
                    command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dateTimePickerDateOfBirth.Text;
                    command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = textBoxMobile.Text;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxMail.Text;
                    command.Parameters.Add("@joindate", SqlDbType.NVarChar).Value = dateTimePickerDateJoined.Text;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text;
                    command.Parameters.Add("@basicSalary", SqlDbType.NVarChar).Value = textBoxSalary.Text;
                    command.Parameters.Add("@post", SqlDbType.NVarChar).Value = textBoxPost.Text;

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Inserted Into Microsoft SQL Server Database Successfully");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ! " + ex.Message);
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
             if (String.IsNullOrEmpty(textBoxSearch.Text))
            {
                MessageBox.Show("text Box Search Is Empty");
            }
            else { 
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "UPDATE Newstaff SET Fname = @Fname, lname = @lname, gender = @gender, dob = @dob, mobile = @mobile, email = @email, joindate = @joindate, city = @city, basicSalary = @basicSalary, post = @post WHERE SID = " + textBoxSearch.Text;
            try
            {
                string gend = "";
                if (radioButtonMale.Checked == true)
                {
                    gend = "Male";
                } else
                    if (radioButtonFemale.Checked == true)
                {
                    gend = "Female";
                }
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = textBoxFname.Text;
                command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = textBoxLName.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gend;
                command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dateTimePickerDateOfBirth.Text;
                command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = textBoxMobile.Text;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxMail.Text;
                command.Parameters.Add("@joindate", SqlDbType.NVarChar).Value = dateTimePickerDateJoined.Text;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text;
                command.Parameters.Add("@basicSalary", SqlDbType.NVarChar).Value = textBoxSalary.Text;
                command.Parameters.Add("@post", SqlDbType.NVarChar).Value = textBoxPost.Text;
                
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Updated Data From Microsoft SQL Server Management Studio Successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! " + ex.Message);
            }
            finally
            {
                populatetreeViewFromSQLServer();
                command.Dispose();
                connection.Close();
            }

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This Data", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(textBoxSearch.Text))
                {
                    MessageBox.Show("Text Box Search Is Empty");
                }
                else
                {
                    SqlConnection connection = databaseConnection.getConn();
                    SqlCommand command = null;
                    string sql = "DELETE FROM Newstaff WHERE SID = " + textBoxSearch.Text;
                    try
                    {

                        connection.Open();
                        command = new SqlCommand(sql, connection);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("DELETED");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ! " + ex.Message);
                    }
                    finally
                    {
                        //Clear All Fields.
                        clearAllFields();
                        command.Dispose();
                        connection.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Data Not Removed", "Remove Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff WHERE SID = " + textBoxSearch.Text;
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxSearch.Text = dataReader.GetInt32(0).ToString();
                    textBoxFname.Text = (string)dataReader["Fname"];
                    textBoxLName.Text = (string)dataReader["lname"];
                    textBoxMobile.Text = dataReader.GetInt64(5).ToString();
                    if ((string)dataReader["gender"] == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if ((string)dataReader["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    dateTimePickerDateOfBirth.Text = (string)dataReader["dob"];
                    dateTimePickerDateJoined.Text = (string)dataReader["joindate"];
                    textBoxMail.Text = (string)dataReader["email"];
                    textBoxCity.Text = (string)dataReader["city"];
                    textBoxSalary.Text = dataReader.GetDecimal(9).ToString();
                    textBoxPost.Text = (string)dataReader["post"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();

                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection = After Select ");
                    connection.Close();
                }
            }

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff WHERE SID = " + treeView1.SelectedNode.Text;
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxSearch.Text = dataReader.GetInt32(0).ToString();
                    textBoxFname.Text = (string)dataReader["Fname"];
                    textBoxLName.Text = (string)dataReader["lname"];
                    textBoxMobile.Text = dataReader["mobile"].ToString();
                    if ((string)dataReader["gender"] == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if ((string)dataReader["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    dateTimePickerDateOfBirth.Text = (string)dataReader["dob"];
                    dateTimePickerDateJoined.Text = (string)dataReader["joindate"];
                    textBoxMail.Text = (string)dataReader["email"];
                    textBoxCity.Text = (string)dataReader["city"];
                    textBoxSalary.Text = dataReader["basicSalary"].ToString();
                    textBoxPost.Text = (string)dataReader["post"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();

                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection = After Select ");
                    connection.Close();
                }
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            SqlConnection connection = databaseConnection.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff WHERE SID = " + treeView1.SelectedNode.Text;
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxSearch.Text = dataReader.GetInt32(0).ToString();
                    textBoxFname.Text = (string)dataReader["Fname"];
                    textBoxLName.Text = (string)dataReader["lname"];
                    textBoxMobile.Text = dataReader["mobile"].ToString();
                    if ((string)dataReader["gender"] == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if ((string)dataReader["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    dateTimePickerDateOfBirth.Text = (string)dataReader["dob"];
                    dateTimePickerDateJoined.Text = (string)dataReader["joindate"];
                    textBoxMail.Text = (string)dataReader["email"];
                    textBoxCity.Text = (string)dataReader["city"];
                    textBoxSalary.Text = dataReader["basicSalary"].ToString();
                    textBoxPost.Text = (string)dataReader["post"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();

                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection = After Select ");
                    connection.Close();
                }
            }
        }

        private void AccountProfile_Load(object sender, EventArgs e)
        {

        }
        


    }
}
