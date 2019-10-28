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
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAddMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMembers
            // 
            this.lbMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 16;
            this.lbMembers.Location = new System.Drawing.Point(11, 108);
            this.lbMembers.Margin = new System.Windows.Forms.Padding(2);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(438, 308);
            this.lbMembers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Members";
            // 
            // BTNAddMember
            // 
            this.BTNAddMember.Location = new System.Drawing.Point(11, 440);
            this.BTNAddMember.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAddMember.Name = "BTNAddMember";
            this.BTNAddMember.Size = new System.Drawing.Size(438, 57);
            this.BTNAddMember.TabIndex = 4;
            this.BTNAddMember.Text = "Add Member";
            this.BTNAddMember.UseVisualStyleBackColor = true;
            this.BTNAddMember.Click += new System.EventHandler(this.BTNAddMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 83);
            this.panel1.TabIndex = 5;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(472, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNAddMember);
            this.Controls.Add(this.lbMembers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNAddMember;
        private System.Windows.Forms.Panel panel1;
    }
}