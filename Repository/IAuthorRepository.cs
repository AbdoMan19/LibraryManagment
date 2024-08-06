﻿using LibraryManagment.Models;
using NuGet.Frameworks;

namespace LibraryManagment.Repository
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        bool AddAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(int id);

    }
}
