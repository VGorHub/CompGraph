using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraph.View
{
    public partial class LabQuarterForm : Form
    {

        double[,] tetrahedron = new double[4, 4]; // матрица тела

        double[,] matr_preob = new double[4, 4]; // матрица преобразования

        // Элементы матрицы преобразования
        double l, m, n, // Сдвиг
        a, b, c, d, e, f, h, i, j; // Масштаб


        Bitmap myBitmap;

        public LabQuarterForm()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width + 200, pictureBox1.Height);
            Generate();
        }



        //Инициализация формы фигуры
        private void Init_Tetrahedron()
        {
            tetrahedron[0, 0] = 0; tetrahedron[0, 1] = -75; tetrahedron[0, 2] = 0; tetrahedron[0, 3] = 1;
            tetrahedron[1, 0] = -75; tetrahedron[1, 1] = 75; tetrahedron[1, 2] = 50; tetrahedron[1, 3] = 1;
            tetrahedron[2, 0] = 75; tetrahedron[2, 1] = 75; tetrahedron[2, 2] = 50; tetrahedron[2, 3] = 1;
            tetrahedron[3, 0] = 0; tetrahedron[3, 1] = 75; tetrahedron[3, 2] = -100; tetrahedron[3, 3] = 1;
        }

        //инициализация матрицы сдвига
        private void Init_matr_preob()
        {
            matr_preob[0, 0] = a; matr_preob[0, 1] = b; matr_preob[0, 2] = c; matr_preob[0, 3] = 0;
            matr_preob[1, 0] = d; matr_preob[1, 1] = e; matr_preob[1, 2] = f; matr_preob[1, 3] = 0;
            matr_preob[2, 0] = h; matr_preob[2, 1] = i; matr_preob[2, 2] = j; matr_preob[2, 3] = 0;
            matr_preob[3, 0] = l; matr_preob[3, 1] = m; matr_preob[3, 2] = n; matr_preob[3, 3] = 1;
        }

        //Обнуление матрицы преобразования
        private void Clear_matr_preob()
        {
            l = m = n = b = c = d = f = h = i = 0;
            a = e = j = 1;
        }

        //умножение матриц
        private double[,] Multiply_matr(double[,] a, double[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            double[,] r = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        //вывод фигуры на экран
        private void Draw_Tetrahedron(ref double[,] shape)
        {
            Init_matr_preob(); //инициализация матрицы преобразования

            shape = Multiply_matr(shape, matr_preob); //перемножение матриц

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            for (int i = 0; i < 4; i ++)
                for (int j = 0;j < 4; j ++)
                {
                    g.DrawLine(myPen, (int)shape[i, 0], (int)shape[i, 1], (int)shape[j, 0], (int)shape[j, 1]);
                }

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = myBitmap;

        }

        //Отрисовка системы координат
        private void Draw_Osi()
        {
            Pen myPen = new Pen(Color.DimGray, 1);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            g.DrawLine(myPen, 300, (int)myBitmap.Height, 300, 0);
            g.DrawLine(myPen, 0, 200, (int)myBitmap.Width, 200);

        }

        //Генерация кадра
        private void Generate()
        {
            Init_Tetrahedron();

            Clear_matr_preob();

            l = 300;
            m = 200;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            Clear_matr_preob();

            //Выбор элементов в комбобоксах
            ComboBox1.SelectedIndex = 1;
            RotateSpeedComboBox.SelectedIndex = 1;
            MoveComboBox.SelectedIndex = 1;
            ScaleComboBox.SelectedIndex = 1;

        }

        //Вращение 1
        private void Rotate_Click(object sender, EventArgs ev)
        {
            double angle = double.Parse(RotateSpeedComboBox.SelectedItem.ToString());

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;


            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    e = Math.Cos(-angle * Math.PI / 180);
                    f = Math.Sin(-angle * Math.PI / 180);
                    i = 0 - Math.Sin(-angle * Math.PI / 180);
                    j = Math.Cos(-angle * Math.PI / 180);
                    break;
                case 1:
                    a = Math.Cos(-angle * Math.PI / 180);
                    c = 0 - Math.Sin(-angle * Math.PI / 180);
                    h = Math.Sin(-angle * Math.PI / 180);
                    j = Math.Cos(-angle * Math.PI / 180);
                    break;
                case 2:
                    a = Math.Cos(-angle * Math.PI / 180);
                    b = Math.Sin(-angle * Math.PI / 180);
                    d = 0 - Math.Sin(-angle * Math.PI / 180);
                    e = Math.Cos(-angle * Math.PI / 180);
                    break;
                default:
                    break;
            }




            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = 300;
            m = 200;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);



            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;

        }

        //Вращение 2
        private void RotateButton1_Click(object sender, EventArgs ev)
        {
            double angle = double.Parse(RotateSpeedComboBox.SelectedItem.ToString());

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;


            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();


            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    e = Math.Cos(angle * Math.PI / 180);
                    f = Math.Sin(angle * Math.PI / 180);
                    i = 0 - Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 1:
                    a = Math.Cos(angle * Math.PI / 180);
                    c = 0 - Math.Sin(angle * Math.PI / 180);
                    h = Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 2:
                    a = Math.Cos(angle * Math.PI / 180);
                    b = Math.Sin(angle * Math.PI / 180);
                    d = 0 - Math.Sin(angle * Math.PI / 180);
                    e = Math.Cos(angle * Math.PI / 180);
                    break;
                default:
                    break;
            }


            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = 300;
            m = 200;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);



            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;
        }

        //Сдвиг влево
        private void LeftButton_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(MoveComboBox.SelectedItem.ToString());

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    l = -distance;
                    break;
                case 1:
                    m = -distance;
                    break;
                case 2:
                    n = -distance;
                    break;
                default:
                    break;
            }

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;

        }

        //Сдвиг вправо
        private void RightButton_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(MoveComboBox.SelectedItem.ToString());

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    l = distance;
                    break;
                case 1:
                    m = distance;
                    break;
                case 2:
                    n = distance;
                    break;
                default:
                    break;
            }

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;
        }

        //Масштаб +
        private void PlusButton_Click(object sender, EventArgs ev)
        {
            double scale = double.Parse(ScaleComboBox.SelectedItem.ToString());

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    a = scale;
                    break;
                case 1:
                    e = scale;
                    break;
                case 2:
                    j = scale;
                    break;
                default:
                    break;
            }

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = 300;
            m = 200;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);



            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;
        }

        //Масштаб -
        private void MinusButton_Click(object sender, EventArgs ev)
        {
            double scale = double.Parse(ScaleComboBox.SelectedItem.ToString());

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    a = 1/scale;
                    break;
                case 1:
                    e = 1/scale;
                    break;
                case 2:
                    j = 1 / scale;
                    break;
                default:
                    break;
            }

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = 300;
            m = 200;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);



            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;
        }


    }
}
