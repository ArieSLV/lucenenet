﻿using System;
using System.Reflection;

using NUnitLite;

namespace Lucene.Net.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
#if !DNXCORE50
            new AutoRun().Execute(args);
#else
            new AutoRun(typeof(Program).GetTypeInfo().Assembly).Execute(args, null, null);
#endif
        }
    }
}