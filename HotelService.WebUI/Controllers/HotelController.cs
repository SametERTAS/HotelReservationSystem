using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class HotelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.Hotel.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Hotel.Add(hotel);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Hotel.Update(hotel);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Hotel.Delete(hotel);
            }
            return RedirectToAction("Index");
        }
    }
}
