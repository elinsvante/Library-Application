namespace Library
{
    partial class AddCopyForm
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
            this.dropDown_books = new System.Windows.Forms.ComboBox();
            this.dropDown_condition = new System.Windows.Forms.ComboBox();
            this.BTNAddCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dropDown_books
            // 
            this.dropDown_books.FormattingEnabled = true;
            this.dropDown_books.Location = new System.Drawing.Point(74, 75);
            this.dropDown_books.Name = "dropDown_books";
            this.dropDown_books.Size = new System.Drawing.Size(390, 33);
            this.dropDown_books.TabIndex = 0;
            // 
            // dropDown_condition
            // 
            this.dropDown_condition.FormattingEnabled = true;
            this.dropDown_condition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.dropDown_condition.Location = new System.Drawing.Point(512, 75);
            this.dropDown_condition.Name = "dropDown_condition";
            this.dropDown_condition.Size = new System.Drawing.Size(121, 33);
            this.dropDown_condition.TabIndex = 1;
            // 
            // BTNAddCopy
            // 
            this.BTNAddCopy.Location = new System.Drawing.Point(74, 191);
            this.BTNAddCopy.Name = "BTNAddCopy";
            this.BTNAddCopy.Size = new System.Drawing.Size(559, 96);
            this.BTNAddCopy.TabIndex = 2;
            this.BTNAddCopy.Text = "Add Copy";
            this.BTNAddCopy.UseVisualStyleBackColor = true;
            this.BTNAddCopy.Click += new System.EventHandler(this.BTNAddCopy_Click);
            // 
            // AddCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.BTNAddCopy);
            this.Controls.Add(this.dropDown_condition);
            this.Controls.Add(this.dropDown_books);
            this.Name = "AddCopyForm";
            this.Text = "AddCopyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dropDown_books;
        private System.Windows.Forms.ComboBox dropDown_condition;
        private System.Windows.Forms.Button BTNAddCopy;
    }
}