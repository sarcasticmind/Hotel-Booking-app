using Hotel_Reservation.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Reservation.Services
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        
        private readonly HotelBookingContext context;

        public RoomTypeRepository(HotelBookingContext _context)
        {
            context = _context;
        }
        public List<RoomType> GetAll()
        {

            List<RoomType> roomTypes = context.RoomTypes.ToList();
            return roomTypes;

        }

        public RoomType GetByID(int id)
        {
            RoomType room = context.RoomTypes.FirstOrDefault(c => c.Id == id);
            return room;
        }
        public RoomType GetByType(string roomtype)
        {
            RoomType room = context.RoomTypes.FirstOrDefault(c => c.Type == roomtype);
            return room;
        }
        public void Insert(RoomType roomType)
        {
            context.RoomTypes.Add(roomType);
            context.SaveChanges();

        }

        public int Update(RoomType newroomtype, int id)
        {
            var oldroomtype = GetByID(id);
            if (oldroomtype == null)
            {
                oldroomtype.Type = newroomtype.Type;
                oldroomtype.price=newroomtype.price;
            }
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            RoomType room = context.RoomTypes.FirstOrDefault(c => c.Id == id);
            context.RoomTypes.Remove(room);
            int rows = context.SaveChanges();
            return rows;

        }

    }
}
