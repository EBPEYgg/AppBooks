namespace Programming.View
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий страницу Rectangles.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Инициализация Point2D, хранящее центр координат.
        /// </summary>
        private Point2D _point2D = new Point2D();
        /// <summary>
        /// Инициализация списка с прямоугольниками на вкладке Rectangles.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        /// <summary>
        /// Список с параметрами текущего выбранного прямоугольника.
        /// </summary>
        private Rectangle _currentRectangleInList = new Rectangle();
        /// <summary>
        /// Список с нарисованными прямоугольниками на вкладке Rectangles.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();
        /// <summary>
        /// TODO: селектед индех
        /// </summary>
        private int _selectedIndex = -1;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void PanelAddRectangleButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int length = random.Next(20, 100);
            int width = random.Next(20, 100);
            int pointX = random.Next(20, CanvasPanel.Width - 100);
            int pointY = random.Next(20, CanvasPanel.Height - 100);

            _point2D = new Point2D(pointX, pointY);
            _currentRectangleInList = new Rectangle(length, width, _point2D);
            _rectanglesList.Add(_currentRectangleInList);
            RectanglesListBox.Items.Add(
                $"{_currentRectangleInList.Id}: " +
                $"(X= {_currentRectangleInList.Center.X}; " +
                $"Y = {_currentRectangleInList.Center.Y}; " +
                $"W= {_currentRectangleInList.Width}; " +
                $"H= {_currentRectangleInList.Length})"
                );

            Panel currentPanelRectangle = new Panel();
            currentPanelRectangle.Location = new Point(pointX, pointY);
            currentPanelRectangle.Size = new Size(width, length);
            currentPanelRectangle.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            currentPanelRectangle.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Controls.Add(currentPanelRectangle);
            _rectanglePanels.Add(currentPanelRectangle);
            FindCollision();
        }

        private void PanelDeleteRectangleButton_Click(object sender, EventArgs e)
        {
            int indexPanelRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangleInList = _rectanglesList[indexPanelRectangle];
            RectanglesListBox.Items.RemoveAt(indexPanelRectangle);
            _rectanglesList.Remove(_currentRectangleInList);
            CanvasPanel.Controls.RemoveAt(indexPanelRectangle);
            _rectanglePanels.RemoveAt(indexPanelRectangle);
            FindCollision();
        }

        private void PanelRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1 &&
                _selectedIndex != RectanglesListBox.SelectedIndex)
            {
                ClearRectangleInfo();
                _selectedIndex = RectanglesListBox.SelectedIndex;
                _currentRectangleInList = _rectanglesList[_selectedIndex];
                IdTextBox.Text = _currentRectangleInList.Id.ToString();
                PointXTextBox.Text = _currentRectangleInList.Center.X.ToString();
                PointYTextBox.Text = _currentRectangleInList.Center.Y.ToString();
                WidthTextBox.Text = _currentRectangleInList.Width.ToString();
                LengthTextBox.Text = _currentRectangleInList.Length.ToString();
            }
        }

        private void PanelWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(WidthTextBox.Text, out var temp))
                    {
                        WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var widthRectangle = Convert.ToInt32(WidthTextBox.Text);
                    _currentRectangleInList.Width = widthRectangle;
                    // изменение ширины прямоугольника
                    _rectanglePanels[_selectedIndex].Width = widthRectangle;
                    WidthTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                    UpdateRectangleInfo(_currentRectangleInList);
                }
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void PanelLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(LengthTextBox.Text, out var temp))
                    {
                        LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var lengthRectangle = Convert.ToInt32(LengthTextBox.Text);
                    _currentRectangleInList.Length = lengthRectangle;
                    // изменение высоты прямоугольника
                    _rectanglePanels[_selectedIndex].Height = lengthRectangle;
                    LengthTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                    UpdateRectangleInfo(_currentRectangleInList);
                }
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

        private void PanelXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(PointXTextBox.Text, out var temp))
                    {
                        PointXTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var pointXRectangle = Convert.ToInt32(PointXTextBox.Text);
                    _currentRectangleInList.Center.X = pointXRectangle;
                    _rectanglePanels[_selectedIndex].Location = new Point(pointXRectangle, _rectanglePanels[_selectedIndex].Location.Y);
                    PointXTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                    UpdateRectangleInfo(_currentRectangleInList);
                }
            }
            catch (FormatException)
            {
                PointXTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                PointXTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void PanelYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(PointYTextBox.Text, out var temp))
                    {
                        PointYTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var pointYRectangle = Convert.ToInt32(PointYTextBox.Text);
                    _currentRectangleInList.Center.Y = pointYRectangle;
                    _rectanglePanels[_selectedIndex].Location = new Point(_rectanglePanels[_selectedIndex].Location.X, pointYRectangle);
                    PointYTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                    UpdateRectangleInfo(_currentRectangleInList);
                }
            }
            catch (FormatException)
            {
                PointYTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                PointYTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void FindCollision()
        {
            if (_rectanglesList.Count > 0)
            {
                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                }

                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    for (int j = 0; j < _rectanglesList.Count; j++)
                    {
                        if (_rectanglePanels[i] != _rectanglePanels[j])
                        {
                            if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                            {
                                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                                _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                            }
                        }
                    }
                }
            }
        }

        private void ClearRectangleInfo()
        {
            IdTextBox.Clear();
            PointXTextBox.Clear();
            PointYTextBox.Clear();
            WidthTextBox.Clear();
            LengthTextBox.Clear();
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            RectanglesListBox.Items[_selectedIndex] =
                $"{_currentRectangleInList.Id}: " +
                $"(X= {_currentRectangleInList.Center.X}; " +
                $"Y = {_currentRectangleInList.Center.Y}; " +
                $"W= {_currentRectangleInList.Width}; " +
                $"H= {_currentRectangleInList.Length})";
            RectanglesListBox.SelectedIndex = _selectedIndex;

        }
    }
}