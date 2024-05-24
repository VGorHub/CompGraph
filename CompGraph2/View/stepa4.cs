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
    public partial class stepa4 : UserControl
    {
        
        double[,] tetrahedron = new double[49, 4]; // матрица тела

        double[,] matr_preob = new double[4, 4]; // матрица преобразования

        // Элементы матрицы преобразования
        double l, m, n, // Сдвиг
        a, b, c, d, e, f, h, i, j; // Масштаб

        double angle; // Угол поворота
        double distance; // дистанция сдвига
        double scale; //Кратность размера


        Bitmap myBitmap;

        public stepa4()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width + 200, pictureBox1.Height);
            Generate();
        }



        //Инициализация формы фигуры
        private void Init_Tetrahedron()
        {
            int k = 0;
            for (int i = -3; i <= 3; i++)
            {
                for (int j = -3; j <= 3; j++)
                {
                    double z = Math.Exp(Math.Sin(i) - (j * j));
                    tetrahedron[k, 0] = i; tetrahedron[k, 1] = j; tetrahedron[k, 2] = z; tetrahedron[k, 3] = 1;
                    k++;
                }
            }
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

            Pen myPen = new Pen(Color.Blue, 3); // цвет линии и ширина

            // создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            int gridSize = 7; 

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    int index = i * gridSize + j;

                    
                    if (j < gridSize - 1)
                    {
                        int nextIndex = index + 1;
                        g.DrawLine(myPen, (int)shape[index, 0], (int)shape[index, 1], (int)shape[nextIndex, 0], (int)shape[nextIndex, 1]);
                    }

                    
                    if (i < gridSize - 1)
                    {
                        int nextIndex = index + gridSize;
                        g.DrawLine(myPen, (int)shape[index, 0], (int)shape[index, 1], (int)shape[nextIndex, 0], (int)shape[nextIndex, 1]);
                    }
                }
            }

            g.Dispose(); // освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); // освобождаем ресурсы, связанные с Pen
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


        /////////////////////////////////////////////////////////////// Вращение


        //Тик вращения
        private void RotateTimer_Tick(object sender, EventArgs ea)
        {
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
                    i = -Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 1:
                    a = Math.Cos(angle * Math.PI / 180);
                    c = -Math.Sin(angle * Math.PI / 180);
                    h = Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 2:
                    a = Math.Cos(angle * Math.PI / 180);
                    b = Math.Sin(angle * Math.PI / 180);
                    d = -Math.Sin(angle * Math.PI / 180);
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

        //Вращение 1
        private void Rotate_Click(object sender, EventArgs ev)
        {

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
                    i = -Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 1:
                    a = Math.Cos(angle * Math.PI / 180);
                    c = -Math.Sin(angle * Math.PI / 180);
                    h = Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 2:
                    a = Math.Cos(angle * Math.PI / 180);
                    b = Math.Sin(angle * Math.PI / 180);
                    d = -Math.Sin(angle * Math.PI / 180);
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

        //Вращение 1 старт
        private void RotateButton1_MouseDown(object sender, MouseEventArgs e)
        {
            angle = double.Parse(RotateSpeedComboBox.SelectedItem.ToString());
            RotateTimer.Start();
        }

        //Остановка вращения
        private void RotateButton1_MouseUp(object sender, MouseEventArgs e)
        {
            RotateTimer.Stop();
        }

        //Вращение 2
        private void RotateButton1_Click(object sender, EventArgs ev)
        {

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
                    i = -Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 1:
                    a = Math.Cos(angle * Math.PI / 180);
                    c = -Math.Sin(angle * Math.PI / 180);
                    h = Math.Sin(angle * Math.PI / 180);
                    j = Math.Cos(angle * Math.PI / 180);
                    break;
                case 2:
                    a = Math.Cos(angle * Math.PI / 180);
                    b = Math.Sin(angle * Math.PI / 180);
                    d = -Math.Sin(angle * Math.PI / 180);
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

        //Вращение 2 старт
        private void RotateButton2_MouseDown(object sender, MouseEventArgs e)
        {
            angle = 0 - double.Parse(RotateSpeedComboBox.SelectedItem.ToString());
            RotateTimer.Start();
        }

        //Остановка вращения
        private void RotateButton2_MouseUp(object sender, MouseEventArgs e)
        {
            RotateTimer.Stop();
        }


        /////////////////////////////////////////////////////////////// Сдвиг

        //Тик сдвига
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            if (CheckedListBox.CheckedItems.Contains("Ox"))
                l = distance;
            if (CheckedListBox.CheckedItems.Contains("Oy"))
                m = distance;
            if (CheckedListBox.CheckedItems.Contains("Oz"))
                n = distance;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;
        }

        //Сдвиг влево
        private void LeftButton_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            if (CheckedListBox.CheckedItems.Contains("Ox"))
                l = distance;
            if (CheckedListBox.CheckedItems.Contains("Oy"))
                m = distance;
            if (CheckedListBox.CheckedItems.Contains("Oz"))
                n = distance;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;

        }

        //Сдвиг влево старт
        private void LeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            distance = -double.Parse(MoveComboBox.SelectedItem.ToString());
            MoveTimer.Start();
        }

        //Сдвиг влево конец
        private void LeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            MoveTimer.Stop();
        }

        //Сдвиг вправо
        private void RightButton_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            if (CheckedListBox.CheckedItems.Contains("Ox"))
                l = distance;
            if (CheckedListBox.CheckedItems.Contains("Oy"))
                m = distance;
            if (CheckedListBox.CheckedItems.Contains("Oz"))
                n = distance;

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;
        }

        //Сдвиг вправо старт
        private void RightButton_MouseDown(object sender, MouseEventArgs e)
        {
            distance = double.Parse(MoveComboBox.SelectedItem.ToString());
            MoveTimer.Start();
        }

        //Сдвиг вправо конец
        private void RightButton_MouseUp(object sender, MouseEventArgs e)
        {
            MoveTimer.Stop();
        }

        /////////////////////////////////////////////////////////////// Масштаб

        //Тик масштаба
        private void SizeTimer_Tick(object sender, EventArgs ea)
        {

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            if (CheckedListBox.CheckedItems.Contains("Ox"))
                a = scale;
            if (CheckedListBox.CheckedItems.Contains("Oy"))
                e = scale;
            if (CheckedListBox.CheckedItems.Contains("Oz"))
                j = scale;

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

        //Масштаб +
        private void PlusButton_Click(object sender, EventArgs ev)
        {

            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            if (CheckedListBox.CheckedItems.Contains("Ox"))
                a = scale;
            if (CheckedListBox.CheckedItems.Contains("Oy"))
                e = scale;
            if (CheckedListBox.CheckedItems.Contains("Oz"))
                j = scale;

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

        //Масштаб + старт
        private void PlusButton_MouseDown(object sender, MouseEventArgs e)
        {
            scale = double.Parse(ScaleComboBox.SelectedItem.ToString());
            SizeTimer.Start();
        }

        //Масштаб + конец
        private void PlusButton_MouseUp(object sender, MouseEventArgs e)
        {
            SizeTimer.Stop();
        }

        //Масштаб -
        private void MinusButton_Click(object sender, EventArgs ev)
        {
            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            l = -300;
            m = -200;

            Draw_Tetrahedron(ref tetrahedron);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            if (CheckedListBox.CheckedItems.Contains("Ox"))
                a = scale;
            if (CheckedListBox.CheckedItems.Contains("Oy"))
                e = scale;
            if (CheckedListBox.CheckedItems.Contains("Oz"))
                j = scale;

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

        //Масштаб - старт
        private void MinusButton_MouseDown(object sender, MouseEventArgs e)
        {
            scale = 1 / double.Parse(ScaleComboBox.SelectedItem.ToString());
            SizeTimer.Start();
        }

        //Масштаб - конец
        private void MinusButton_MouseUp(object sender, MouseEventArgs e)
        {
            SizeTimer.Stop();
        }

        ///////////////////////////////////////////////////////////////

        private void ViewButton_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(myBitmap);

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            g.Clear(SystemColors.Control);

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    g.DrawLine(myPen, (int)(tetrahedron[i, 0] + 100), (int)(tetrahedron[i, 1] - 100), (int)(tetrahedron[j, 0] + 100), (int)(tetrahedron[j, 1] - 100));
                    g.DrawLine(myPen, (int)(tetrahedron[i, 1] + 0), (int)(tetrahedron[i, 2] + 250), (int)(tetrahedron[j, 1] + 0), (int)(tetrahedron[j, 2] + 250));
                    g.DrawLine(myPen, (int)(tetrahedron[i, 0] + 100), (int)(tetrahedron[i, 2] + 250), (int)(tetrahedron[j, 0] + 100), (int)(tetrahedron[j, 2] + 250));
                }

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose();
            pictureBox1.Image = myBitmap;
        }

        private void ViewButton_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();

            Draw_Osi();

            Draw_Tetrahedron(ref tetrahedron);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;

        }
    }
}
