using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDucVu_5951071123.Controllers
{
    public class StudentController : ApiController
    {
        public IEnumerable<StudentInfo> Get()
        {
            yield return new StudentInfo
            {
                Name = "Trần Đức Vũ";
                Age = 21;
            };
            ;
        }
    }
}
