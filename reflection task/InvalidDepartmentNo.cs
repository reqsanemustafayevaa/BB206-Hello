using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflection_task
{
    public class InvalidDepartmentNo:Exception
    {
        public InvalidDepartmentNo()
        {

        }
        public InvalidDepartmentNo(string message) : base(message)
        {

        }
    }
}
