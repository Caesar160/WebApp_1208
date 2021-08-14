using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp12_08.Models;

namespace WebApp12_08.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
       IRepository<Book> Books { get; }
       IRepository<LoveUnit> LoveUnits { get; }
       IRepository<SMS> SMSs { get; }
       void Save();
    }
}