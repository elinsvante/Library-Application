namespace Library
{
    partial class MembersLoanForm
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
            this.lbMemberLoan = new System.Windows.Forms.ListBox();
            this.tbMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMemberReturned = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dropDown_filterLoans = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNReturnBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberLoan
            // 
            this.lbMemberLoan.FormattingEnabled = true;
            this.lbMemberLoan.Location = new System.Drawing.Point(12, 156);
            this.lbMemberLoan.Name = "lbMemberLoan";
            this.lbMemberLoan.Size = new System.Drawing.Size(398, 303);
            this.lbMemberLoan.TabIndex = 0;
            // 
            // tbMember
            // 
            this.tbMember.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMember.Location = new System.Drawing.Point(27, 49);
            this.tbMember.Multiline = true;
            this.tbMember.Name = "tbMember";
            this.tbMember.ReadOnly = true;
            this.tbMember.Size = new System.Drawing.Size(255, 39);
            this.tbMember.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Loans For Member:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Returned Loans";
            // 
            // lbMemberReturned
            // 
            this.lbMemberReturned.FormattingEnabled = true;
            this.lbMemberReturned.Location = new System.Drawing.Point(762, 54);
            this.lbMemberReturned.Name = "lbMemberReturned";
            this.lbMemberReturned.Size = new System.Drawing.Size(116, 30);
            this.lbMemberReturned.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Overdue";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(794, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(66, 30);
            this.listBox2.TabIndex = 1;
            // 
            // dropDown_filterLoans
            // 
            this.dropDown_filterLoans.FormattingEnabled = true;
            this.dropDown_filterLoans.Items.AddRange(new object[] {
            "All Loans",
            "Loans Overdue",
            "Loans Returned"});
            this.dropDown_filterLoans.Location = new System.Drawing.Point(12, 129);
            this.dropDown_filterLoans.Name = "dropDown_filterLoans";
            this.dropDown_filterLoans.Size = new System.Drawing.Size(121, 21);
            this.dropDown_filterLoans.TabIndex = 7;
            this.dropDown_filterLoans.SelectedIndexChanged += new System.EventHandler(this.dropDown_filterLoans_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 109);
            this.panel1.TabIndex = 8;
            // 
            // BTNReturnBook
            // 
            this.BTNReturnBook.Location = new System.Drawing.Point(12, 465);
            this.BTNReturnBook.Name = "BTNReturnBook";
            this.BTNReturnBook.Size = new System.Drawing.Size(398, 44);
            this.BTNReturnBook.TabIndex = 9;
            this.BTNReturnBook.Text = "Return Book";
            this.BTNReturnBook.UseVisualStyleBackColor = true;
            this.BTNReturnBook.Click += new System.EventHandler(this.BTNReturnBook_Click);
            // 
            // MembersLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(425, 521);
            this.Controls.Add(this.BTNReturnBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dropDown_filterLoans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMemberReturned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbMemberLoan);
            this.Name = "MembersLoanForm";
            this.Text = "MembersLoanForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMemberLoan;
        private System.Windows.Forms.TextBox tbMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbMemberReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox dropDown_filterLoans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNReturnBook;
    }
}