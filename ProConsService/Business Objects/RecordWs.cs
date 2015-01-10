using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProConsService.Business_Objects
{
    [DataContract]
    public class RecordWs
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public decimal Total { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public Guid AccountId { get; set; }
        [DataMember]
        public virtual AccountWS Account { get; set; }
        [DataMember]
        public Guid CategoryId { get; set; }
        [DataMember]
        public virtual CategoryWS Category { get; set; }
    }
}