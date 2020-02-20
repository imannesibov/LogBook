using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook.Model
{
    class Auditory
    {

        public string auditoryName = "3E";
        public Teacher teacher = new Teacher();
        public List<Student> students = new List<Student>();

        public Auditory()
        {
            teacher.Crystal = 5;
            teacher.Fullname = "Ismayil Huseyinli";


            Grade _grade = new Grade();


            _grade = new Grade();
            _grade.Crystal = "0";
            _grade.Point = "";

            students.Add(new Student { Fullname = "Mahammad Memmedov", imageURL = Properties.Resources.mahammad, RowNumber = "1",grade  = _grade});

            _grade = new Grade();
            _grade.Crystal = "0";
            _grade.Point = "0";

            students.Add(new Student { Fullname = "Alasgar Alizade", imageURL = Properties.Resources.alasgar, RowNumber = "2", grade = _grade,});;
            _grade = new Grade();
            _grade.Crystal = "0";
            _grade.Point = "0";

            students.Add(new Student { Fullname = "Zabil Haciyev", imageURL = Properties.Resources.zabil, RowNumber = "3", grade = _grade,});;
            _grade = new Grade();
            _grade.Crystal = "0";
            _grade.Point = "0";

            students.Add(new Student { Fullname = "Arif Hesenov", imageURL = Properties.Resources.arif, RowNumber = "4", grade = _grade,});;

        }
    }
}
