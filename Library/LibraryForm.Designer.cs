namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbCopies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAddBook = new System.Windows.Forms.Button();
            this.dropDown_authors = new System.Windows.Forms.ComboBox();
            this.BTNAddCopy = new System.Windows.Forms.Button();
            this.BTNAddAuthor = new System.Windows.Forms.Button();
            this.BTNBooksOfAuthor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNReturn = new System.Windows.Forms.Button();
            this.lbReturnedLoans = new System.Windows.Forms.ListBox();
            this.lbCurrentLoans = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dropDown_members = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNLoan = new System.Windows.Forms.Button();
            this.BTNMembers = new System.Windows.Forms.Button();
            this.lbAvailableCopies = new System.Windows.Forms.ListBox();
            this.BTNLoansForMember = new System.Windows.Forms.Button();
            this.dropDown_filterCopies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropDown_filterLoans = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(24, 120);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(566, 459);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // lbCopies
            // 
            this.lbCopies.FormattingEnabled = true;
            this.lbCopies.Location = new System.Drawing.Point(137, 155);
            this.lbCopies.Name = "lbCopies";
            this.lbCopies.Size = new System.Drawing.Size(305, 251);
            this.lbCopies.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Books";
            // 
            // BTNAddBook
            // 
            this.BTNAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddBook.Location = new System.Drawing.Point(56, 599);
            this.BTNAddBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAddBook.Name = "BTNAddBook";
            this.BTNAddBook.Size = new System.Drawing.Size(273, 49);
            this.BTNAddBook.TabIndex = 12;
            this.BTNAddBook.Text = "Add Book";
            this.BTNAddBook.UseVisualStyleBackColor = true;
            this.BTNAddBook.Click += new System.EventHandler(this.BTNAddBook_Click);
            // 
            // dropDown_authors
            // 
            this.dropDown_authors.FormattingEnabled = true;
            this.dropDown_authors.Location = new System.Drawing.Point(373, 599);
            this.dropDown_authors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dropDown_authors.Name = "dropDown_authors";
            this.dropDown_authors.Size = new System.Drawing.Size(180, 21);
            this.dropDown_authors.TabIndex = 13;
            // 
            // BTNAddCopy
            // 
            this.BTNAddCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddCopy.Location = new System.Drawing.Point(56, 652);
            this.BTNAddCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAddCopy.Name = "BTNAddCopy";
            this.BTNAddCopy.Size = new System.Drawing.Size(273, 49);
            this.BTNAddCopy.TabIndex = 14;
            this.BTNAddCopy.Text = "Add BookCopy";
            this.BTNAddCopy.UseVisualStyleBackColor = true;
            this.BTNAddCopy.Click += new System.EventHandler(this.BTNAddCopy_Click);
            // 
            // BTNAddAuthor
            // 
            this.BTNAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddAuthor.Location = new System.Drawing.Point(373, 663);
            this.BTNAddAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAddAuthor.Name = "BTNAddAuthor";
            this.BTNAddAuthor.Size = new System.Drawing.Size(180, 38);
            this.BTNAddAuthor.TabIndex = 19;
            this.BTNAddAuthor.Text = "Add Author";
            this.BTNAddAuthor.UseVisualStyleBackColor = true;
            this.BTNAddAuthor.Click += new System.EventHandler(this.BTNAddAuthor_Click);
            // 
            // BTNBooksOfAuthor
            // 
            this.BTNBooksOfAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBooksOfAuthor.Location = new System.Drawing.Point(373, 624);
            this.BTNBooksOfAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNBooksOfAuthor.Name = "BTNBooksOfAuthor";
            this.BTNBooksOfAuthor.Size = new System.Drawing.Size(180, 35);
            this.BTNBooksOfAuthor.TabIndex = 20;
            this.BTNBooksOfAuthor.Text = "All Books Of Author";
            this.BTNBooksOfAuthor.UseVisualStyleBackColor = true;
            this.BTNBooksOfAuthor.Click += new System.EventHandler(this.BTNBooksOfAuthor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 94);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1140, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "-";
            // 
            // BTNReturn
            // 
            this.BTNReturn.Location = new System.Drawing.Point(34, 650);
            this.BTNReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNReturn.Name = "BTNReturn";
            this.BTNReturn.Size = new System.Drawing.Size(250, 35);
            this.BTNReturn.TabIndex = 7;
            this.BTNReturn.Text = "Return";
            this.BTNReturn.UseVisualStyleBackColor = true;
            this.BTNReturn.Click += new System.EventHandler(this.BTNReturn_Click);
            // 
            // lbReturnedLoans
            // 
            this.lbReturnedLoans.FormattingEnabled = true;
            this.lbReturnedLoans.ItemHeight = 16;
            this.lbReturnedLoans.Location = new System.Drawing.Point(291, 466);
            this.lbReturnedLoans.Name = "lbReturnedLoans";
            this.lbReturnedLoans.Size = new System.Drawing.Size(250, 164);
            this.lbReturnedLoans.TabIndex = 3;
            // 
            // lbCurrentLoans
            // 
            this.lbCurrentLoans.FormattingEnabled = true;
            this.lbCurrentLoans.ItemHeight = 16;
            this.lbCurrentLoans.Location = new System.Drawing.Point(34, 466);
            this.lbCurrentLoans.Name = "lbCurrentLoans";
            this.lbCurrentLoans.Size = new System.Drawing.Size(250, 164);
            this.lbCurrentLoans.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "All Copies On Loan";
            // 
            // dropDown_members
            // 
            this.dropDown_members.FormattingEnabled = true;
            this.dropDown_members.Location = new System.Drawing.Point(39, 337);
            this.dropDown_members.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dropDown_members.Name = "dropDown_members";
            this.dropDown_members.Size = new System.Drawing.Size(182, 24);
            this.dropDown_members.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(287, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "All Returned Loans";
            // 
            // BTNLoan
            // 
            this.BTNLoan.Location = new System.Drawing.Point(39, 374);
            this.BTNLoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNLoan.Name = "BTNLoan";
            this.BTNLoan.Size = new System.Drawing.Size(180, 35);
            this.BTNLoan.TabIndex = 5;
            this.BTNLoan.Text = "Loan";
            this.BTNLoan.UseVisualStyleBackColor = true;
            this.BTNLoan.Click += new System.EventHandler(this.BTNLoan_Click);
            // 
            // BTNMembers
            // 
            this.BTNMembers.Location = new System.Drawing.Point(416, 374);
            this.BTNMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNMembers.Name = "BTNMembers";
            this.BTNMembers.Size = new System.Drawing.Size(125, 35);
            this.BTNMembers.TabIndex = 17;
            this.BTNMembers.Text = "Members";
            this.BTNMembers.UseVisualStyleBackColor = true;
            this.BTNMembers.Click += new System.EventHandler(this.BTNMembers_Click);
            // 
            // lbAvailableCopies
            // 
            this.lbAvailableCopies.FormattingEnabled = true;
            this.lbAvailableCopies.ItemHeight = 16;
            this.lbAvailableCopies.Location = new System.Drawing.Point(39, 158);
            this.lbAvailableCopies.Name = "lbAvailableCopies";
            this.lbAvailableCopies.Size = new System.Drawing.Size(502, 164);
            this.lbAvailableCopies.TabIndex = 4;
            // 
            // BTNLoansForMember
            // 
            this.BTNLoansForMember.Location = new System.Drawing.Point(232, 374);
            this.BTNLoansForMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNLoansForMember.Name = "BTNLoansForMember";
            this.BTNLoansForMember.Size = new System.Drawing.Size(180, 35);
            this.BTNLoansForMember.TabIndex = 18;
            this.BTNLoansForMember.Text = "All Loans For Member";
            this.BTNLoansForMember.UseVisualStyleBackColor = true;
            this.BTNLoansForMember.Click += new System.EventHandler(this.BTNLoansForMember_Click);
            // 
            // dropDown_filterCopies
            // 
            this.dropDown_filterCopies.FormattingEnabled = true;
            this.dropDown_filterCopies.Items.AddRange(new object[] {
            "All Copies",
            "Available Copies"});
            this.dropDown_filterCopies.Location = new System.Drawing.Point(416, 122);
            this.dropDown_filterCopies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dropDown_filterCopies.Name = "dropDown_filterCopies";
            this.dropDown_filterCopies.Size = new System.Drawing.Size(125, 24);
            this.dropDown_filterCopies.TabIndex = 23;
            this.dropDown_filterCopies.SelectedIndexChanged += new System.EventHandler(this.dropDown_filterCopies_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Available Copies";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.dropDown_filterLoans);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dropDown_filterCopies);
            this.panel1.Controls.Add(this.BTNLoansForMember);
            this.panel1.Controls.Add(this.lbAvailableCopies);
            this.panel1.Controls.Add(this.BTNMembers);
            this.panel1.Controls.Add(this.BTNLoan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dropDown_members);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbCurrentLoans);
            this.panel1.Controls.Add(this.lbReturnedLoans);
            this.panel1.Controls.Add(this.BTNReturn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(622, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 728);
            this.panel1.TabIndex = 24;
            // 
            // dropDown_filterLoans
            // 
            this.dropDown_filterLoans.FormattingEnabled = true;
            this.dropDown_filterLoans.Items.AddRange(new object[] {
            "All Copies",
            "Available Copies"});
            this.dropDown_filterLoans.Location = new System.Drawing.Point(194, 437);
            this.dropDown_filterLoans.Margin = new System.Windows.Forms.Padding(2);
            this.dropDown_filterLoans.Name = "dropDown_filterLoans";
            this.dropDown_filterLoans.Size = new System.Drawing.Size(90, 24);
            this.dropDown_filterLoans.TabIndex = 24;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1234, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNBooksOfAuthor);
            this.Controls.Add(this.lbCopies);
            this.Controls.Add(this.BTNAddAuthor);
            this.Controls.Add(this.BTNAddCopy);
            this.Controls.Add(this.dropDown_authors);
            this.Controls.Add(this.BTNAddBook);
            this.Controls.Add(this.lbBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbCopies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNAddBook;
        private System.Windows.Forms.ComboBox dropDown_authors;
        private System.Windows.Forms.Button BTNAddCopy;
        private System.Windows.Forms.Button BTNAddAuthor;
        private System.Windows.Forms.Button BTNBooksOfAuthor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNReturn;
        private System.Windows.Forms.ListBox lbReturnedLoans;
        private System.Windows.Forms.ListBox lbCurrentLoans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropDown_members;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNLoan;
        private System.Windows.Forms.Button BTNMembers;
        private System.Windows.Forms.ListBox lbAvailableCopies;
        private System.Windows.Forms.Button BTNLoansForMember;
        private System.Windows.Forms.ComboBox dropDown_filterCopies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dropDown_filterLoans;
    }
}

