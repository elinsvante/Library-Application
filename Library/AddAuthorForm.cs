using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library
{
    public partial class AddAuthorForm : Form
    {
        AuthorService authorService;

        public AddAuthorForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.authorService = new AuthorService(repFactory);
        }

        private void BTNAddAuthor_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            if(string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter name of the author.");
            }
            else
            {
                Author newAuthor = new Author(name);
                authorService.Add(newAuthor);
                this.Close();
            } 
        }
    }
}
