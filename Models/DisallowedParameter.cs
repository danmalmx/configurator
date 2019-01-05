using System;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

namespace ConfigThis.Models
{
    public class DisallowedParameter
    {
        public int ObjectId { get; set; }
        public Parameter Parameter { get; set; }
        public int ParameterId { get; set; }
        public DisallowedRule DisallowedRule { get; set; }
        public int DisallowedRuleId { get; set; }
    }
}
