namespace Lab_3
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private int step = 50;
        private const int drawStep = 7;
        private int a = 0;
        private int b = 1;
        private int c = 1;
        private int d = 0;
        private int leftBorderVal = -100;
        private int rightBorderVal = 100;
        private bool isGraphShown = false;
        private bool isValidData = true;

        protected void DrawAxises()
        {
            grahPlane.Refresh();
            Graphics graphic = graphic = grahPlane.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(34, 34, 34), 3f);

            int height = grahPlane.Height;
            int width = grahPlane.Width;

            int x = 0;
            int y = grahPlane.Size.Height / 2;

            graphic.DrawLine(pen, x, y, width, y);
            graphic.DrawLine(pen, width / 2, 0, width / 2, height);

            for (int i = (width / 2) % step; i < width; i += step)
                graphic.DrawLine(pen, i, y + (step / 10 + 5), i, y - (step / 10 + 5));

            for (int i = y % step; i < height; i += step)
                graphic.DrawLine(pen, width / 2 + (step / 10 + 5), i, width / 2 - (step / 10 + 5), i);
        }

        protected void DrawGraph()
        {
            int xPrev = Math.Max(0, grahPlane.Width / 2 + leftBorderVal * step);
            int yPrev = grahPlane.Height / 2 - Convert.ToInt32(
                    a * step + b * step * Math.Sin(
                        c * (xPrev - grahPlane.Width / 2) / Convert.ToDouble(step) + d)
                    );
            Graphics graphic = graphic = grahPlane.CreateGraphics();
            Pen pen = new Pen(Color.BlueViolet, 3f);
            //
            while (xPrev < Math.Min(grahPlane.Width, grahPlane.Width / 2 + rightBorderVal * step))
            {
                int x = xPrev + drawStep;
                int y = grahPlane.Height / 2 - Convert.ToInt32(
                    a * step + b * step * Math.Sin(
                        c * (x - grahPlane.Width / 2) / Convert.ToDouble(step) + d)
                    );

                graphic.DrawLine(pen, xPrev, yPrev, x, y);

                xPrev = x;
                yPrev = y;
            }
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
            DrawGraph();
            isGraphShown = true;
        }

        private int ValidateValues(string? text, ref int value)
        {
            if (string.IsNullOrEmpty(text))
                return 0;
            else if (!int.TryParse(text, out value))
                return -1;

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
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }

            if (leftBorderVal < rightBorderVal)
            {
                isValidData = true;
                return;
            }
            MessageBox.Show("Left border must be less than right!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                default:
                    break;
            }

            if (rightBorderVal > leftBorderVal)
            {
                isValidData = true;
                return;
            }
            MessageBox.Show("Right border must be greater than left!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void aValue_Leave(object sender, EventArgs e)
        {
            switch (ValidateValues(aValue.Text, ref a))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    isValidData = true;
                    return;
            }

            isValidData = false;
            aValue.Focus();
            aValue.Select(0, aValue.Text.Length);
        }

        private void bValue_Leave(object sender, EventArgs e)
        {
            switch (ValidateValues(bValue.Text, ref b))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    isValidData = true;
                    return;
            }

            isValidData = false;
            bValue.Focus();
            bValue.Select(0, bValue.Text.Length);
        }

        private void cValue_Leave(object sender, EventArgs e)
        {
            switch (ValidateValues(cValue.Text, ref c))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    isValidData = true;
                    return;
            }

            isValidData = false;
            cValue.Focus();
            cValue.Select(0, cValue.Text.Length);
        }

        private void dValue_Leave(object sender, EventArgs e)
        {
            switch (ValidateValues(dValue.Text, ref d))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    isValidData = true;
                    return;
            }

            isValidData = false;
            dValue.Focus();
            dValue.Select(0, dValue.Text.Length);
        }

        private void stepValue_Leave(object sender, EventArgs e)
        {
            switch (ValidateValues(stepValue.Text, ref step))
            {
                case 0:
                    MessageBox.Show("Field must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case -1:
                    MessageBox.Show("Invalid data!\nIntegers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    isValidData = true;
                    break;
            }
            
            if(step > 5 )
            {
                isValidData = true;
                return;
            }

            if( step <= 0) MessageBox.Show("Step value can't be negative or 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else MessageBox.Show("Step value is too tiny!\nGraph is more visible with step > 5", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            isValidData = false;
            stepValue.Focus();
            stepValue.Select(0, stepValue.Text.Length);
        }
    }
}
