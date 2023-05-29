using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gym_Management_System
{
    public partial class MembersControl : UserControl
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jhonj\\OneDrive\\Desktop\\GymManagementSystem\\Gym Management System\\GMSDB.mdf\";Integrated Security=True";
        public MembersControl()
        {
            InitializeComponent();
        }

        private void MembersControl_Load(object sender, EventArgs e)
        {
            membersdata();

        }
        private void membersdata()
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select * from Members", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtclients = new DataTable();
            dtclients.Load(sdr);
            con.Close();
            gvMembers.DataSource = dtclients;
        }

        private void btnExpiredMembership_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select * from Members Where ExpiryDate < GetDate()", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtclients = new DataTable();
            dtclients.Load(sdr);
            con.Close();
            gvMembers.DataSource = dtclients;
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            membersdata();
        }

        private void SearchByID_Click(object sender, EventArgs e)
        {
            string searchByID = txtSearchbyID.Text;


            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE MemberId = @SearchByID", con);
                cmd.Parameters.AddWithValue("@SearchByID", searchByID);

                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtClients = new DataTable();
                dtClients.Load(sdr);
                con.Close();

                gvMembers.DataSource = dtClients;
            }
        }

        private void btnSearchbyName_Click(object sender, EventArgs e)
        {
            string searchByName = txtSearchbyName.Text;


            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE MemberId = @searchByName", con);
                cmd.Parameters.AddWithValue("@searchByName", searchByName);

                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtClients = new DataTable();
                dtClients.Load(sdr);
                con.Close();

                gvMembers.DataSource = dtClients;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MembershipApplication application = new MembershipApplication();
            application.Show();
        }

    }
}
