using System;

namespace ExtensionLibrary.ConditionExtensions
{
    public static class ObjectChecks
    {
        public static bool IsBoolean(this object actualValue)
        {
            return (actualValue is bool);
        }

        public static bool IsNotBoolean(this object actualValue)
        {
            return !(actualValue is bool);
        }

        public static bool IsInteger(this object actualValue)
        {
            return (actualValue is int);
        }

        public static bool IsNotInteger(this object actualValue)
        {
            return !(actualValue is int);
        }

        public static bool IsLong(this object actualValue)
        {
            return (actualValue is long);
        }

        public static bool IsNotLong(this object actualValue)
        {
            return !(actualValue is long);
        }

        public static bool IsShort(this object actualValue)
        {
            return (actualValue is short);
        }

        public static bool IsNotShort(this object actualValue)
        {
            return !(actualValue is short);
        }

        public static bool IsDouble(this object actualValue)
        {
            return (actualValue is double);
        }

        public static bool IsNotDouble(this object actualValue)
        {
            return !(actualValue is double);
        }

        public static bool IsDatetime(this object actualValue)
        {
            return (actualValue is DateTime);
        }

        public static bool IsNotDatetime(this object actualValue)
        {
            return !(actualValue is DateTime);
        }

        public static bool IsNull(this object actualValue)
        {
            return (actualValue == null);
        }

        public static bool IsNotNull(this object actualValue)
        {
            return actualValue != null;
        }

        public static bool IsEqual(this object actualValue, object targetValue)
        {
            return actualValue == targetValue;
        }

        public static bool IsNotEqual(this object actualValue, object targetValue)
        {
            return actualValue != targetValue;
        }
    }
}