namespace Gym_Management_System
{
    partial class MembershipApplication
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
            this.txtEMGCYRelationship = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMembershipType = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEMGYContactInfo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEMGYName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCivilStatus = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Navtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pbMemberPic = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEMGCYRelationship
            // 
            this.txtEMGCYRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMGCYRelationship.Location = new System.Drawing.Point(20, 176);
            this.txtEMGCYRelationship.Name = "txtEMGCYRelationship";
            this.txtEMGCYRelationship.Size = new System.Drawing.Size(195, 26);
            this.txtEMGCYRelationship.TabIndex = 28;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Green;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(619, 393);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(213, 30);
            this.btnApply.TabIndex = 53;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 30);
            this.button1.TabIndex = 51;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Items.AddRange(new object[] {
            "Weekly",
            "SemiMonthly",
            "Monthly",
            "SemiYearly",
            "Yearly"});
            this.cbMembershipType.Location = new System.Drawing.Point(356, 334);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(182, 28);
            this.cbMembershipType.TabIndex = 50;
            this.cbMembershipType.SelectedIndexChanged += new System.EventHandler(this.cbMembershipType_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.txtEMGCYRelationship);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtEMGYContactInfo);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtEMGYName);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(601, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 225);
            this.panel5.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "RelationShip:";
            // 
            // txtEMGYContactInfo
            // 
            this.txtEMGYContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMGYContactInfo.Location = new System.Drawing.Point(19, 125);
            this.txtEMGYContactInfo.Name = "txtEMGYContactInfo";
            this.txtEMGYContactInfo.Size = new System.Drawing.Size(195, 26);
            this.txtEMGYContactInfo.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Contact Info:";
            // 
            // txtEMGYName
            // 
            this.txtEMGYName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMGYName.Location = new System.Drawing.Point(20, 72);
            this.txtEMGYName.Name = "txtEMGYName";
            this.txtEMGYName.Size = new System.Drawing.Size(195, 26);
            this.txtEMGYName.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "In Case Of Emergency";
            // 
            // cbCivilStatus
            // 
            this.cbCivilStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCivilStatus.FormattingEnabled = true;
            this.cbCivilStatus.Location = new System.Drawing.Point(452, 174);
            this.cbCivilStatus.Name = "cbCivilStatus";
            this.cbCivilStatus.Size = new System.Drawing.Size(127, 28);
            this.cbCivilStatus.TabIndex = 48;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(452, 110);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(127, 28);
            this.cbGender.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(352, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Membership Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(448, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Civil Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(448, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Gender:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(34, 336);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(255, 26);
            this.txtEmailAddress.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(32, 252);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(547, 34);
            this.txtAddress.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Address:";
            // 
            // txtContNo
            // 
            this.txtContNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContNo.Location = new System.Drawing.Point(205, 174);
            this.txtContNo.Name = "txtContNo";
            this.txtContNo.Size = new System.Drawing.Size(182, 26);
            this.txtContNo.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(205, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 26);
            this.txtName.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 385);
            this.panel2.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 10);
            this.panel4.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(858, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 395);
            this.panel3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Contact Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Navtitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 55);
            this.panel1.TabIndex = 30;
            // 
            // Navtitle
            // 
            this.Navtitle.AutoSize = true;
            this.Navtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navtitle.Location = new System.Drawing.Point(12, 9);
            this.Navtitle.Name = "Navtitle";
            this.Navtitle.Size = new System.Drawing.Size(195, 36);
            this.Navtitle.TabIndex = 3;
            this.Navtitle.Text = "Add Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name: ";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(597, 314);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(88, 18);
            this.lblBirthDate.TabIndex = 54;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 337);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::Gym_Management_System.Properties.Resources.icons8_minimize_50;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Location = new System.Drawing.Point(760, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(49, 43);
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::Gym_Management_System.Properties.Resources.icons8_circled_x_50;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(815, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 40);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            // 
            // pbMemberPic
            // 
            this.pbMemberPic.BackgroundImage = global::Gym_Management_System.Properties.Resources.Insert_Image_Here;
            this.pbMemberPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMemberPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMemberPic.Location = new System.Drawing.Point(32, 72);
            this.pbMemberPic.Name = "pbMemberPic";
            this.pbMemberPic.Size = new System.Drawing.Size(163, 151);
            this.pbMemberPic.TabIndex = 27;
            this.pbMemberPic.TabStop = false;
            this.pbMemberPic.Click += new System.EventHandler(this.pbMemberPic_Click);
            // 
            // MembershipApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMembershipType);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cbCivilStatus);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMemberPic);
            this.Name = "MembershipApplication";
            this.Text = "MembershipApplication";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEMGCYRelationship;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbMembershipType;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEMGYContactInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEMGYName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCivilStatus;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label Navtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMemberPic;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}