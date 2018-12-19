namespace ExtensionLibrary.ConditionExtensions
{
    public static class StringChecks
    {
        public static bool IsEqual(this string actualValue, string targetValue)
        {
            return actualValue == targetValue;
        }

        public static bool IsNotEqual(this string actualValue, string targetValue)
        {
            return actualValue != targetValue;
        }

        public static bool IsNull(this string actualValue)
        {
            return actualValue == null;
        }

        public static bool IsNotNull(this string actualValue)
        {
            return actualValue != null;
        }

        public static bool IsNullOrEmpty(this string actualValue)
        {
            return string.IsNullOrEmpty(actualValue);
        }

        public static bool IsNotNullOrEmpty(this string actualValue)
        {
            return !string.IsNullOrEmpty(actualValue);
        }

        public static bool ContainsWithoutCase(this string actualValue, string targetValue)
        {
            return actualValue.ToLower().Contains(targetValue.ToLower());
        }

        public static bool IsEqualWithoutCase(this string actualValue, string targetValue)
        {
            return actualValue.ToLower().IsEqual(targetValue.ToLower());
        }
    }
}