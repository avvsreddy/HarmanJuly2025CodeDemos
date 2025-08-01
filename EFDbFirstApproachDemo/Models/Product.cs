﻿using System;
using System.Collections.Generic;

namespace EFDbFirstApproachDemo.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Price { get; set; }

    public string? Brand { get; set; }

    public string? Category { get; set; }

    public bool? InStock { get; set; }
}
