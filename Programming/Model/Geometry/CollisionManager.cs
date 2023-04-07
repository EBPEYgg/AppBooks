/// <summary>
/// Класс, описывающий проверку о пересечении/столкновении геометрических фигур.
/// </summary>
internal class CollisionManager
{
    /// <summary>
    /// Метод, проверяющий столкновение геометрических прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник</param>
    /// <param name="rectangle2">Второй прямоугольник</param>
    /// <returns>Возвращает true or false.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        // Находим расстояние между центрами прямоугольников по осям X и Y
        double distanceX = Math.Abs((rectangle1.Center.X + rectangle1.Width / 2) - (rectangle2.Center.X + rectangle2.Width / 2));
        double distanceY = Math.Abs((rectangle1.Center.Y + rectangle1.Length / 2) - (rectangle2.Center.Y + rectangle2.Length / 2));

        // Высчитываем минимальное расстояние по осям X и Y для пересечения прямоугольников
        double minDistanceX = (rectangle1.Width / 2) + (rectangle2.Width / 2);
        double minDistanceY = (rectangle1.Length / 2) + (rectangle2.Length / 2);

        // Проверяем столкновение по осям X и Y
        bool collisionX = (distanceX < minDistanceX);
        bool collisionY = (distanceY < minDistanceY);
        
        return (collisionX && collisionY);
    }

    /// <summary>
    /// Метод, проверяющий столкновение геометрических колец.
    /// </summary>
    /// <param name="ring1">Первый круг</param>
    /// <param name="ring2">Второй круг</param>
    /// <returns>Возвращает true or false.</returns>
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(ring1.ExternalRadius, 2) + Math.Pow(ring2.ExternalRadius, 2));
        return hypotenuse < (ring1.ExternalRadius + ring2.ExternalRadius);
    }
}
