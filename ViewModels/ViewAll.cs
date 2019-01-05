using System;
using System.Collections.Generic;
using ConfigThis.Models;

namespace ConfigThis.NewFolder
{
    public class ViewAll
    {
        public IEnumerable<DisallowedParameter>DisallowedParameters { get; set; }
        public IEnumerable<DisallowedRule>DisallowedRules { get; set; }
        public IEnumerable<DisallowedValue>DisallowedValues { get; set; }
        public IEnumerable<Parameter>Parameters { get; set; }
        public IEnumerable<ParameterValue>ParameterValues { get; set; }
        public IEnumerable<Product>Products { get; set; }

        public ViewAll()
        {
        }

    }
}
