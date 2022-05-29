using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation.Models;
using Microsoft.AspNetCore.Http;
using Hotel_Reservation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Hotel_Reservation.Controllers
{
    //[Authorize] 
    public class BookingsController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly HotelBookingContext _context;
        IBookingRepository bookingRepository;
        public BookingsController(UserManager<User> userManager,HotelBookingContext context,
            IBookingRepository bookingRepository)
        {
            this.userManager = userManager;
            _context = context;
            this.bookingRepository = bookingRepository;
        }

        // GET: Bookings
        public  IActionResult Index()
        { ViewData["Rooms"] = _context.Rooms.Where(w => w.IsReserved.Equals(false)).ToList();
            
            return View("Reservation", bookingRepository.GetStatus());
        }

        public IActionResult Create()
        {
            ViewData["RoomType"] = _context.RoomTypes.ToList();


            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Booking booking)
        {
            booking.customerId = userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                bookingRepository.Insert(booking);
                ViewBag.SuccessMessage =  "Your Resevation is Sent...Wait Manager Approve";
                ModelState.Clear();

                return RedirectToAction("Create");
            }
           
            ViewData["RoomType"] = _context.RoomTypes.ToList();

            return View(booking);
        }

        // GET: Bookings/Edit/5
        public IActionResult Edit(int id)
        {

            var booking = bookingRepository.GetByID(id);
            if (booking == null)
            {
                return NotFound();
            }
            
            return View(booking);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,  Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bookingRepository.Update(booking, id);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
           
            return View(booking);
        }

      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var booking = bookingRepository.Delete(id);
          
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            ViewData["Rooms"] = _context.Rooms.Where(w => w.IsReserved.Equals(false)).ToList();

            return _context.Bookings.Any(e => e.Id == id);
        }
        public IActionResult accept(Booking booking)
        {
            
            booking.Status = 1;
            
            bookingRepository.Update(booking,booking.Id);

            return RedirectToAction("Index", "Bookings");


        } public IActionResult Refuse(Booking booking)
        { 
            booking.Status = 0;
            bookingRepository.Update(booking,booking.Id);
            return RedirectToAction("Index", "Bookings");


        }

       public IActionResult GetMyActivity()
        {
            string id = userManager.GetUserId(User);
            return View(bookingRepository.GetAll().Where(w => w.customerId == id).ToList());
        }
    }
}
