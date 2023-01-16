using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Operation
{
    public int IdOperation { get; set; }

    public string NameOperation { get; set; } = null!;

    public int? IdModule { get; set; }

    public virtual Module? IdModuleNavigation { get; set; }

    public virtual ICollection<RolOperation> RolOperations { get; } = new List<RolOperation>();
}
