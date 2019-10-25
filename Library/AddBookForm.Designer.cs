namespace Library
{
    partial class AddBookForm
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dropDown_authors = new System.Windows.Forms.ComboBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.BTNAddBook = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(98, 81);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(372, 31);
            this.tbTitle.TabIndex = 0;
            // 
            // dropDown_authors
            // 
            this.dropDown_authors.FormattingEnabled = true;
            this.dropDown_authors.Location = new System.Drawing.Point(98, 159);
            this.dropDown_authors.Name = "dropDown_authors";
            this.dropDown_authors.Size = new System.Drawing.Size(372, 33);
            this.dropDown_authors.TabIndex = 1;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(98, 251);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(372, 31);
            this.tbISBN.TabIndex = 2;
            // 
            // BTNAddBook
            // 
            this.BTNAddBook.Location = new System.Drawing.Point(98, 440);
            this.BTNAddBook.Name = "BTNAddBook";
            this.BTNAddBook.Size = new System.Drawing.Size(372, 95);
            this.BTNAddBook.TabIndex = 3;
            this.BTNAddBook.Text = "Add Book";
            this.BTNAddBook.UseVisualStyleBackColor = true;
            this.BTNAddBook.Click += new System.EventHandler(this.BTNAddBook_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(98, 334);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(372, 31);
            this.tbDescription.TabIndex = 4;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 642);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.BTNAddBook);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.dropDown_authors);
            this.Controls.Add(this.tbTitle);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ComboBox dropDown_authors;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Button BTNAddBook;
        private System.Windows.Forms.TextBox tbDescription;
    }
}