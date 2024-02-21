namespace Lab_3
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private const int pixelsPerSection = 100;
        private double step = 0.1;
        private double a = 0;
        private double b = 1;
        private double c = 1;
        private double d = 0;
        private double leftBorderVal = -10;
        private double rightBorderVal = 10;
        private bool isGraphShown = false;
        private bool isValidData = true;
        double[] x = new double[0];
        double[] y = new double[0];

        protected void DrawAxises()
        {
            graphPlane.Refresh();
            Graphics graphic = graphic = graphPlane.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(34, 34, 34), 2f);

            int height = graphPlane.Height;
            int width = graphPlane.Width;

            int x = 0;
            int y = graphPlane.Size.Height / 2;

            graphic.DrawLine(pen, x, y, width, y);
            graphic.DrawLine(pen, width / 2, 0, width / 2, height);

            for (int i = (width / 2) % pixelsPerSection; i < width; i += pixelsPerSection)
                graphic.DrawLine(pen, i, y + (pixelsPerSection / 10 + 5), i, y - (pixelsPerSection / 10 + 5));

            for (int i = y % pixelsPerSection; i < height; i += pixelsPerSection)
                graphic.DrawLine(pen, width / 2 + (pixelsPerSection / 10 + 5), i, width / 2 - (pixelsPerSection / 10 + 5), i);
        }

        protected void DrawGraph()
        {
            int xPrev = Math.Max(0, graphPlane.Width / 2 + Convert.ToInt32(leftBorderVal * pixelsPerSection));
            int yPrev = graphPlane.Height / 2 - Convert.ToInt32(
                    a * pixelsPerSection + b * pixelsPerSection * Math.Sin(
                        c * (xPrev - graphPlane.Width / 2) / Convert.ToDouble(pixelsPerSection) + d)
                    );

            Graphics graphic = graphic = graphPlane.CreateGraphics();
            Pen pen = new Pen(Color.BlueViolet, 3f);

            Point[] points = CalculateGraphPoints();

            for (int i = 0; i < points.Length && xPrev < Math.Min(graphPlane.Width, graphPlane.Width / 2 + Convert.ToInt32(rightBorderVal * pixelsPerSection)); i++)
            {
                if (points[i].X <= xPrev) continue;
                graphic.DrawLine(pen, xPrev, yPrev, points[i].X, points[i].Y);

                xPrev = points[i].X;
                yPrev = points[i].Y;
            }

        }

        private Point[] CalculateGraphPoints()
        {

            x = FunctionPoints.GenerateX(step, leftBorderVal, rightBorderVal);
            y = FunctionPoints.GenerateY(x, [a, b, c, d]);

            Point[] points = new Point[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                points[i].X = graphPlane.Width / 2 + Convert.ToInt32(x[i] * pixelsPerSection);
                points[i].Y = graphPlane.Height / 2 - Convert.ToInt32(y[i] * pixelsPerSection);
            }

            return points;
        }

        private void grahPlane_Resize(object sender, EventArgs e)
        {
            DrawAxises();
            if (isGraphShown) DrawGraph();
        }

        private void GraphForm_Shown(object sender, EventArgs e)
        {
            DrawAxises();
        }

        private void drawGraphBtn_Click(object sender, EventArgs e)
        {
            DrawAxises();
            if (CheckGraphOdds())
            {
                DrawGraph();
                isGraphShown = true;
                showCoordinatesBtn.Enabled = true;
            }
        }

        private string FormatTextField(string text)
        {
            if (text.IndexOf(',') == -1)
                return text + ",00";
            if (text.Length - 1 - text.IndexOf(',') < 2)
                return text + '0';
            return text;
        }

        private bool CheckGraphOdds()
        {
            isGraphShown = false;

            if (!isValidData) return false;

            if (Math.Abs(a) > graphPlane.Height / 2 / step)
            {
                MessageBox.Show("Change \"A\" value, either way graph won't be seen with current window size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (leftBorderVal > graphPlane.Width / 2 / step)
            {
                MessageBox.Show("Make \"Left Border\" value less, either way graph won't be seen with current window size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rightBorderVal < -graphPlane.Width / 2 / step)
            {
                MessageBox.Show("Make \"Right Border\" value greater, either way graph won't be seen with current window size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private int ValidateValues(string? text, ref double value)
        {
            if (string.IsNullOrEmpty(text))
                return 0;
            else if (!double.TryParse(text, out value))
                return -1;
            else if (text.IndexOf(',') != -1 && text.Length - 1 - text.IndexOf(',') > 2)
                return 2;
            return 1;
        }
        private void leftBorderValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(leftBorderValue.Text, ref leftBorderVal))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nNumbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    if (leftBorderVal < rightBorderVal)
                    {
                        leftBorderValue.Text = FormatTextField(leftBorderValue.Text);
                        isValidData = true;
                        return;
                    }
                    MessageBox.Show("Left border must be less than right!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }


            isValidData = false;
            leftBorderValue.Focus();
            leftBorderValue.Select(0, leftBorderValue.Text.Length);
        }

        private void rightBorderValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(rightBorderValue.Text, ref rightBorderVal))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    if (rightBorderVal > leftBorderVal)
                    {
                        rightBorderValue.Text = FormatTextField(rightBorderValue.Text);
                        isValidData = true;
                        return;
                    }
                    MessageBox.Show("Right border must be greater than left!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            isValidData = false;
            rightBorderValue.Focus();
            rightBorderValue.Select(0, rightBorderValue.Text.Length);
        }

        private void aValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(aValue.Text, ref a))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nNumbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    aValue.Text = FormatTextField(aValue.Text);
                    isValidData = true;
                    return;
            }

            isValidData = false;
            aValue.Focus();
            aValue.Select(0, aValue.Text.Length);
        }

        private void bValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(bValue.Text, ref b))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nNumbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    bValue.Text = FormatTextField(bValue.Text);
                    isValidData = true;
                    return;
            }

            isValidData = false;
            bValue.Focus();
            bValue.Select(0, bValue.Text.Length);
        }

        private void cValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(cValue.Text, ref c))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nNumbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    cValue.Text = FormatTextField(cValue.Text);
                    isValidData = true;
                    return;
            }

            isValidData = false;
            cValue.Focus();
            cValue.Select(0, cValue.Text.Length);
        }

        private void dValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(dValue.Text, ref d))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nNumbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    dValue.Text = FormatTextField(dValue.Text);
                    isValidData = true;
                    return;
            }

            isValidData = false;
            dValue.Focus();
            dValue.Select(0, dValue.Text.Length);
        }

        private void stepValue_Check(object sender, EventArgs e)
        {
            switch (ValidateValues(stepValue.Text, ref step))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nNumbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show("Programm accepts values up to 2 decimal places!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    if (step > 1)
                        MessageBox.Show("Step value can't be greater than 1!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (step <= 0)
                        MessageBox.Show("Step value can't be negative or 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        stepValue.Text = FormatTextField(stepValue.Text);
                        isValidData = true;
                        return;
                    }
                    break;
            }

            isValidData = false;
            stepValue.Focus();
            stepValue.Select(0, stepValue.Text.Length);
        }

        private void showCoordinatesBtn_Click(object sender, EventArgs e)
        {
            Form table = new TableForm(x, y);
            table.ShowDialog();
        }
    }
}
