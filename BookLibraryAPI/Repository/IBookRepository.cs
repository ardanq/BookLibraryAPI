﻿using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Entities;

namespace BookLibraryAPI.Repository
{
    public interface IBookRepository
    {
        Book GetById(int Id);

        void CreateBook(Book book);

        void DeleteById(int Id);

        void UpdateBook(Book book);
    }
}
