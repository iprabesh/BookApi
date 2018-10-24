using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BookApi.Models;
using Microsoft.AspNetCore.Cors;

namespace BookApi.Controllers{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")] // For Cors
    [ApiController]
    public class BookItemController : ControllerBase{
        private readonly BookItemContext _context;
        public BookItemController(BookItemContext context)
        {
            _context = context;
            if(_context.BookItems.Count()==0)
            {
                //Create a new Book if list is empty
                _context.BookItems.Add(new BookItem {title = "Java Your Way"});
                _context.BookItems.Add(new BookItem {title = "Ruby Your Way"});
                _context.SaveChanges();
            }
        }

         [HttpGet]
         [EnableCors("AllowAllHeaders")] // For Cors
         public ActionResult<List<BookItem>> GetAll()
         {
            return _context.BookItems.ToList();
         }

    }
}