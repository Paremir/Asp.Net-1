using BTDLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BTDLab2.Controllers
{
    public class HomeController : Controller
    {
        MyContext db = new MyContext();

        public ActionResult Index(int IdMom = 1, int IdSon = 2, int IdDoc = 5)
        {
            ViewBag.Mom = IdMom;
            ViewBag.Son = IdSon;
            ViewBag.Doc = IdDoc;
            return View(db.Characters.ToArray());
        }
        public ActionResult Places()
        {
            return View(db.Places.ToList());
        }
        [HttpGet]
        public ActionResult CreatePlace()
        {
            return View();
        }       
        [HttpPost]
        public ActionResult CreatePlace(Place place)
        {
            db.Places.Add(place);
            db.SaveChanges();
            return RedirectToAction("Places");
        }
        public ActionResult DeletePlace(int id)
        {
            Place temp = db.Places.Find(id);
            db.Places.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Places");
        }
        [HttpGet]
        public ActionResult EditPlace(int id)
        {
            Place place = db.Places.Find(id);
            return View(place);
        }

        [HttpPost]
        public ActionResult EditPlace(Place place)
        {
            db.Entry(place).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Places");
        }
        public ActionResult Diseases()
        {
            return View(db.Diseases.ToList());
        }
        [HttpGet]
        public ActionResult CreateDisease()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDisease(Disease disease)
        {
            db.Diseases.Add(disease);
            db.SaveChanges();
            return RedirectToAction("Diseases");
        }
        public ActionResult DeleteDisease(int id)
        {
            Disease temp = db.Diseases.Find(id);
            db.Diseases.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Diseases");
        }
        [HttpGet]
        public ActionResult EditDisease(int id)
        {
            Disease disease = db.Diseases.Find(id);
            return View(disease);
        }

        [HttpPost]
        public ActionResult EditDisease(Disease disease)
        {
            db.Entry(disease).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Diseases");
        }
        public ActionResult Words()
        {
            return View(db.Words.ToList());
        }
        [HttpGet]
        public ActionResult CreateWord()
        {
            ViewBag.Diseases = new SelectList(db.Diseases, "Id", "Name");

            return View();
        }
        [HttpPost]
        public ActionResult CreateWord(Word word)
        {
            db.Words.Add(word);
            db.SaveChanges();
            return RedirectToAction("Words");
        }
        public ActionResult DeleteWord(int id)
        {
            Word temp = db.Words.Find(id);
            db.Words.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Words");
        }
        [HttpGet]
        public ActionResult EditWord(int id)
        {
            ViewBag.Diseases = new SelectList(db.Diseases, "Id", "Name");
            Word word = db.Words.Find(id);
            return View(word);
        }

        [HttpPost]
        public ActionResult EditWord(Word word)
        {
            db.Entry(word).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Words");
        }
        [HttpGet]
        public ActionResult Create()
        {

            ViewBag.Roles = new SelectList(db.Roles, "Id", "Name");
            ViewBag.Places = new SelectList(db.Places, "Id", "Name");
            ViewBag.Words = new SelectList(db.Words, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Character character)
        {

            db.Characters.Add(character);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Character temp = db.Characters.Find(id);
            db.Characters.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            ViewBag.Roles = new SelectList(db.Roles, "Id", "Name");
            ViewBag.Places = new SelectList(db.Places, "Id", "Name");
            ViewBag.Words = new SelectList(db.Words, "Id", "Name");
            Character character = db.Characters.Find(id);
            return View(character);
        }

        [HttpPost]
        public ActionResult Edit (Character character)
        {
            db.Entry(character).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}