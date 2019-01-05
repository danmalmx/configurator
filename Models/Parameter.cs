using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConfigThis.Models
{
    public class Parameter
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
