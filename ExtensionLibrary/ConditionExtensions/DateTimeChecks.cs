using System;

namespace ExtensionLibrary.ConditionExtensions
{
    public static class DateTimeChecks
    {
        public static bool IsEqual(this DateTime actualValue, DateTime targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqual(this DateTime actualValue, DateTime targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsMinDate(this DateTime actualValue)
        {
            return (actualValue == DateTime.MinValue);
        }

        public static bool IsNotMinDate(this DateTime actualValue)
        {
            return (actualValue != DateTime.MinValue);
        }

        public static bool IsGreaterThan(this DateTime actualValue, DateTime targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this DateTime actualValue, DateTime targetValue)
        {
            return (actualValue < targetValue);
        }

        #region Nullable

        public static bool IsEqual(this DateTime? actualValue, DateTime? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqual(this DateTime? actualValue, DateTime targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqual(this DateTime actualValue, DateTime? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqual(this DateTime actualValue, DateTime? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqual(this DateTime? actualValue, DateTime? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqual(this DateTime? actualValue, DateTime targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsMinDate(this DateTime? actualValue)
        {
            return (actualValue == DateTime.MinValue);
        }

        public static bool IsNotMinDate(this DateTime? actualValue)
        {
            return (actualValue != DateTime.MinValue);
        }

        public static bool IsGreaterThan(this DateTime? actualValue, DateTime targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this DateTime? actualValue, DateTime targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsGreaterThan(this DateTime actualValue, DateTime? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this DateTime actualValue, DateTime? targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsGreaterThan(this DateTime? actualValue, DateTime? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this DateTime? actualValue, DateTime? targetValue)
        {
            return (actualValue < targetValue);
        }

        #endregion
    }
}