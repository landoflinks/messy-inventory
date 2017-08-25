namespace messy_inventory
{
    partial class AddGame
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblConsole = new System.Windows.Forms.Label();
            this.LblDeveloper = new System.Windows.Forms.Label();
            this.LblPublisher = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.TxtDeveloper = new System.Windows.Forms.TextBox();
            this.TxtPublisher = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.CmbCondition = new System.Windows.Forms.ComboBox();
            this.CmbSubmit = new System.Windows.Forms.Button();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblTitle.Location = new System.Drawing.Point(44, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(39, 17);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title:";
            // 
            // LblConsole
            // 
            this.LblConsole.AutoSize = true;
            this.LblConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblConsole.Location = new System.Drawing.Point(20, 42);
            this.LblConsole.Name = "LblConsole";
            this.LblConsole.Size = new System.Drawing.Size(63, 17);
            this.LblConsole.TabIndex = 1;
            this.LblConsole.Text = "Console:";
            // 
            // LblDeveloper
            // 
            this.LblDeveloper.AutoSize = true;
            this.LblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDeveloper.Location = new System.Drawing.Point(6, 76);
            this.LblDeveloper.Name = "LblDeveloper";
            this.LblDeveloper.Size = new System.Drawing.Size(77, 17);
            this.LblDeveloper.TabIndex = 2;
            this.LblDeveloper.Text = "Developer:";
            // 
            // LblPublisher
            // 
            this.LblPublisher.AutoSize = true;
            this.LblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPublisher.Location = new System.Drawing.Point(12, 113);
            this.LblPublisher.Name = "LblPublisher";
            this.LblPublisher.Size = new System.Drawing.Size(71, 17);
            this.LblPublisher.TabIndex = 3;
            this.LblPublisher.Text = "Publisher:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCondition.Location = new System.Drawing.Point(12, 153);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(71, 17);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Condition:";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPrice.Location = new System.Drawing.Point(39, 194);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(44, 17);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "Price:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtTitle.Location = new System.Drawing.Point(89, 6);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(219, 23);
            this.TxtTitle.TabIndex = 6;
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConsole.Location = new System.Drawing.Point(89, 39);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(219, 23);
            this.txtConsole.TabIndex = 7;
            // 
            // TxtDeveloper
            // 
            this.TxtDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtDeveloper.Location = new System.Drawing.Point(89, 73);
            this.TxtDeveloper.Name = "TxtDeveloper";
            this.TxtDeveloper.Size = new System.Drawing.Size(219, 23);
            this.TxtDeveloper.TabIndex = 8;
            // 
            // TxtPublisher
            // 
            this.TxtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtPublisher.Location = new System.Drawing.Point(89, 110);
            this.TxtPublisher.Name = "TxtPublisher";
            this.TxtPublisher.Size = new System.Drawing.Size(219, 23);
            this.TxtPublisher.TabIndex = 9;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtPrice.Location = new System.Drawing.Point(89, 191);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(219, 23);
            this.TxtPrice.TabIndex = 10;
            // 
            // CmbCondition
            // 
            this.CmbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbCondition.FormattingEnabled = true;
            this.CmbCondition.Items.AddRange(new object[] {
            "Like New",
            "Great",
            "Good",
            "Average",
            "Below Average",
            "Poor",
            "Pitch This Thing"});
            this.CmbCondition.Location = new System.Drawing.Point(89, 152);
            this.CmbCondition.Name = "CmbCondition";
            this.CmbCondition.Size = new System.Drawing.Size(219, 24);
            this.CmbCondition.TabIndex = 11;
            // 
            // CmbSubmit
            // 
            this.CmbSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbSubmit.Location = new System.Drawing.Point(89, 238);
            this.CmbSubmit.Name = "CmbSubmit";
            this.CmbSubmit.Size = new System.Drawing.Size(82, 30);
            this.CmbSubmit.TabIndex = 12;
            this.CmbSubmit.Text = "Submit";
            this.CmbSubmit.UseVisualStyleBackColor = true;
            this.CmbSubmit.Click += new System.EventHandler(this.CmbSubmit_Click);
            // 
            // CmbCancel
            // 
            this.CmbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbCancel.Location = new System.Drawing.Point(305, 238);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(82, 30);
            this.CmbCancel.TabIndex = 13;
            this.CmbCancel.Text = "Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 280);
            this.Controls.Add(this.CmbCancel);
            this.Controls.Add(this.CmbSubmit);
            this.Controls.Add(this.CmbCondition);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtPublisher);
            this.Controls.Add(this.TxtDeveloper);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.LblPublisher);
            this.Controls.Add(this.LblDeveloper);
            this.Controls.Add(this.LblConsole);
            this.Controls.Add(this.LblTitle);
            this.Name = "AddGame";
            this.Text = "Add New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblConsole;
        private System.Windows.Forms.Label LblDeveloper;
        private System.Windows.Forms.Label LblPublisher;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TextBox TxtDeveloper;
        private System.Windows.Forms.TextBox TxtPublisher;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.ComboBox CmbCondition;
        private System.Windows.Forms.Button CmbSubmit;
        private System.Windows.Forms.Button CmbCancel;
    }
}