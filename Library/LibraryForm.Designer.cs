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
            this.BTNChangeBook = new System.Windows.Forms.Button();
            this.lbCopies = new System.Windows.Forms.ListBox();
            this.lbReturnedLoans = new System.Windows.Forms.ListBox();
            this.lbAvailableCopies = new System.Windows.Forms.ListBox();
            this.BTNLoan = new System.Windows.Forms.Button();
            this.dropDown_members = new System.Windows.Forms.ComboBox();
            this.BTNReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentLoans = new System.Windows.Forms.ListBox();
            this.BTNAddBook = new System.Windows.Forms.Button();
            this.dropDown_authors = new System.Windows.Forms.ComboBox();
            this.BTNAddCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNMembers = new System.Windows.Forms.Button();
            this.BTNLoansForMember = new System.Windows.Forms.Button();
            this.BTNAddAuthor = new System.Windows.Forms.Button();
            this.BTNBooksOfAuthor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNShow = new System.Windows.Forms.Button();
            this.dropDown_filterCopies = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 25;
            this.lbBooks.Location = new System.Drawing.Point(24, 88);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(6);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(1009, 479);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // BTNChangeBook
            // 
            this.BTNChangeBook.Location = new System.Drawing.Point(626, 1167);
            this.BTNChangeBook.Margin = new System.Windows.Forms.Padding(4);
            this.BTNChangeBook.Name = "BTNChangeBook";
            this.BTNChangeBook.Size = new System.Drawing.Size(121, 72);
            this.BTNChangeBook.TabIndex = 1;
            this.BTNChangeBook.Text = "TEST: Change the book title";
            this.BTNChangeBook.UseVisualStyleBackColor = true;
            this.BTNChangeBook.Click += new System.EventHandler(this.BTNChangeBook_Click);
            // 
            // lbCopies
            // 
            this.lbCopies.FormattingEnabled = true;
            this.lbCopies.ItemHeight = 25;
            this.lbCopies.Location = new System.Drawing.Point(1070, 88);
            this.lbCopies.Margin = new System.Windows.Forms.Padding(6);
            this.lbCopies.Name = "lbCopies";
            this.lbCopies.Size = new System.Drawing.Size(606, 479);
            this.lbCopies.TabIndex = 2;
            // 
            // lbReturnedLoans
            // 
            this.lbReturnedLoans.FormattingEnabled = true;
            this.lbReturnedLoans.ItemHeight = 25;
            this.lbReturnedLoans.Location = new System.Drawing.Point(1278, 821);
            this.lbReturnedLoans.Margin = new System.Windows.Forms.Padding(6);
            this.lbReturnedLoans.Name = "lbReturnedLoans";
            this.lbReturnedLoans.Size = new System.Drawing.Size(561, 329);
            this.lbReturnedLoans.TabIndex = 3;
            // 
            // lbAvailableCopies
            // 
            this.lbAvailableCopies.FormattingEnabled = true;
            this.lbAvailableCopies.ItemHeight = 25;
            this.lbAvailableCopies.Location = new System.Drawing.Point(1070, 88);
            this.lbAvailableCopies.Margin = new System.Windows.Forms.Padding(6);
            this.lbAvailableCopies.Name = "lbAvailableCopies";
            this.lbAvailableCopies.Size = new System.Drawing.Size(769, 479);
            this.lbAvailableCopies.TabIndex = 4;
            // 
            // BTNLoan
            // 
            this.BTNLoan.Location = new System.Drawing.Point(1479, 633);
            this.BTNLoan.Name = "BTNLoan";
            this.BTNLoan.Size = new System.Drawing.Size(360, 68);
            this.BTNLoan.TabIndex = 5;
            this.BTNLoan.Text = "Loan";
            this.BTNLoan.UseVisualStyleBackColor = true;
            this.BTNLoan.Click += new System.EventHandler(this.BTNLoan_Click);
            // 
            // dropDown_members
            // 
            this.dropDown_members.FormattingEnabled = true;
            this.dropDown_members.Location = new System.Drawing.Point(1479, 591);
            this.dropDown_members.Name = "dropDown_members";
            this.dropDown_members.Size = new System.Drawing.Size(360, 33);
            this.dropDown_members.TabIndex = 6;
            // 
            // BTNReturn
            // 
            this.BTNReturn.Location = new System.Drawing.Point(879, 1256);
            this.BTNReturn.Name = "BTNReturn";
            this.BTNReturn.Size = new System.Drawing.Size(360, 68);
            this.BTNReturn.TabIndex = 7;
            this.BTNReturn.Text = "Return";
            this.BTNReturn.UseVisualStyleBackColor = true;
            this.BTNReturn.Click += new System.EventHandler(this.BTNReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1064, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "All Available Copies";
            // 
            // lbCurrentLoans
            // 
            this.lbCurrentLoans.FormattingEnabled = true;
            this.lbCurrentLoans.ItemHeight = 25;
            this.lbCurrentLoans.Location = new System.Drawing.Point(879, 835);
            this.lbCurrentLoans.Margin = new System.Windows.Forms.Padding(6);
            this.lbCurrentLoans.Name = "lbCurrentLoans";
            this.lbCurrentLoans.Size = new System.Drawing.Size(360, 304);
            this.lbCurrentLoans.TabIndex = 11;
            // 
            // BTNAddBook
            // 
            this.BTNAddBook.Location = new System.Drawing.Point(24, 707);
            this.BTNAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAddBook.Name = "BTNAddBook";
            this.BTNAddBook.Size = new System.Drawing.Size(418, 95);
            this.BTNAddBook.TabIndex = 12;
            this.BTNAddBook.Text = "Add Book";
            this.BTNAddBook.UseVisualStyleBackColor = true;
            this.BTNAddBook.Click += new System.EventHandler(this.BTNAddBook_Click);
            // 
            // dropDown_authors
            // 
            this.dropDown_authors.FormattingEnabled = true;
            this.dropDown_authors.Location = new System.Drawing.Point(472, 591);
            this.dropDown_authors.Name = "dropDown_authors";
            this.dropDown_authors.Size = new System.Drawing.Size(360, 33);
            this.dropDown_authors.TabIndex = 13;
            // 
            // BTNAddCopy
            // 
            this.BTNAddCopy.Location = new System.Drawing.Point(24, 591);
            this.BTNAddCopy.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAddCopy.Name = "BTNAddCopy";
            this.BTNAddCopy.Size = new System.Drawing.Size(418, 95);
            this.BTNAddCopy.TabIndex = 14;
            this.BTNAddCopy.Text = "Add BookCopy";
            this.BTNAddCopy.UseVisualStyleBackColor = true;
            this.BTNAddCopy.Click += new System.EventHandler(this.BTNAddCopy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(886, 771);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "All Copies On Loan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1289, 773);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "All Returned Loans";
            // 
            // BTNMembers
            // 
            this.BTNMembers.Location = new System.Drawing.Point(1278, 1196);
            this.BTNMembers.Name = "BTNMembers";
            this.BTNMembers.Size = new System.Drawing.Size(561, 59);
            this.BTNMembers.TabIndex = 17;
            this.BTNMembers.Text = "Members";
            this.BTNMembers.UseVisualStyleBackColor = true;
            this.BTNMembers.Click += new System.EventHandler(this.BTNMembers_Click);
            // 
            // BTNLoansForMember
            // 
            this.BTNLoansForMember.Location = new System.Drawing.Point(879, 1175);
            this.BTNLoansForMember.Name = "BTNLoansForMember";
            this.BTNLoansForMember.Size = new System.Drawing.Size(360, 64);
            this.BTNLoansForMember.TabIndex = 18;
            this.BTNLoansForMember.Text = "All Loans For Member";
            this.BTNLoansForMember.UseVisualStyleBackColor = true;
            this.BTNLoansForMember.Click += new System.EventHandler(this.BTNLoansForMember_Click);
            // 
            // BTNAddAuthor
            // 
            this.BTNAddAuthor.Location = new System.Drawing.Point(472, 736);
            this.BTNAddAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAddAuthor.Name = "BTNAddAuthor";
            this.BTNAddAuthor.Size = new System.Drawing.Size(360, 68);
            this.BTNAddAuthor.TabIndex = 19;
            this.BTNAddAuthor.Text = "Add Author";
            this.BTNAddAuthor.UseVisualStyleBackColor = true;
            this.BTNAddAuthor.Click += new System.EventHandler(this.BTNAddAuthor_Click);
            // 
            // BTNBooksOfAuthor
            // 
            this.BTNBooksOfAuthor.Location = new System.Drawing.Point(472, 651);
            this.BTNBooksOfAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBooksOfAuthor.Name = "BTNBooksOfAuthor";
            this.BTNBooksOfAuthor.Size = new System.Drawing.Size(360, 68);
            this.BTNBooksOfAuthor.TabIndex = 20;
            this.BTNBooksOfAuthor.Text = "All Books Of Author";
            this.BTNBooksOfAuthor.UseVisualStyleBackColor = true;
            this.BTNBooksOfAuthor.Click += new System.EventHandler(this.BTNBooksOfAuthor_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Copies On Loan",
            "All Overdue Loans",
            "All Returned Loans"});
            this.comboBox1.Location = new System.Drawing.Point(24, 1145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 33);
            this.comboBox1.TabIndex = 21;
            // 
            // BTNShow
            // 
            this.BTNShow.Location = new System.Drawing.Point(24, 1196);
            this.BTNShow.Margin = new System.Windows.Forms.Padding(4);
            this.BTNShow.Name = "BTNShow";
            this.BTNShow.Size = new System.Drawing.Size(360, 68);
            this.BTNShow.TabIndex = 22;
            this.BTNShow.Text = "Show";
            this.BTNShow.UseVisualStyleBackColor = true;
            // 
            // dropDown_filterCopies
            // 
            this.dropDown_filterCopies.FormattingEnabled = true;
            this.dropDown_filterCopies.Items.AddRange(new object[] {
            "All Copies",
            "Available Copies"});
            this.dropDown_filterCopies.Location = new System.Drawing.Point(1663, 41);
            this.dropDown_filterCopies.Name = "dropDown_filterCopies";
            this.dropDown_filterCopies.Size = new System.Drawing.Size(176, 33);
            this.dropDown_filterCopies.TabIndex = 23;
            this.dropDown_filterCopies.SelectedIndexChanged += new System.EventHandler(this.dropDown_filterCopies_SelectedIndexChanged);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2220, 1388);
            this.Controls.Add(this.dropDown_filterCopies);
            this.Controls.Add(this.BTNShow);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNBooksOfAuthor);
            this.Controls.Add(this.BTNAddAuthor);
            this.Controls.Add(this.BTNLoansForMember);
            this.Controls.Add(this.BTNMembers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNAddCopy);
            this.Controls.Add(this.dropDown_authors);
            this.Controls.Add(this.BTNAddBook);
            this.Controls.Add(this.lbCurrentLoans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNReturn);
            this.Controls.Add(this.dropDown_members);
            this.Controls.Add(this.BTNLoan);
            this.Controls.Add(this.lbAvailableCopies);
            this.Controls.Add(this.lbReturnedLoans);
            this.Controls.Add(this.lbCopies);
            this.Controls.Add(this.BTNChangeBook);
            this.Controls.Add(this.lbBooks);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button BTNChangeBook;
        private System.Windows.Forms.ListBox lbCopies;
        private System.Windows.Forms.ListBox lbReturnedLoans;
        private System.Windows.Forms.ListBox lbAvailableCopies;
        private System.Windows.Forms.Button BTNLoan;
        private System.Windows.Forms.ComboBox dropDown_members;
        private System.Windows.Forms.Button BTNReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCurrentLoans;
        private System.Windows.Forms.Button BTNAddBook;
        private System.Windows.Forms.ComboBox dropDown_authors;
        private System.Windows.Forms.Button BTNAddCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNMembers;
        private System.Windows.Forms.Button BTNLoansForMember;
        private System.Windows.Forms.Button BTNAddAuthor;
        private System.Windows.Forms.Button BTNBooksOfAuthor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTNShow;
        private System.Windows.Forms.ComboBox dropDown_filterCopies;
    }
}

