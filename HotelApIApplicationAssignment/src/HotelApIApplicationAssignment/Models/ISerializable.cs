using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApIApplicationAssignment.Models
{
    public interface ISerializable
    {
       byte[] serialization(List<Hotel> hotels);
       List<Hotel> Deserialization(byte[] data);

    }
}
