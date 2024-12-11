using DiaryApp.Controllers.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db; 
        
        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;  // inject the DbContext into the controller
        }
        public IActionResult Index()
        {
            // Get all diary entries from the database
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList(); 

            // Return the view with the list of diary entries
            return View(objDiaryEntryList); 
        }
        

        public IActionResult Create()
        {
            // Return the view for creating a new diary entry
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length <3)
            {
                ModelState.AddModelError("Title", "Title cannot be less than 3 characters");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj); // create a new entry for the entry object
                _db.SaveChanges();  // save the changes to the database
                return RedirectToAction("Index");  // redirect to the Index view after creating a new diary entry
            }
            return View(obj); // return the view with the error if the model state is not valid
        }



        // edit view controller 
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title cannot be less than 3 characters");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj); // updateentry for the entry object
                _db.SaveChanges();  // save the changes to the database
                return RedirectToAction("Index");  // redirect to the Index view after creating a new diary entry
            }
            return View(obj); // return the view with the error if the model state is not valid
        }


        //delete view controller 
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
           
                _db.DiaryEntries.Remove(obj); // Delete  for the entry object
                _db.SaveChanges();  // save the changes to the database
                return RedirectToAction("Index");  // redirect to the Index view after creating a new diary entry
           
        }
    }
}