using System;
using System.Collections.Generic;

namespace avtosalonApp;

public partial class Car
{
    public int CarId { get; set; }

    public string CarBrand { get; set; } = null!;

    public string CarModel { get; set; } = null!;

    public int ProductionyYear { get; set; }

    public int Price { get; set; }

    public string Color { get; set; } = null!;

    public string VinNumber { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();
}
