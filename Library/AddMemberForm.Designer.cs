namespace Library
{
    partial class AddMemberForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPersonalNumber = new System.Windows.Forms.TextBox();
            this.BTNAddMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(333, 31);
            this.tbName.TabIndex = 0;
            // 
            // tbPersonalNumber
            // 
            this.tbPersonalNumber.Location = new System.Drawing.Point(83, 180);
            this.tbPersonalNumber.Name = "tbPersonalNumber";
            this.tbPersonalNumber.Size = new System.Drawing.Size(333, 31);
            this.tbPersonalNumber.TabIndex = 1;
            // 
            // BTNAddMember
            // 
            this.BTNAddMember.Location = new System.Drawing.Point(83, 286);
            this.BTNAddMember.Name = "BTNAddMember";
            this.BTNAddMember.Size = new System.Drawing.Size(344, 60);
            this.BTNAddMember.TabIndex = 2;
            this.BTNAddMember.Text = "Add Member";
            this.BTNAddMember.UseVisualStyleBackColor = true;
            this.BTNAddMember.Click += new System.EventHandler(this.BTNAddMember_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 446);
            this.Controls.Add(this.BTNAddMember);
            this.Controls.Add(this.tbPersonalNumber);
            this.Controls.Add(this.tbName);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPersonalNumber;
        private System.Windows.Forms.Button BTNAddMember;
    }
}