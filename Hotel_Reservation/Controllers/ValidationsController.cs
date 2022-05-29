using Hotel_Reservation.Models;
using Hotel_Reservation.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hotel_Reservation.Controllers
{
    public class ValidationsController : Controller
    {

        IBookingRepository bookingRepository;
        IRoomRepository roomRepository;
        IRoomTypeRepository roomTypeRepository;
        
        public ValidationsController(IBookingRepository bookingRepository, IRoomTypeRepository roomTypeRepository, IRoomRepository roomRepository)
        {
            this.bookingRepository = bookingRepository;
            this.roomRepository = roomRepository;
            this.roomTypeRepository = roomTypeRepository;
            
        }
        HotelBookingContext context = new HotelBookingContext();
        // ---------custom validation for unique client name ----------------//
        public IActionResult UniqueRoomType(string RoomType)
        {
            var roomtype = roomTypeRepository.GetByType(RoomType);
            if (roomtype == null)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }



        //-----------booking validation Datetime___________//
        public IActionResult ToGreaterThanFrom(DateTime From, DateTime To)
        {
            if (From< To)
            {

                return Json(true);

            }
            else
                return Json(false);


        }
    }
}
