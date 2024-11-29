using System;
using System.Collections.Generic;

namespace avtosalonApp;

public partial class Deal
{
    public int DealId { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public int? DealidCar { get; set; }

    public string? LoginEmpl { get; set; }

    public string? LoginClient { get; set; }

    public virtual Car? DealidCarNavigation { get; set; }

    public virtual Client? LoginClientNavigation { get; set; }

    public virtual Employee? LoginEmplNavigation { get; set; }
}
