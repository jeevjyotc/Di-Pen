﻿using Pen.Declare;
using System;
using System.Collections.Generic;

namespace Pen
{
    public class DependencyDefinition
    {
        public DependencyAttribute Declaration { get; set; }

        public Type Type { get; set; }

        public ProviderDefinition Provider { get; set; }

        public Lifestyles Lifestyle { get; set; }

        public Type Initializer { get; set; }

        public List<Decorator> Decorators { get; set; }

        public bool IsTarget
        {
            get
            {
                return this == TargetDependency.Instance;
            }
        }
    }
}
