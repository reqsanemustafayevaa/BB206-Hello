using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflection_task
{
    public class InvalidNameException:Exception
    {
        public InvalidNameException()
        {

        }
        public InvalidNameException(string message) : base(message)
        {

        }

    }
}
