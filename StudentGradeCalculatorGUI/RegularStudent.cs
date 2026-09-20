using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeCalculatorGUI
{
    public class RegularStudent : Student
    {
        public RegularStudent(string name, double grade1, double grade2, double grade3)
            : base(name, grade1, grade2, grade3)
        {
        }

        public override char DetermineLetterGrade()
        {
            return base.DetermineLetterGrade();
        }
    }
}
