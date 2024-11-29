using System;
using System.Collections.Generic;

namespace avtosalonApp;

public partial class Client
{
    public string LoginClient { get; set; } = null!;

    public string PasswordClient { get; set; } = null!;

    public string ClientsFullName { get; set; } = null!;

    public string ClientCity { get; set; } = null!;

    public string ClientResidentialAddress { get; set; } = null!;

    public string ClientPhoneNumber { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();
}
