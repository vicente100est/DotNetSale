using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Module
{
    public int IdModule { get; set; }

    public string? NameModule { get; set; }

    public virtual ICollection<Operation> Operations { get; } = new List<Operation>();
}
