using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20aprilTasks.utilities.Exceptions
{
    public class AgeException : Exception
    {
        public AgeException(string message) :base(message)
        {
          
        }
    }
}
