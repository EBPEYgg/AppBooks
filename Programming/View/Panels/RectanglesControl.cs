namespace Programming.View
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий RectanglesGroupBox.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Фиксированное количество создаваемых прямоугольников на вкладке Classes.
        /// </summary>
        const int N = 5;
        /// <summary>
        /// Инициализация массива с прямоугольниками размерностью N.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[N];
        /// <summary>
        /// Массив с данными текущего выбранного прямоугольника.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();
        /// <summary>
        /// Инициализация Point2D, хранящее центр координат.
        /// </summary>
        private Point2D _point2D = new Point2D();

        /// <summary>
        /// Метод, который выполняет поиск прямоугольника с максимальной шириной 
        /// в списке прямоугольников.
        /// </summary>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth()
        {
            double maxWidthRectangle = -1;
            int IndexRectangleWithMaxWidth = 0;
            for (int i = 0; i < RectanglesListBox.Items.Count; i++)
            {
                var currentWidthRectangle = _rectangles[i].Width;
                if (currentWidthRectangle > maxWidthRectangle)
                {
                    maxWidthRectangle = currentWidthRectangle;
                    IndexRectangleWithMaxWidth = i;
                }
            }
            return IndexRectangleWithMaxWidth;
        }

        public RectanglesControl()
        {
            InitializeComponent();

            Random random = new Random();

            string[] Enumes = { nameof(Color), nameof(EducationForm), nameof(Genre), nameof(Manufactures), nameof(Season), nameof(Weekday) };
            double[] PointX = new double[5];
            double[] PointY = new double[5];

            for (int i = 0; i < N; i++)
            {
                var Length = random.Next(1, 10);
                var Width = random.Next(1, 10);
                var CurrentColors = Enum.ToObject(typeof(Color), random.Next(0, 5)).ToString();
                _point2D = new Point2D(Convert.ToDouble(Length) / 2, Convert.ToDouble(Width) / 2);
                _rectangles[i] = new Rectangle(Length, Width, CurrentColors, _point2D);
                PointX[i] = _rectangles[i].Center.X;
                PointY[i] = _rectangles[i].Center.Y;
                RectanglesListBox.Items.Add($"Rectangle {i}");
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            LengthTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color!.ToString();
            PointXTextBox.Text = _currentRectangle.Center.X.ToString();
            PointYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(LengthTextBox.Text, out var temp))
                {
                    LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var lengthRectangle = Convert.ToDouble(LengthTextBox.Text);
                _currentRectangle.Height = lengthRectangle;
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(WidthTextBox.Text, out var temp))
                {
                    WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var widthRectangle = Convert.ToDouble(WidthTextBox.Text);
                _currentRectangle.Width = widthRectangle;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите корректное число.", "Ошибка ввода");
            }
            catch (OverflowException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.", "Ошибка ввода");
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var flag = false;
                foreach (var item in ColorTextBox.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentRectangle.Color = ColorTextBox.Text;
                    ColorTextBox.BackColor = System.Drawing.Color.White;
                }

                if (ColorTextBox.Text == "")
                {
                    ColorTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }

                if (flag == false)
                {
                    ColorTextBox.BackColor = System.Drawing.Color.LightPink;
                    throw new ArgumentException("Некорректный цвет.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void FindWidthButton_Click(object sender, EventArgs e)
        {
            RectangleWithMaxWidthLabel.Text = $"Прямоугольник с наиб. шириной: Rectangle {FindRectangleWithMaxWidth()}";
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
            RectangleWithMaxWidthLabel.Visible = true;
        }
    }
}