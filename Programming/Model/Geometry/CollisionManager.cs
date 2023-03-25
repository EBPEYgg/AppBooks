/// <summary>
/// Класс, выполняющий проверку о пересечении/столкновении геометрических фигур.
/// </summary>
internal class CollisionManager
{
    /// <summary>
    /// Метод, проверяющий столкновение геометрических прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник</param>
    /// <param name="rectangle2">Второй прямоугольник</param>
    /// <returns>Возвращает true or false.</returns>
    bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        var dX = Math.Abs(rectangle1.Center.X + rectangle2.Center.X) / 2;
        var dY = Math.Abs(rectangle1.Center.Y + rectangle2.Center.Y) / 2;
        return dX < (Math.Abs(rectangle1.Width + rectangle2.Width) / 2)
            || dY < (Math.Abs(rectangle1.Length + rectangle2.Length) / 2);
    }

    /// <summary>
    /// Метод, проверяющий столкновение геометрических колец.
    /// </summary>
    /// <param name="ring1">Первый круг</param>
    /// <param name="ring2">Второй круг</param>
    /// <returns>Возвращает true or false.</returns>
    bool IsCollision(Ring ring1, Ring ring2)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(ring1.ExternalRadius, 2) + Math.Pow(ring2.ExternalRadius, 2));
        return hypotenuse < (ring1.ExternalRadius + ring2.ExternalRadius);
    }
}
