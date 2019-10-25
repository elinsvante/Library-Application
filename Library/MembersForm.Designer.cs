namespace Library
{
    partial class MembersForm
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
            this.lbMembersLoan = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNAddMember = new System.Windows.Forms.Button();
            this.BTNLoanForMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMembersLoan
            // 
            this.lbMembersLoan.FormattingEnabled = true;
            this.lbMembersLoan.ItemHeight = 25;
            this.lbMembersLoan.Location = new System.Drawing.Point(975, 82);
            this.lbMembersLoan.Name = "lbMembersLoan";
            this.lbMembersLoan.Size = new System.Drawing.Size(664, 729);
            this.lbMembersLoan.TabIndex = 0;
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 25;
            this.lbMembers.Location = new System.Drawing.Point(52, 82);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(664, 729);
            this.lbMembers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Members";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(969, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Members Loan";
            // 
            // BTNAddMember
            // 
            this.BTNAddMember.Location = new System.Drawing.Point(52, 852);
            this.BTNAddMember.Name = "BTNAddMember";
            this.BTNAddMember.Size = new System.Drawing.Size(664, 77);
            this.BTNAddMember.TabIndex = 4;
            this.BTNAddMember.Text = "Add Member";
            this.BTNAddMember.UseVisualStyleBackColor = true;
            this.BTNAddMember.Click += new System.EventHandler(this.BTNAddMember_Click);
            // 
            // BTNLoanForMember
            // 
            this.BTNLoanForMember.Location = new System.Drawing.Point(53, 953);
            this.BTNLoanForMember.Name = "BTNLoanForMember";
            this.BTNLoanForMember.Size = new System.Drawing.Size(664, 77);
            this.BTNLoanForMember.TabIndex = 5;
            this.BTNLoanForMember.Text = "Show Members Loans";
            this.BTNLoanForMember.UseVisualStyleBackColor = true;
            this.BTNLoanForMember.Click += new System.EventHandler(this.BTNLoanForMember_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1096);
            this.Controls.Add(this.BTNLoanForMember);
            this.Controls.Add(this.BTNAddMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.lbMembersLoan);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMembersLoan;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNAddMember;
        private System.Windows.Forms.Button BTNLoanForMember;
    }
}