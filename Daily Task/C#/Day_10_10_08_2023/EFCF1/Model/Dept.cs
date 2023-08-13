﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1.Model
{
    internal class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Depno { get; set; }
        public string? Dname { get; set; }


        public ICollection<Emp>? Emps { get; set; }

    }
}
