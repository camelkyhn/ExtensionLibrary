namespace ExtensionLibrary.ConditionExtensions
{
    public static class BooleanChecks
    {
        public static bool IsTrue(this bool actualValue)
        {
            return actualValue;
        }

        public static bool IsFalse(this bool actualValue)
        {
            return actualValue == false;
        }

        #region Nullable

        public static bool IsTrue(this bool? actualValue)
        {
            return actualValue == true;
        }

        public static bool IsFalse(this bool? actualValue)
        {
            return actualValue == false;
        }

        public static bool IsEqual(this bool actualValue, bool? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqual(this bool? actualValue, bool targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqual(this bool? actualValue, bool? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqual(this bool actualValue, bool? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqual(this bool? actualValue, bool targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqual(this bool? actualValue, bool? targetValue)
        {
            return (actualValue != targetValue);
        }

        #endregion
    }
}