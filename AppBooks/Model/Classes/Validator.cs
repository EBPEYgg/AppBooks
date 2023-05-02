/// <summary>
/// Класс, описывающий методы для проверки входящих значений.
/// </summary>
// TODO: namespace
internal static class Validator
{
    /// <summary>
    /// Метод, который проверяет число на положительность.
    /// </summary>
    /// <returns>Возвращает true or false.</returns>
    public static void AssertOnPositiveValue(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("Число не является положительным.");
        }
    }

    /// <summary>
    /// Метод, который проверяет число на положительность.
    /// </summary>
    /// <returns>Возвращает true or false.</returns>
    public static void AssertOnPositiveValue(double number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("Число не является положительным.");
        }
    }

    /// <summary>
    /// Метод, который проверяет число на вхождение в заданный диапазон.
    /// </summary>
    /// <param name="value">Число, которое нужно проверить.</param>
    /// <param name="min">Минимальная граница диапазона (не включительно).</param>
    /// <param name="max">Максимальная граница диапазона (не включительно).</param>
    /// <returns>Возвращает true or false.</returns>
    public static void AssertValueInRange(int value, int min, int max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException("Число не входит в заданный диапазон.");
        }
    }

    /// <summary>
    /// Метод, который проверяет число на вхождение в заданный диапазон.
    /// </summary>
    /// <param name="value">Число, которое нужно проверить.</param>
    /// <param name="min">Минимальная граница диапазона (не включительно).</param>
    /// <param name="max">Максимальная граница диапазона (не включительно).</param>
    /// <returns>Возвращает true or false.</returns>
    public static void AssertValueInRange(double value, double min, double max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException("Число не входит в заданный диапазон.");
        }
    }

    /// <summary>
    /// Метод, который проверяет входящую строку на наличие латиницы.
    /// </summary>
    /// <param name="name">Строка.</param>
    /// <returns>True or false.</returns>
    public static bool CheckStringContainsOnlyEnglishLetters(string? value)
    {
        bool flag = true;
        foreach (char c in value)
        {
            if (!(((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || (c == ' ')))
            {
                flag = false;
                break;
            }
        }

        return flag;
    }
}