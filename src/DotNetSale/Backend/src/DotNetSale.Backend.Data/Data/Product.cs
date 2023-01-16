using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Product
{
    public long IdProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public string CodeProduct { get; set; } = null!;

    public DateTime DateProduct { get; set; }

    public decimal PriceProduct { get; set; }

    public decimal CostProduct { get; set; }

    public long ExistenceProduct { get; set; }

    public virtual ICollection<EntryDetail> EntryDetails { get; } = new List<EntryDetail>();

    public virtual ICollection<LossDetail> LossDetails { get; } = new List<LossDetail>();

    public virtual ICollection<SaleDetail> SaleDetails { get; } = new List<SaleDetail>();
}
