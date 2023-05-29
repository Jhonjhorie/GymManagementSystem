using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace Gym_Management_System
{
    public partial class MembershipViewDetail : Form
    {
        public MembershipViewDetail()
        {
            InitializeComponent();
        }

        private void btnPreviewID_Click(object sender, EventArgs e)
        {
            MembershipDisplayID DisplayID = new MembershipDisplayID();
            DisplayID.Show();
        }
    }
}
