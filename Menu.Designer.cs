
namespace J27C76
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.HighestDonationPrint = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowDonations = new System.Windows.Forms.Button();
            this.DonationBox = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // HighestDonationPrint
            // 
            this.HighestDonationPrint.Location = new System.Drawing.Point(215, 108);
            this.HighestDonationPrint.Name = "HighestDonationPrint";
            this.HighestDonationPrint.Size = new System.Drawing.Size(117, 49);
            this.HighestDonationPrint.TabIndex = 3;
            this.HighestDonationPrint.Text = "Show the highest donation and save it in a file";
            this.HighestDonationPrint.UseVisualStyleBackColor = true;
            this.HighestDonationPrint.Click += new System.EventHandler(this.HighestDonationPrint_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Location = new System.Drawing.Point(12, 122);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.MaximumSize = new System.Drawing.Size(250, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "What would you like to do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowDonations
            // 
            this.ShowDonations.Location = new System.Drawing.Point(79, 108);
            this.ShowDonations.Name = "ShowDonations";
            this.ShowDonations.Size = new System.Drawing.Size(117, 49);
            this.ShowDonations.TabIndex = 6;
            this.ShowDonations.Text = "Display all current donations";
            this.ShowDonations.UseVisualStyleBackColor = true;
            this.ShowDonations.Click += new System.EventHandler(this.ShowDonations_Click);
            // 
            // DonationBox
            // 
            this.DonationBox.FileName = "DonationBox";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 169);
            this.Controls.Add(this.ShowDonations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.HighestDonationPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HighestDonationPrint;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowDonations;
        private System.Windows.Forms.OpenFileDialog DonationBox;
    }
}