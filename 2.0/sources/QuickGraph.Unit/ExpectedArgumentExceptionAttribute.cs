﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickGraph.Unit
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =false, Inherited =true)]
    public sealed class ExpectedArgumentExceptionAttribute : ExpectedExceptionAttribute
    {
        public ExpectedArgumentExceptionAttribute()
            :base(typeof(ArgumentException))
        {}
    }
}
