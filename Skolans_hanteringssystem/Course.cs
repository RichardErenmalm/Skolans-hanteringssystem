using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolans_hanteringssystem
{
    public class Course
    {
        //elever som är inskrivna till kursen
        List <Student> students;

        //kursens lärare
        public string courseTeacher;

        //kursens uppgifter
        List <Assignment> assignments;
    }
}
