using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPKBLuxmeter.Models
{
    public partial class Lightning
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public int? MaxOutput { get; set; }
        public int? Nroom { get; set; }
        public bool? Turned { get; set; }
    }
}
