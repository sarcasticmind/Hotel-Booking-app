using Hotel_Reservation.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Reservation.Services
{
    public class BookingRepository : IBookingRepository
    {

        HotelBookingContext context;
        private readonly IRoomRepository roomRepository;

        public BookingRepository(HotelBookingContext _context,IRoomRepository roomRepository)
        {
            context = _context;
            this.roomRepository = roomRepository;
        }

        public List<Booking> GetAll()
        {

            List<Booking> bookings = context.Bookings.ToList();
            return bookings;

        }

        public Booking GetByID(int id)
        {
            Booking booking = context.Bookings.FirstOrDefault(c => c.Id == id);
            return booking;
        }
        public void Insert(Booking booking)
        {
            context.Bookings.Add(booking);
            context.SaveChanges();

        }


        public int Update(Booking newBooking, int id)
        {
            var oldbooking = GetByID(id);
            if (oldbooking != null)
            {
               
                oldbooking.Status = newBooking.Status;
                if (oldbooking.Status == 1)
                {
                    oldbooking.RoomId = newBooking.RoomId;
                }

            }
            if(newBooking.Status==1)
                roomRepository.GetByID((int)newBooking.RoomId).IsReserved = true;
        

            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            Booking booking = context.Bookings.FirstOrDefault(c => c.Id == id);
            context.Bookings.Remove(booking);
            int rows = context.SaveChanges();
            return rows;

        }

        public List<Booking> GetStatus()
        {
          return  context.Bookings.Where(w => w.Status == null).ToList();
        }
    }
}
