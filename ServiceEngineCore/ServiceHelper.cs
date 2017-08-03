using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace ServiceEngineCore
{
    static class LocalServiceHelper
    {
        public static bool IsSameGenericType(this Type source, Type compare)
        {
            return
                compare.GetTypeInfo().IsGenericType &&
                source.GetTypeInfo().IsGenericType &&
                compare.GetGenericTypeDefinition()
        }
    }
}
