using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection.Metadata;
using System.Data;

namespace LexingtonAcademy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < clbClasses.Items.Count - 1; i++)
            //{
            //    SqlConnection conn = new SqlConnection("Data Source=AUSTINDELL;Initial Catalog=LexingtonPreschool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //    SqlCommand cmd = new SqlCommand("Insert Into Students(FirstName, LastName, Classes)Values(@FirstName,@LastName,@Classes)", conn);
            //    cmd.Parameters.AddWithValue("FirstName", tbFirstName.Text);
            //    cmd.Parameters.AddWithValue("LastName", tbLastName.Text);
            //    cmd.Parameters.AddWithValue("Classes", clbClasses.GetItemCheckState(i));
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    this.Close();
            //}

            
            string connectionString = "Data Source=AUSTINDELL;Initial Catalog=LexingtonPreschool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlQuery = "INSERT INTO Students (FirstName, LastName, Classes) VALUES (" + "'" + tbFirstName.Text + "'" + "," + "'" + tbLastName.Text + "'" + "," + "'" + clbClasses.Text + "'" + ")";


            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
            this.Close();
            var myForm = new Form2();
            myForm.Show();

        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (SqlConnection sqlConn = new SqlConnection("Data Source=AUSTINDELL;Initial Catalog=LexingtonPreschool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) ;
            //{
            //    SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Classes", sqlConn);
            //    sqlConn.Open();
            //    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            //    while(sqlReader.Read())
            //    {
            //        cbClasses.Items.Add(sqlReader.GetString(0));
            //    }
            //    sqlReader.Close();
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbClasses_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }
    }
}