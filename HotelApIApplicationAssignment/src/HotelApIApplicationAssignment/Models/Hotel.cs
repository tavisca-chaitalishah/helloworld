using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApIApplicationAssignment.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Star_Rating { get; set; }

        public string City_Name { get; set; }

        public string Description { get; set; }
    }
}
