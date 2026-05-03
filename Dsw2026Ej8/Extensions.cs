using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal static class Extensions
    {
        
            public static string ToProductCode(this string code)
            {
                if (string.IsNullOrWhiteSpace(code))
                {
                    return "sin codigo";
                }
                return code.Trim().ToUpper().Replace(" ", "-");
            }
        }
    }


