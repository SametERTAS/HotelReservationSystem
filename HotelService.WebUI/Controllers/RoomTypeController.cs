using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.RoomType;
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
        private readonly IMapper _mapper;
        public RoomTypeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var roomTypes = _unitOfWork.RoomType.GetAll();
            var model = _mapper.Map<IEnumerable<RoomTypeIndexVM>>(roomTypes);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RoomTypeCreateVM roomType)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<RoomType>(roomType);
                _unitOfWork.RoomType.Add(model);
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
            var entity = _unitOfWork.RoomType.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<RoomTypeUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(RoomTypeUpdateVM roomType)
        {

            if (ModelState.IsValid)
            {
                var model = _mapper.Map<RoomType>(roomType);
                _unitOfWork.RoomType.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var entity = _unitOfWork.RoomType.GetById(x => x.Id.Equals(id));
            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.RoomType.Delete(entity);

            return RedirectToAction("Index");
        }
    }
}
