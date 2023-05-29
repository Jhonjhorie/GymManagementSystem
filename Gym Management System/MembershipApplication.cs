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
using ZXing.Common;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Gym_Management_System
{
    public partial class MembershipApplication : Form
    {
        public MembershipApplication()
        {
            InitializeComponent();
        }

        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jhonj\\OneDrive\\Desktop\\GymManagementSystem\\Gym Management System\\GMSDB.mdf\";Integrated Security=True";



        private void pbMemberPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(imagePath);

                // Display the selected image in the PictureBox
                pbMemberPic.Image = selectedImage;
            }
        }


        private byte[] savephoto()
        {
            MemoryStream ms = new MemoryStream();
            pbMemberPic.Image.Save(ms, pbMemberPic.Image.RawFormat);
            return ms.GetBuffer();
        }

        DateTime Expirydate;
        DateTime JoinDate = DateTime.Now;

        // auto select renewal date depending on membership type
        private void cbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMembershipType.SelectedIndex == 0)
            {
                Expirydate = DateTime.Now.AddDays(7);

            }
            if (cbMembershipType.SelectedIndex == 1)
            {
                Expirydate = DateTime.Now.AddDays(15);
            }
            if (cbMembershipType.SelectedIndex == 2)
            {
                Expirydate = DateTime.Now.AddDays(30);
            }
            if (cbMembershipType.SelectedIndex == 3)
            {
                Expirydate = DateTime.Now.AddDays(80);
            }
            if (cbMembershipType.SelectedIndex == 4)
            {
                Expirydate = DateTime.Now.AddDays(160);
            }
        }

        public string GenerateMemberID()
        {
            int nextMemberId = GetNextMemberIDFromDatabase();
            return "M" + nextMemberId.ToString();
        }

        private int GetNextMemberIDFromDatabase()
        {
            int nextMemberId = 0;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "SELECT MAX(CAST(SUBSTRING(MemberID, 2, LEN(MemberID) - 1) AS INT)) AS MaxMemberId FROM Members";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextMemberId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextMemberId;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {

            // Generate QR code content (member info)
            string qrCodeContent = $"{GenerateMemberID()}\n{txtName.Text}\n{JoinDate}";

            // Generate QR code image
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions { Width = 300, Height = 300, Margin = 0 }
            };
            Bitmap qrCodeImage = barcodeWriter.Write(qrCodeContent);

            // Convert QR code image to byte array
            byte[] qrCodeBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                qrCodeBytes = ms.ToArray();
            }

            // Insert member info and QR code into the database
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                string sql = "INSERT INTO Members (MemberID, FullName, Email, Phone, DateOfBirth, Gender, MembershipType, JoinDate, ExpiryDate, RenewDate, QRCode, MemberPicture, EmergencytoContact, EmergencyContactNo, ETCRelationship) " +
                             "VALUES (@MemberID, @FullName, @Email, @Phone, @DateOfBirth, @Gender, @MembershipType, @JoinDate, @ExpiryDate, @RenewDate, @QRCode, @MemberPicture, @EmergencytoContact, @EmergencyContactNo, @ETCRelationship)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", GenerateMemberID());
                    command.Parameters.AddWithValue("@FullName", txtName.Text);
                    command.Parameters.AddWithValue("@Email", txtEmailAddress.Text);
                    command.Parameters.AddWithValue("@Phone", txtContNo.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Gender", cbGender.Text);
                    command.Parameters.AddWithValue("@MembershipType", cbMembershipType.Text);
                    command.Parameters.AddWithValue("@JoinDate", DateTime.Now); 
                    command.Parameters.AddWithValue("@ExpiryDate", Expirydate); 
                    command.Parameters.AddWithValue("@RenewDate", DBNull.Value);
                    command.Parameters.AddWithValue("@QRCode", qrCodeBytes);
                    command.Parameters.AddWithValue("@MemberPicture", savephoto());
                    command.Parameters.AddWithValue("@EmergencytoContact", txtEMGYName.Text);
                    command.Parameters.AddWithValue("@EmergencyContactNo", txtEMGYContactInfo.Text); 
                    command.Parameters.AddWithValue("@ETCRelationship", txtEMGCYRelationship.Text); 
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Member added successfully.");
            clearinputs();
        }
        private void clearinputs()
        {
            txtName.Text = "";
            txtEmailAddress.Text = "";
            txtContNo.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cbGender.Text = "";
            cbMembershipType.Text = "";
            txtEMGYName.Text = "";
            txtEMGYContactInfo.Text = "";
            txtEMGCYRelationship.Text = ""; 
            pbMemberPic.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearinputs();
        }
        
    private string GenerateMemberID(int memberId)
    {
        return "M" + memberId.ToString();
    }



    }
}
