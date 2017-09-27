using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11Cameron.Controllers
{
    public class StudentsController : Controller
    {
        public string Form()
        {
            return "Enter your Name and Major to enroll";
        }

        public string NewEntry(string name, string major, int year)
        {
            return $"Name: {name} \nMajor: {major}\nYear: {year} ";

        }

        public string ViewStudents(string names)
        {

                return $"Students: {names}" +
                    $"\n\n\nTo return Home, remove all characters following /Students in your URL.";
        }
    }
}
