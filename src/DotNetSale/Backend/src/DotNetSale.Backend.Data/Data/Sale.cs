using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Sale
{
    public long IdSale { get; set; }

    public decimal TotalSale { get; set; }

    public DateTime DateSale { get; set; }

    public int? IdStatus { get; set; }

    public virtual StatusProduct? IdStatusNavigation { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; } = new List<SaleDetail>();
}
