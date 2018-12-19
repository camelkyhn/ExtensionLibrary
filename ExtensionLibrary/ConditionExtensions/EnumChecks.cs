using System;

namespace ExtensionLibrary.ConditionExtensions
{
    public static class EnumChecks
    {
        public static bool IsEqual(this Enum actualValue, Enum targetValue)
        {
            return Equals(actualValue, targetValue);
        }

        public static bool IsNotEqual(this Enum actualValue, Enum targetValue)
        {
            return !Equals(actualValue, targetValue);
        }

        public static bool IsNull(this Enum actualValue)
        {
            return Equals(actualValue, null);
        }

        public static bool IsNotNull(this Enum actualValue)
        {
            return !Equals(actualValue, null);
        }
    }
}