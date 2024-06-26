﻿using System;
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
    public partial class LabThird_10 : UserControl
    {

        double[,] ship = new double[4, 3]; // матрица тела
        double[,] ship1 = new double[4, 3]; // текущее тело 1
        double[,] ship2 = new double[4, 3]; // текущее тело 2
        double[,] matr_sdv = new double[3, 3]; // матрица преобразования

        double k, l, a, b, c, d; // элементы матрицы преобразования

        int angle1 = 0;
        int angle2 = 0;

        Bitmap myBitmap;

        public LabThird_10()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width + 200, pictureBox1.Height);
            Generate();
            
        }

        //Инициализация формы корабля
        private void Init_Ship()
        {
            ship[0, 0] = 0; ship[0, 1] = -30; ship[0, 2] = 1;
            ship[1, 0] = 20; ship[1, 1] = 20; ship[1, 2] = 1;
            ship[2, 0] = 0; ship[2, 1] = 0; ship[2, 2] = 1;
            ship[3, 0] = -20; ship[3, 1] = 20; ship[3, 2] = 1;
        }

        //инициализация матрицы сдвига
        private void Init_matr_preob(double k1, double l1, double a1, double b1, double c1, double d1)
        {
            matr_sdv[0, 0] = a1; matr_sdv[0, 1] = b1; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = c1; matr_sdv[1, 1] = d1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        //Обнуление матрицы преобразования
        private void Clear_matr_preob()
        {
            k = l = b = c = 0;
            a = d = 1;

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

        //вывод квадрата на экран
        private void Draw_Ship(ref double[,] kv1)
        {
            Init_matr_preob(k, l, a, b, c, d); //инициализация матрицы преобразования

            kv1 = Multiply_matr(kv1, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, (int)kv1[0, 0], (int)kv1[0, 1], (int)kv1[1, 0], (int)kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, (int)kv1[1, 0], (int)kv1[1, 1], (int)kv1[2, 0], (int)kv1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, (int)kv1[2, 0], (int)kv1[2, 1], (int)kv1[3, 0], (int)kv1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, (int)kv1[3, 0], (int)kv1[3, 1], (int)kv1[0, 0], (int)kv1[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = myBitmap;

        }

        private void Draw_Planet()
        {
            Pen myPen = new Pen(Color.Green, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(myBitmap);

            // Указываем центр и радиус планеты
            int centerX = myBitmap.Width / 2;
            int centerY = myBitmap.Height / 2;
            int radius = 50;

            // Рисуем планету
            g.DrawEllipse(myPen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = myBitmap;

        }

        //Создание сцены
        private void Generate()
        {
            Clear_matr_preob();

            Draw_Planet(); //инициализация планеты

            //вывод кораблей
            Init_Ship();

            ship1 = ship;
            ship2 = ship;

            k = myBitmap.Width / 2 + 150;
            l = myBitmap.Height / 2 - 40;

            Draw_Ship(ref ship1);

            k = myBitmap.Width / 2 + 200;
            l = myBitmap.Height / 2 - 40;

            Draw_Ship(ref ship2);

            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(myBitmap);

            g.Clear(SystemColors.Control);

            Clear_matr_preob();
                        
            //Сдвиг к началу координат
            k = myBitmap.Width / -2;
            l = myBitmap.Height / -2 + 40;

            Draw_Ship(ref ship1);
            Draw_Ship(ref ship2);

            Clear_matr_preob();

            ////////////////////////////////////////////////

            //Преобразования первого корабля
            //Поворот
            a = Math.Cos(-5 * Math.PI / 180);
            b = Math.Sin(-5 * Math.PI / 180);
            c = 0 - Math.Sin(-5 * Math.PI / 180);
            d = Math.Cos(-5 * Math.PI / 180);

            angle1 += 5;

            Draw_Ship(ref ship1);

            Clear_matr_preob();

            //Изменение размера
            if (angle1 >= 360) { angle1 -= 360; }
            if ((angle1 >= 0 && angle1 < 80) || angle1 >= 280)
            {
                a = 1 / 1.02;
                d = 1 / 1.02;
            }
            else if (angle1 >= 100 && angle1 < 260)
            {
                a = 1.02;
                d = 1.02;
            }

            Draw_Ship(ref ship1);

            Clear_matr_preob();

            /////////////////////////////////////////////

            //Преобразования второго корабля
            //Поворот
            a = Math.Cos(-4 * Math.PI / 180);
            b = Math.Sin(-4 * Math.PI / 180);
            c = 0 - Math.Sin(-4 * Math.PI / 180);
            d = Math.Cos(-4 * Math.PI / 180);

            angle2 += 4;

            Draw_Ship(ref ship2);

            Clear_matr_preob();

            //Изменение размера
            if (angle2 >= 360) { angle2 -= 360; }
            if ((angle2 >= 0 && angle2 < 80) || angle2 >= 280)
            {
                a = 1 / 1.02;
                d = 1 / 1.02;
            }
            else if (angle2 >= 100 && angle2 < 260)
            {
                a = 1.02;
                d = 1.02;
            }

            Draw_Ship(ref ship2);

            Clear_matr_preob();

            //////////////////////////////////////

            //Отрисовка нового кадра
            g.Clear(SystemColors.Control);

            Draw_Planet();

            k = myBitmap.Width / 2;
            l = myBitmap.Height / 2 - 40;

            Draw_Ship(ref ship1);
            Draw_Ship(ref ship2);

            Clear_matr_preob();

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = myBitmap;

        }
    }
}
