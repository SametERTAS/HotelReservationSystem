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
            var districts = _unitOfWork.District.GetAll();
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
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(District district)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.District.Update(district);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(District district)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.District.Delete(district);
            }
            return RedirectToAction("Index");
        }
    }
}
