using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Solak_Simulator.Models
{
    public class Drops
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public string Rarity { get; set; }

        public string Range { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Drops>(this);

    }
}
