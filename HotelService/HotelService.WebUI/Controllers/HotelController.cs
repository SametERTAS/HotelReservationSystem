using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.Hotel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class HotelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public HotelController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var hotels = _unitOfWork.Hotel.GetAll();
            var model = _mapper.Map<IEnumerable<HotelIndexVM>>(hotels);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var districts = _unitOfWork.District.GetAll();
            ViewBag.Districts = new SelectList(districts, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(HotelCreateVM hotel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Hotel>(hotel);
                _unitOfWork.Hotel.Add(model);
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
            var districts = _unitOfWork.District.GetAll();
            ViewBag.Districts = new SelectList(districts, "Id", "Name");
            var entity = _unitOfWork.Hotel.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<HotelUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(HotelUpdateVM hotel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Hotel>(hotel);
                _unitOfWork.Hotel.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.Hotel.GetById(x => x.Id.Equals(id));
            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.Hotel.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
