/// <summary>
/// Класс, описывающий создание нового случайного объекта прямоугольника.
/// </summary>
internal class RectangleFactory
{
    /// <summary>
    /// Метод, создающий новый случайный объект прямоугольника.
    /// </summary>
    /// <returns>Новый случайный объект прямоугольника с размерами и центром координат.</returns>
    public Rectangle Randomize()
    {
        Random random = new Random();
        var point2D = new Point2D(random.Next(20, 400), random.Next(20, 400));
        return new Rectangle(random.Next(20, 100), random.Next(20, 100), point2D);
    }
}