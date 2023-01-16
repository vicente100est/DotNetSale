using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class SaleDetail
{
    public long IdSd { get; set; }

    public decimal UnitCostSd { get; set; }

    public decimal UnitePriceSd { get; set; }

    public int QuantitySd { get; set; }

    public long? IdProduct { get; set; }

    public long? IdSale { get; set; }

    public virtual Product? IdProductNavigation { get; set; }

    public virtual Sale? IdSaleNavigation { get; set; }
}
