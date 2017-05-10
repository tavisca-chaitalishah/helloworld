using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelApIApplicationAssignment.Models;

namespace HotelApIApplicationAssignment.Models
{
    public class HotelDataOperation : IManagable
    {
        private static List<Hotel> _hotels = new List<Hotel>();
        List<Hotel> IManagable.GetHotels()
        {
            System.Threading.Thread.Sleep(5000);
            return _hotels;
        }

        public List<Hotel> GetHotels(string city)
        {
            System.Threading.Thread.Sleep(5000);
            var hotels = _hotels.FindAll(cityToSearch => cityToSearch.City_Name == city);
            return hotels;
        }

        public void InsertHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }

        public void deleteHotel(Hotel hotel)
        {
            Hotel hotelToDelete = _hotels.FirstOrDefault(d => (d.Id == hotel.Id));
            _hotels.Remove(hotelToDelete);
        }

        public bool updateHotelDescription(Hotel hotel)
        {
            var hotelToChange = _hotels.FirstOrDefault(x => x.Id == hotel.Id);

            if (hotelToChange == null)
                return false;
            hotelToChange.Description = hotel.Description;
            return true;
        }
    }
}

