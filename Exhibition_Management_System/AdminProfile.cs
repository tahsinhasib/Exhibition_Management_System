﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exhibition_Management_System
{
    public partial class AdminProfile : Form
    {
        public AdminProfile(string Profile)
        {
            InitializeComponent();

            SqlConnection con = null;

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-TGP1F01;Initial Catalog=ExhibitDB;Integrated Security=True");
                con.Open();

                /* -->>> string query1 = "SELECT Username FROM UserDataTable WHERE Username = '" + Profile + "'";
                 * 
                 * This line constructs a SQL query string that will be used to select the "Username" 
                 * column from the "UserDataTable" table where the "Username" column matches the input 
                 * "Profile" string. The query string is stored in the query1 variable.
                 * 
                 * -->>> SqlCommand cmd1 = new SqlCommand(query1, con);
                 * 
                 * This line creates a new SqlCommand object named cmd1 that will execute the SQL query 
                 * stored in the query1 variable. The con parameter passed to the constructor is a 
                 * SqlConnection object that represents the connection to the database.
                 * 
                 * 
                 * -->>> DataSet ds1 = new DataSet();
                 * 
                 * This line creates a new DataSet object named ds1 that will hold the results of the SQL query.
                 * 
                 * -->>> SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
                 * 
                 * This line creates a new SqlDataAdapter object named adp1 that will fill the DataSet object with 
                 * data from the database using the SqlCommand object cmd1
                 * 
                 * -->>> adp1.Fill(ds1);
                 * 
                 * This line executes the SQL query and fills the DataSet object ds1 with the result.
                 * 
                 * -->>> DataTable dt1 = ds1.Tables[0];
                 * 
                 * This line creates a new DataTable object named dt1 that contains the first table of the DataSet 
                 * object ds1, which in this case will contain only one table.
                 * 
                 * -->>> string Username = dt1.Rows[0]["Username"].ToString();
                 * 
                 * This line retrieves the value of the "Username" column from the first row of the DataTable object 
                 * dt1 and stores it in the Username variable as a string.
                 * 
                 * -->>> label9.Text = Username;
                 * 
                 * This line sets the Text property of a Label object named label9 to the value of the Username variable, 
                 * which will display the retrieved "Username" value in the UI.
                 */




                string query1 = "SELECT Username FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                DataSet ds1 = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
                adp1.Fill(ds1);
                DataTable dt1 = ds1.Tables[0];
                string Username = dt1.Rows[0]["Username"].ToString();
                label9.Text = Username;

                string query2 = "SELECT Password FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                DataSet ds2 = new DataSet();
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                adp2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                string Password = dt2.Rows[0]["Password"].ToString();
                label10.Text = Password;

                string query3 = "SELECT Phone FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                DataSet ds3 = new DataSet();
                SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                adp3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                string Phone = dt3.Rows[0]["Phone"].ToString();
                label11.Text = Phone;

                string query4 = "SELECT Email FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                DataSet ds4 = new DataSet();
                SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
                adp4.Fill(ds4);
                DataTable dt4 = ds4.Tables[0];
                string Email = dt4.Rows[0]["Email"].ToString();
                label12.Text = Email;

                string query5 = "SELECT Gender FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd5 = new SqlCommand(query5, con);
                DataSet ds5 = new DataSet();
                SqlDataAdapter adp5 = new SqlDataAdapter(cmd5);
                adp5.Fill(ds5);
                DataTable dt5 = ds5.Tables[0];
                string Gender = dt5.Rows[0]["Gender"].ToString();
                label13.Text = Gender;

                string query6 = "SELECT Account FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd6 = new SqlCommand(query6, con);
                DataSet ds6 = new DataSet();
                SqlDataAdapter adp6 = new SqlDataAdapter(cmd6);
                adp6.Fill(ds6);
                DataTable dt6 = ds6.Tables[0];
                string Account = dt6.Rows[0]["Account"].ToString();
                label14.Text = Account;

                string query7 = "SELECT Address FROM UserDataTable WHERE Username = '" + Profile + "'";
                SqlCommand cmd7 = new SqlCommand(query7, con);
                DataSet ds7 = new DataSet();
                SqlDataAdapter adp7 = new SqlDataAdapter(cmd7);
                adp7.Fill(ds7);
                DataTable dt7 = ds7.Tables[0];
                string Address = dt7.Rows[0]["Address"].ToString();
                label15.Text = Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            // Selects the value for roundness
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 40, 40));
        }


        /*A method signature for an external method call to the Windows GDI (Graphics Device Interface) 
         * library function "CreateRoundRectRgn" The CreateRoundRectRgn method is used to create a region 
         * with rounded corners, which can be used to define the shape of a window, a button, or any other 
         * control in a graphical user interface. The parameters to this function specify the coordinates 
         * of a rectangle and the size of the ellipse that defines the curvature of the corners.
         * 
         * The DllImport attribute is used to indicate that this method is implemented in an external 
         * library (Gdi32.dll in this case) and that the method signature should be marshaled to and from 
         * unmanaged code. The EntryPoint parameter specifies the name of the function in the external 
         * library that corresponds to this method.
         * 
         * The IntPtr return type indicates that the method returns a handle to the region that is created, 
         * which can be used in other GDI functions to manipulate the region.
         * 
         * Responsible for making the outlines rounded for buttons and panels.
         */


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
