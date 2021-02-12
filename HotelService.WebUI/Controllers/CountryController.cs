using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.Country;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class CountryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CountryController(IUnitOfWork unitOfWork, IMapper mapper)
        {

            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var countries = _unitOfWork.Country.GetAll();
            var model = _mapper.Map<IEnumerable<CountryIndexVM>>(countries);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CountryCreateVM Country)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Country>(Country);
                _unitOfWork.Country.Add(model);
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

            var country = _unitOfWork.Country.GetById(x=>x.Id.Equals(id));
            var model = _mapper.Map<CountryUpdateVM>(country);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CountryUpdateVM country)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Country>(country);
                _unitOfWork.Country.Update(model);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = _unitOfWork.Country.GetById(x => x.Id.Equals(id));
            if (model != null)
            {
                _unitOfWork.Country.Delete(model);
                return RedirectToAction("Index");
            }
            return NotFound();


        }
    }
}
