using ArdalanAraghi_CRUD.Models;
using ArdalanAraghi_CRUD.Services.Repository;
using ArdalanAraghi_CRUD.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Customer, int> DBCustomer;
        public HomeController(IRepository<Customer, int> DBCustomer)
        {
            this.DBCustomer = DBCustomer;
        }
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult InsertConfirm(CustomerViewModel model, [FromServices] IMapper mapper)
        {
            if (DBCustomer.GetAll().Any(x => x.Firstname == model.Firstname) == false &&
                DBCustomer.GetAll().Any(x => x.Lastname == model.Lastname) == false &&
                DBCustomer.GetAll().Any(x => x.DateOfBirth == model.DateOfBirth) == false)
            {
                Customer customer = mapper.Map<Customer>(model);
                DBCustomer.Insert(customer);
                TempData["modalmsg"] = "The registration operation was successful!";
            }
            else
            {
                TempData["modalmsg2"] = "The registration operation was unsuccessful!";
            }
            return RedirectToAction("Insert");
        }
        public IActionResult CustomersList()
        {
            return View(DBCustomer.GetAll());
        }
        public IActionResult RemoveConfirm(int Id)
        {
            DBCustomer.Delete(Id);
            TempData["modalmsg"] = "Customer removed!";
            return RedirectToAction("CustomersList");
        }
        public IActionResult Edit(int Id)
        {
            Customer customer = DBCustomer.Find(Id);
            ViewData["Customer"] = customer;
            return View();
        }
        public IActionResult Update(CustomerViewModel model, [FromServices] IMapper mapper)
        {
            Customer customer = DBCustomer.Find(model.Id);
            customer.Firstname = model.Firstname;
            customer.Lastname = model.Lastname;
            customer.PhoneNumber = model.PhoneNumber;
            customer.BankAccountNumber = model.BankAccountNumber;
            customer.DateOfBirth = model.DateOfBirth;
            customer.Email = model.Email;
            DBCustomer.Update(customer);
            TempData["modalmsg"] = "Customer updated!";
            return RedirectToAction("CustomersList");
        }
    }
}
