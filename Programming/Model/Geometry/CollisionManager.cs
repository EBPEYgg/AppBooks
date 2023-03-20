/// <summary>
/// Класс, выполняющий проверку о пересечении/столкновении геометрических фигур.
/// </summary>
internal class CollisionManager
{
    /// <summary>
    /// Расстояние по X координате от центра одной фигуры до центра другой фигуры.
    /// </summary>
    private int dX;
    /// <summary>
    /// Расстояние по Y координате от центра одной фигуры до центра другой фигуры.
    /// </summary>
    private int dY;
    /// <summary>
    /// Гипотенуза между центрами колец.
    /// </summary>
    private double hypotenuse;

    /// <summary>
    /// Метод, проверяющий столкновение геометрических прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник</param>
    /// <param name="rectangle2">Второй прямоугольник</param>
    /// <returns>Возвращает true or false.</returns>
    bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        //if (dX < |Ширина1 - Ширина2| / 2) || (dY < |Длина1 - Длина2| / 2)
        if (dX < (Math.Abs(rectangle1.Width - rectangle2.Width) / 2)
            || dY < (Math.Abs(rectangle1.Length - rectangle2.Width) / 2))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Метод, проверяющий столкновение геометрических кругов.
    /// </summary>
    /// <param name="ring1">Первый круг</param>
    /// <param name="ring2">Второй круг</param>
    /// <returns>Возвращает true or false.</returns>
    bool IsCollision(Ring ring1, Ring ring2)
    {
        hypotenuse = Math.Sqrt(Math.Pow(ring1.ExternalRadius, 2) + Math.Pow(ring2.ExternalRadius, 2));
        //if (гипотенуза < (Радиус1 + Радиус2))
        if (hypotenuse < (ring1.ExternalRadius + ring2.ExternalRadius))
        {
            return true;
        }
        return false;
    }
}
