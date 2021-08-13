using EFDataApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp12_08.Models;

namespace WebApp12_08.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
       private ApplicationContext DbContext
        {
            get;
        }
        public BooksController(ApplicationContext applicationContext)
        {
            DbContext = applicationContext;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return DbContext.Books.ToList();
        }

        [HttpPut]
        public IEnumerable<Book> Update(Book book)
        {

            DbContext.Books.Update(book);
            DbContext.SaveChanges();
            return DbContext.Books.ToList();
        }
        
        [HttpPost]
        public  IEnumerable<Book> Create(Book book)
        {
            DbContext.Books.Add(book);
            DbContext.SaveChanges();
           return DbContext.Books.ToList();
        }

        [HttpDelete]
        public IEnumerable<Book> Delete(int book_id)
        {
            DbContext.Books.Remove(DbContext.Books.Find(book_id));
            DbContext.SaveChanges();
            return DbContext.Books.ToList(); 
        }
    }
}
