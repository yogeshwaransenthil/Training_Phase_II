using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JWTAuth.Models;

public partial class Emp
{
    public int Empno { get; set; }

    public string? Ename { get; set; }

    public string? Address { get; set; }

    public int? Deptno { get; set; }

    [JsonIgnore]
    public virtual Dept? DeptnoNavigation { get; set; }
}
