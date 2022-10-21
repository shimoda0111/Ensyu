using System;
using System.Collections.Generic;

namespace Ensyu.Models
{
    public partial class Unext
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public int Length { get; set; }
    }
}
