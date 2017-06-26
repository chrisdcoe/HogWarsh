using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HogWarsh.Models;
using HogWarsh.Repositories;

namespace HogWarsh.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository studentRepository;
        private HouseRepository houseRepository;

        [HttpGet]
        public ActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActuallyEnroll(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("Enroll");
            }

            studentRepository = new StudentRepository();
            studentRepository.Create(student);
            return RedirectToAction("Students");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            studentRepository = new StudentRepository();
            var student = studentRepository.GetById(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            studentRepository = new StudentRepository();
            studentRepository.Update(student);
            return RedirectToAction("Students");
        }

        [HttpGet]
        public ActionResult Students()
        {
            studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();

            return View(students);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            studentRepository = new StudentRepository();
            var student = studentRepository.GetById(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            studentRepository = new StudentRepository();
            studentRepository.Delete(student.Id);
            return RedirectToAction("Students");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            studentRepository = new StudentRepository();

            return View(studentRepository.GetById(id));
        }
    }
}