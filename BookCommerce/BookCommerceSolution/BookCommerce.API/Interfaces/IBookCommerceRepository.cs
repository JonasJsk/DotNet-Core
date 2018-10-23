﻿using BookCommerce.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCommerce.API.Interfaces
{
    public interface IBookCommerceRepository
    {
        #region Author Exists
        bool AuthorExists(int authorId);
        #endregion

        #region Get All Authors
        IEnumerable<Author> GetAllAuthors();
        #endregion

        #region Get Author
        Author GetAuthor(int authorId, bool inludeBook);
        #endregion

        /* --------------------------------- */

        #region Get All Books
        IEnumerable<Book> GetAllBooks();
        #endregion

        #region Get All Books By Author
        IEnumerable<Book> GetAllBooksByAuthor(string authorname);
        #endregion

        #region Get All Books By Title
        IEnumerable<Book> GetAllBooksByTitle(string title);
        #endregion

        #region Get All Books By Term
        IEnumerable<Book> GetAllBooksByTerm(string term);
        #endregion

        /* --------------------------------- */

        #region Get Book For Authors
        IEnumerable<Book> GetBookForAuthors(int authorId);
        #endregion

        #region Get Book For Author
        Book GetBookForAuthor(int authorId, int bookId);
        #endregion

        /* --------------------------------- */

        #region Add Book For Author
        void AddBookForAuthor(int authorId, Book book);
        #endregion

        /* --------------------------------- */

        #region Delete Book
        void DeleteBook(Book book);
        #endregion

        #region Save
        bool Save();
        #endregion
    }
}