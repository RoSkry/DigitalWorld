using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.Common
{
    public static class ArgumentsExtensions
    {
        public static void ThrowIf(this int arg, Func<int, bool> condition, string errorMessage)
        {
            if (condition(arg))
            {
                throw new ArgumentException(errorMessage);
            }
        }

        public static void ThrowIf(this long arg, Func<long, bool> condition, string errorMessage)
        {
            if (condition(arg))
            {
                throw new ArgumentException(errorMessage);
            }
        }

        public static void ThrowIfNull(this object arg, string errorMessage = "Argument cannot be null.")
        {
            if (arg == null)
            {
                throw new ArgumentNullException(nameof(arg), errorMessage);
            }
        }

        public static void ThrowIfNullOrWhitespace(this string arg, string errorMessage = "String argument cannot be null or whitespace.")
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                throw new ArgumentException(errorMessage);
            }
        }
    }
}
