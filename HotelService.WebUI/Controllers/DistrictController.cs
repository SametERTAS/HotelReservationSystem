using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.District;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public DistrictController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var districts = _unitOfWork.District.GetAllInclude(null,"City");
            var model = _mapper.Map<IEnumerable<DistrictIndexVM>>(districts);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cities = _unitOfWork.City.GetAll();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(DistrictCreateVM district)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<District>(district);
                _unitOfWork.District.Add(model);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            var cities = _unitOfWork.City.GetAll();
            ViewBag.Cities = new SelectList(cities, "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }
            var district = _unitOfWork.District.GetById(x=>x.Id.Equals(id));
            var model = _mapper.Map<DistrictUpdateVM>(district);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(DistrictUpdateVM district)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<District>(district);
                _unitOfWork.District.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = _unitOfWork.District.GetById();
            if (model != null)
            {
                _unitOfWork.District.Delete(model);
            }
            return RedirectToAction("Index");
        }
    }
}
