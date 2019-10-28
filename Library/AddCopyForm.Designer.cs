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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropDown_books
            // 
            this.dropDown_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown_books.FormattingEnabled = true;
            this.dropDown_books.Location = new System.Drawing.Point(100, 128);
            this.dropDown_books.Margin = new System.Windows.Forms.Padding(2);
            this.dropDown_books.Name = "dropDown_books";
            this.dropDown_books.Size = new System.Drawing.Size(197, 24);
            this.dropDown_books.TabIndex = 0;
            // 
            // dropDown_condition
            // 
            this.dropDown_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dropDown_condition.Location = new System.Drawing.Point(100, 167);
            this.dropDown_condition.Margin = new System.Windows.Forms.Padding(2);
            this.dropDown_condition.Name = "dropDown_condition";
            this.dropDown_condition.Size = new System.Drawing.Size(62, 24);
            this.dropDown_condition.TabIndex = 1;
            // 
            // BTNAddCopy
            // 
            this.BTNAddCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddCopy.Location = new System.Drawing.Point(100, 208);
            this.BTNAddCopy.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAddCopy.Name = "BTNAddCopy";
            this.BTNAddCopy.Size = new System.Drawing.Size(197, 44);
            this.BTNAddCopy.TabIndex = 2;
            this.BTNAddCopy.Text = "Add Copy";
            this.BTNAddCopy.UseVisualStyleBackColor = true;
            this.BTNAddCopy.Click += new System.EventHandler(this.BTNAddCopy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Book Copy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Condition:";
            // 
            // AddCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(394, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNAddCopy);
            this.Controls.Add(this.dropDown_condition);
            this.Controls.Add(this.dropDown_books);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCopyForm";
            this.Text = "AddCopyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropDown_books;
        private System.Windows.Forms.ComboBox dropDown_condition;
        private System.Windows.Forms.Button BTNAddCopy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}