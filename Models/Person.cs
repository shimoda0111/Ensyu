﻿using System;
using System.Collections.Generic;

namespace Ensyu.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
    }
}
