namespace Programming.Model.Classes
{
    static internal class Validator
    {
        public static bool AssertOnPositiveValue(int number)
        {
            try
            {
                if (number > 0) 
                    return true;
                else 
                    return false;
            }
            catch
            {
                throw new ArgumentException("Входное значение не является положительным");
            }
        }

        public static bool AssertOnPositiveValue(double number)
        {
            try
            {
                if (number > 0) 
                    return true;
                else 
                    return false;
            }
            catch
            {
                throw new ArgumentException("Входное значение не является положительным");
            }
        }

        public static bool AssertValueInRange(int value, int min, int max)
        {
            try
            {
                if ((min < value) && (max > value))
                    return true;

                return false;
            }
            catch
            {
                throw new ArgumentException("Число не входит в диапазон");
            }
        }

        public static bool AssertValueInRange(double value, double min, double max)
        {
            try
            {
                if ((min < value) && (max > value))
                    return true;

                return false;
            }
            catch
            {
                throw new ArgumentException("Число не входит в диапазон");
            }
        }
    }
}
