using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ProConsService.Service_Objects
{
    [DataContract]
    public class RetrieveMultipleRequest
    {
        [DataMember]
        public List<FilterCondition> Criteria { get; set; }
    }
}