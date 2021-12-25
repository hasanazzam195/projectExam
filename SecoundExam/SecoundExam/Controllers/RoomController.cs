using Microsoft.AspNetCore.Mvc;
using SecoundExam.data;
using SecoundExam.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.Controllers
{
    public class RoomController : Controller
    {
        private  IRoomService roomService;

        public RoomController(IRoomService _roomService)
        {
            roomService = _roomService;
        }
        public IActionResult Index()
        {
            List<Room> li = roomService.Load();
            return View("RoomList",li);
        }

        public IActionResult SearchData()
        {
            int No = Convert.ToInt32(Request.Form["txtSerch"]);
            List<Room> li = roomService.LoadByName(No);
            return View("RoomList", li);
        }

        public IActionResult PatiantData(int id)
        {
            TempData["ID"] = id;
            return RedirectToAction("Index", "Patiant");
        }
    }
}
