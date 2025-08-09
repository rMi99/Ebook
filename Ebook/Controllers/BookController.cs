using Ebook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ebook.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            try {
            var books = _context.Book.ToList();
            return View(books);
            } catch (Exception ex) {
            
            return View();
            }
        }
        //GET : Load the create book page
        public IActionResult Create()
        {
            return View();
        }

        //Post : Load the create book page
        [HttpPost]
        public IActionResult Create(Book bookRequest)
        {
            //var bookRequest = this.bookRequest;
            //var bookRequest.id 
            _context.Book.Add(bookRequest);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(Guid id)
        {
            var bookDetail = _context.Book.Find(id);
            return View(bookDetail);

        }
        //GET for book edit
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var book = _context.Book.Find(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (book != null)
            {
                _context.Book.Update(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();

        }
    }
}
