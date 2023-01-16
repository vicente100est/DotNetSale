using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Entry
{
    public long IdIn { get; set; }

    public DateTime DateIn { get; set; }

    public decimal TotalIn { get; set; }

    public int? IdStatus { get; set; }

    public virtual ICollection<EntryDetail> EntryDetails { get; } = new List<EntryDetail>();

    public virtual StatusProduct? IdStatusNavigation { get; set; }
}
