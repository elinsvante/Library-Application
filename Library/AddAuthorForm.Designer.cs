namespace Library
{
    partial class AddAuthorForm
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
            this.BTNAddAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(85, 77);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(363, 31);
            this.tbName.TabIndex = 0;
            // 
            // BTNAddAuthor
            // 
            this.BTNAddAuthor.Location = new System.Drawing.Point(85, 149);
            this.BTNAddAuthor.Name = "BTNAddAuthor";
            this.BTNAddAuthor.Size = new System.Drawing.Size(363, 52);
            this.BTNAddAuthor.TabIndex = 1;
            this.BTNAddAuthor.Text = "Add Author";
            this.BTNAddAuthor.UseVisualStyleBackColor = true;
            this.BTNAddAuthor.Click += new System.EventHandler(this.BTNAddAuthor_Click);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 270);
            this.Controls.Add(this.BTNAddAuthor);
            this.Controls.Add(this.tbName);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button BTNAddAuthor;
    }
}