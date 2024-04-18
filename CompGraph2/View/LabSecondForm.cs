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
    public partial class LabSecondForm : Form
    {
        public int xn, yn, xk, yk;

        public LabSecondForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //numberNodes – переменная, задающая количество узлов для
            //аппроксимации отрезка
            //xOutput – x-координата очередного узла
            //yOutput – y-координата очередного узла
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;
            //Объявляем объект "myPen", задающий цвет и толщину пера 
            Pen myPen = new Pen(Color.Red, 1);            
             //Объявляем объект "g" класса Graphics и предоставляем
             //ему возможность рисования на pictureBox1:
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
                //Рисуем прямоугольник
                //Рисуем закрашенный прямоугольник:
                //Объявляем объект "redBrush", задающий цвет кисти
                // SolidBrush redBrush = new SolidBrush(Color.Red);
                //Рисуем закрашенный прямоугольник
                // g.FillRectangle(redBrush, (int)xOutput, (int)yOutput, 2, 2);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }

        }        

    }
}
