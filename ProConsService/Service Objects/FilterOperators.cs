using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProConsService.Service_Objects
{
    [DataContract(Name = "FilterOperators")]
    public enum FilterOperators
    {
        [EnumMember]
        Equal=1
    }
}