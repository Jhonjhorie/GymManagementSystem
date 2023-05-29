namespace Gym_Management_System
{
    partial class EquipmentsControl
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
            this.Members = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Members
            // 
            this.Members.AutoSize = true;
            this.Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.Location = new System.Drawing.Point(293, 224);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(300, 58);
            this.Members.TabIndex = 1;
            this.Members.Text = "Equipments";
            // 
            // EquipmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Members);
            this.Name = "EquipmentsControl";
            this.Size = new System.Drawing.Size(829, 507);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Members;
    }
}
