﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook.Model
{
    public class Grade
    {
        public string Point { get; set; }
        public string Crystal { get; set; }
    }
    public class Student
    {
        public string Fullname { get; set; }
        public Bitmap imageURL { get; set; }
        public Grade grade { get; set; }
        public string RowNumber { get; set; }

    }
}
