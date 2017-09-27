using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11Cameron.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to student enrollent " +
                "\n\nTo REGISTER as a new student:" +
                "\n\n1. Add this text after localhost:XXXXX" +
                "\n    /Students/NewEntry?Name= &Major= &Year= " +
                "\n\n2. Add values for 'Name', 'Major', and 'Year' then press 'Enter'" +
                "\n\nTo VIEW all students, add this text after localhost:XXXXX \n\n  /Students/ViewStudents?";
        }

        public string GradYear(int graduation)
        {
            return $"Graduation Year: {graduation}";
        }
    }
}
