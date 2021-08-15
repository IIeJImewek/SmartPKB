using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPKBHub.Models
{
    public partial class Heating
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Temp { get; set; }
        public int? CurOutput { get; set; }
        public int? NormOutput { get; set; }
        public int? MaxOutput { get; set; }
        public int? Nroom { get; set; }
        public bool? Turned { get; set; }
    }
}
