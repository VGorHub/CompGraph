using System;
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
    public partial class VGor3 : UserControl
    {
        private int[,] bicycle = new int[12, 3]; // Массив для хранения координат велосипеда

        private int[,] spokes = new int[10, 3];
        private int[,] spokesZad = new int[5, 3];
        
        private int[,] pedals = new int[3, 3];

        private Timer timer; // Добавленный таймер
        Bitmap Bitmap { get; set; }
        int PBWidth, PBHeight;

        double[,] matr_sdv = new double[3, 3]; //матрица преобразования

        double[,] matr_sdv2 = new double[3, 3]; //матрица преобразования

        double[,] matr_sdv3 = new double[3, 3]; //матрица преобразования

        double[,] matr_sdv4 = new double[3, 3]; //матрица преобразования

        double[,] matr_sdv5 = new double[3, 3]; //матрица преобразования

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
        

        // Метод для инициализации таймера
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 25; // Интервал в миллисекундах (в данном случае 1 секунда)
            timer.Tick += Timer_Tick; // Обработчик события Tick таймера
            timer.Enabled = true; // Включение таймера
        }

        // Обработчик события Tick таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Увеличение значений k и l
            k += 5; // Например, на 10 каждый раз            
            // Перерисовка велосипеда
            fi += 10;
            ClearPictureBox();
            Draw_Bicycle();

        }
        private void ClearPictureBox()
        {
            Bitmap = new Bitmap(PBWidth, PBHeight);
            pictureBox1.Image = Bitmap;
        }
        public VGor3()
        {
            InitializeComponent();

        }

        //инициализация матрицы сдвига
        private void Init_matr_preob(ref double[,] matr_sdv, int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        private void Init_matr_preob_rotate(ref double[,] matr_sdv5, int k1, int l1,int F)
        {
            double Fi = F / 180.0 * Math.PI;
            matr_sdv5[0, 0] = Math.Cos(Fi); matr_sdv5[0, 1] = Math.Sin(Fi); matr_sdv5[0, 2] = 0;
            matr_sdv5[1, 0] = -Math.Sin(Fi); matr_sdv5[1, 1] = Math.Cos(Fi); matr_sdv5[1, 2] = 0;
            matr_sdv5[2, 0] = -k1*(Math.Cos(Fi)-1)+l1*(Math.Sin(Fi)); matr_sdv5[2, 1] = -k1 * (Math.Sin(Fi)) - l1 * (Math.Cos(Fi)-1); matr_sdv5[2, 2] = 1;

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

        private void Lab3VGor_Load(object sender, EventArgs e)
        {
            PBWidth = pictureBox1.Width;
            PBHeight = pictureBox1.Height;
            Bitmap = new Bitmap(PBWidth, PBHeight);
            k = PBWidth / 2; // Используем половину ширины PictureBox
            l = PBHeight / 2; // Используем половину высоты PictureBox
            Draw_Bicycle();
            InitializeTimer();
        }

        private void Init_bicycle()
        {
            // Координаты велосипеда: [x, y, 1]
            bicycle[0, 0] = -90; bicycle[0, 1] = 0; bicycle[0, 2] = 1; // Заднее колесо 
            bicycle[11, 0] = 60; bicycle[11, 1] = 0; bicycle[11, 2] = 1; // Переднее колесо
            bicycle[1, 0] = 30; bicycle[1, 1] = -30; bicycle[1, 2] = 1; // Переднее колесо              
            bicycle[2, 0] = -18; bicycle[2, 1] = -36; bicycle[2, 2] = 1; // сиденье
            bicycle[3, 0] = 36; bicycle[3, 1] = -48; bicycle[3, 2] = 1; // руль

            bicycle[4, 0] = -24; bicycle[4, 1] = -48; bicycle[4, 2] = 1; // сиденья 
            bicycle[5, 0] = -6; bicycle[5, 1] = -48; bicycle[5, 2] = 1; // Седло
            bicycle[6, 0] = -42; bicycle[6, 1] = -42; bicycle[6, 2] = 1; // Седло

            bicycle[7, 0] = 30; bicycle[7, 1] = -60; bicycle[7, 2] = 1; // руля
            bicycle[8, 0] = 48; bicycle[8, 1] = -66; bicycle[8, 2] = 1; // руль  
            bicycle[9, 0] = 0; bicycle[9, 1] = 6; bicycle[9, 2] = 1; // педалей

            bicycle[10, 0] = -120; bicycle[10, 1] = -30; bicycle[10, 2] = 1; // Заднее колесо 
        }

        private void Init_spokes()
        {
            
            spokes[5, 0] = 60; spokes[5, 1] = 0; spokes[5, 2] = 1; // Переднее колесо спица 
            spokes[6, 0] = 60; spokes[6, 1] = 30; spokes[6, 2] = 1; // Переднее колесо спица
            spokes[7, 0] = 60; spokes[7, 1] = -30; spokes[7, 2] = 1; // Переднее колесо спица 
            spokes[8, 0] = 30; spokes[8, 1] = 0; spokes[8, 2] = 1; //Переднее колесо спица 
            spokes[9, 0] = 90; spokes[9, 1] = 0; spokes[9, 2] = 1; //Переднее колесо спица 
        }
        private void Init_spokes_zad()
        {
            spokesZad[0, 0] = -90; spokesZad[0, 1] = 0; spokesZad[0, 2] = 1; // Заднее колесо 
            spokesZad[1, 0] = -90; spokesZad[1, 1] = -30; spokesZad[1, 2] = 1; // Заднее колесо спица
            spokesZad[2, 0] = -90; spokesZad[2, 1] = 30; spokesZad[2, 2] = 1; // Заднее колесо спица
            spokesZad[3, 0] = -120; spokesZad[3, 1] = 0; spokesZad[3, 2] = 1; // Заднее колесо спица
            spokesZad[4, 0] = -60; spokesZad[4, 1] = 0; spokesZad[4, 2] = 1; // Заднее колесо спица 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw_Bicycle();
        }

        private void Init_pedals()
        {
            pedals[0, 0] = 0; pedals[0, 1] = 6; pedals[0, 2] = 1; // педалей
            pedals[1, 0] = 12; pedals[1, 1] = 12; pedals[1, 2] = 1; // Педаль 1
            pedals[2, 0] = 24; pedals[2, 1] = 12; pedals[2, 2] = 1; // Педаль 2
        }

        private void Draw_Bicycle()
        {
            Init_bicycle();
            Init_spokes();
            Init_spokes_zad();
            Init_pedals();

            Init_matr_preob(ref matr_sdv, k, l);
            Init_matr_preob(ref matr_sdv2, k, l);
            Init_matr_preob(ref matr_sdv3, k, l);            
                    

            int[,] bicycle1 = Multiply_matr(bicycle, matr_sdv); 
            int[,] spokes2 = Multiply_matr(spokes, matr_sdv);
            int[,] spokesZad2 = Multiply_matr(spokesZad, matr_sdv);
            int[,] pedals2 = Multiply_matr(pedals, matr_sdv);

            Init_matr_preob_rotate(ref matr_sdv2, 60+k, 0+l, fi);
            Init_matr_preob_rotate(ref matr_sdv3, -90+k, 0 + l, fi);
            Init_matr_preob_rotate(ref matr_sdv4, 0 + k, 6 + l, fi);
            

            int[,] spokes1 = Multiply_matr(spokes2, matr_sdv2);
            int[,] spokesZad1 = Multiply_matr(spokesZad2, matr_sdv3);
            int[,] pedals1 = Multiply_matr(pedals2, matr_sdv4);

            Init_matr_preob_rotate(ref matr_sdv5, pedals1[1, 0], pedals1[1, 1], -fi);

            int[,] tempPedals1 = pedals1;
            int[,] tempPedals2 = Multiply_matr(tempPedals1, matr_sdv5);

            pedals1[2, 0] = tempPedals2[2,0];
            pedals1[2, 1] = tempPedals2[2,1];
            //int[,] bicycle1 = Multiply_matr(bicycle2, matr_sdv);


            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);

            // Отрисовка компонентов велосипеда
            int wheelSize = (int)(60 * xscale * xdisplay);

            for (int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 3; j++) 
                {
                    bicycle1[i,j] = bicycle1[i, j] % (PBWidth);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    spokesZad1[i, j] = spokesZad1[i, j] % (PBWidth);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    spokes1[i, j] = spokes1[i, j] % (PBWidth);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pedals1[i, j] = pedals1[i, j] % (PBWidth);
                }
            }

            // Отрисовка заднего колеса с учетом измененного размера
            g.DrawEllipse(myPen, bicycle1[10, 0], bicycle1[10, 1], wheelSize, wheelSize);

            // Отрисовка переднего колеса с учетом измененного размера
            g.DrawEllipse(myPen, bicycle1[1, 0], bicycle1[1, 1], wheelSize, wheelSize);

            g.DrawLine(myPen, bicycle1[0, 0], bicycle1[0, 1], bicycle1[2, 0], bicycle1[2, 1]);//зад колесо сиденье 
            g.DrawLine(myPen, bicycle1[2, 0], bicycle1[2, 1], bicycle1[3, 0], bicycle1[3, 1]);//сид руль
            g.DrawLine(myPen, bicycle1[3, 0], bicycle1[3, 1], bicycle1[9, 0], bicycle1[9, 1]);//руль пед
            
            g.DrawLine(myPen, bicycle1[9, 0], bicycle1[9, 1], bicycle1[0, 0], bicycle1[0, 1]);//пед зад
            g.DrawLine(myPen, bicycle1[9, 0], bicycle1[9, 1], bicycle1[4, 0], bicycle1[4, 1]);//пед сид
            g.DrawLine(myPen, bicycle1[4, 0], bicycle1[4, 1], bicycle1[5, 0], bicycle1[5, 1]);//
            g.DrawLine(myPen, bicycle1[4, 0], bicycle1[4, 1], bicycle1[6, 0], bicycle1[6, 1]);//
            g.DrawLine(myPen, bicycle1[11, 0], bicycle1[11, 1], bicycle1[7, 0], bicycle1[7, 1]);// перед колесо руль
            g.DrawLine(myPen, bicycle1[7, 0], bicycle1[7, 1], bicycle1[8, 0], bicycle1[8, 1]);//руль


            g.DrawLine(myPen, spokesZad1[0, 0], spokesZad1[0, 1], spokesZad1[1, 0], spokesZad1[1, 1]);
            g.DrawLine(myPen, spokesZad1[0, 0], spokesZad1[0, 1], spokesZad1[2, 0], spokesZad1[2, 1]);
            g.DrawLine(myPen, spokesZad1[0, 0], spokesZad1[0, 1], spokesZad1[3, 0], spokesZad1[3, 1]);
            g.DrawLine(myPen, spokesZad1[0, 0], spokesZad1[0, 1], spokesZad1[4, 0], spokesZad1[4, 1]);

            g.DrawLine(myPen, spokes1[5, 0], spokes1[5, 1], spokes1[6, 0], spokes1[6, 1]);
            g.DrawLine(myPen, spokes1[5, 0], spokes1[5, 1], spokes1[7, 0], spokes1[7, 1]);
            g.DrawLine(myPen, spokes1[5, 0], spokes1[5, 1], spokes1[8, 0], spokes1[8, 1]);
            g.DrawLine(myPen, spokes1[5, 0], spokes1[5, 1], spokes1[9, 0], spokes1[9, 1]);

            g.DrawLine(myPen, pedals1[0, 0], pedals1[0, 1], pedals1[1, 0], pedals1[1, 1]);
            g.DrawLine(myPen, pedals1[1, 0], pedals1[1, 1], pedals1[2, 0], pedals1[2, 1]);


            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
            pictureBox1.Image = Bitmap;

        }
    }
}