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
            this.components = new System.ComponentModel.Container();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbCopies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAddBook = new System.Windows.Forms.Button();
            this.dropDown_authors = new System.Windows.Forms.ComboBox();
            this.BTNAddCopy = new System.Windows.Forms.Button();
            this.BTNAddAuthor = new System.Windows.Forms.Button();
            this.BTNBooksOfAuthor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNReturn = new System.Windows.Forms.Button();
            this.lbCurrentLoans = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dropDown_members = new System.Windows.Forms.ComboBox();
            this.BTNLoan = new System.Windows.Forms.Button();
            this.BTNMembers = new System.Windows.Forms.Button();
            this.lbAvailableCopies = new System.Windows.Forms.ListBox();
            this.BTNLoansForMember = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelShowAllAvailableCopies = new System.Windows.Forms.Label();
            this.label_ShowAll = new System.Windows.Forms.Label();
            this.dropDown_filterLoans = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 16;
            this.lbBooks.Location = new System.Drawing.Point(14, 100);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(505, 244);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // lbCopies
            // 
            this.lbCopies.FormattingEnabled = true;
            this.lbCopies.Location = new System.Drawing.Point(14, 360);
            this.lbCopies.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbCopies.Name = "lbCopies";
            this.lbCopies.Size = new System.Drawing.Size(505, 199);
            this.lbCopies.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Books";
            // 
            // BTNAddBook
            // 
            this.BTNAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddBook.Location = new System.Drawing.Point(62, 575);
            this.BTNAddBook.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNAddBook.Name = "BTNAddBook";
            this.BTNAddBook.Size = new System.Drawing.Size(202, 50);
            this.BTNAddBook.TabIndex = 12;
            this.BTNAddBook.Text = "Add Book";
            this.BTNAddBook.UseVisualStyleBackColor = true;
            this.BTNAddBook.Click += new System.EventHandler(this.BTNAddBook_Click);
            // 
            // dropDown_authors
            // 
            this.dropDown_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown_authors.FormattingEnabled = true;
            this.dropDown_authors.Location = new System.Drawing.Point(314, 575);
            this.dropDown_authors.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dropDown_authors.Name = "dropDown_authors";
            this.dropDown_authors.Size = new System.Drawing.Size(124, 24);
            this.dropDown_authors.TabIndex = 13;
            // 
            // BTNAddCopy
            // 
            this.BTNAddCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddCopy.Location = new System.Drawing.Point(62, 639);
            this.BTNAddCopy.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNAddCopy.Name = "BTNAddCopy";
            this.BTNAddCopy.Size = new System.Drawing.Size(202, 50);
            this.BTNAddCopy.TabIndex = 14;
            this.BTNAddCopy.Text = "Add BookCopy";
            this.BTNAddCopy.UseVisualStyleBackColor = true;
            this.BTNAddCopy.Click += new System.EventHandler(this.BTNAddCopy_Click);
            // 
            // BTNAddAuthor
            // 
            this.BTNAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddAuthor.Location = new System.Drawing.Point(314, 648);
            this.BTNAddAuthor.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNAddAuthor.Name = "BTNAddAuthor";
            this.BTNAddAuthor.Size = new System.Drawing.Size(122, 40);
            this.BTNAddAuthor.TabIndex = 19;
            this.BTNAddAuthor.Text = "Add Author";
            this.BTNAddAuthor.UseVisualStyleBackColor = true;
            this.BTNAddAuthor.Click += new System.EventHandler(this.BTNAddAuthor_Click);
            // 
            // BTNBooksOfAuthor
            // 
            this.BTNBooksOfAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBooksOfAuthor.Location = new System.Drawing.Point(314, 606);
            this.BTNBooksOfAuthor.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNBooksOfAuthor.Name = "BTNBooksOfAuthor";
            this.BTNBooksOfAuthor.Size = new System.Drawing.Size(122, 40);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 81);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(971, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1001, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTNReturn
            // 
            this.BTNReturn.Location = new System.Drawing.Point(35, 621);
            this.BTNReturn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNReturn.Name = "BTNReturn";
            this.BTNReturn.Size = new System.Drawing.Size(202, 50);
            this.BTNReturn.TabIndex = 7;
            this.BTNReturn.Text = "Return Book";
            this.BTNReturn.UseVisualStyleBackColor = true;
            this.BTNReturn.Click += new System.EventHandler(this.BTNReturn_Click);
            // 
            // lbCurrentLoans
            // 
            this.lbCurrentLoans.FormattingEnabled = true;
            this.lbCurrentLoans.ItemHeight = 16;
            this.lbCurrentLoans.Location = new System.Drawing.Point(35, 444);
            this.lbCurrentLoans.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbCurrentLoans.Name = "lbCurrentLoans";
            this.lbCurrentLoans.Size = new System.Drawing.Size(421, 164);
            this.lbCurrentLoans.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loans";
            // 
            // dropDown_members
            // 
            this.dropDown_members.FormattingEnabled = true;
            this.dropDown_members.Location = new System.Drawing.Point(40, 309);
            this.dropDown_members.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dropDown_members.Name = "dropDown_members";
            this.dropDown_members.Size = new System.Drawing.Size(127, 24);
            this.dropDown_members.TabIndex = 6;
            // 
            // BTNLoan
            // 
            this.BTNLoan.Location = new System.Drawing.Point(175, 309);
            this.BTNLoan.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNLoan.Name = "BTNLoan";
            this.BTNLoan.Size = new System.Drawing.Size(281, 31);
            this.BTNLoan.TabIndex = 5;
            this.BTNLoan.Text = "Loan";
            this.BTNLoan.UseVisualStyleBackColor = true;
            this.BTNLoan.Click += new System.EventHandler(this.BTNLoan_Click);
            // 
            // BTNMembers
            // 
            this.BTNMembers.Location = new System.Drawing.Point(335, 342);
            this.BTNMembers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNMembers.Name = "BTNMembers";
            this.BTNMembers.Size = new System.Drawing.Size(121, 34);
            this.BTNMembers.TabIndex = 17;
            this.BTNMembers.Text = "Members";
            this.BTNMembers.UseVisualStyleBackColor = true;
            this.BTNMembers.Click += new System.EventHandler(this.BTNMembers_Click);
            // 
            // lbAvailableCopies
            // 
            this.lbAvailableCopies.FormattingEnabled = true;
            this.lbAvailableCopies.ItemHeight = 16;
            this.lbAvailableCopies.Location = new System.Drawing.Point(40, 128);
            this.lbAvailableCopies.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbAvailableCopies.Name = "lbAvailableCopies";
            this.lbAvailableCopies.Size = new System.Drawing.Size(416, 164);
            this.lbAvailableCopies.TabIndex = 4;
            // 
            // BTNLoansForMember
            // 
            this.BTNLoansForMember.Location = new System.Drawing.Point(175, 342);
            this.BTNLoansForMember.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNLoansForMember.Name = "BTNLoansForMember";
            this.BTNLoansForMember.Size = new System.Drawing.Size(158, 34);
            this.BTNLoansForMember.TabIndex = 18;
            this.BTNLoansForMember.Text = "All Loans For Member";
            this.BTNLoansForMember.UseVisualStyleBackColor = true;
            this.BTNLoansForMember.Click += new System.EventHandler(this.BTNLoansForMember_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Available Copies";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.labelShowAllAvailableCopies);
            this.panel1.Controls.Add(this.label_ShowAll);
            this.panel1.Controls.Add(this.dropDown_filterLoans);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BTNLoansForMember);
            this.panel1.Controls.Add(this.lbAvailableCopies);
            this.panel1.Controls.Add(this.BTNMembers);
            this.panel1.Controls.Add(this.BTNLoan);
            this.panel1.Controls.Add(this.dropDown_members);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbCurrentLoans);
            this.panel1.Controls.Add(this.BTNReturn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(538, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 703);
            this.panel1.TabIndex = 24;
            // 
            // labelShowAllAvailableCopies
            // 
            this.labelShowAllAvailableCopies.AutoSize = true;
            this.labelShowAllAvailableCopies.ForeColor = System.Drawing.SystemColors.Window;
            this.labelShowAllAvailableCopies.Location = new System.Drawing.Point(395, 108);
            this.labelShowAllAvailableCopies.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelShowAllAvailableCopies.Name = "labelShowAllAvailableCopies";
            this.labelShowAllAvailableCopies.Size = new System.Drawing.Size(61, 17);
            this.labelShowAllAvailableCopies.TabIndex = 26;
            this.labelShowAllAvailableCopies.Text = "Show All";
            this.labelShowAllAvailableCopies.Click += new System.EventHandler(this.labelShowAllAvailableCopies_Click);
            // 
            // label_ShowAll
            // 
            this.label_ShowAll.AutoSize = true;
            this.label_ShowAll.ForeColor = System.Drawing.SystemColors.Window;
            this.label_ShowAll.Location = new System.Drawing.Point(291, 418);
            this.label_ShowAll.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_ShowAll.Name = "label_ShowAll";
            this.label_ShowAll.Size = new System.Drawing.Size(61, 17);
            this.label_ShowAll.TabIndex = 25;
            this.label_ShowAll.Text = "Show All";
            this.label_ShowAll.Click += new System.EventHandler(this.label_ShowAll_Click);
            // 
            // dropDown_filterLoans
            // 
            this.dropDown_filterLoans.FormattingEnabled = true;
            this.dropDown_filterLoans.Items.AddRange(new object[] {
            "All Current Loans",
            "Loans Overdue",
            "Loans Returned"});
            this.dropDown_filterLoans.Location = new System.Drawing.Point(354, 416);
            this.dropDown_filterLoans.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dropDown_filterLoans.Name = "dropDown_filterLoans";
            this.dropDown_filterLoans.Size = new System.Drawing.Size(102, 24);
            this.dropDown_filterLoans.TabIndex = 24;
            this.dropDown_filterLoans.SelectedIndexChanged += new System.EventHandler(this.dropDown_filterLoans_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1051, 732);
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
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
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
        private System.Windows.Forms.ListBox lbCurrentLoans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropDown_members;
        private System.Windows.Forms.Button BTNLoan;
        private System.Windows.Forms.Button BTNMembers;
        private System.Windows.Forms.ListBox lbAvailableCopies;
        private System.Windows.Forms.Button BTNLoansForMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dropDown_filterLoans;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_ShowAll;
        private System.Windows.Forms.Label labelShowAllAvailableCopies;
    }
}

