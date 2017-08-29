namespace messy_inventory
{
    partial class AddEmployee
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
            this.LblEmployeeNum = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthday = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblSpecialty = new System.Windows.Forms.Label();
            this.LblActive = new System.Windows.Forms.Label();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmployeeNum
            // 
            this.LblEmployeeNum.AutoSize = true;
            this.LblEmployeeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblEmployeeNum.Location = new System.Drawing.Point(12, 9);
            this.LblEmployeeNum.Name = "LblEmployeeNum";
            this.LblEmployeeNum.Size = new System.Drawing.Size(86, 17);
            this.LblEmployeeNum.TabIndex = 0;
            this.LblEmployeeNum.Text = "Employee #:";
            this.LblEmployeeNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblFirstName.Location = new System.Drawing.Point(18, 43);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(80, 17);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name:";
            this.LblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblLastName.Location = new System.Drawing.Point(18, 77);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(80, 17);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Last Name:";
            this.LblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblBirthday
            // 
            this.LblBirthday.AutoSize = true;
            this.LblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblBirthday.Location = new System.Drawing.Point(34, 109);
            this.LblBirthday.Name = "LblBirthday";
            this.LblBirthday.Size = new System.Drawing.Size(64, 17);
            this.LblBirthday.TabIndex = 3;
            this.LblBirthday.Text = "Birthday:";
            this.LblBirthday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPosition.Location = new System.Drawing.Point(36, 140);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(62, 17);
            this.LblPosition.TabIndex = 4;
            this.LblPosition.Text = "Position:";
            this.LblPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblSpecialty
            // 
            this.LblSpecialty.AutoSize = true;
            this.LblSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSpecialty.Location = new System.Drawing.Point(29, 176);
            this.LblSpecialty.Name = "LblSpecialty";
            this.LblSpecialty.Size = new System.Drawing.Size(69, 17);
            this.LblSpecialty.TabIndex = 5;
            this.LblSpecialty.Text = "Specialty:";
            this.LblSpecialty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblActive
            // 
            this.LblActive.AutoSize = true;
            this.LblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblActive.Location = new System.Drawing.Point(48, 213);
            this.LblActive.Name = "LblActive";
            this.LblActive.Size = new System.Drawing.Size(50, 17);
            this.LblActive.TabIndex = 6;
            this.LblActive.Text = "Active:";
            this.LblActive.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbCancel.Location = new System.Drawing.Point(312, 262);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(82, 30);
            this.CmbCancel.TabIndex = 15;
            this.CmbCancel.Text = "Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            this.CmbCancel.Click += new System.EventHandler(this.CmbCancel_Click);
            // 
            // CmbSubmit
            // 
            this.CmbSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbSubmit.Location = new System.Drawing.Point(96, 262);
            this.CmbSubmit.Name = "CmbSubmit";
            this.CmbSubmit.Size = new System.Drawing.Size(82, 30);
            this.CmbSubmit.TabIndex = 14;
            this.CmbSubmit.Text = "Submit";
            this.CmbSubmit.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 304);
            this.Controls.Add(this.CmbCancel);
            this.Controls.Add(this.CmbSubmit);
            this.Controls.Add(this.LblActive);
            this.Controls.Add(this.LblSpecialty);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.LblBirthday);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblEmployeeNum);
            this.Name = "AddEmployee";
            this.Text = "Add New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeNum;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblBirthday;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblSpecialty;
        private System.Windows.Forms.Label LblActive;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbSubmit;
    }
}