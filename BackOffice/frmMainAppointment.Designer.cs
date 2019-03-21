namespace BackOffice
{
    partial class frmMainAppointment
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
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAppointments
            // 
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.Location = new System.Drawing.Point(56, 60);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(317, 186);
            this.lstAppointments.TabIndex = 0;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(56, 261);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(56, 291);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = ".";
            // 
            // frmMainAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 375);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.lstAppointments);
            this.Name = "frmMainAppointment";
            this.Text = "Appointment Manager";
            this.Load += new System.EventHandler(this.frmMainAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label lblError;
    }
}

