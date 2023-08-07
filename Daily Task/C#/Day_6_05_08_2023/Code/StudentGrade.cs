using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic_Programs
{
    internal class StudentGrade : StudentMarks
    {
        public StudentGrade(string? collegeName, string? collegeAddress,int rno, string name, string address, int m1, int m2, int m3) : base( collegeName, collegeAddress,rno, name, address, m1, m2, m3)
        {

        }
        public char CalcualteGrade()
        {
            double average = CalculateAverage();
            if (average >= 90)
                return 'A';
            else if (average >= 80 && average < 90)
                return 'B';
            else
                return 'C';
        }
    }

}
