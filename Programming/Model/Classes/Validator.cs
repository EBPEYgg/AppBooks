/// <summary>
/// Класс с методами для проверки входящих значений.
/// </summary>

static internal class Validator
{
    /// <summary>
    /// Проверяет число на положительность.
    /// </summary>
    /// <returns>Возвращает true or false, если оно > 0.</returns>
    public static bool AssertOnPositiveValue(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Число не является положительным.");
        }

        return number > 0;
    }

    /// <summary>
    /// Проверяет число на положительность.
    /// </summary>
    /// <returns>Возвращает true or false, если оно > 0.</returns>
    public static bool AssertOnPositiveValue(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Число не является положительным.");
        }

        return number > 0;
    }

    /// <summary>
    /// Проверяет число на вхождение в заданный диапазон.
    /// </summary>
    /// <param name="value">Число, которое нужно проверить.</param>
    /// <param name="min">Минимальная граница диапазона (не включительно).</param>
    /// <param name="max">Максимальная граница диапазона (не включительно).</param>
    /// <returns>Возвращает true or false, если оно входит в заданный диапазон.</returns>
    public static bool AssertValueInRange(int value, int min, int max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException("Число не входит в заданный диапазон.");
        }

        return (min < value) && (max > value);
    }

    /// <summary>
    /// Проверяет число на вхождение в заданный диапазон.
    /// </summary>
    /// <param name="value">Число, которое нужно проверить.</param>
    /// <param name="min">Минимальная граница диапазона (не включительно).</param>
    /// <param name="max">Максимальная граница диапазона (не включительно).</param>
    /// <returns>Возвращает true or false, если оно входит в заданный диапазон.</returns>
    public static bool AssertValueInRange(double value, double min, double max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException("Число не входит в заданный диапазон.");
        }

        return (min < value) && (max > value);
    }
}