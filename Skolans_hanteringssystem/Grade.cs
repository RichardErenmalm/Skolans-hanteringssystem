using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolans_hanteringssystem
{
    public class Grade
    {
        //typ av betyg, alltså läxa, prov eller kurs
        public string gradeType;

        //kursen, läxan eller betygets namn
        public string gradeItem;

        //vilket betyg eleven har fått
        public string gradeValue;

        //kommentar från läraren
        public string teacherComment;

        //vilken elev som betygsätts
        public string student;
    }
}
