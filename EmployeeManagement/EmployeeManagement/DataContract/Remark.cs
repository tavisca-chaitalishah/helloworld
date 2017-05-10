using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    [DataContract]
    public class Remark
    {
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public DateTime CreateTimeStamp { get; set; }
    }
}