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
    public partial class LabSecond : UserControl
    {

        private int xn, yn, xk, yk;
        Bitmap myBitmap ; // объект Bitmap для вывода отрезка
        Color currentBorderColor = Color.Black ; // текущий цвет отрезка и текущий цвет заливки
        string currentPenStile = "Тонкая";

        public LabSecond()
        {
            InitializeComponent();
            comboBoxLineStyle.SelectedIndex =0;
            myBitmap = new Bitmap(pictureBox1.Width+200, pictureBox1.Height);
        }

        //ДОБАВЬТЕ СВОИ РАДИОБАТТОНЫ В ВАЛИДАЦИЮ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
                {
                    xn = e.X;
                    yn = e.Y;
                }
                else MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
            }
        }
        private Point GetCoordinatesOnPictureBox(MouseEventArgs e)
        {
            // Получаем координаты клика относительно контрола pictureBox1
            Point locationOnPictureBox = pictureBox1.PointToClient(e.Location);
            return locationOnPictureBox;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                //numberNodes – переменная, задающая количество узлов для
                //аппроксимации отрезка
                //xOutput – x-координата очередного узла
                //yOutput – y-координата очередного узла
                int index, numberNodes;
                double xOutput, yOutput, dx, dy;

                //Объявляем объект "myPen", задающий цвет и толщину пера
                Pen myPen = new Pen(currentBorderColor, 1);

                //Объявляем объект "g" класса Graphics и предоставляем
                //ему возможность рисования на pictureBox1:
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

                //реализация обычного алгоритма ЦДА
                xk = e.X;
                yk = e.Y;
                dx = xk - xn;
                dy = yk - yn;
                numberNodes = 200;
                xOutput = xn;
                yOutput = yn;
                for (index = 1; index <= numberNodes; index++)
                {
                    
                    PutPixel((int)xOutput, (int)yOutput,myPen, index);
                    xOutput = xOutput + dx / numberNodes;
                    yOutput = yOutput + dy / numberNodes;

                }
            }
            else if (radioButton3.Checked)
            {
                
                xk = e.X;
                yk = e.Y;
                
                DrawBresenhamLine(xn, yn, xk, yk);

            }
            else if (radioButton4.Checked)
            {
                xk = e.X;
                yk = e.Y;
                LineFill();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            //Задаем цвет пикселя по схеме RGB (от 0 до 255 для каждого цвета)

            Color newPixelColor = SystemColors.Control;

            for (int x = 0; x < myBitmap.Width; x++)
            {
                for (int y = 0; y < myBitmap.Height; y++)
                {
                    myBitmap.SetPixel(x, y, newPixelColor);
                }
            }
            pictureBox1.Image = myBitmap;
            // pictureBox1.Image = null;

        }
        private void DrawBresenhamLine(int xn, int yn, int xk, int yk)
        {
            int X = xn;
            int Y = yn;
            int Px = Math.Abs(xk - xn);
            int Py = Math.Abs(yk - yn);
            int stepX = Math.Sign(xk - xn);//возвращает знак разности между xk и xn.(-1 || 1 || 0)
            int stepY = Math.Sign(yk - yn);
            int E;
            Pen myPen = new Pen(currentBorderColor, 1);
            if (Py <= Px) // 0 <= |Py| <= |Px|
            {
                E = 2 * Py - Px;
                for (int i = 0; i <= Px; i++)
                {
                    PutPixel(X, Y,myPen,i); // Установка пикселя

                    if (E >= 0)
                    {
                        Y = Y + stepY;
                        E = E - 2 * Px;
                    }

                    X = X + stepX;
                    E = E + 2 * Py;
                }
            }
            else // |Py| > |Px|
            {
                E = 2 * Px - Py;
                for (int i = 0; i <= Py; i++)
                {
                    PutPixel(X, Y,myPen,i); // Установка пикселя

                    if (E >= 0)
                    {
                        X = X + stepX;
                        E = E - 2 * Py;
                    }

                    Y = Y + stepY;
                    E = E + 2 * Px;
                }
            }

        }


        private void PutPixel(int x, int y , Pen myPen,int counter = 0)
        {
            Graphics g = Graphics.FromImage(myBitmap);

            switch (currentPenStile)
            {
                case "Тонкая":

                    g.DrawRectangle(myPen, x, y, 1, 1);


                    break;
                case "Толстая":

                    //Рисуем прямоугольник
                    g.DrawRectangle(myPen, x, y, 5, 5);

                    //Рисуем закрашенный прямоугольник:
                    //Объявляем объект "redBrush", задающий цвет кисти
                    SolidBrush redBrush = new SolidBrush(currentBorderColor);

                    //Рисуем закрашенный прямоугольник
                    g.FillRectangle(redBrush, x, y, 5, 5);



                    break;
                case "Сплошная":

                    //Рисуем прямоугольник
                    g.DrawRectangle(myPen, x, y, 2, 2);


                    break;
                case "Пунктирная":
                    if (counter % 20 < 10)
                    {
                        g.DrawRectangle(myPen, x, y, 2, 2);
                    }
                    counter++;
                    break;

            }
            //передаем полученный растр mybitmap в элемент pictureBox
            pictureBox1.Image = myBitmap;
        }

        private void CDA(int xStart, int yStart, int xEnd, int yEnd)
        {
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;

            xn = xStart;
            yn = yStart;

            xk = xEnd;
            yk = yEnd;

            dx = xk - xn;
            dy = yk - yn;

            numberNodes = 200;

            xOutput = xn;
            yOutput = yn;

            for (index = 1; index <= numberNodes; index++)
            {
                myBitmap.SetPixel((int)xOutput, (int)yOutput,
               currentBorderColor);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }
        }
      


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK && radioButton1.Checked)
            {
                currentBorderColor = colorDialog1.Color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //отключаем кнопки
            button1.Enabled = false;
            button2.Enabled = false;

            //создаем новый экземпляр Bitmap размером с элемент pictureBox1 (myBitmap)
            //на нем выводим попиксельно отрезок
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
            {
                if (radioButton1.Checked == true)
                {
                    //рисуем прямоугольник
                    CDA(10, 10, 10, 110);
                    CDA(10, 10, 110, 10);
                    CDA(10, 110, 110, 110);
                    CDA(110, 10, 110, 110);

                    //рисуем треугольник
                    CDA(150, 10, 150, 200);
                    CDA(250, 50, 150, 200);
                    CDA(150, 10, 250, 150);
                }
                else
                {
                    if (radioButton2.Checked == true)
                    {
                        //получаем растр созданного рисунка в mybitmap
                        myBitmap = pictureBox1.Image as Bitmap;

                        // задаем координаты затравки
                        xn = 160;
                        yn = 40;

                        // вызываем рекурсивную процедуру заливки с затравкой
                        FloodFill(xn, yn);
                    }
                }
                //передаем полученный растр mybitmap в элемент pictureBox
                pictureBox1.Image = myBitmap;

                // обновляем pictureBox и активируем кнопки
                pictureBox1.Refresh();
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
        // Обработчик события для выбора стиля линии
        private void comboBoxLineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStyle = comboBoxLineStyle.SelectedItem.ToString();

            currentPenStile = selectedStyle;
        }

        //Заливка с затравкой
        private void FloodFill(int x1, int y1)
        {
            // получаем цвет текущего пикселя с координатами x1, y1
            Color oldPixelColor = myBitmap.GetPixel(x1, y1);

            // сравнение цветов происходит в формате RGB
            // для этого используем метод ToArgb объекта Color
            if ((oldPixelColor.ToArgb() != currentBorderColor.ToArgb())
            && (oldPixelColor.ToArgb() != Color.Green.ToArgb()))
            {
                //перекрашиваем пиксель
                myBitmap.SetPixel(x1, y1, Color.Green);

                //вызываем метод для 4-х соседних пикселей
                FloodFill(x1 + 1, y1);
                FloodFill(x1 - 1, y1);
                FloodFill(x1, y1 + 1);
                FloodFill(x1, y1 - 1);
            }
            else
            {
                //выходим из метода
                return;
            }

        }

        private void LineFill()
        {

            Stack<Point> pixels = new Stack<Point>();
            
            //Затравка в стек
            pixels.Push(new Point(xn, yn));

            //Задаём цвет заливки
            Color workColor = myBitmap.GetPixel(xn, yn);

            if (workColor == currentBorderColor)
            {
                return;
            }

            while (pixels.Count > 0)
            {
                //Достаём пиксель из стека
                Point xyr = pixels.Pop();

                if (myBitmap.GetPixel(xyr.X, xyr.Y) != workColor)
                {
                    continue;
                }

                //Для движения в другую сторону
                Point xyl = xyr;

                //Вправо
                do
                {
                    //Ставим пиксель
                    myBitmap.SetPixel(xyr.X, xyr.Y, currentBorderColor);

                    xyr.X = xyr.X + 1;

                } while (myBitmap.GetPixel(xyr.X, xyr.Y) == workColor);

                //Влево
                do
                {
                    //Ставим пиксель
                    myBitmap.SetPixel(xyl.X, xyl.Y, currentBorderColor);

                    xyl.X = xyl.X - 1;

                } while (myBitmap.GetPixel(xyl.X, xyl.Y) == workColor);

                //Поставлен ли пиксель в конце
                bool endIsPlace = false;

                //Ниже
                for (int x = xyl.X+1; x < xyr.X; x++)
                {
                    endIsPlace = false;
                    if (myBitmap.GetPixel(x, xyl.Y-1) == workColor)
                    {
                        if (myBitmap.GetPixel(x+1, xyl.Y - 1) != workColor)
                        {
                            pixels.Push(new Point(x, xyl.Y - 1));

                            endIsPlace = true;
                        }
                    }
                }
                if (myBitmap.GetPixel(xyr.X-1, xyl.Y - 1) == workColor & endIsPlace != true)
                {
                    pixels.Push(new Point(xyr.X-1, xyl.Y - 1));
                }

                //Выше
                for (int x = xyl.X + 1; x < xyr.X; x++)
                {
                    endIsPlace = false;
                    if (myBitmap.GetPixel(x, xyl.Y + 1) == workColor)
                    {
                        if (myBitmap.GetPixel(x + 1, xyl.Y + 1) != workColor)
                        {
                            pixels.Push(new Point(x, xyl.Y + 1));

                            endIsPlace = true;
                        }
                    }
                }
                if (myBitmap.GetPixel(xyr.X-1, xyl.Y + 1) == workColor & endIsPlace != true)
                {
                    pixels.Push(new Point(xyr.X-1, xyl.Y + 1));
                }
                
            }

            pictureBox1.Image = myBitmap;

        }

    }
}
