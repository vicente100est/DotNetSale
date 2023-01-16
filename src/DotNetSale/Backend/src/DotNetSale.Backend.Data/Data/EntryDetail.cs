using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class EntryDetail
{
    public long IdEd { get; set; }

    public decimal UnitCostEd { get; set; }

    public int QuantityEd { get; set; }

    public long? IdIn { get; set; }

    public long? IdProduct { get; set; }

    public virtual Entry? IdInNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
