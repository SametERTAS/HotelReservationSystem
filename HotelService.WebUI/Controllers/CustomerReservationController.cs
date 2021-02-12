using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.CustomerReservation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class CustomerReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CustomerReservationController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var customerReservations = _unitOfWork.CustomerReservation.GetAllInclude(null,"Reservation.Room.RoomType","Customer");
            var model = _mapper.Map<IEnumerable<CustomerReservationIndexVM>>(customerReservations);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var customers = _unitOfWork.Customer.GetAll();
            var reservations = _unitOfWork.Reservation.GetAll();
            ViewBag.Customers = new SelectList(customers, "Id", "FullName");
            ViewBag.Reservations = new SelectList(reservations, "Id", "Id");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerReservationCreateVM customerReservation)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<CustomerReservation>(customerReservation);
                _unitOfWork.CustomerReservation.Add(model);
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
            var entity = _unitOfWork.CustomerReservation.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<CustomerReservationUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            var customers = _unitOfWork.Customer.GetAll();
            var reservations = _unitOfWork.Reservation.GetAll();
            ViewBag.Customers = new SelectList(customers, "Id", "FullName");
            ViewBag.Reservations = new SelectList(reservations, "Id", "Id");
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CustomerReservationUpdateVM customerReservation)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<CustomerReservation>(customerReservation);
                _unitOfWork.CustomerReservation.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.CustomerReservation.GetById(x => x.Id.Equals(id));

            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.CustomerReservation.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
