using AutoMapper;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.Customer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CustomerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var customers = _unitOfWork.Customer.GetAll();
            var model = _mapper.Map<IEnumerable<CustomerIndexVM>>(customers);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerCreateVM customer)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Customer>(customer);
                _unitOfWork.Customer.Add(model);
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
            var entity = _unitOfWork.Customer.GetById(x => x.Id.Equals(id));
            var model = _mapper.Map<CustomerUpdateVM>(entity);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CustomerUpdateVM customer)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Customer>(customer);
                _unitOfWork.Customer.Update(entity);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _unitOfWork.Customer.GetById(x => x.Id.Equals(id));
            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.Customer.Delete(entity);

            return RedirectToAction("Index");
        }
    }
}
