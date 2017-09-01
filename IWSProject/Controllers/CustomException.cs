using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IWSProject.Controllers
{
    class CustomException : Exception
    {
        public CustomException(string message)
        {

        }

    }
}