﻿using System;

namespace Sample
{
    public class Tenant
    {
        public Tenant()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
