using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConfigThis.Models
{
    public class ParameterValue
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public int ParameterId { get; set; }
    }
}