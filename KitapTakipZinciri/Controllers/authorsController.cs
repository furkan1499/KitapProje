using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KitapTakipZinciri.Models;
using System.Data.Entity.Migrations;

namespace KitapTakipZinciri.Controllers
{
    public class authorsController : Controller
    {
        MyDB db = new MyDB();


        // GET: authors
        public async Task<IActionResult> Index()
        {
            return View(db.authors.ToList());
        }

        // GET: authors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = db.books.Where(x => x.id == id).FirstOrDefault();

            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // GET: authors/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: authors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,surname,birthday,bookId,description")] author author)
        {
            
            if (ModelState.IsValid)
            {
                ViewBag.bookId = db.authors.Where(x => x.bookId == x.book.id).FirstOrDefault();
                db.authors.Add(author);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: authors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await db.authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // POST: authors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,surname,birthday,bookId,description")] author author)
        {
            if (id != author.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.authors.AddOrUpdate(author);
                    
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!authorExists(author.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: authors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = db.authors.Where(x => x.id == id).FirstOrDefault();

            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // POST: authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authors = await db.authors.FindAsync(id);
            db.authors.Remove(authors);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool authorExists(int id)
        {
            return db.authors.Any(e => e.id == id);
        }
    }
}
