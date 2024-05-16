using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// для работы с библиотекой OpenGL
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl
using Tao.Platform.Windows;
namespace CompGraph.View
{
    public partial class Grisha_Fourth_Work : UserControl
    {
        public Grisha_Fourth_Work()
        {
            InitializeComponent();
            // Инициализация контекста окна графического вывода
            Pr.InitializeContexts();
        }
        private void showSolid(int obj)
        {
            switch (obj)
            {
                case 1:
                    Glut.glutSolidCone(0.2, 0.75, 16, 8); break; // Конус
                case 2:
                    Glut.glutSolidCube(0.75); break; // Куб
                case 3:
                    Glut.glutSolidCylinder(0.2, 0.75, 16, 16); break;//Цилиндр 
                case 4:
                    Gl.glScaled(0.5, 0.5, 0.5);
                    Glut.glutSolidDodecahedron(); break; // Додекаэдр
                case 5:
                    Glut.glutSolidIcosahedron(); break; // Икосаэдр
                case 6:
                    Glut.glutSolidOctahedron(); break; // Октаэдр
                case 7:
                    Glut.glutSolidRhombicDodecahedron(); break; // Ромбический додекаэдр
                case 8:
                    double[] offset = { 0.0 };
                    Glut.glutSolidSierpinskiSponge(7, offset, 1); break; // Фрактал Губка Серпиского
                case 9:
                    Glut.glutSolidSphere(0.75, 16, 16); break; // Сфера
                case 10:
                    Glut.glutSolidTeapot(0.5); break; // Чайник
                case 11:
                    Gl.glRotated(180, 0, 1, 0);
                    Glut.glutSolidTetrahedron(); break; // Тетраэдр
                case 12:
                    Glut.glutSolidTorus(0.15, 0.65, 16, 16); break; // Тор
            }
        }
        private void draw(int obj)
        {
            // Очистка буфера цвета и буфера глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_ACCUM_BUFFER_BIT);
            // Матрица проецирования
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glRotated(-30, 1, 0, 0);
            Gl.glRotated(45, 0, 1, 0);
            // Видовая матрица
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            if (radioButton1.Checked)
            {
                // Белый цвет
                Gl.glColor3f(1, 1, 1);
                // Выводим glut-примитив в виде каркаса
                switch (obj)
                {
                    case 1:
                        Glut.glutWireCone(0.2, 0.75, 16, 8); break; // Конус
                    case 2:
                        Glut.glutWireCube(0.75); break; // Куб
                    case 3:
                        Glut.glutWireCylinder(0.2, 0.75, 16, 16); break; // Цилиндр
                    case 4:
                        Gl.glScaled(0.5, 0.5, 0.5);
                        Glut.glutWireDodecahedron(); break; // Додекаэдр
                    case 5:
                        Glut.glutWireIcosahedron(); break; // Икосаэдр
                    case 6:
                        Glut.glutWireOctahedron(); break; // Октаэдр
                    case 7:
                        Glut.glutWireRhombicDodecahedron(); break; // Ромбический додекаэдр
                    case 8:
                        double[] offset = { 0, 0, 0 };
                        Glut.glutWireSierpinskiSponge(7, offset, 1); break; // Фрактал Губка Серпиского
                    case 9:
                        Glut.glutWireSphere(0.75, 16, 16); break; // Сфера
                    case 10:
                        Glut.glutWireTeapot(0.5); break; // Чайник
                    case 11:
                        Gl.glRotated(180, 0, 1, 0);
                        Glut.glutWireTetrahedron(); break; // Тетраэдр
                    case 12:
                        Glut.glutWireTorus(0.15, 0.65, 16, 16); break; // Тор
                }
            }
            else if (radioButton2.Checked)
            {
                // Модель освещенности с одним источником цвета
                float[] light_position = { 10, 10, -30, 0 }; // Координаты источника света
                float[] lghtClr = { 1, 1, 1, 0 }; // Источник излучает белый цвет
                float[] mtClr = { 0, 1, 0, 0 }; // Материал зеленого цвета
                Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL); // Заливка полигонов
                Gl.glShadeModel(Gl.GL_SMOOTH); // Вывод с интерполяцией цветов
                Gl.glEnable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, lghtClr); // Рассеивание
                Gl.glEnable(Gl.GL_LIGHT0); // Включаем в уравнение освещенности источник GL_LIGHT0
                // Диффузионная компонента цвета материала
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mtClr);
                // Выводим тонированный glut-примитив
                showSolid(obj);
                Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            }
            Pr.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            draw(1); // Конус
        }
        private void button2_Click(object sender, EventArgs e)
        {
            draw(2); // Куб
        }
        private void button3_Click(object sender, EventArgs e)
        {
            draw(3); // Цилиндр
        }
        private void button4_Click(object sender, EventArgs e)
        {
            draw(4); // Додекаэдр
        }
        private void button5_Click(object sender, EventArgs e)
        {
            draw(5); // Икосаэдр
        }
        private void button6_Click(object sender, EventArgs e)
        {
            draw(6); // Октаэдр
        }
        private void button7_Click(object sender, EventArgs e)
        {
            draw(7); // Ромбический додекаэдр
        }
        private void button8_Click(object sender, EventArgs e)
        {
            draw(8); // Фрактал Губка Серпиского
        }
        private void button9_Click(object sender, EventArgs e)
        {
            draw(9); // Сфера
        }
        private void button10_Click(object sender, EventArgs e)
        {
            draw(10); // Чайник
        }
        private void button11_Click(object sender, EventArgs e)
        {
            draw(11); // Тетраэдр
        }
        private void button12_Click(object sender, EventArgs e)
        {
            draw(12); // Тор
        }
        private void Grisha_Fourth_Work_Load(object sender, EventArgs e)
        {
            // Черный цвет фона
            Gl.glClearColor(0, 0, 0, 1);
            // Инициализация Glut
            Glut.glutInit();
            // Используем в Glut систему цветов RGB, двойную буферизацию
            //(экранный и внеэкранный буферы) и буфер глубины
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            // Активизируем тест глубины
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }
    }
}
