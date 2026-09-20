using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeCalculatorGUI
{
    public class Student
    {
        private string name;
        private double grade1;
        private double grade2;
        private double grade3;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Grade1
        {
            get { return grade1; }
            set { grade1 = value; }
        }

        public double Grade2
        {
            get { return grade2; }
            set { grade2 = value; }
        }

        public double Grade3
        {
            get { return grade3; }
            set { grade3 = value; }
        }

        public Student(string name, double grade1, double grade2, double grade3)
        {
            Name = name;
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }

        public double CalculateAverage()
        {
            return (Grade1 + Grade2 + Grade3) / 3;
        }

        public virtual char DetermineLetterGrade()
        {
            double average = CalculateAverage();

            if (average >= 90)
                return 'A';
            else if (average >= 80)
                return 'B';
            else if (average >= 70)
                return 'C';
            else if (average >= 60)
                return 'D';
            else
                return 'F';
        }
    }
}
