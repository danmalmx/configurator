using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConfigThis.Models
{
    public class Product
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
    }
}
