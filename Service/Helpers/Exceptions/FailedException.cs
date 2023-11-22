using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Service.Helpers.Exceptions
{
    public class FailedException:Exception
    {
        public FailedException() : this("Password and Confirm Password must match,Please add again:")
        {
            
        }
        public FailedException(string msj):base(msj)
        {

        }

    }
}
