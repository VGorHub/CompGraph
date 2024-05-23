namespace CompGraph.View
{
    partial class grisha41
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pr = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button14 = new System.Windows.Forms.Button();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.numericUpDownLightX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLightZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLightY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightY)).BeginInit();
            this.SuspendLayout();
            // 
            // Pr
            // 
            this.Pr.AccumBits = ((byte)(0));
            this.Pr.AutoCheckErrors = false;
            this.Pr.AutoFinish = false;
            this.Pr.AutoMakeCurrent = true;
            this.Pr.AutoSwapBuffers = true;
            this.Pr.BackColor = System.Drawing.Color.Black;
            this.Pr.ColorBits = ((byte)(32));
            this.Pr.DepthBits = ((byte)(16));
            this.Pr.Location = new System.Drawing.Point(2, 12);
            this.Pr.Name = "Pr";
            this.Pr.Size = new System.Drawing.Size(762, 513);
            this.Pr.StencilBits = ((byte)(0));
            this.Pr.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "конус";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "куб";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(770, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "цилиндр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(770, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "додекаэдр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(770, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "икосаэдр";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(770, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "октаэдр";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(770, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "ромбический додекаэдр";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(770, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "губка Серпиского";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(770, 246);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "сфера";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(770, 275);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "чайник";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(770, 304);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(166, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "тетраэдр";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(770, 333);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(166, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "тор";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(861, 408);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "стоп";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(770, 362);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Wire";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(770, 385);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Solid";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(770, 434);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "X";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(770, 457);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Y";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(770, 480);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(33, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Z";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(770, 408);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 23;
            this.button14.Text = "старт";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(138, 548);
            this.trackBarR.Maximum = 150;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(626, 45);
            this.trackBarR.TabIndex = 24;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(138, 650);
            this.trackBarB.Maximum = 150;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(626, 45);
            this.trackBarB.TabIndex = 25;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(138, 599);
            this.trackBarG.Maximum = 150;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(626, 45);
            this.trackBarG.TabIndex = 26;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // numericUpDownLightX
            // 
            this.numericUpDownLightX.Location = new System.Drawing.Point(12, 548);
            this.numericUpDownLightX.Name = "numericUpDownLightX";
            this.numericUpDownLightX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLightX.TabIndex = 27;
            this.numericUpDownLightX.ValueChanged += new System.EventHandler(this.numericUpDownLightX_ValueChanged);
            // 
            // numericUpDownLightZ
            // 
            this.numericUpDownLightZ.Location = new System.Drawing.Point(12, 650);
            this.numericUpDownLightZ.Name = "numericUpDownLightZ";
            this.numericUpDownLightZ.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLightZ.TabIndex = 28;
            this.numericUpDownLightZ.ValueChanged += new System.EventHandler(this.numericUpDownLightZ_ValueChanged);
            // 
            // numericUpDownLightY
            // 
            this.numericUpDownLightY.Location = new System.Drawing.Point(12, 599);
            this.numericUpDownLightY.Name = "numericUpDownLightY";
            this.numericUpDownLightY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLightY.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 745);
            this.Controls.Add(this.numericUpDownLightY);
            this.Controls.Add(this.numericUpDownLightZ);
            this.Controls.Add(this.numericUpDownLightX);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pr);
            this.Name = "Form1";
            this.Text = "ре";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl Pr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.NumericUpDown numericUpDownLightX;
        private System.Windows.Forms.NumericUpDown numericUpDownLightZ;
        private System.Windows.Forms.NumericUpDown numericUpDownLightY;
    }
}

