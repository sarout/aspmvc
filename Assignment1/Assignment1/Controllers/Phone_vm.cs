using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Controllers
{
    public class PhoneBase
    {
        public PhoneBase()
        {
            PhoneName = string.Empty;
            Manifacture = string.Empty;
            DateReleased = DateTime.Now;

            // int, doubles does not need to be initialized as they are auto-initialized to 0
        }

        public int id { get; set; }
        public string PhoneName { get; set; }
        public string Manifacture { get; set; }
        public DateTime DateReleased { get; set; }
        public int MSRP { get; set; }
        public double ScreenSize { get; set; }

    }
}