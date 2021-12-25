using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecoundExam.data;
using SecoundExam.service;
using SecoundExam.Models;

namespace SecoundExam.Controllers
{
    public class PatiantController : Controller
    {
        private  IPatiantservice patiantservice;

        public PatiantController(IPatiantservice _patiantservice)
        {
            patiantservice = _patiantservice;
        }
        public IActionResult Index()
        {
            List <patiant> li = patiantservice.load();
            int id = (int)TempData["ID"];
            return View("PatiantList", li);
        }

        public IActionResult Exit(int id)
        {
            patiant p = patiantservice.Exit(id);
            return View("PatiantList", p);
        }

        public IActionResult save(VMPatiant vm)
        {
            if (vm.pat.BedNo <= 3) { 
            patiantservice.Insert(vm.pat);
            }
            return View("NewPatiant",vm);
        }
    }
}
