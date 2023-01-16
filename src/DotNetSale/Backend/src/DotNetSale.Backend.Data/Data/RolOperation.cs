using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class RolOperation
{
    public int IdRo { get; set; }

    public int? IdRol { get; set; }

    public int? IdOperation { get; set; }

    public virtual Operation? IdOperationNavigation { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
