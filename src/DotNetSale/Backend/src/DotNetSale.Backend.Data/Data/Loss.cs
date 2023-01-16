using System;
using System.Collections.Generic;

namespace DotNetSale.Backend.Data.Data;

public partial class Loss
{
    public long IdLoss { get; set; }

    public DateTime DateLoss { get; set; }

    public int IdStatus { get; set; }

    public decimal? TotalLoss { get; set; }

    public virtual StatusProduct IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<LossDetail> LossDetails { get; } = new List<LossDetail>();
}
