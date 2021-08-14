using EFDataApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp12_08.Interfaces;
using WebApp12_08.Models;

namespace WebApp12_08.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationContext DbContext;
        private BooksRepository booksRepository;
       // private LoveUnitsRepository loveUnitsRepository;
       //private SMSsRepository sMSsRepository;
        public EFUnitOfWork(string connectionString)
        {
            DbContext = new ApplicationContext(connectionString);
        }
        public IRepository<Book> Books
        {
            get
            {
                if (booksRepository == null)
                    booksRepository = new BooksRepository(DbContext);
                return booksRepository;
            }
        }

        public IRepository<LoveUnit> LoveUnits => throw new NotImplementedException();

        public IRepository<SMS> SMSs => throw new NotImplementedException();

        public void Save()
        {
            DbContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}