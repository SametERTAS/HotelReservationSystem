using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.City;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class CityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public CityController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var cities = _unitOfWork.City.GetAllInclude(null, "Country");
            var model = _mapper.Map<IEnumerable<CityIndexVM>>(cities);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(_unitOfWork.Country.GetAll(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CityCreateVM city)

        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<City>(city);
                _unitOfWork.City.Add(model);


            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            var countries = _unitOfWork.Country.GetAll();
            ViewBag.Countries = new SelectList(countries, "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }
            var city = _unitOfWork.City.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<CityUpdateVM>(city);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CityUpdateVM city)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<City>(city);
                _unitOfWork.City.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = _unitOfWork.City.GetById(x => x.Id.Equals(id));
            if (ModelState.IsValid)
            {
                _unitOfWork.City.Delete(model);
                return RedirectToAction("Index");
            }
            return NotFound();

        }
    }
}
