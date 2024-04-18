using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompGraph.View
{
    public partial class Grisha_3Laba_Tab : UserControl
    {
        double[,] hex = new double[6, 3]; // матрица тела
        double[,] hex1 = new double[6, 3]; // текущее тело
        double[,] matr_sdv = new double[3, 3]; //матрица преобразования

        double k, l, a, b, c, d, a1, b1, c1, d1; // элементы матрицы преобразования
        double kvx, kvy;
        private Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Orange, Color.Purple };
        private int colorIndex = 0;
        // наличие осей и фигуры
        bool axles = false;
        bool shape = false;

        bool f = true;
        private double angle = 0; // Угол поворота

        Timer timer = new Timer(); // Таймер для автоматического обновления

        public Grisha_3Laba_Tab()
        {
            InitializeComponent();
            // Настройка таймера
            timer.Interval = 10000; // Интервал в миллисекундах (здесь 1 секунда)
            timer.Tick += timer1_Tick; // Подписка на событие Tick
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Image logo = Properties.Resources.tusur_logo;

            Graphics g = pictureBox1.CreateGraphics();

            Font font = new Font("Arial", 20);
            Brush brush = new SolidBrush(Color.Black);

            g.DrawString("60 лет ТУСУР", font, brush, new Point(50, 50));
            g.DrawImage(logo, new Point(50, 100));
            g.Dispose();
        }

        private void Init_Hexagon()
        {
            // Инициализация матрицы координат шестиугольника
            hex[0, 0] = 0; hex[0, 1] = -50; hex[0, 2] = 1;
            hex[1, 0] = 43; hex[1, 1] = -25; hex[1, 2] = 1;
            hex[2, 0] = 43; hex[2, 1] = 25; hex[2, 2] = 1;
            hex[3, 0] = 0; hex[3, 1] = 50; hex[3, 2] = 1;
            hex[4, 0] = -43; hex[4, 1] = 25; hex[4, 2] = 1;
            hex[5, 0] = -43; hex[5, 1] = -25; hex[5, 2] = 1;
        }
        private void DrawHexagon(Color color)
        {

            Graphics g = pictureBox1.CreateGraphics();

            Pen myPen = new Pen(color, 2);

            // Найдем центр PictureBox
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            // Повернем каждую точку шестиугольника относительно его центра
            double[,] rotatedHexagon = new double[6, 2];
            for (int i = 0; i < 6; i++)
            {
                double x = hex[i, 0] + centerX;
                double y = hex[i, 1] + centerY;
                double rotatedX = (x - centerX) * Math.Cos(angle) - (y - centerY) * Math.Sin(angle) + centerX;
                double rotatedY = (x - centerX) * Math.Sin(angle) + (y - centerY) * Math.Cos(angle) + centerY;
                rotatedHexagon[i, 0] = rotatedX;
                rotatedHexagon[i, 1] = rotatedY;
            }

            // Отрисуем повернутый шестиугольник
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(myPen, (int)rotatedHexagon[i, 0], (int)rotatedHexagon[i, 1], (int)rotatedHexagon[i + 1, 0], (int)rotatedHexagon[i + 1, 1]);
            }
            g.DrawLine(myPen, (int)rotatedHexagon[5, 0], (int)rotatedHexagon[5, 1], (int)rotatedHexagon[0, 0], (int)rotatedHexagon[0, 1]);
            myPen.Dispose();
            g.Dispose();
        } 
        private void button4_Start_Click(object sender, EventArgs e)
        {
            shape = true;
            //середина pictureBox
            k = pictureBox1.Width / 2;
            kvx = k;
            l = pictureBox1.Height / 2;
            kvy = l;
            a = a1 = 1;
            b = b1 = 0;
            c = c1 = 0;
            d = d1 = 1;

            Init_Hexagon(); //инициализация матрицы тела
            hex1 = hex;
            // Рисуем шестиугольник
            DrawHexagon(Color.Black);

            k = 0;
            l = 0;
            timer1.Start(); // Запускаем таймер
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, что текст в textBox1 может быть преобразован в число
            if (double.TryParse(textBox1_Angle.Text, out double rotationAngle))
            {
                // Переводим угол из градусов в радианы
                double angleInRadians = rotationAngle * Math.PI / 180;

                // Устанавливаем угол поворота
                angle = angleInRadians;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init_Hexagon();
            Array.Copy(hex, hex1, hex.Length);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Увеличение размеров шестиугольника
            for (int i = 0; i < 6; i++)
            {
                hex[i, 0] *= 1.1; // Увеличение координаты x
                hex[i, 1] *= 1.1; // Увеличение координаты y
            }

            double cosAngle = Math.Cos(angle);
            double sinAngle = Math.Sin(angle);
            for (int i = 0; i < 6; i++)
            {
                double x = hex[i, 0];
                double y = hex[i, 1];
                hex[i, 0] = x * cosAngle - y * sinAngle;
                hex[i, 1] = x * sinAngle + y * cosAngle;
            }

            // Выбираем следующий цвет из массива
            Color nextColor = colors[(colorIndex + 1) % colors.Length];

            // Перерисовка шестиугольника с новым цветом
            DrawHexagon(nextColor);

            // Увеличиваем индекс цвета для следующего раза
            colorIndex = (colorIndex + 1) % colors.Length;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Останавливаем таймер

            // Создаем объект Graphics и очищаем PictureBox
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor = SystemColors.Control);
            g.Dispose();
        }
    }
}
