using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class EksUser
{
    public int IdEksUser { get; set; }

    public string NameEksUser { get; set; } = null!;

    public string EmailEksUser { get; set; } = null!;

    public string PasswordEksUser { get; set; } = null!;

    public DateTime DateEksUser { get; set; }

    public int? IdRol { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
