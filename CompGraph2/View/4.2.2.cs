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
	public partial class _4 : UserControl
	{
		double[,] tetrahedron = new double[4, 4]; // матрица тела

		double[,] matr_preob = new double[4, 4]; // матрица преобразования

		double[,] osi = new double[4, 4]; // оси координат

		double[,] rotateOs = new double[2, 4]; // ось вращения

		double[] cameraNormal = new double[4];

		bool[,] edgeIsVisible = new bool[4, 4];

		double angle = 0; // Угол поворота

		// Элементы матрицы преобразования
		double l, m, n, // Сдвиг
		a, b, c, d, e, f, h, i, j; // Масштаб

		Bitmap myBitmap;


		public _4()
		{
			InitializeComponent();
			myBitmap = new Bitmap(pictureBox1.Width + 200, pictureBox1.Height);
			Generate();
		}

		///////////////////////////////////////////////////////// Инициализация

		//Инициализация формы фигуры
		private void Init_Tetrahedron()
		{
			tetrahedron[0, 0] = 0; tetrahedron[0, 1] = 0; tetrahedron[0, 2] = -37.5;  tetrahedron[0, 3] = 1;
			tetrahedron[1, 0] = -37.5; tetrahedron[1, 1] = 25; tetrahedron[1, 2] = 37.5; tetrahedron[1, 3] = 1;
			tetrahedron[2, 0] = 37.5; tetrahedron[2, 1] = 25; tetrahedron[2, 2] = 37.5; tetrahedron[2, 3] = 1;
			tetrahedron[3, 0] = 0; tetrahedron[3, 1] = -50; tetrahedron[3, 2] = 37.5; tetrahedron[3, 3] = 1;
		}

		//инициализация матрицы сдвига
		private void Init_matr_preob()
		{
			matr_preob[0, 0] = a; matr_preob[0, 1] = b; matr_preob[0, 2] = c; matr_preob[0, 3] = 0;
			matr_preob[1, 0] = d; matr_preob[1, 1] = e; matr_preob[1, 2] = f; matr_preob[1, 3] = 0;
			matr_preob[2, 0] = h; matr_preob[2, 1] = i; matr_preob[2, 2] = j; matr_preob[2, 3] = 0;
			matr_preob[3, 0] = l; matr_preob[3, 1] = m; matr_preob[3, 2] = n; matr_preob[3, 3] = 1;
		}

		//инициализация осей
		private void Init_Osi()
		{
			osi[0, 0] = 0; osi[0, 1] = 0; osi[0, 2] = 0; osi[0, 3] = 1;
			osi[1, 0] = 100; osi[1, 1] = 0; osi[1, 2] = 0; osi[1, 3] = 1;
			osi[2, 0] = 0; osi[2, 1] = 100; osi[2, 2] = 0; osi[2, 3] = 1;
			osi[3, 0] = 0; osi[3, 1] = 0; osi[3, 2] = 100; osi[3, 3] = 1;
		}

		//инициализация матрицы сдвига
		private void Init_rotate_os()
		{
			rotateOs[0, 0] = -50; rotateOs[0, 1] = -50; rotateOs[0, 2] = -50; rotateOs[0, 3] = 1;
			rotateOs[1, 0] = 50; rotateOs[1, 1] = 50; rotateOs[1, 2] = 50; rotateOs[1, 3] = 1;

		}

		//инициализация рёбер
		private void Init_Edges()
		{
			edgeIsVisible[0, 0] = false; edgeIsVisible[0, 1] = false; edgeIsVisible[0, 2] = false; edgeIsVisible[0, 3] = false;
			edgeIsVisible[1, 0] = false; edgeIsVisible[1, 1] = false; edgeIsVisible[1, 2] = false; edgeIsVisible[1, 3] = false;
			edgeIsVisible[2, 0] = false; edgeIsVisible[2, 1] = false; edgeIsVisible[2, 2] = false; edgeIsVisible[2, 3] = false;
			edgeIsVisible[3, 0] = false; edgeIsVisible[3, 1] = false; edgeIsVisible[3, 2] = false; edgeIsVisible[3, 3] = false;
		}

		//инициализация нормали камеры
		private void Init_Cam_Normal()
		{
			cameraNormal[0] = -37.797; cameraNormal[1] = 32.732260035; cameraNormal[2] = 86.6003666898;
		}

		//Обнуление матрицы преобразования
		private void Clear_matr_preob()
		{
			l = m = n = b = c = d = f = h = i = 0;
			a = e = j = 1;
		}

		/////////////////////////////////////////////////////////

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

		//векторное умножение векторов
		public double[] CrossMultiply(double[] v1, double[] v2)
		{

			double[] result = new double[3];

			result[0] = v1[1] * v2[2] - v1[2] * v2[1];
			result[1] = v1[2] * v2[0] - v1[0] * v2[2];
			result[2] = v1[0] * v2[1] - v1[1] * v2[0];

			return result;
		}

		//скалярное произведение векторов
		public double Multiply_Vector(double[] v1, double[] v2)
		{
			double result = 0;
			for (int i = 0; i < 3; ++i)
				result += v1[i] * v2[i];
			return result;
		}

		//проверка угла между векторами
		bool faceIsVisible(double[] v1, double[] v2)
		{
			double mod_v1 = Math.Sqrt((v1[0] * v1[0]) + (v1[1] * v1[1]) + (v1[2] * v1[2]));
			double mod_v2 = Math.Sqrt((v2[0] * v2[0]) + (v2[1] * v2[1]) + (v2[2] * v2[2])); 

			double cos = Multiply_Vector(v1, v2) / (mod_v1 * mod_v2);

			return (cos > 0);
			
		}

		///////////////////////////////////////////////////////// Отрисовка фигуры

		//отрисовка фигуры без вида
		private void Draw_Tetrahedron(ref double[,] shape)
		{
			Init_matr_preob(); //инициализация матрицы преобразования

			shape = Multiply_matr(shape, matr_preob); //перемножение матриц

			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 4; j++)
				{
					Line(shape[i, 0], shape[i, 1], shape[j, 0], shape[j, 1], Color.DarkBlue, 3);
				}

			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			pictureBox1.Image = myBitmap;

		}

		//вывод фигуры на экран
		private void Draw_ViewVisibleTetrahedron(ref double[,] shape)
		{
			///////////////////////////// перемещение в 0,0

			Clear_matr_preob();

			l = -250;
			m = -200;

			Init_matr_preob(); //инициализация матрицы преобразования

			var viewShape = Multiply_matr(shape, matr_preob); //перемножение матриц

			Clear_matr_preob();

			/////////////////////////////

			double alfa = 22.208;
			double beta = 20.705;

			a = Math.Cos(alfa * Math.PI / 180);
			b = Math.Sin(alfa * Math.PI / 180) * Math.Sin(beta * Math.PI / 180);
			e = Math.Cos(beta * Math.PI / 180);
			h = Math.Sin(alfa * Math.PI / 180);
			i = -Math.Cos(alfa * Math.PI / 180) * Math.Sin(beta * Math.PI / 180);
			j = 0;

			Init_matr_preob();

			viewShape = Multiply_matr(viewShape, matr_preob); //перемножение матриц

			Clear_matr_preob();

			///////////////////////////// возвращение обратно

			l = 250;
			m = 200;

			Init_matr_preob(); //инициализация матрицы преобразования

			viewShape = Multiply_matr(viewShape, matr_preob); //перемножение матриц

			Clear_matr_preob();

			/////////////////////////////
			

			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 4; j++)
				{
					if (edgeIsVisible[i,j])
					{
						Line(viewShape[i, 0], viewShape[i, 1], viewShape[j, 0], viewShape[j, 1], Color.DarkBlue, 3);
					}

				}

			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			pictureBox1.Image = myBitmap;

		}

		//вывод фигуры на экран
		private void Draw_ViewInvisibleTetrahedron(ref double[,] shape)
		{
			///////////////////////////// перемещение в 0,0

			Clear_matr_preob();

			l = -250;
			m = -200;

			Init_matr_preob(); //инициализация матрицы преобразования

			var viewShape = Multiply_matr(shape, matr_preob); //перемножение матриц

			Clear_matr_preob();

			/////////////////////////////

			double alfa = 22.208;
			double beta = 20.705;

			a = Math.Cos(alfa * Math.PI / 180);
			b = Math.Sin(alfa * Math.PI / 180) * Math.Sin(beta * Math.PI / 180);
			e = Math.Cos(beta * Math.PI / 180);
			h = Math.Sin(alfa * Math.PI / 180);
			i = -Math.Cos(alfa * Math.PI / 180) * Math.Sin(beta * Math.PI / 180);
			j = 0;

			Init_matr_preob();

			viewShape = Multiply_matr(viewShape, matr_preob); //перемножение матриц

			Clear_matr_preob();

			///////////////////////////// возвращение обратно

			l = 250;
			m = 200;

			Init_matr_preob(); //инициализация матрицы преобразования

			viewShape = Multiply_matr(viewShape, matr_preob); //перемножение матриц

			Clear_matr_preob();

			/////////////////////////////


			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 4; j++)
				{
					if (!edgeIsVisible[i, j])
					Line(viewShape[i, 0], viewShape[i, 1], viewShape[j, 0], viewShape[j, 1], Color.DarkBlue, 1, true);
				}

			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			pictureBox1.Image = myBitmap;

		}

		///////////////////////////////////////////////////////// Отрисовка осей

		//Отрисовка системы координат
		private void Draw_Osi()
		{
			Init_matr_preob(); //инициализация матрицы преобразования

			//перемножение матриц для сдвига
			osi = Multiply_matr(osi, matr_preob);

			rotateOs = Multiply_matr(rotateOs, matr_preob);

			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			Line(osi[0, 0], osi[0, 1], rotateOs[0, 0], rotateOs[0, 1], Color.Gray, 1);

			Line(osi[0, 0], osi[0, 1], osi[1, 0], osi[1, 1], Color.Green, 1);
			Line(osi[0, 0], osi[0, 1], osi[2, 0], osi[2, 1], Color.Blue, 1);
			Line(osi[0, 0], osi[0, 1], osi[3, 0], osi[3, 1], Color.Red, 1);

			Line(osi[0, 0], osi[0, 1], rotateOs[1, 0], rotateOs[1, 1], Color.Gray, 1);


			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			pictureBox1.Image = myBitmap;
		}

		//Отрисовка системы координат
		private void Draw_ViewOsi()
		{
			///////////////////////////// перемещение в 0,0

			Clear_matr_preob();

			l = -250;
			m = -200;

			Init_matr_preob(); //инициализация матрицы преобразования

			var viewOsi = Multiply_matr(osi, matr_preob); //перемножение матриц
			var viewRotateOs = Multiply_matr(rotateOs, matr_preob); //перемножение матриц

			Clear_matr_preob();

			/////////////////////////////

			double alfa = 22.208;
			double beta = 20.705;

			a = Math.Cos(alfa * Math.PI / 180);
			b = Math.Sin(alfa * Math.PI / 180) * Math.Sin(beta * Math.PI / 180);
			e = Math.Cos(beta * Math.PI / 180);
			h = Math.Sin(alfa * Math.PI / 180);
			i = -Math.Cos(alfa * Math.PI / 180) * Math.Sin(beta * Math.PI / 180);

			Init_matr_preob();

			viewOsi = Multiply_matr(viewOsi, matr_preob); //перемножение матриц
			viewRotateOs = Multiply_matr(viewRotateOs, matr_preob); //перемножение матриц

			Clear_matr_preob();

			///////////////////////////// возвращение обратно

			l = 250;
			m = 200;

			Init_matr_preob(); //инициализация матрицы преобразования

			viewOsi = Multiply_matr(viewOsi, matr_preob); //перемножение матриц
			viewRotateOs = Multiply_matr(viewRotateOs, matr_preob); //перемножение матриц

			Clear_matr_preob();

			/////////////////////////////
			


			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			Line(viewOsi[0, 0], viewOsi[0, 1], viewRotateOs[0, 0], viewRotateOs[0, 1], Color.DarkGray, 3);

			Line(viewOsi[0, 0], viewOsi[0, 1], viewOsi[1, 0], viewOsi[1, 1], Color.Green, 2);
			Line(viewOsi[0, 0], viewOsi[0, 1], viewOsi[2, 0], viewOsi[2, 1], Color.Blue, 2);
			Line(viewOsi[0, 0], viewOsi[0, 1], viewOsi[3, 0], viewOsi[3, 1], Color.Red, 2);

			Line(viewOsi[0, 0], viewOsi[0, 1], viewRotateOs[1, 0], viewRotateOs[1, 1], Color.DarkGray, 3);


			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			pictureBox1.Image = myBitmap;
		}

		///////////////////////////////////////////////////////// Кадры

		//Генерация кадра
		private void Generate()
		{
			Init_Edges();

			Init_Tetrahedron();

			Init_Osi();

			Init_rotate_os();

			Init_Cam_Normal();

			Clear_matr_preob();

			l = 250;
			m = 200;

			Draw_Osi();

			Draw_Tetrahedron(ref tetrahedron);

			Clear_matr_preob();

			Timer_Tick(new object(), new EventArgs());

		}

		private void Timer_Tick(object sender, EventArgs ea)
		{
			Clear_matr_preob();

			l = -250;
			m = -200;

			Draw_Tetrahedron(ref tetrahedron);

			Clear_matr_preob();

			//////////

			e = Math.Cos(angle * Math.PI / 180);
			f = Math.Sin(angle * Math.PI / 180);
			i = -Math.Sin(angle * Math.PI / 180);
			j = Math.Cos(angle * Math.PI / 180);

			Draw_Tetrahedron(ref tetrahedron);
			Clear_matr_preob();

			//////////

			a = Math.Cos(angle * Math.PI / 180);
			c = -Math.Sin(angle * Math.PI / 180);
			h = Math.Sin(angle * Math.PI / 180);
			j = Math.Cos(angle * Math.PI / 180);

			Draw_Tetrahedron(ref tetrahedron);
			Clear_matr_preob();

			//////////

			a = Math.Cos(angle * Math.PI / 180);
			b = Math.Sin(angle * Math.PI / 180);
			d = -Math.Sin(angle * Math.PI / 180);
			e = Math.Cos(angle * Math.PI / 180);

			Draw_Tetrahedron(ref tetrahedron);
			Clear_matr_preob();

			//////////

			Clear_matr_preob();

			l = 250;
			m = 200;

			Draw_Tetrahedron(ref tetrahedron);

			Clear_matr_preob();

			///////////////////////////////

			Graphics g = Graphics.FromImage(myBitmap);

			g.Clear(SystemColors.Control);

			//поиск граней
			Init_Edges();

			visibleEdges();

			Draw_ViewInvisibleTetrahedron(ref tetrahedron);

			Draw_ViewOsi();

			Draw_ViewVisibleTetrahedron(ref tetrahedron);
		}

		///////////////////////////////////////////////////////// Buttons
		private void RotateButton1_MouseDown(object sender, MouseEventArgs e)
		{
			angle = 5;
			Timer.Start();
		}

		private void RotateButton1_MouseUp(object sender, MouseEventArgs e)
		{
			angle = 0;
			Timer.Stop();
		}

		private void RotateButton2_MouseDown(object sender, MouseEventArgs e)
		{
			angle = -5;
			Timer.Start();
		}

		private void RotateButton2_MouseUp(object sender, MouseEventArgs e)
		{
			angle = 0;
			Timer.Stop();
		}



























		/////////////////////////////////////////////////////////////////

		/// <summary>
		/// Отрисовка линии
		/// </summary>
		private void Line(double x1, double y1, double x2, double y2)
		{
			Pen myPen = new Pen(Color.Blue, 3);// цвет линии и ширина

			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			g.DrawLine(myPen, (int)x1, (int)y1, (int)x2, (int)y2);

			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
			pictureBox1.Image = myBitmap;
		}

		/// <summary>
		/// Отрисовка линии с параметрами
		/// </summary>
		/// <param name="color">Цвет линиии</param>
		/// <param name="width">Ширина линии</param>
		/// <param name="isDotted">Пунктирная ли линия</param>
		private void Line(double x1, double y1, double x2, double y2, Color color, float width)
		{

			//создаем новый объект Graphics (поверхность рисования) из pictureBox
			Graphics g = Graphics.FromImage(myBitmap);

			Pen myPen = new Pen(color, width);// цвет линии и ширина

			g.DrawLine(myPen, (int)x1, (int)y1, (int)x2, (int)y2);

			g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
			myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
			pictureBox1.Image = myBitmap;
		}

		/// <summary>
		/// Отрисовка линии с параметрами
		/// </summary>
		/// <param name="color">Цвет линиии</param>
		/// <param name="width">Ширина линии</param>
		/// <param name="isDotted">Пунктирная ли линия</param>
		private void Line(double x1, double y1, double x2, double y2, Color color, float width, bool isDotted)
		{

			int X = (int)x1;
			int Y = (int)y1;
			int Px = Math.Abs((int)x2 - (int)x1);
			int Py = Math.Abs((int)y2 - (int)y1);
			int stepX = Math.Sign(x2 - x1);//возвращает знак разности между xk и xn.(-1 || 1 || 0)
			int stepY = Math.Sign(y2 - y1);
			int E;

			if (Py <= Px) // 0 <= |Py| <= |Px|
			{
				E = 2 * Py - Px;
				for (int i = 0; i <= Px; i++)
				{
					PutPixel(X, Y, i, color, width, isDotted); // Установка пикселя

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
					PutPixel(X, Y, i, color, width, isDotted); // Установка пикселя

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

		//Пиксель
		private void PutPixel(int x, int y, int counter, Color color, float width, bool isDotted)
		{
			Graphics g = Graphics.FromImage(myBitmap);

			Pen myPen = new Pen(color, width);// цвет линии и ширина

			if (isDotted == true)
			{
				if (counter % 30 < 10)
				{
					g.DrawRectangle(myPen, x, y, width, width);
				}
			}
			else
			{
				g.DrawRectangle(myPen, x, y, width, width);
			}
			//передаем полученный растр mybitmap в элемент pictureBox
			pictureBox1.Image = myBitmap;
		}

		//вычисляет, какие рёбра видимые
		private void visibleEdges()
		{
			double[][] normals = new double[4][];

			normals[0] = getNormal(0, 1, 2);
			normals[1] = getNormal(0, 2, 3);
			normals[2] = getNormal(0, 3, 1);
			normals[3] = getNormal(3, 2, 1);

			//Проверка каждой грани
			int[] numbers1 = { 0, 1, 2 };
			if (faceIsVisible(normals[0], cameraNormal))
			{
				foreach (var i in numbers1)
					foreach (var j in numbers1)
					{
						edgeIsVisible[i, j] = true;
					}
			}

			int[] numbers2 = { 0, 2, 3 };
			if (faceIsVisible(normals[1], cameraNormal))
			{
				foreach (var i in numbers2)
					foreach (var j in numbers2)
					{
						edgeIsVisible[i, j] = true;
					}
			}

			int[] numbers3 = { 0, 3, 1 };
			if (faceIsVisible(normals[2], cameraNormal))
			{
				foreach (var i in numbers3)
					foreach (var j in numbers3)
					{
						edgeIsVisible[i, j] = true;
					}
			}

			int[] numbers4 = { 3, 2, 1 };
			if (faceIsVisible(normals[3], cameraNormal))
			{
				foreach (var i in numbers4)
					foreach (var j in numbers4)
					{
						edgeIsVisible[i, j] = true;
					}
			}

		}

		private double[] getNormal(int root_h, int root_a, int root_b)
		{
			double[] v_a = new double[3];
			double[] v_b = new double[3]; 

			for (int i = 0; i < 3; i++) 
			{
				v_a[i] = tetrahedron[root_h,i] - tetrahedron[root_a,i];
				v_b[i] = tetrahedron[root_h,i] - tetrahedron[root_b,i];
			}

			return CrossMultiply(v_a, v_b);
		}

	}
}


