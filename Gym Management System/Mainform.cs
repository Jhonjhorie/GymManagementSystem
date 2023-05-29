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

namespace Gym_Management_System.View.Admin
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();


        }

        DashboardControl Dashboard = new DashboardControl();
        MembersControl Members = new MembersControl();  
        EquipmentsControl Equipments = new EquipmentsControl();
        GymStaff Gymstaff = new GymStaff();
        private void Mainform_Load(object sender, EventArgs e)
        {
            Navtitle.Text = "Dashboard";
            Dashboard.Show();
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.BringToFront();
            Members.Hide();
            Equipments.Hide();
            Gymstaff.Hide();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Navtitle.Text = "Dashboard";
            Dashboard.Show();
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.BringToFront();
            Members.Hide();
            Equipments.Hide();
            Gymstaff.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Navtitle.Text = "Members";
            Members.Show();
            Members.Dock = DockStyle.Fill;
            Members.BringToFront();
            Dashboard.Hide();
            Equipments.Hide();
            Gymstaff.Hide();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            Navtitle.Text = "Equipments";
            Equipments.Show();
            Equipments.Dock = DockStyle.Fill;
            Equipments.BringToFront();
            Members.Hide();
            Dashboard.Hide();
            Gymstaff.Hide();
        }

        private void btnGymStaff_Click(object sender, EventArgs e)
        {
            Navtitle.Text = "Gym Staff";
            Gymstaff.Show();
            Gymstaff.Dock = DockStyle.Fill;
            Gymstaff.BringToFront();
            Members.Hide();
            Dashboard.Hide();
            Equipments.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            Dashboard.Hide(); 
            Members.Hide();
            Equipments.Hide();
            Gymstaff.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings adminSettings = new AdminSettings();
            adminSettings.Show();   
        }
    }
}
