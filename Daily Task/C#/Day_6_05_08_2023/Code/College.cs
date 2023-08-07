using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {
        private string? collegeName, collegeAddress;

        public College(string? collegeName, string? collegeAddress)
        {
            this.collegeName = collegeName;
            this.collegeAddress = collegeAddress;
        }

        public string? CollegeName { get => collegeName; set => collegeName = value; }
        public string? CollegeAddress { get => collegeAddress; set => collegeAddress = value; }

        public void CollegeDisplay()
        {
            Console.WriteLine(CollegeName+collegeAddress);
        }
    }

}
