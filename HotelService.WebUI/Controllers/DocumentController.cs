using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class DocumentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DocumentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.Document.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Document document)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Document.Add(document);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Document document)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Document.Update(document);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Document document)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Document.Delete(document);
            }
            return RedirectToAction("Index");
        }
    }
}
