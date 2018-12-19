namespace ExtensionLibrary.ConditionExtensions
{
    public static class IntegerChecks
    {
        public static bool IsEqualTo(this int actualValue, int targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqualTo(this int actualValue, int targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsGreaterThan(this int actualValue, int targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this int actualValue, int targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsGreaterOrEqualTo(this int actualValue, int targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this int actualValue, int targetValue)
        {
            return (actualValue <= targetValue);
        }

        public static bool IsEqualToZero(this int actualValue)
        {
            return (actualValue == 0);
        }

        public static bool IsNotEqualToZero(this int actualValue)
        {
            return actualValue != 0;
        }

        public static bool IsGreaterOrEqualToZero(this int actualValue)
        {
            return (actualValue >= 0);
        }

        public static bool IsGreaterThanZero(this int actualValue)
        {
            return (actualValue > 0);
        }

        public static bool IsLessOrEqualToZero(this int actualValue)
        {
            return (actualValue <= 0);
        }

        public static bool IsLessThanZero(this int actualValue)
        {
            return (actualValue < 0);
        }

        #region Nullable

        public static bool IsEqualTo(this int? actualValue, int targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqualTo(this int actualValue, int? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqualTo(this int? actualValue, int? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqualTo(this int? actualValue, int targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqualTo(this int actualValue, int? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqualTo(this int? actualValue, int? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsEqualToZero(this int? actualValue)
        {
            return actualValue == 0;
        }

        public static bool IsNotEqualToZero(this int? actualValue)
        {
            return actualValue != 0;
        }

        public static bool IsGreaterOrEqualTo(this int? actualValue, int targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterOrEqualTo(this int actualValue, int? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterOrEqualTo(this int? actualValue, int? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this int? actualValue, int targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this int actualValue, int? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this int? actualValue, int? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterThanZero(this int? actualValue)
        {
            return (actualValue > 0);
        }

        public static bool IsLessThanZero(this int? actualValue)
        {
            return (actualValue < 0);
        }

        public static bool IsGreaterOrEqualToZero(this int? actualValue)
        {
            return (actualValue >= 0);
        }

        public static bool IsLessOrEqualToZero(this int? actualValue)
        {
            return (actualValue <= 0);
        }

        public static bool IsGreaterThan(this int? actualValue, int targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsGreaterThan(this int actualValue, int? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsGreaterThan(this int? actualValue, int? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this int? actualValue, int targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsLessThan(this int actualValue, int? targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsLessThan(this int? actualValue, int? targetValue)
        {
            return (actualValue < targetValue);
        }

        #endregion
    }
}