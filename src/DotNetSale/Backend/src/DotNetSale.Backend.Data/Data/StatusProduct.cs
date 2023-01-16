using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class StatusProduct
{
    public int IdStatus { get; set; }

    public string NameStatus { get; set; } = null!;

    public virtual ICollection<Entry> Entries { get; } = new List<Entry>();

    public virtual ICollection<Loss> Losses { get; } = new List<Loss>();

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();
}
