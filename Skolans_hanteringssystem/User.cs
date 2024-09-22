using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolans_hanteringssystem
{
    public abstract class User
    {
        //allmän användar information
        public string name;
        public string password;
        //lista med kurser som användaren har tillgång till
        List<Course> roles;
    }

    public class Teacher : User
    {
        //metod som skapar ett nytt assignment objekt, som kopplas till en course där eleverna... 
        //sedan får tillgång till den
        public void createAssignment()
        {

        }

        //metod som skapar ett betyg objekt och sättter värderna på dess attribut och sedan sätter...
        //betyget i grades listan hos eleven
        public void giveGrade() 
        { 

        }
    }

    public class Student : User
    {
        List<Grade> grades;

        //lämna in uppgift
        public void turnInAssignment() 
        {

        }
        //se satta betyg på prov, läxor och kurser
        public void seeGrades() 
        {

        }

    }
}
