using System;
using System.Collections.Generic;

namespace avtosalonApp;

public partial class Employee
{
    public string LoginEmpl { get; set; } = null!;

    public string PasswordEmpl { get; set; } = null!;

    public string EmplFullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string EmplResidentialAddress { get; set; } = null!;

    public string EmplPhoneNumber { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();
}
