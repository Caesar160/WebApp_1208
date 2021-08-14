using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp12_08.Models;

namespace WebApp12_08.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IActionResult Get();
        IActionResult Update(Book book);
        IActionResult Create(Book book);
        IActionResult Delete(int id);
           
        
    }
}