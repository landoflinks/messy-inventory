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
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(39, 17);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title:";
            // 
            // LblConsole
            // 
            this.LblConsole.AutoSize = true;
            this.LblConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblConsole.Location = new System.Drawing.Point(12, 42);
            this.LblConsole.Name = "LblConsole";
            this.LblConsole.Size = new System.Drawing.Size(63, 17);
            this.LblConsole.TabIndex = 1;
            this.LblConsole.Text = "Console:";
            // 
            // LblDeveloper
            // 
            this.LblDeveloper.AutoSize = true;
            this.LblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDeveloper.Location = new System.Drawing.Point(12, 77);
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
            this.LblPrice.Location = new System.Drawing.Point(12, 193);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(44, 17);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "Price:";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
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
    }
}