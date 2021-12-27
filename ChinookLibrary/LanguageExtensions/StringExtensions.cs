using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookLibrary.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="sender">String to test if null or whitespace</param>
        /// <returns>true if empty or false if not empty</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace(this string sender) => string.IsNullOrWhiteSpace(sender);
        /// <summary>
        /// Determine if a string can be represented as a numeric.
        /// </summary>
        /// <param name="text">value to determine if can be converted to a string</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static bool IsNumeric(this string text) => double.TryParse(text, out _);

        [DebuggerStepThrough]
        public static string Time(this int milliseconds)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(milliseconds);
            return $"{t.Hours:D2}h:{t.Minutes:D2}m:{t.Seconds:D2}s:{t.Milliseconds:D3}ms";
        }
        [DebuggerStepThrough]
        public static string TimeWithoutHoursOrMilliseconds(this int milliseconds)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(milliseconds);

            return t.Minutes < 10 ? 
                $"{t.Minutes}m:{t.Seconds:D2}s" : 
                $"{t.Minutes:D2}m:{t.Seconds:D2}s";
        }
    }
}
