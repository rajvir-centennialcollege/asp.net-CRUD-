using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RajvirKaur_Lab4
{
    public partial class index : System.Web.UI.Page
    {
        SqlCommand comm;

        SqlConnection newConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void addButton_Click(object sender, EventArgs e)
        {

            comm = new SqlCommand("INSERT INTO Student(StudentID,FirstName,LastName)" + "VALUES (@stuID, @fName, @lName)", newConnection);
            comm.Parameters.Add("@stuID", System.Data.SqlDbType.Int);
            comm.Parameters["@stuID"].Value = studentID.Text;

            comm.Parameters.Add("@fName", System.Data.SqlDbType.Char);
            comm.Parameters["@fName"].Value = firstName.Text;

            comm.Parameters.Add("@lName", System.Data.SqlDbType.Char);
            comm.Parameters["@lName"].Value = lastName.Text;

            newConnection.Open();
            
            comm.ExecuteNonQuery();
            
            
            newConnection.Close();


        }

        protected void delButton_Click(object sender, EventArgs e)
        {
           
        }

        protected void getButton_Click(object sender, EventArgs e)
        {
           
                 comm = new SqlCommand("SELECT StudentID,LastName" + " FROM Student where StudentID = @stuID", newConnection);
                int stuID;
                if(!int.TryParse(studentID.Text, out stuID))
            {
                message.Text = "Please Enter the valid Student ID";
            }
            else
            {

                comm.Parameters.Add("@stuID", System.Data.SqlDbType.Int);
                comm.Parameters["@stuID"].Value = stuID;
                newConnection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if(reader.Read())
                {
                    message.Text = "Student ID:" + " " +
                        reader["StudentID"] + "<br/>" +
                        "Last Name: " + " " + reader["LastName"] + "<br/>";
                }
                else
                {
                    message.Text = "There is no such Student Record  for ID" + " " +stuID;

                }
                reader.Close();
                newConnection.Close();


            }
                
            }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            comm = new SqlCommand("UPDATE Student SET FirstName = @fName, LastName = @lName WHERE StudentID = @stuID", newConnection);
            comm.Parameters.Add("@stuID", System.Data.SqlDbType.Char);
            comm.Parameters["@stuID"].Value = studentID.Text;

            comm.Parameters.Add("@fName", System.Data.SqlDbType.Char);
            comm.Parameters["@fName"].Value = firstName.Text;

            comm.Parameters.Add("@lName", System.Data.SqlDbType.Char);
            comm.Parameters["@lName"].Value = lastName.Text;

            newConnection.Open();
            comm.ExecuteNonQuery();
            newConnection.Close();
        }
    }
}