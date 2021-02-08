using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class CustomerReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerReservationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.CustomerReservation.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerReservation customerReservation)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerReservation.Add(customerReservation);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(CustomerReservation customerReservation)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerReservation.Update(customerReservation);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(CustomerReservation customerReservation)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerReservation.Delete(customerReservation);
            }
            return RedirectToAction("Index");
        }
    }
}
