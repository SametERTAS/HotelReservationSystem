using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.Document;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class DocumentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DocumentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var documents = _unitOfWork.Document.GetAllInclude(null,"Customer");
            var model = _mapper.Map<IEnumerable<DocumentIndexVM>>(documents);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var customers = _unitOfWork.Customer.GetAll();
            ViewBag.Customers = new SelectList(customers, "Id", "FullName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(DocumentCreateVM document)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Document>(document);
                _unitOfWork.Document.Add(model);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.Document.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<DocumentUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            var customers = _unitOfWork.Customer.GetAll();
            ViewBag.Customers = new SelectList(customers, "Id", "FullName");
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(DocumentUpdateVM document)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Document>(document);
                _unitOfWork.Document.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.Document.GetById(x => x.Id.Equals(id));
            if (entity != null)
            {
                _unitOfWork.Document.Delete(entity);
                return RedirectToAction("Index");
            }
            return NotFound();

        }
    }
}
