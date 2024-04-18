using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraph.View
{
    public partial class LabThirdForm : Form
    {

        int[,] kv = new int[4, 3]; // матрица тела
        int[,] figur = new int[6, 3];
        int[,] osi = new int[4, 3]; // матрица координат осей
        Bitmap Bitmap { get; set; }
        int PBWidth, PBHeight;
        double[,] matr_sdv = new double[3, 3]; //матрица преобразования
        bool flagXY = false;
        int k, l; // элементы матрицы сдвига

        bool f = true;
        int fi = 0;
        double xscale = 1;
        double yscale = 1;

        double xscaleDelta = 0.1;
        double yscaleDelta = 0.1;

        double xdisplay = 1;
        double ydisplay = 1;

        double Fi
        {
            get
            {
                return fi / 180.0 * Math.PI;
            }
        }

        public LabThirdForm()
        {
            InitializeComponent();
        }

        //инициализация матрицы тела
        private void Init_kvadrat()
        {
            //kv[0, 0] = -50; kv[0, 1] = 0; kv[0, 2] = 1;
            //kv[1, 0] = 0; kv[1, 1] = 50; kv[1, 2] = 1;
            //kv[2, 0] = 50; kv[2, 1] = 0; kv[2, 2] = 1;
            //kv[3, 0] = 0; kv[3, 1] = -50; kv[3, 2] = 1;
            figur[0, 0] = 45; figur[0, 1] = -40; figur[0, 2] = 1;
            figur[1, 0] = 10; figur[1, 1] = 40; figur[1, 2] = 1;
            figur[2, 0] = 10; figur[2, 1] = 20; figur[2, 2] = 1;
            figur[3, 0] = -10; figur[3, 1] = 20; figur[3, 2] = 1;
            figur[4, 0] = -10; figur[4, 1] = 40; figur[4, 2] = 1;
            figur[5, 0] = -45; figur[5, 1] = -40; figur[5, 2] = 1;
        }
       private void Init_figur()
        {
            figur[0, 0] = 45; figur[0, 1] = -40; figur[0, 2] = 1;
            figur[1, 0] = 10; figur[1, 1] = 40; figur[1, 2] = 1;
            figur[2, 0] = 10; figur[2, 1] = 20; figur[2, 2] = 1;
            figur[3, 0] = -10; figur[3, 1] = 20; figur[3, 2] = 1;
            figur[4, 0] = -10; figur[4, 1] = 40; figur[4, 2] = 1;
            figur[5, 0] = -45; figur[5, 1] = -40; figur[5, 2] = 1;
        }

        //инициализация матрицы сдвига
        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }
        private void Init_matr_preob_scale(int k1, int l1)
        {
            matr_sdv[0, 0] = xscale * xdisplay; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = yscale * ydisplay; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        private void Init_matr_preob_rotate(int k1, int l1)
        {
            matr_sdv[0, 0] = Math.Cos(Fi); matr_sdv[0, 1] = Math.Sin(Fi); matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = -Math.Sin(Fi); matr_sdv[1, 1] = Math.Cos(Fi); matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = 0; matr_sdv[2, 1] = 0; matr_sdv[2, 2] = 1;

        }

        //инициализация матрицы осей
        private void Init_osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;

        }

        //умножение матриц
        private int[,] Multiply_matr(int[,] a, double[,] b)
        {
            int n = a.GetLength(0);
            int m = b.GetLength(1);
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

        //вывод квадратика в центре pictureBox
        private void button2_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;

            //вывод квадратика в середине
            Draw_Kv();
        }
        private void Draw_Figur()
        {
            Init_figur();
            Init_matr_preob(k,l);

            int[,] figur1 = Multiply_matr(figur, matr_sdv);

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);

            // рисуем 1 сторону 
            g.DrawLine(myPen, figur1[0, 0], figur1[0, 1], figur1[1, 0], figur1[1, 1]);
            // рисуем 2 сторону 
            g.DrawLine(myPen, figur1[1, 0], figur1[1, 1], figur1[2, 0], figur1[2, 1]);
            // рисуем 3 сторону 
            g.DrawLine(myPen, figur1[2, 0], figur1[2, 1], figur1[3, 0], figur1[3, 1]);
            // рисуем 4 сторону 
            g.DrawLine(myPen, figur1[3, 0], figur1[3, 1], figur1[4, 0], figur1[4, 1]);

            g.DrawLine(myPen, figur1[4, 0], figur1[4, 1], figur1[5, 0], figur1[5, 1]);

            g.DrawLine(myPen, figur1[5, 0], figur1[5, 1], figur1[0, 0], figur1[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = Bitmap;
        }

        //вывод квадрата на экран
        private void Draw_Kv()
        {

            //Init_kvadrat(); //инициализация матрицы тела
            //Init_matr_preob(k, l); //инициализация матрицы преобразования

            //int[,] kv1 = Multiply_matr(kv, matr_sdv); //перемножение матриц

            //Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            ////создаем новый объект Graphics (поверхность рисования) из pictureBox
            //Graphics g = Graphics.FromImage(Bitmap);

            //// рисуем 1 сторону квадрата
            //g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            //// рисуем 2 сторону квадрата
            //g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            //// рисуем 3 сторону квадрата
            //g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            //// рисуем 4 сторону квадрата
            //g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);

            //g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            //myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            //pictureBox1.Image = Bitmap;
            Init_figur();
            Init_matr_preob(k, l);

            Init_matr_preob_rotate(k, l);
            int[,] figur2 = Multiply_matr(figur, matr_sdv);
            if (flagXY)
            {
                double[,] displayXY = new double[3, 3];
                displayXY[0, 0] = 0; displayXY[0, 1] = 1; displayXY[0, 2] = 0;
                displayXY[1, 0] = 1; displayXY[1, 1] = 0; displayXY[1, 2] = 0;
                displayXY[2, 0] = 0; displayXY[2, 1] = 0; displayXY[2, 2] = 1;
                figur2 = Multiply_matr(figur2, displayXY);
                
            }
            
            Init_matr_preob_scale(k, l);
            int[,] figur1 = Multiply_matr(figur2, matr_sdv);







            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);

            // рисуем 1 сторону 
            g.DrawLine(myPen, figur1[0, 0], figur1[0, 1], figur1[1, 0], figur1[1, 1]);
            // рисуем 2 сторону 
            g.DrawLine(myPen, figur1[1, 0], figur1[1, 1], figur1[2, 0], figur1[2, 1]);
            // рисуем 3 сторону 
            g.DrawLine(myPen, figur1[2, 0], figur1[2, 1], figur1[3, 0], figur1[3, 1]);
            // рисуем 4 сторону 
            g.DrawLine(myPen, figur1[3, 0], figur1[3, 1], figur1[4, 0], figur1[4, 1]);

            g.DrawLine(myPen, figur1[4, 0], figur1[4, 1], figur1[5, 0], figur1[5, 1]);

            g.DrawLine(myPen, figur1[5, 0], figur1[5, 1], figur1[0, 0], figur1[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = Bitmap;

        }

        //вывод осей в центре pictureBox
        private void button1_Click(object sender, EventArgs e)
        {
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            Draw_osi();
        }

        //сдвиг вправо
        private void button4_Click(object sender, EventArgs e)
        {
            k += 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();

        }

        //непрерывное перемещение
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            button8.Text = "Стоп";
            if (f == true)
                timer1.Start();
            else
            {
                timer1.Stop();
                button8.Text = "Старт";
            }
            f = !f;

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            k++;
            Draw_Kv();
            Thread.Sleep(100);

        }
        private void ClearPictureBox()
        {
            Bitmap = new Bitmap(PBWidth, PBHeight);
            pictureBox1.Image = Bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            l = 0;
            k = 0;

            f = true;
            fi = 0;
            xscale = 1;
            yscale = 1;

            xscaleDelta = 0.1;
            yscaleDelta = 0.1;

            xdisplay = 1;
            ydisplay = 1;

        }

        private void LabThirdForm_Load(object sender, EventArgs e)
        {
            PBWidth = pictureBox1.Width;
            PBHeight = pictureBox1.Height;
            Bitmap = new Bitmap(PBWidth, PBHeight);
        }
        //сдвиг влево
        private void button5_Click(object sender, EventArgs e)
        {
            k -= 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }
        //сдвиг вниз
        private void button6_Click(object sender, EventArgs e)
        {
            l += 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }
        //сдвиг вверх
        private void button7_Click(object sender, EventArgs e)
        {
            l -= 1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            xdisplay *= -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ydisplay *= -1;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            yscale += yscaleDelta;
            ClearPictureBox();
            Draw_osi(); Draw_Kv();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            xscale += xscaleDelta;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (yscale - yscaleDelta > 0)
            {
                yscale -= yscaleDelta;
                ClearPictureBox();
                Draw_osi();
                Draw_Kv();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (xscale - xscaleDelta > 0)
            {
                xscale -= xscaleDelta;
                ClearPictureBox();
                Draw_osi();
                Draw_Kv();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fi += 10;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            fi -= 10;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            flagXY = !flagXY;
            ClearPictureBox();
            Draw_osi();
            Draw_Kv();
            
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;

            //вывод квадратика в середине
            Draw_Figur();
        }



        //вывод осей на экран
        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(PBWidth / 2, PBHeight / 2);

            int[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 1);// цвет линии и ширина
            Graphics g = Graphics.FromImage(Bitmap);

            // рисуем ось ОХ
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);

            // рисуем ось ОУ
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);

            g.Dispose();
            myPen.Dispose();

            pictureBox1.Image = Bitmap;
        }




    }
}
