using System;
using System.Windows.Forms;
// для работы с библиотекой OpenGL
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl
using Tao.Platform.Windows;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompGraph.View
{
    public partial class testetst1 : Form
    {
        //Углы вращения
        public float X { get; set; } = 0f;
        public float Y { get; set; } = 0f;
        public float Z { get; set; } = 0f;

        public int CurrentObject { get; set; } = 1;


        public float Speed { get; set; } = 1f;

        public testetst1()
        {
            InitializeComponent();
            // Инициализация контекста окна графического вывода
            Pr.InitializeContexts();
            Glut.glutInit();

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

            // Поворачиваем по 3 углам
            Gl.glRotated(X, 1, 0, 0);
            Gl.glRotated(Y, 0, 1, 0);
            Gl.glRotated(Z, 0, 0, 1);

            // Видовая матрица
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            if (radioButton1.Checked)
            {
                // Устанавливаем цвет из трекбаров
                float r = trackBarR.Value / 255.0f;
                float g = trackBarG.Value / 255.0f;
                float b = trackBarB.Value / 255.0f;
                Gl.glColor3f(r, g, b);
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
                float[] light_position = { (float)numericUpDownLightX.Value, (float)numericUpDownLightY.Value, (float)numericUpDownLightZ.Value, 1 }; // Координаты источника света
                float[] lightColor = { 1, 1, 1, 1 };
                float[] ambientLight = { 0.2f, 0.2f, 0.2f, 1.0f }; // Слабое освещение
                float[] diffuseLight = { 1, 1, 1, 1 }; // Основной цвет света, который определяет основной цвет освещенных участков объекта.
                float[] specularLight = { 1, 1, 1, 1 }; // Цвет блика, который виден на поверхности объекта
                float[] lightAttenuation = { 1, 0.05f, 0 }; // Коэффициенты затухания света

                float r = trackBarR.Value / 255.0f;
                float g = trackBarG.Value / 255.0f;
                float b = trackBarB.Value / 255.0f;
                float[] mtClr = { r, g, b, 1 }; // Материал зеленого цвета

                float[] materialSpecular = { 1, 1, 1, 1 }; // Белый блик на материале
                float materialShininess = 50.0f; // Блеск материала

                Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL); // Заливка полигонов
                Gl.glShadeModel(Gl.GL_SMOOTH); // Вывод с интерполяцией цветов
                Gl.glEnable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность

                // Настройка источника света
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, ambientLight);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, diffuseLight);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, specularLight);
                Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_CONSTANT_ATTENUATION, lightAttenuation[0]);
                Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_LINEAR_ATTENUATION, lightAttenuation[1]);
                Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_QUADRATIC_ATTENUATION, lightAttenuation[2]);
                Gl.glEnable(Gl.GL_LIGHT0); // Включаем в уравнение освещенности источник GL_LIGHT0

                // Диффузионная компонента цвета материала
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mtClr);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, materialSpecular);
                Gl.glMaterialf(Gl.GL_FRONT, Gl.GL_SHININESS, materialShininess);
                // Выводим тонированный glut-примитив
                showSolid(obj);
                Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            }
            Pr.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentObject = 1;
            draw(CurrentObject);
            // Конус
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CurrentObject = 2;
            draw(CurrentObject); // Куб
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CurrentObject = 3;
            draw(CurrentObject); // Цилиндр
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CurrentObject = 4;
            draw(CurrentObject); // Додекаэдр
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CurrentObject = 5;
            draw(CurrentObject); // Икосаэдр
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CurrentObject = 6;
            draw(CurrentObject); // Октаэдр
        }
        private void button7_Click(object sender, EventArgs e)
        {
            CurrentObject = 7;
            draw(CurrentObject); // Ромбический додекаэдр
        }
        private void button8_Click(object sender, EventArgs e)
        {
            CurrentObject = 8;
            draw(CurrentObject); // Фрактал Губка Серпиского
        }
        private void button9_Click(object sender, EventArgs e)
        {
            CurrentObject = 9;
            draw(CurrentObject); // Сфера
        }
        private void button10_Click(object sender, EventArgs e)
        {
            CurrentObject = 10;
            draw(CurrentObject); // Чайник
        }
        private void button11_Click(object sender, EventArgs e)
        {
            CurrentObject = 11;
            draw(CurrentObject); // Тетраэдр
        }
        private void button12_Click(object sender, EventArgs e)
        {
            CurrentObject = 12;
            draw(CurrentObject); // Тор
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Черный цвет фона
            Gl.glClearColor(0, 0, 0, 1);
            // Инициализация Glut
            Glut.glutInit();
            // Используем в Glut систему цветов RGB, двойную буферизацию (экранный и внеэкранный буферы) и буфер глубины
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            // Активизируем тест глубины
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void numericUpDownLightX_ValueChanged(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }

        private void numericUpDownLightZ_ValueChanged(object sender, EventArgs e)
        {
            draw(CurrentObject);
        }
    }
}
