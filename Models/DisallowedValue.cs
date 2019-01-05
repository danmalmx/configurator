using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConfigThis.Models
{
    public class DisallowedValue
    {
        public int ObjectId { get; set; }
        public DisallowedParameter DisallowedParameter { get; set; }
        public int DisallowedParameterId { get; set; }
        public ParameterValue ParameterValue { get; set; }
        public int ParameterValueId { get; set; }

      
    }
}
