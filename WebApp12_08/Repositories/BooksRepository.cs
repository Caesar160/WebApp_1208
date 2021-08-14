using EFDataApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApp12_08.Interfaces;
using WebApp12_08.Models;

namespace WebApp12_08.Repositories
{
    public class BooksRepository : IRepository<Book>
    {
        private ApplicationContext DbContext
        {
            get;
        }
        public BooksRepository(ApplicationContext applicationContext)
        {
            DbContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DbContext.Books.ToList());
        }

        [HttpPut]
        public IActionResult Update(Book book)
        {
            DbContext.Books.Update(book);
            DbContext.SaveChanges();
            return Ok(DbContext.Books.ToList());
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            DbContext.Books.Add(book);
            DbContext.SaveChanges();
            return Ok(DbContext.Books.ToList());
        }

        [HttpDelete]
        public IActionResult Delete(int book_id)
        {
            DbContext.Books.Remove(DbContext.Books.Find(book_id));
            DbContext.SaveChanges();
            return Ok(DbContext.Books.ToList());
        }
    }
}