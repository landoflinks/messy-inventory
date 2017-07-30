namespace messy_inventory
{
    partial class frmInventory
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
            this.appTitle = new System.Windows.Forms.Label();
            this.cmdShowInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(240, 9);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(224, 26);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "Messy\'s Used Games";
            // 
            // cmdShowInventory
            // 
            this.cmdShowInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowInventory.Location = new System.Drawing.Point(264, 67);
            this.cmdShowInventory.Name = "cmdShowInventory";
            this.cmdShowInventory.Size = new System.Drawing.Size(151, 34);
            this.cmdShowInventory.TabIndex = 1;
            this.cmdShowInventory.Text = "Current Inventory";
            this.cmdShowInventory.UseVisualStyleBackColor = true;
            this.cmdShowInventory.Click += new System.EventHandler(this.cmdShowInventory_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 481);
            this.Controls.Add(this.cmdShowInventory);
            this.Controls.Add(this.appTitle);
            this.Name = "frmInventory";
            this.Text = "Inventory App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Button cmdShowInventory;
    }
}

