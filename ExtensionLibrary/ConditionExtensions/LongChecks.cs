namespace ExtensionLibrary.ConditionExtensions
{
    public static class LongChecks
    {
        public static bool IsEqualTo(this long actualValue, long targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqualTo(this long actualValue, long targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsGreaterThan(this long actualValue, long targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this long actualValue, long targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsGreaterOrEqualTo(this long actualValue, long targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this long actualValue, long targetValue)
        {
            return (actualValue <= targetValue);
        }

        public static bool IsEqualToZero(this long actualValue)
        {
            return (actualValue == 0);
        }

        public static bool IsNotEqualToZero(this long actualValue)
        {
            return actualValue != 0;
        }

        public static bool IsGreaterOrEqualToZero(this long actualValue)
        {
            return (actualValue >= 0);
        }

        public static bool IsGreaterThanZero(this long actualValue)
        {
            return (actualValue > 0);
        }

        public static bool IsLessOrEqualToZero(this long actualValue)
        {
            return (actualValue <= 0);
        }

        public static bool IsLessThanZero(this long actualValue)
        {
            return (actualValue < 0);
        }

        #region Nullable

        public static bool IsEqualTo(this long? actualValue, long targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqualTo(this long actualValue, long? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqualTo(this long? actualValue, long? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqualTo(this long? actualValue, long targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqualTo(this long actualValue, long? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqualTo(this long? actualValue, long? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsEqualToZero(this long? actualValue)
        {
            return actualValue == 0;
        }

        public static bool IsNotEqualToZero(this long? actualValue)
        {
            return actualValue != 0;
        }

        public static bool IsGreaterOrEqualTo(this long? actualValue, long targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterOrEqualTo(this long actualValue, long? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterOrEqualTo(this long? actualValue, long? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this long? actualValue, long targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this long actualValue, long? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this long? actualValue, long? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterThanZero(this long? actualValue)
        {
            return (actualValue > 0);
        }

        public static bool IsLessThanZero(this long? actualValue)
        {
            return (actualValue < 0);
        }

        public static bool IsGreaterOrEqualToZero(this long? actualValue)
        {
            return (actualValue >= 0);
        }

        public static bool IsLessOrEqualToZero(this long? actualValue)
        {
            return (actualValue <= 0);
        }

        public static bool IsGreaterThan(this long? actualValue, long targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsGreaterThan(this long actualValue, long? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsGreaterThan(this long? actualValue, long? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this long? actualValue, long targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsLessThan(this long actualValue, long? targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsLessThan(this long? actualValue, long? targetValue)
        {
            return (actualValue < targetValue);
        }

        #endregion
    }
}