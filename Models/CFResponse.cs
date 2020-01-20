using System.Runtime.Serialization;
using System.Collections.Generic;

namespace contests_finder.Models
{
    [DataContract]
    public class CFResponse<T>
    {
        [DataMember(Name="status")]
        public string Status { get; set; }

        [DataMember(Name="result")]
        public T Result { get; set; }
    }
}