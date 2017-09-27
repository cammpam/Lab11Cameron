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
        RegisterStudent register = new RegisterStudent();
        
        public string Form()
        {
            return "Enter your Name and Major to enroll";
        }

        public string NewEntry(string name, string major, int year)
        {
            return register.RegisterInfo(name, major, year) +
                "\n\n\n\nTo REGISTER as a new student, replace values for Name, Major and Year in the URL" +
                "\n\nTo VIEW all students, replace text after localhost:XXXXX with:\n\n  /Students/ViewStudents?" +
                "\n\nTo RETURN HOME delete all text after localhost:XXXXX";
            
            

        }

        public string ViewStudents(string names)
        {

            return register.ViewList() +
                "\n\nTo REGISTER as a new student:" +
                "\n\n1. Replace text after localhost:XXXXX with:" +
                "\n    /Students/NewEntry?Name= &Major= &Year= " +
                "\n\n2. Add values for 'Name', 'Major', and 'Year' then press 'Enter'" +
                "\n\nTo RETURN HOME delete all text after localhost:XXXXX";


        }

        public string Error()
        {
            return "Something went wrong";
        }
    }
}
