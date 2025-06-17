using System;
using System.Collections.Generic;

namespace ThirdProject.Models;

public partial class vProductAndDescription
{
    public int ProductID { get; set; }

    public string Culture { get; set; } = null!;

    public string Description { get; set; } = null!;
}
