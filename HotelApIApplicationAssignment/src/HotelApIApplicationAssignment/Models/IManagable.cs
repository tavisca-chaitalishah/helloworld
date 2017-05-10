using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApIApplicationAssignment.Models
{
    public interface IManagable
    {
        List<Hotel> GetHotels();
        List<Hotel> GetHotels(string city);

        void InsertHotel(Hotel hotel);

       void deleteHotel(Hotel hotel);
        bool updateHotelDescription(Hotel hotel);

    }
}
