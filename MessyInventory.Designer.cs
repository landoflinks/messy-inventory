namespace messy_inventory
{
    partial class FrmInventory
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.CmdAddGame = new System.Windows.Forms.Button();
            this.CmdAddEmployee = new System.Windows.Forms.Button();
            this.CmdEmployeeList = new System.Windows.Forms.Button();
            this.DgvInventory = new System.Windows.Forms.DataGridView();
            this.LstBoxEmployees = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(240, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Messy\'s Used Games";
            // 
            // CmdAddGame
            // 
            this.CmdAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmdAddGame.Location = new System.Drawing.Point(12, 116);
            this.CmdAddGame.Name = "CmdAddGame";
            this.CmdAddGame.Size = new System.Drawing.Size(131, 34);
            this.CmdAddGame.TabIndex = 2;
            this.CmdAddGame.Text = "Add Game";
            this.CmdAddGame.UseVisualStyleBackColor = true;
            this.CmdAddGame.Click += new System.EventHandler(this.CmdAddGame_Click);
            // 
            // CmdAddEmployee
            // 
            this.CmdAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmdAddEmployee.Location = new System.Drawing.Point(12, 67);
            this.CmdAddEmployee.Name = "CmdAddEmployee";
            this.CmdAddEmployee.Size = new System.Drawing.Size(131, 34);
            this.CmdAddEmployee.TabIndex = 3;
            this.CmdAddEmployee.Text = "Add Employee";
            this.CmdAddEmployee.UseVisualStyleBackColor = true;
            this.CmdAddEmployee.Click += new System.EventHandler(this.CmdAddEmployee_Click);
            // 
            // CmdEmployeeList
            // 
            this.CmdEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEmployeeList.Location = new System.Drawing.Point(300, 67);
            this.CmdEmployeeList.Name = "CmdEmployeeList";
            this.CmdEmployeeList.Size = new System.Drawing.Size(144, 34);
            this.CmdEmployeeList.TabIndex = 4;
            this.CmdEmployeeList.Text = "Employee List";
            this.CmdEmployeeList.UseVisualStyleBackColor = true;
            this.CmdEmployeeList.Click += new System.EventHandler(this.CmbEmployeeList_Click);
            // 
            // DgvInventory
            // 
            this.DgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInventory.Location = new System.Drawing.Point(12, 173);
            this.DgvInventory.Name = "DgvInventory";
            this.DgvInventory.Size = new System.Drawing.Size(716, 296);
            this.DgvInventory.TabIndex = 6;
            // 
            // LstBoxEmployees
            // 
            this.LstBoxEmployees.FormattingEnabled = true;
            this.LstBoxEmployees.Location = new System.Drawing.Point(490, 13);
            this.LstBoxEmployees.Name = "LstBoxEmployees";
            this.LstBoxEmployees.Size = new System.Drawing.Size(238, 147);
            this.LstBoxEmployees.TabIndex = 7;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 493);
            this.Controls.Add(this.LstBoxEmployees);
            this.Controls.Add(this.DgvInventory);
            this.Controls.Add(this.CmdEmployeeList);
            this.Controls.Add(this.CmdAddEmployee);
            this.Controls.Add(this.CmdAddGame);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmInventory";
            this.Text = "Inventory Application";
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button CmdAddGame;
        private System.Windows.Forms.Button CmdAddEmployee;
        private System.Windows.Forms.Button CmdEmployeeList;
        private System.Windows.Forms.DataGridView DgvInventory;
        private System.Windows.Forms.ListBox LstBoxEmployees;
    }
}

