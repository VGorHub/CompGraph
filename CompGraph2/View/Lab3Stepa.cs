using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Threading;

namespace CompGraph.View
{
    public partial class Lab3Stepa : UserControl
    {
        int[,] kv = new int[4, 3];
        int[,] bt = new int[9, 3];
        int[,] bd = new int[5, 3];
        double[,] matr_sdv = new double[3, 3];
        int k, l;
        int k2 = 0;
        int k3 = 0;
        int l2 = 0;
        int l3 = 0;
        bool f;
        int[,] bd2;
        int[,] bt2;
        bool check_bird = true;
        bool check_boat = true;
        double xscaleDelta = 0.05;
        double yscaleDelta = 0.05;
        double xscale1 = 1;
        double yscale1 = 1;
        double xdisplay1 = 1;
        double ydisplay1 = 1;
        double xscale2 = 1;
        double yscale2 = 1;
        double xdisplay2 = 1;
        double ydisplay2 = 1;
        Bitmap Bitmap;
        public Lab3Stepa()
        {
            InitializeComponent();
            timer1.Interval = 100;
            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        private void ClearBit()
        {
            Bitmap.Dispose();
            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Bitmap;
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
        }
        private void radioButton_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Auto.Checked == true)
            {
                button_Auto.Visible = true;
                button_down.Visible = false;
                button_left.Visible = false;
                button_right.Visible = false;
                button_up.Visible = false;
            }
            else
            {
                button_Auto.Visible = false;
                button_down.Visible = true;
                button_left.Visible = true;
                button_right.Visible = true;
                button_up.Visible = true;
            }
        }
        
        private int[,] Multiply_matr(int[,] a, double[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] r = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += (int)(a[i, ii] * b[ii, j]);
                    }
                }
            }
            return r;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearBit();
            if (f == false)
            {
                button_Auto_Click(sender, e);
            }
            radioButton_Auto.Visible = false;
            radioButton_Bird.Visible = false;
            radioButton_Boat.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
        }
        private void Init_Sea()
        {
            int current1 = pictureBox1.Width / 2;
            int current2 = pictureBox1.Height / 2;
            kv[0, 0] = -current1+100; kv[0, 1] = current2 - 100; kv[0, 2] = 1;
            kv[1, 0] = -current1 + 50; kv[1, 1] = -current2 + 520; kv[1, 2] = 1;
            kv[2, 0] = current1 - 50; kv[2, 1] = -current2 + 520; kv[2, 2] = 1;
            kv[3, 0] = current1-100; kv[3, 1] = current2 - 100; kv[3, 2] = 1;
            
        }
        private void Init_matr_preob_scale(int k1, int l1, double xscale, double xdisplay, double yscale, double ydisplay)
        {
            matr_sdv[0, 0] = xscale * xdisplay; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = yscale * ydisplay; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }
        
        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }
        private void Init_Bird()
        {
            if (check_bird == true)
            {
                bd[0, 0] = 0; bd[0, 1] = 0; bd[0, 2] = 1;
                bd[4, 0] = 40; bd[4, 1] = 0; bd[4, 2] = 1;
            }
            else
            {
                bd[0, 0] = 0; bd[0, 1] = -8; bd[0, 2] = 1;
                bd[4, 0] = 40; bd[4, 1] = -8; bd[4, 2] = 1;
            }
            
            bd[1, 0] = 10; bd[1, 1] = -5; bd[1, 2] = 1;
            bd[2, 0] = 20; bd[2, 1] = 0; bd[2, 2] = 1;
            bd[3, 0] = 30; bd[3, 1] = -5; bd[3, 2] = 1;
            
        }
        private void Draw_Bird()
        {
            k = pictureBox1.Width - 250 +k3;
            l = pictureBox1.Height - 150 +l3;
            Init_Bird();
            Init_matr_preob_scale(k, l, xscale1, xdisplay1, yscale1, ydisplay1); //инициализация матрицы преобразования
            int[,] kv1 = Multiply_matr(bd, matr_sdv);
            bd2 = Multiply_matr(bd, matr_sdv);
            Pen myPen = new Pen(Color.Black, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);
            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            //// рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            //// рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[4, 0], kv1[4, 1]);
            
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = Bitmap;
        }
        private void Draw_Sunset(Graphics g)
        {
            Rectangle sunRect = new Rectangle(270, 320, 200, 200); // Прямоугольник, в который вписан круг солнца
            LinearGradientBrush brush = new LinearGradientBrush(
                sunRect,
                Color.Orange, // Цвет солнца (желтый)
                Color.Transparent, // Прозрачный цвет, чтобы создать эффект заката
                LinearGradientMode.Vertical); // Вертикальное направление градиента
            g.FillEllipse(brush, sunRect); // Рисуем круг солнца с градиентным заполнением
        }
        private void Init_Boat()
        {
            if (check_boat == true)
            {
                bt[5, 0] = 60; bt[5, 1] = -45; bt[5, 2] = 1;
                
            }
            else
            {
                bt[5, 0] = 10; bt[5, 1] = -45; bt[5, 2] = 1;
                
            }
            bt[0, 0] = 0; bt[0, 1] = 0; bt[0, 2] = 1;
            bt[1, 0] = 70; bt[1, 1] = 0; bt[1, 2] = 1;
            bt[2, 0] = 90; bt[2, 1] = -15; bt[2, 2] = 1;
            bt[3, 0] = 35; bt[3, 1] = -15; bt[3, 2] = 1;
            bt[4, 0] = 35; bt[4, 1] = -60; bt[4, 2] = 1;
            bt[6, 0] = 35; bt[6, 1] = -30; bt[6, 2] = 1;
            bt[7, 0] = 35; bt[7, 1] = -15; bt[7, 2] = 1;
            bt[8, 0] = -20; bt[8, 1] = -15; bt[8, 2] = 1;
        }
        private void Draw_Boat()
        {
            k =  pictureBox1.Width - 200+k2;
            l =  pictureBox1.Height - 50+l2;
            Init_Boat();
            Init_matr_preob_scale(k, l, xscale2, xdisplay2, yscale2, ydisplay2); //инициализация матрицы преобразования
            int[,] kv1 = Multiply_matr(bt, matr_sdv);
            bt2 = Multiply_matr(bt, matr_sdv);
            //kv2 = Multiply_matr(bt, matr_sdv);
            // Создаем кисть для заливки фигуры
            Brush brush = new SolidBrush(Color.Gray); // Цвет заливки
            Pen myPen = new Pen(Color.Black, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            //// рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            //// рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[4, 0], kv1[4, 1]);
            g.DrawLine(myPen, kv1[4, 0], kv1[4, 1], kv1[5, 0], kv1[5, 1]);
            g.DrawLine(myPen, kv1[5, 0], kv1[5, 1], kv1[6, 0], kv1[6, 1]);
            g.DrawLine(myPen, kv1[6, 0], kv1[6, 1], kv1[7, 0], kv1[7, 1]);
            g.DrawLine(myPen, kv1[7, 0], kv1[7, 1], kv1[8, 0], kv1[8, 1]);
            g.DrawLine(myPen, kv1[8, 0], kv1[8, 1], kv1[0, 0], kv1[0, 1]);
            // Создаем массив точек, представляющий вершины фигуры
            Point[] points = new Point[]
            {
                new Point(kv1[0, 0], kv1[0, 1]),
                new Point(kv1[1, 0], kv1[1, 1]),
                new Point(kv1[2, 0], kv1[2, 1]),
                new Point(kv1[3, 0], kv1[3, 1]),
                new Point(kv1[4, 0], kv1[4, 1]),
                new Point(kv1[5, 0], kv1[5, 1]),
                new Point(kv1[6, 0], kv1[6, 1]),
                new Point(kv1[7, 0], kv1[7, 1]),
                new Point(kv1[8, 0], kv1[8, 1])
            };

            // Создаем новый объект Graphics (поверхность рисования) из pictureBox
            

            // Заливаем фигуру цветом
            g.FillPolygon(brush, points);

            // Освобождаем ресурсы
            brush.Dispose();
            g.Dispose();
            pictureBox1.Image = Bitmap;
        }
        private void Draw_Waves(Graphics g, int[,] kv)
        {
            // Определим параметры волн
            int waveLength = 50; // Длина волны
            float waveHeight = 4; // Высота волны
            int waveCount = (kv[2, 0] - kv[1, 0]) / waveLength - 1; // Количество волн

            // Рисуем волны внутри четырехугольника моря
            Pen wavePen = new Pen(Color.Blue); // Цвет волн
            float curr = 70;
            int curr2 = 50;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < waveCount; i++)
                {
                    int startX = kv[1, 0] + i * waveLength + curr2;
                    int endX = startX + waveLength / 2;
                    float startY = kv[1, 1] - waveHeight - curr;
                    float endY = kv[1, 1] + waveHeight - curr;

                    // Создаем массив точек, через которые пройдет кривая
                    Point[] curvePoints = 
                        {
                        new Point(startX, (int)startY),
                        new Point(endX, (int)endY),
                        new Point(startX + waveLength, (int)startY)
                    };

                    // Рисуем кривую, проходящую через эти точки
                    g.DrawCurve(wavePen, curvePoints);
                }

                waveHeight += waveHeight / 5;
                waveLength += 3;
                curr -= 25;
                curr2 -= 15;
            }
            
        }
        private void Draw_Sea()
        {
            Init_Sea(); //инициализация матрицы тела
            Init_matr_preob(k, l); //инициализация матрицы преобразования
            int[,] kv1 = Multiply_matr(kv, matr_sdv); //перемножение матриц
            
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);
            Draw_Sunset(g);
            
            // Создаем градиентный кисть
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(kv[0, 0], kv[0, 1]),
                new Point(kv[1, 0], kv[1, 1]),
                Color.Blue,
                Color.White)
            {
                // Устанавливаем вертикальное направление градиента
                WrapMode = WrapMode.TileFlipXY,
                InterpolationColors = new ColorBlend(3)
                {
                    Colors = new[] { Color.Transparent,Color.FromArgb(0,125,255)},
                    Positions = new[] { 0f, 1f }
                }
            }; // Здесь можно указать цвета для начала и конца градиента

            // Создаем графический объект для рисования


            // Заполняем четырехугольник градиентной кистью
            g.FillPolygon(brush, new Point[]
            {
                new Point(kv1[0, 0], kv1[0, 1]),
                new Point(kv1[1, 0], kv1[1, 1]),
                new Point(kv1[2, 0], kv1[2, 1]),
                new Point(kv1[3, 0], kv1[3, 1])
            });
            Draw_Waves(g, kv1);
            Draw_Boat();
            Draw_Bird();
            // Освобождаем ресурсы
            brush.Dispose();
            

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = Bitmap;
        }

        private void button_right_Click(object sender, EventArgs e)
        {

            if (radioButton_Boat.Checked == true)
            {
                k2 += 5;

                Draw_Boat();
                
                if (bt2[1,0]<=500)
                {
                    if (check_boat != true)
                    {
                        check_boat = !check_boat;
                    }
                    ClearBit();

                    Draw_Sea();
                }
                else
                {
                    k2 -= 5;

                    ClearBit();

                    Draw_Sea();
                }
                
            }
            else
            {
                k3 += 5;
                check_bird = !check_bird;
                ClearBit();

                Draw_Sea();
            }


        }

        private void button_left_Click(object sender, EventArgs e)
        {
            
            if (radioButton_Boat.Checked == true)
            {
                k2 -= 5;
                Draw_Boat();
                if (bt2[1,0]>=177)
                {
                    if (check_boat != false)
                    {
                        check_boat = !check_boat;
                    }

                    ClearBit();

                    Draw_Sea();
                }
                else
                {
                    k2 += 5;

                    ClearBit();

                    Draw_Sea();
                }
                
            }
            else
            {
                k3 -= 5;
                check_bird = !check_bird;
                ClearBit();

                Draw_Sea();
            }
        }

        private void button_up_Click(object sender, EventArgs e)
        {

            if (radioButton_Boat.Checked == true)
            {
                l2 -= 5;
                Draw_Boat();
                if (bt2[1, 1] >= 442)
                {
                    if (check_boat != false)
                    {
                        check_boat = !check_boat;
                    }
                    
                    if(xscale2>=0.1)
                    {
                        xscale2 -= xscaleDelta;
                        xscale2 -= xscaleDelta;
                        yscale2 -= yscaleDelta;
                    }
                    
                    ClearBit();

                    Draw_Sea();
                }
                else
                {
                    l2 += 5;

                    ClearBit();

                    Draw_Sea();
                }
            }
            else
            {
                l3 -= 5;
                check_bird = !check_bird;
                
                if (xscale1>=0.1)
                {
                    xscale1 -= xscaleDelta;
                    xscale1 -= xscaleDelta;
                    yscale1 -= yscaleDelta;
                }
                
                ClearBit();

                Draw_Sea();
            }
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            if (radioButton_Boat.Checked == true)
            {
                l2 += 5;
                Draw_Boat();
                if (bt2[1, 1] <= 517)
                {
                    if (check_boat != false)
                    {
                        check_boat = !check_boat;
                    }
                    
                    xscale2 += xscaleDelta;
                    xscale2 += xscaleDelta;
                    yscale2 += yscaleDelta;
                    ClearBit();

                    Draw_Sea();
                }
                else
                {
                    l2 -= 5;

                    ClearBit();

                    Draw_Sea();
                }
            }
            else
            {

                l3 += 5;
                Draw_Bird();
                if (bd2[1,1]<=507)
                {
                    check_bird = !check_bird;
                    if(xscale1 <=2.1)
                    {
                        xscale1 += xscaleDelta;
                        xscale1 += xscaleDelta;
                        yscale1 += yscaleDelta;
                    }
                    
                    ClearBit();

                    Draw_Sea();
                }
                else
                {
                    l3-= 5;
                    ClearBit();

                    Draw_Sea();
                }
                
            }
        }

        private void button_Auto_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            if (f == true)
            {
                timer1.Start();
            }

            else
            {
                timer1.Stop();
            }
            f = !f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5);
            for (int i = 0; i <5; i++)
            {
                if (randomNumber == 1)
                {
                    l2 -= 5;
                    Draw_Boat();
                    if (bt2[1, 1] >= 442)
                    {
                        if (check_boat != false)
                        {
                            check_boat = !check_boat;
                        }

                        if (xscale2 >= 0.1)
                        {
                            xscale2 -= xscaleDelta;
                            xscale2 -= xscaleDelta;
                            yscale2 -= yscaleDelta;
                        }

                        ClearBit();

                        Draw_Sea();
                    }
                    else
                    {
                        l2 += 5;

                        ClearBit();

                        Draw_Sea();
                    }
                }
                else if (randomNumber == 2)
                {
                    k2 += 5;

                    Draw_Boat();

                    if (bt2[1, 0] <= 500)
                    {
                        if (check_boat != true)
                        {
                            check_boat = !check_boat;
                        }
                        ClearBit();

                        Draw_Sea();
                    }
                    else
                    {
                        k2 -= 5;

                        ClearBit();

                        Draw_Sea();
                    }
                }
                else if (randomNumber == 3)
                {
                    k2 -= 5;
                    Draw_Boat();
                    if (bt2[1, 0] >= 177)
                    {
                        if (check_boat != false)
                        {
                            check_boat = !check_boat;
                        }

                        ClearBit();

                        Draw_Sea();
                    }
                    else
                    {
                        k2 += 5;

                        ClearBit();

                        Draw_Sea();
                    }
                }
                else if (randomNumber == 4)
                {
                    l2 += 5;
                    Draw_Boat();
                    if (bt2[1, 1] <= 517)
                    {
                        if (check_boat != false)
                        {
                            check_boat = !check_boat;
                        }

                        xscale2 += xscaleDelta;
                        xscale2 += xscaleDelta;
                        yscale2 += yscaleDelta;
                        ClearBit();

                        Draw_Sea();
                    }
                    else
                    {
                        l2 -= 5;

                        ClearBit();

                        Draw_Sea();
                    }
                }
            }
            


            Random random2 = new Random();
            int randomNumber2 = random2.Next(1, 5);
            
            for (int j = 0; j < 5; j++)
            {
                if (randomNumber2 == 1)
                {
                    l3 -= 5;
                    check_bird = !check_bird;

                    if (xscale1 >= 0.1)
                    {
                        xscale1 -= xscaleDelta;
                        xscale1 -= xscaleDelta;
                        yscale1 -= yscaleDelta;
                    }

                    ClearBit();

                    Draw_Sea();
                }
                else if (randomNumber2 == 2)
                {
                    k3 += 5;
                    check_bird = !check_bird;
                    ClearBit();

                    Draw_Sea();
                }
                else if (randomNumber2 == 3)
                {
                    k3 -= 5;
                    check_bird = !check_bird;
                    ClearBit();

                    Draw_Sea();
                }
                else if (randomNumber2 == 4)
                {
                    l3 += 5;
                    Draw_Bird();
                    if (bd2[1, 1] <= 507)
                    {
                        check_bird = !check_bird;
                        if (xscale1 <= 2.1)
                        {
                            xscale1 += xscaleDelta;
                            xscale1 += xscaleDelta;
                            yscale1 += yscaleDelta;
                        }

                        ClearBit();

                        Draw_Sea();
                    }
                    else
                    {
                        l3 -= 5;
                        ClearBit();

                        Draw_Sea();
                    }
                }
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            Draw_Sea();
            radioButton_Auto.Visible = true;
            radioButton_Bird.Visible = true;
            radioButton_Boat.Visible = true;
            radioButton_Auto.Checked = true;
            button1.Visible = false;
            button2.Visible = true;

        }
    }
}
