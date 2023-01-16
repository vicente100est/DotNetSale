using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class LossDetail
{
    public long IdLd { get; set; }

    public long? IdLoss { get; set; }

    public decimal UnitCostLd { get; set; }

    public long? IdProduct { get; set; }

    public int QuantityLd { get; set; }

    public virtual Loss? IdLossNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
