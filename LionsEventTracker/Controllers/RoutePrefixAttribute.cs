﻿using System;

namespace LionsEventTracker.Controllers
{
    internal class RoutePrefixAttribute : Attribute
    {
        private string v;

        public RoutePrefixAttribute(string v)
        {
            this.v = v;
        }
    }
}