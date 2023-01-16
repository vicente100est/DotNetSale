using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Rol
{
    public int IdRol { get; set; }

    public string NameRol { get; set; } = null!;

    public virtual ICollection<EksUser> EksUsers { get; } = new List<EksUser>();

    public virtual ICollection<RolOperation> RolOperations { get; } = new List<RolOperation>();
}
