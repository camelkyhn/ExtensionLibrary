namespace ExtensionLibrary.ConditionExtensions
{
    public static class ShortChecks
    {
        public static bool IsEqualTo(this short actualValue, short targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqualTo(this short actualValue, short targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsGreaterThan(this short actualValue, short targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this short actualValue, short targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsGreaterOrEqualTo(this short actualValue, short targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this short actualValue, short targetValue)
        {
            return (actualValue <= targetValue);
        }

        public static bool IsEqualToZero(this short actualValue)
        {
            return (actualValue == 0);
        }

        public static bool IsNotEqualToZero(this short actualValue)
        {
            return actualValue != 0;
        }

        public static bool IsGreaterOrEqualToZero(this short actualValue)
        {
            return (actualValue >= 0);
        }

        public static bool IsGreaterThanZero(this short actualValue)
        {
            return (actualValue > 0);
        }

        public static bool IsLessOrEqualToZero(this short actualValue)
        {
            return (actualValue <= 0);
        }

        public static bool IsLessThanZero(this short actualValue)
        {
            return (actualValue < 0);
        }

        #region Nullable

        public static bool IsEqualTo(this short? actualValue, short targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqualTo(this short actualValue, short? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsEqualTo(this short? actualValue, short? targetValue)
        {
            return (actualValue == targetValue);
        }

        public static bool IsNotEqualTo(this short? actualValue, short targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqualTo(this short actualValue, short? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsNotEqualTo(this short? actualValue, short? targetValue)
        {
            return (actualValue != targetValue);
        }

        public static bool IsEqualToZero(this short? actualValue)
        {
            return actualValue == 0;
        }

        public static bool IsNotEqualToZero(this short? actualValue)
        {
            return actualValue != 0;
        }

        public static bool IsGreaterOrEqualTo(this short? actualValue, short targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterOrEqualTo(this short actualValue, short? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterOrEqualTo(this short? actualValue, short? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this short? actualValue, short targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this short actualValue, short? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsLessOrEqualTo(this short? actualValue, short? targetValue)
        {
            return (actualValue >= targetValue);
        }

        public static bool IsGreaterThanZero(this short? actualValue)
        {
            return (actualValue > 0);
        }

        public static bool IsLessThanZero(this short? actualValue)
        {
            return (actualValue < 0);
        }

        public static bool IsGreaterOrEqualToZero(this short? actualValue)
        {
            return (actualValue >= 0);
        }

        public static bool IsLessOrEqualToZero(this short? actualValue)
        {
            return (actualValue <= 0);
        }

        public static bool IsGreaterThan(this short? actualValue, short targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsGreaterThan(this short actualValue, short? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsGreaterThan(this short? actualValue, short? targetValue)
        {
            return (actualValue > targetValue);
        }

        public static bool IsLessThan(this short? actualValue, short targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsLessThan(this short actualValue, short? targetValue)
        {
            return (actualValue < targetValue);
        }

        public static bool IsLessThan(this short? actualValue, short? targetValue)
        {
            return (actualValue < targetValue);
        }

        #endregion
    }
}