using System;
using System.Runtime.CompilerServices;

namespace Extensions
{
    public static class ExtensionMethods
    {
        public static Tuple<bool,string> IsValidIntegerandWithinBounds(this string target, int min, int max)
        {
            if(!int.TryParse(target, out _))
            {
                return new Tuple<bool, string>(false, "Input is not a valid integer, please enter a valid integer");
            }

            var parsedInput = int.Parse(target);

            if(parsedInput <= 1 || parsedInput >= 10)
            {
                return new Tuple<bool, string>(false, "Input is not within the desired range, please enter a number between 1 and 10");
            }

            return new Tuple<bool, string>(true, $"You entered: {parsedInput}");
        }

        public static bool IsNullWhitespaceOrEmpty(this string target)
        {
            return string.IsNullOrEmpty(target) || string.IsNullOrWhiteSpace(target);
        }

        public static bool IsEqual(this string target, string comparison)
        {
            return target == comparison;
        }

        public static Tuple<bool, double> TryMultiply(this string target, string value)
        {
            if(!double.TryParse(target, out var targetDouble) || !double.TryParse(value, out var valueDouble))
            {
                return new Tuple<bool, double>(false, 0);
            }
            else
            {
                return new Tuple<bool, double>(true, targetDouble * valueDouble);
            }
        }

        public static Tuple<bool, double> TryAdd(this string target, string value)
        {
            if (!double.TryParse(target, out var targetDouble) || !double.TryParse(value, out var valueDouble))
            {
                return new Tuple<bool, double>(false, 0);
            }
            else
            {
                return new Tuple<bool, double>(true, targetDouble + valueDouble);
            }
        }

        public static Tuple<bool, double> TrySubtract(this string target, string value)
        {
            if (!double.TryParse(target, out var targetDouble) || !double.TryParse(value, out var valueDouble))
            {
                return new Tuple<bool, double>(false, 0);
            }
            else
            {
                return new Tuple<bool, double>(true, targetDouble - valueDouble);
            }
        }

        public static Tuple<bool, double> TryDivide(this string target, string value)
        {

            if (!double.TryParse(target, out var targetDouble) || !double.TryParse(value, out var valueDouble))
            {
                return new Tuple<bool, double>(false, 0);
            }
            else
            {
                if(valueDouble == 0)
                {
                    return new Tuple<bool, double>(false, 0);
                }

                return new Tuple<bool, double>(true, targetDouble / valueDouble);
            }
        }
    }
}
