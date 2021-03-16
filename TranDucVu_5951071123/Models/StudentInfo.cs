using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranDucVu_5951071123.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
    }
}