﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff:StaffDetails
    {
        private string? dept;
        private double basic_salary;
        private readonly int _da, _hra, _cca, _pf;

        public TeachingStaff(string? collegeName, string? collegeAddress,int eno, string? name, string? address, string? dept, double basic_salary, int da, int hra, int cca, int pf)
            :base(collegeName, collegeAddress,eno, name,address)
        {
            this.dept = dept;
            this.basic_salary = basic_salary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public string? Dept { get => dept; set => dept = value; }
        public double Basic_salary { get => basic_salary; set => basic_salary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {

            float allowance = (float)
                (Basic_salary * ((float)Da / 100)+
                (Basic_salary * ((float)Hra / 100))
                -  (Basic_salary * ((float)Cca / 100))
                - (Basic_salary*((float)Pf /100)));

            float ded=(float)(Basic_salary * ((float)Pf /100));
            float netsal = (float)(Basic_salary * ((double)Da / 100));
            return netsal;
        }
    }
}
