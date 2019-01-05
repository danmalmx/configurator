using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConfigThis.Models
{
    public class DisallowedRule
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
    }
}
