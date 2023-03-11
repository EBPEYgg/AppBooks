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
        //if (dX < |Ширина1 - Ширина2| / 2) || (dY < |Длина1 - Длина2| / 2)
        return true;
    }

    /// <summary>
    /// Метод, проверяющий столкновение геометрических кругов.
    /// </summary>
    /// <param name="ring1">Первый круг</param>
    /// <param name="ring2">Второй круг</param>
    /// <returns>Возвращает true or false.</returns>
    bool IsCollision(Ring ring1, Ring ring2)
    {
        //if (c < (Радиус1 + Радиус2))
        //c - гипотенуза
        return true;
    }
}
