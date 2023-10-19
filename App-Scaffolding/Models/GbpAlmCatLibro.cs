using System;
using System.Collections.Generic;

namespace App_Scaffolding.Models;

public partial class GbpAlmCatLibro
{
    public long IdLibros { get; set; }

    public string? Titulo { get; set; }

    public string? Autor { get; set; }

    public string? Isbn { get; set; }

    public long? Edicion { get; set; }
}
