using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentDetails:College
    {
        private int rno;
        private string? name, address;
        public StudentDetails(string? collegeName, string? collegeAddress,int rno = 0, string? name = null, string? address = null): base(collegeName, collegeAddress)
        {
            this.rno = rno;
            this.name = name;
            this.address = address;
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
    }

}
