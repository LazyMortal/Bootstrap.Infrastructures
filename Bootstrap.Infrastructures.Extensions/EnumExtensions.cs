﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Bootstrap.Infrastructures.Extensions
{
    public static class EnumExtensions
    {
        public static bool IsDefined<T>(this T e) where T : struct
        {
            var type = typeof(T);
            if (type.IsEnum)
                return Enum.GetValues(type).Cast<T>().Contains(e);
            return true;
        }
    }
}