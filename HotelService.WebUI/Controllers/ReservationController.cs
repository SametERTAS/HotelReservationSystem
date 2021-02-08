using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReservationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.Reservation.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Reservation.Add(reservation);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Reservation.Update(reservation);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Reservation.Delete(reservation);
            }
            return RedirectToAction("Index");
        }
    }
}
