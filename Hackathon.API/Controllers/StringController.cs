using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.API.Controllers
{
    public class StringController : Controller
    {
        public string ReverseString(string inputString)
        {
            string reversed = new(inputString.Reverse().ToArray());
            return reversed;
        }
    }
}
