using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class ProductType
{
    public short Id { get; set; }

    public string ProductType1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}