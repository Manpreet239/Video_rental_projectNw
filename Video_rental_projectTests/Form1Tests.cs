using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            BookingVideo booking = new BookingVideo(1, 1, 1, "02/01/2021", "02/02/2021");
            booking.ReturnVideo();
        }
    }
}