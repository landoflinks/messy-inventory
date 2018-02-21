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
            this.TxtEmployeeNum = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtBirthday = new System.Windows.Forms.TextBox();
            this.TxtSpecialty = new System.Windows.Forms.TextBox();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.CmbPosition = new System.Windows.Forms.ComboBox();
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
            this.LblSpecialty.Size = new System.Drawing.Size(70, 17);
            this.LblSpecialty.TabIndex = 5;
            this.LblSpecialty.Text = "Expertise:";
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
            this.CmbCancel.Location = new System.Drawing.Point(312, 247);
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
            this.CmbSubmit.Location = new System.Drawing.Point(96, 247);
            this.CmbSubmit.Name = "CmbSubmit";
            this.CmbSubmit.Size = new System.Drawing.Size(82, 30);
            this.CmbSubmit.TabIndex = 14;
            this.CmbSubmit.Text = "Submit";
            this.CmbSubmit.UseVisualStyleBackColor = true;
            this.CmbSubmit.Click += new System.EventHandler(this.CmbSubmit_Click);
            // 
            // TxtEmployeeNum
            // 
            this.TxtEmployeeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtEmployeeNum.Location = new System.Drawing.Point(104, 6);
            this.TxtEmployeeNum.Name = "TxtEmployeeNum";
            this.TxtEmployeeNum.Size = new System.Drawing.Size(219, 23);
            this.TxtEmployeeNum.TabIndex = 16;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtFirstName.Location = new System.Drawing.Point(104, 40);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(219, 23);
            this.TxtFirstName.TabIndex = 17;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtLastName.Location = new System.Drawing.Point(104, 74);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(219, 23);
            this.TxtLastName.TabIndex = 18;
            // 
            // TxtBirthday
            // 
            this.TxtBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtBirthday.Location = new System.Drawing.Point(104, 106);
            this.TxtBirthday.Name = "TxtBirthday";
            this.TxtBirthday.Size = new System.Drawing.Size(219, 23);
            this.TxtBirthday.TabIndex = 19;
            this.TxtBirthday.Text = "01/01/17";
            // 
            // TxtSpecialty
            // 
            this.TxtSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSpecialty.Location = new System.Drawing.Point(104, 173);
            this.TxtSpecialty.Name = "TxtSpecialty";
            this.TxtSpecialty.Size = new System.Drawing.Size(219, 23);
            this.TxtSpecialty.TabIndex = 20;
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(104, 216);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(15, 14);
            this.ChkActive.TabIndex = 21;
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // CmbPosition
            // 
            this.CmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Items.AddRange(new object[] {
            "Clerk",
            "Shift Lead",
            "Manager",
            "Owner"});
            this.CmbPosition.Location = new System.Drawing.Point(104, 137);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(219, 24);
            this.CmbPosition.TabIndex = 22;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 288);
            this.Controls.Add(this.CmbPosition);
            this.Controls.Add(this.ChkActive);
            this.Controls.Add(this.TxtSpecialty);
            this.Controls.Add(this.TxtBirthday);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtEmployeeNum);
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
        private System.Windows.Forms.TextBox TxtEmployeeNum;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtBirthday;
        private System.Windows.Forms.TextBox TxtSpecialty;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.ComboBox CmbPosition;
    }
}