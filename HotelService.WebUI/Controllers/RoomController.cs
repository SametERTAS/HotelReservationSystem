using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.Room;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var rooms = _unitOfWork.Room.GetAllInclude(null,"Hotel","RoomType");
            var model = _mapper.Map<IEnumerable<RoomIndexVM>>(rooms);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var hotels = _unitOfWork.Hotel.GetAll();
            var roomTypes = _unitOfWork.RoomType.GetAll();
            ViewBag.Hotels = new SelectList(hotels, "Id", "Name");
            ViewBag.RoomTypes = new SelectList(roomTypes, "Id", "RoomName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(RoomCreateVM room)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Room>(room);
                _unitOfWork.Room.Add(model);
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
            var entity = _unitOfWork.Room.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<RoomUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            var hotels = _unitOfWork.Hotel.GetAll();
            var roomTypes = _unitOfWork.RoomType.GetAll();
            ViewBag.Hotels = new SelectList(hotels, "Id", "Name");
            ViewBag.RoomTypes = new SelectList(roomTypes, "Id", "RoomName");
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(RoomUpdateVM room)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Room>(room);
                _unitOfWork.Room.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.Room.GetById(x => x.Id.Equals(id));
            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.Room.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
