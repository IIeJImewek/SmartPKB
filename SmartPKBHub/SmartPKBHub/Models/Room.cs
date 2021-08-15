using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPKBHub.Models
{
    public partial class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Area { get; set; }
        public int? Nlux { get; set; }
        public double? CurTemp { get; set; }
    }
}
