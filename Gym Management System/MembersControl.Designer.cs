namespace Gym_Management_System
{
    partial class MembersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchbyID = new System.Windows.Forms.TextBox();
            this.txtSearchbyName = new System.Windows.Forms.TextBox();
            this.gvMembers = new System.Windows.Forms.DataGridView();
            this.btnExpiredMembership = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.btnSearchbyName = new System.Windows.Forms.PictureBox();
            this.SearchByID = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchbyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchbyID
            // 
            this.txtSearchbyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbyID.Location = new System.Drawing.Point(42, 12);
            this.txtSearchbyID.Name = "txtSearchbyID";
            this.txtSearchbyID.Size = new System.Drawing.Size(201, 30);
            this.txtSearchbyID.TabIndex = 0;
            this.txtSearchbyID.Text = "Search by ID";
            // 
            // txtSearchbyName
            // 
            this.txtSearchbyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbyName.Location = new System.Drawing.Point(407, 12);
            this.txtSearchbyName.Name = "txtSearchbyName";
            this.txtSearchbyName.Size = new System.Drawing.Size(201, 30);
            this.txtSearchbyName.TabIndex = 4;
            this.txtSearchbyName.Text = "Search by Name";
            // 
            // gvMembers
            // 
            this.gvMembers.AllowUserToOrderColumns = true;
            this.gvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMembers.Location = new System.Drawing.Point(9, 67);
            this.gvMembers.Name = "gvMembers";
            this.gvMembers.RowHeadersWidth = 51;
            this.gvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvMembers.RowTemplate.Height = 24;
            this.gvMembers.Size = new System.Drawing.Size(813, 314);
            this.gvMembers.TabIndex = 5;
            // 
            // btnExpiredMembership
            // 
            this.btnExpiredMembership.BackColor = System.Drawing.Color.Red;
            this.btnExpiredMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpiredMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiredMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredMembership.ForeColor = System.Drawing.Color.White;
            this.btnExpiredMembership.Location = new System.Drawing.Point(9, 454);
            this.btnExpiredMembership.Name = "btnExpiredMembership";
            this.btnExpiredMembership.Size = new System.Drawing.Size(295, 40);
            this.btnExpiredMembership.TabIndex = 7;
            this.btnExpiredMembership.Text = "Expired Membership";
            this.btnExpiredMembership.UseVisualStyleBackColor = false;
            this.btnExpiredMembership.Click += new System.EventHandler(this.btnExpiredMembership_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(527, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Membership Application";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::Gym_Management_System.Properties.Resources.icons8_refresh_50;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Location = new System.Drawing.Point(729, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(58, 58);
            this.refresh.TabIndex = 9;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // btnSearchbyName
            // 
            this.btnSearchbyName.BackColor = System.Drawing.Color.Black;
            this.btnSearchbyName.BackgroundImage = global::Gym_Management_System.Properties.Resources.MagnifyingglassBlack;
            this.btnSearchbyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchbyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchbyName.Location = new System.Drawing.Point(614, 12);
            this.btnSearchbyName.Name = "btnSearchbyName";
            this.btnSearchbyName.Size = new System.Drawing.Size(55, 30);
            this.btnSearchbyName.TabIndex = 3;
            this.btnSearchbyName.TabStop = false;
            this.btnSearchbyName.Click += new System.EventHandler(this.btnSearchbyName_Click);
            // 
            // SearchByID
            // 
            this.SearchByID.BackColor = System.Drawing.Color.Black;
            this.SearchByID.BackgroundImage = global::Gym_Management_System.Properties.Resources.MagnifyingglassBlack;
            this.SearchByID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchByID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByID.Location = new System.Drawing.Point(249, 12);
            this.SearchByID.Name = "SearchByID";
            this.SearchByID.Size = new System.Drawing.Size(55, 30);
            this.SearchByID.TabIndex = 2;
            this.SearchByID.TabStop = false;
            this.SearchByID.Click += new System.EventHandler(this.SearchByID_Click);
            // 
            // MembersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExpiredMembership);
            this.Controls.Add(this.gvMembers);
            this.Controls.Add(this.txtSearchbyName);
            this.Controls.Add(this.btnSearchbyName);
            this.Controls.Add(this.SearchByID);
            this.Controls.Add(this.txtSearchbyID);
            this.Name = "MembersControl";
            this.Size = new System.Drawing.Size(829, 507);
            this.Load += new System.EventHandler(this.MembersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchbyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchbyID;
        private System.Windows.Forms.PictureBox SearchByID;
        private System.Windows.Forms.PictureBox btnSearchbyName;
        private System.Windows.Forms.TextBox txtSearchbyName;
        private System.Windows.Forms.DataGridView gvMembers;
        private System.Windows.Forms.Button btnExpiredMembership;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renewDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn qRCodeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencytoContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTCRelationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox refresh;
    }
}
