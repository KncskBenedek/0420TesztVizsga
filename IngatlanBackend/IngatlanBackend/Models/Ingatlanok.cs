﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IngatlanBackend.Models;

public partial class Ingatlanok
{
    public int? Id { get; set; }
    public int Kategoria { get; set; }

    public string? Leiras { get; set; }

    public DateTime? HirdetesDatuma { get; set; }

    public bool Tehermentes { get; set; }

    public int Ar { get; set; }

    public string? KepUrl { get; set; }

    public virtual Kategorium? KategoriaNavigation { get; set; } = null!;
}
