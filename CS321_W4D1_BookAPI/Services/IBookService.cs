﻿using System.Collections.Generic;
using CS321_W4D1_BookAPI.ApiModels;
using CS321_W4D1_BookAPI.Models;

namespace CS321_W4D1_BookAPI.Services
{
    public interface IBookService
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        Book Add(Book todo); 
        // read
        Book Get(int id);
        // update
        Book Update(Book todo); 
        // delete
        void Remove(Book todo);
        // list
        IEnumerable<Book> GetAll();
		object Update(BookModel updatedBook);
        IEnumerable<Book> GetBooksForAuthor(int id);
	}
}
