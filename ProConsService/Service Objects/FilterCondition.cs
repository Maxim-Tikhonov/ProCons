using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProConsService.Service_Objects
{
    [DataContract]
    public class FilterCondition
    {
        [DataMember]
        public string FieldName { get; set; }
        [DataMember]
        public FilterOperators FilterOperator { get; set; }
        [DataMember]
        public object Value { get; set; }
    }
}