using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IngatlanBackend.Models;

public partial class Kategorium
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Ingatlanok> Ingatlanoks { get; set; } = new List<Ingatlanok>();
}
