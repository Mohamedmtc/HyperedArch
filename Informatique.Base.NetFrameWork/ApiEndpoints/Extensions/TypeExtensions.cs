using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ardalis.ApiEndpoints
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> GetBaseTypesAndThis(this Type type)
        {
            Type current = type;
            while (current != null)
            {
                yield return current;
                current = current.BaseType;
            }
        }
    }
}
