using CompGraph.Model;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using System;


namespace CompGraph.View
{
    public partial class Lab4_Vova : UserControl
    {
        Bitmap Bitmap { get; set; }
        new int Width => PictureBox.Width;
        new int Height => PictureBox.Height;

        float AngleDegrees { get; set; } = 0f;

        float AngleRadians => AngleDegrees / 180f * (float)Math.PI;

        private float xRotation = 20;
        private float yRotation = 20;
        private float zRotation = 0;

        float RotateSpeed { get; set; } = 5f;


        float XRotation
        {
            get => xRotation;
            set
            {
                xRotation = value;                
            }
        }
        float YRotation
        {
            get => yRotation;
            set
            {
                yRotation = value;                
            }
        }
        float ZRotation
        {
            get => zRotation;
            set
            {
                zRotation = value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            try
            {
                RotateSpeed = float.Parse(textBox.Text);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink;
            }
        }
        private void increaseRotateZ_Click(object sender, EventArgs e)
        {
            ZRotation += RotateSpeed;
        }

        private void increaseRotateY_Click(object sender, EventArgs e)
        {
            YRotation += RotateSpeed;
        }

        private void increaseRotateX_Click(object sender, EventArgs e)
        {
            XRotation += RotateSpeed;
        }

        private void decreaseRotateX_Click(object sender, EventArgs e)
        {
            XRotation -= RotateSpeed;
        }

        private void decreaseRotateY_Click(object sender, EventArgs e)
        {
            YRotation -= RotateSpeed;
        }

        private void decreaseRotateZ_Click(object sender, EventArgs e)
        {
            ZRotation -= RotateSpeed;
        }

        /// <summary>
        /// Вдоль оси OZ на плоскость XOY.
        /// </summary>
        TransformMatrix3 PerspectiveXOYMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();

                matrix.P = 0.01f;
                matrix.Q = 0.001f;
                return matrix;
            }
        }

        TransformMatrix3 CenterMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.L = Width / 2f;
                matrix.M = Height / 2f;
                matrix.N = 0;
                return matrix;
            }
        }

        TransformMatrix3 XOYDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.I = -1;
                return matrix;
            }
        }

        TransformMatrix3 YOZDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.A = -1;
                return matrix;
            }
        }

        TransformMatrix3 XOZDisplayMatrix
        {
            get
            {
                var matrix = new TransformMatrix3();
                matrix.E = -1;
                return matrix;
            }
        }

        Model3 Osi
        {
            get
            {
                var osi = new Model3();
                osi.Points.Add(new Point3(0, 0, 0));
                osi.Points.Add(new Point3(1, 0, 0));
                osi.Points.Add(new Point3(0, 1, 0));
                osi.Points.Add(new Point3(0, 0, 1));
                osi.Vectors.Add(new Model3.VectorIndexed(0, 1));
                osi.Vectors.Add(new Model3.VectorIndexed(0, 2));
                osi.Vectors.Add(new Model3.VectorIndexed(0, 3));
                return osi;
            }
        }

        Figure Figure { get; set; } = new Figure();

        int Interval { get; set; } = 50;

        public Lab4_Vova()
        {
            InitializeComponent();
        }

        TransformMatrix3 GetScaleMatrix(float scale)
        {
            var matrix = new TransformMatrix3();
            matrix.A = scale;
            matrix.E = scale;
            matrix.I = scale;
            return matrix;
        }

        TransformMatrix3 GetScaleMatrix(float x, float y, float z)
        {
            var matrix = new TransformMatrix3();
            matrix.A = x;
            matrix.E = y;
            matrix.I = z;
            return matrix;
        }

        TransformMatrix3 GetLocationMatrix(float x, float y, float z)
        {
            var matrix = new TransformMatrix3();
            matrix.L = x;
            matrix.M = y;
            matrix.N = z;
            return matrix;
        }

        TransformMatrix3 GetRotateXMatrix(float fi)
        {
            var rad = (fi - 180) / 180 * (float)Math.PI;
            var matrix = new TransformMatrix3();
            matrix.E = (float)Math.Cos(rad);
            matrix.F = (float)Math.Sin(rad);
            matrix.H = -(float)Math.Sin(rad);
            matrix.I = (float)Math.Cos(rad);
            return matrix;
        }

        TransformMatrix3 GetRotateYMatrix(float fi)
        {
            var rad = (fi - 180)/180 * (float)Math.PI;
            var matrix = new TransformMatrix3();
            matrix.A = (float)Math.Cos(rad);
            matrix.C = -(float)Math.Sin(rad);
            matrix.G = (float)Math.Sin(rad);
            matrix.I = (float)Math.Cos(rad);
            return matrix;
        }

        TransformMatrix3 GetRotateZMatrix(float fi)
        {
            var rad = (fi - 180) / 180 * (float)Math.PI;
            var matrix = new TransformMatrix3();
            matrix.A = (float)Math.Cos(rad);
            matrix.B = (float)Math.Sin(rad);
            matrix.D = -(float)Math.Sin(rad);
            matrix.E = (float)Math.Cos(rad);
            return matrix;
        }

        void DrawFigure()
        {
            var observer = new Point3(0, 0, -10000);
            var pen = new Pen(Color.Black, 5);
            var transparentPen = new Pen(Color.Black, 3);
            var figure = Figure.Transform(GetScaleMatrix(50)).Transform(GetLocationMatrix((float)NumericUpDownX.Value, 0, (float)NumericUpDownZ.Value));
            figure = figure.Transform(GetRotateXMatrix(XRotation)).Transform(GetRotateYMatrix(YRotation)).Transform(GetRotateZMatrix(ZRotation));

            figure = figure.Transform(GetRotateXMatrix(0));
            figure = figure.Transform(GetRotateZMatrix(0)).Transform(GetRotateYMatrix(AngleDegrees));
            figure = figure.Transform(GetLocationMatrix(0, 0, 0));
            var visibleFigure = figure.Transform(PerspectiveXOYMatrix).Transform(CenterMatrix);

            var g = Graphics.FromImage(Bitmap);

            for (var i = 0; i < figure.Edges.Count; i++)
            {
                if (figure.Edges[i].IsVisibleFrom(figure.Barycenter, observer))
                {
                    foreach(var vector in visibleFigure.Edges[i].Vectors)
                    {
                        var start = new PointF(vector.Start.X, vector.Start.Y);
                        var end = new PointF(vector.End.X, vector.End.Y);
                        g.DrawLine(pen, start, end);
                    }
                }
                else
                {
                    foreach (var vector in visibleFigure.Edges[i].Vectors)
                    {
                        var separatorCount = 11;
                        var deltaX = vector.End.X - vector.Start.X;
                        var deltaY = vector.End.Y - vector.Start.Y;

                        for (var k = 0; k < separatorCount; k += 2)
                        {
                            var start = new PointF(
                                vector.Start.X + deltaX * k / separatorCount,
                                vector.Start.Y + deltaY * k / separatorCount);

                            var end = new PointF(
                                vector.Start.X + deltaX * (k + 1) / separatorCount,
                                vector.Start.Y + deltaY * (k + 1) / separatorCount);

                            g.DrawLine(transparentPen, start, end);
                        }
                    }
                }
                
            }

            g.Dispose();
            PictureBox.Image = Bitmap;
        }

        void DrawOsi()
        {
            var penSize = 2;
            var xPen = new Pen(Color.Red, penSize);
            var yPen = new Pen(Color.Green, penSize);
            var zPen = new Pen(Color.Blue, penSize);

            var osi = Osi.Transform(GetScaleMatrix(100)).Transform(PerspectiveXOYMatrix).Transform(CenterMatrix);

            var g = Graphics.FromImage(Bitmap);

            g.DrawLine(
                xPen,
                new PointF(osi.Points[osi.Vectors[0][0]].X, osi.Points[osi.Vectors[0][0]].Y),
                new PointF(osi.Points[osi.Vectors[0][1]].X, osi.Points[osi.Vectors[0][1]].Y));

            g.DrawLine(
                yPen,
                new PointF(osi.Points[osi.Vectors[1][0]].X, osi.Points[osi.Vectors[1][0]].Y),
                new PointF(osi.Points[osi.Vectors[1][1]].X, osi.Points[osi.Vectors[1][1]].Y));

            g.DrawLine(
                zPen,
                new PointF(osi.Points[osi.Vectors[2][0]].X, osi.Points[osi.Vectors[2][0]].Y),
                new PointF(osi.Points[osi.Vectors[2][1]].X, osi.Points[osi.Vectors[2][1]].Y));


            var startOs = new Point3(0, -1, 0);
            var endOs = new Point3(0, 1, 0);
            startOs = startOs.Transform(GetScaleMatrix(100)).Transform(GetLocationMatrix((float)NumericUpDownX.Value, 0, (float)NumericUpDownZ.Value)).Transform(PerspectiveXOYMatrix).Transform(CenterMatrix);
            endOs = endOs.Transform(GetScaleMatrix(100)).Transform(GetLocationMatrix((float)NumericUpDownX.Value, 0, (float)NumericUpDownZ.Value)).Transform(PerspectiveXOYMatrix).Transform(CenterMatrix);
            g.DrawLine(
                xPen,
                new PointF(startOs.X, startOs.Y),
                new PointF(endOs.X, endOs.Y));

            g.Dispose();
            PictureBox.Image = Bitmap;
        }

        void Draw()
        {
            Clear();
            DrawOsi();
            DrawFigure();
        }

        void Clear()
        {
            Bitmap?.Dispose();
            Bitmap = new Bitmap(Width, Height);
            PictureBox.Image = Bitmap;
        }

        private void Lab4_Load(object sender, EventArgs e)
        {

            Bitmap = new Bitmap(Width, Height);
            Draw();
            Timer.Interval = Interval;
            Timer.Enabled = true;
        }

        private void Lab4_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AngleDegrees = (AngleDegrees + 1) % 360f;
            Draw();
        }
    }
}
