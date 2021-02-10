using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.Reservation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ReservationController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var reservations = _unitOfWork.Reservation.GetAll();
            var model = _mapper.Map<IEnumerable<ReservationIndexVM>>(reservations);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var rooms = _unitOfWork.Room.GetAll();
            ViewBag.Rooms = new SelectList(rooms, "Id", "RoomNumber");
            return View();
        }
        [HttpPost]
        public IActionResult Create(ReservationCreateVM reservation)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Reservation>(reservation);
                _unitOfWork.Reservation.Add(model);
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
            var entity = _unitOfWork.Reservation.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<ReservationUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            var rooms = _unitOfWork.Room.GetAll();
            ViewBag.Rooms = new SelectList(rooms, "Id", "RoomNumber");
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ReservationUpdateVM reservation)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Reservation>(reservation);
                _unitOfWork.Reservation.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.Reservation.GetById(x => x.Id.Equals(id));
            if (entity == null)
            {
                return NotFound();
            }

            _unitOfWork.Reservation.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
