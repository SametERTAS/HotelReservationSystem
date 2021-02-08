using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class RoomTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.RoomType.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.RoomType.Add(roomType);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.RoomType.Update(roomType);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.RoomType.Delete(roomType);
            }
            return RedirectToAction("Index");
        }
    }
}
