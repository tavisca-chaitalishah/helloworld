using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApIApplicationAssignment.Models
{
    public class JsonSerialization : ISerializable
    {
        public List<Hotel> Deserialization(byte[] data)
        {
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(Encoding.UTF8.GetString(data));
            return hotels;
        }

        public byte[] serialization(List<Hotel> hotels)
        {
            var ser = new Newtonsoft.Json.JsonSerializer();

            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    ser.Serialize(streamWriter, hotels);

                    streamWriter.Flush();
                }
                return memoryStream.ToArray();

            }
        }
    }
}
