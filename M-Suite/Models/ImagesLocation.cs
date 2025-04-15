using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImagesLocation
{
    public int Id { get; set; }

    public string? Foldername { get; set; }

    public string? Filename { get; set; }

    public string? Parentpath { get; set; }
}
