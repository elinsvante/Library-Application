namespace Library
{
    partial class MakeLoanForm
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
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.BTNMakeLoan = new System.Windows.Forms.Button();
            this.tbLoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 25;
            this.lbMembers.Location = new System.Drawing.Point(55, 74);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(537, 679);
            this.lbMembers.TabIndex = 0;
            // 
            // BTNMakeLoan
            // 
            this.BTNMakeLoan.Location = new System.Drawing.Point(808, 439);
            this.BTNMakeLoan.Name = "BTNMakeLoan";
            this.BTNMakeLoan.Size = new System.Drawing.Size(315, 86);
            this.BTNMakeLoan.TabIndex = 1;
            this.BTNMakeLoan.Text = "Make Loan";
            this.BTNMakeLoan.UseVisualStyleBackColor = true;
            this.BTNMakeLoan.Click += new System.EventHandler(this.BTNMakeLoan_Click);
            // 
            // tbLoan
            // 
            this.tbLoan.Location = new System.Drawing.Point(787, 152);
            this.tbLoan.Name = "tbLoan";
            this.tbLoan.Size = new System.Drawing.Size(360, 31);
            this.tbLoan.TabIndex = 2;
            // 
            // MakeLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 869);
            this.Controls.Add(this.tbLoan);
            this.Controls.Add(this.BTNMakeLoan);
            this.Controls.Add(this.lbMembers);
            this.Name = "MakeLoanForm";
            this.Text = "MakeLoanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Button BTNMakeLoan;
        private System.Windows.Forms.TextBox tbLoan;
    }
}