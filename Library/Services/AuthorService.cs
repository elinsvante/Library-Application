﻿using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        AuthorRepository authorRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        public void Add(Author a)
        {
            authorRepository.Add(a);
        }

        public IEnumerable<Book> BooksByAuthor(Author a)
        {
            return authorRepository.All().Where(author => author.Name == a.Name).SelectMany(authorBooks => authorBooks.Books);
        }
    }
}