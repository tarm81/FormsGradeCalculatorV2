using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeCalculatorGUI
{
    public class HonorsStudent : Student
    {
        public HonorsStudent(string name, double grade1, double grade2, double grade3)
            : base(name, grade1, grade2, grade3)
        {
        }

        public override char DetermineLetterGrade()
        {
            double average = CalculateAverage();

            if (average >= 85)
                return 'A';
            else if (average >= 75)
                return 'B';
            else if (average >= 65)
                return 'C';
            else if (average >= 55)
                return 'D';
            else
                return 'F';
        }
    }
}
