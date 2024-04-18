namespace CompGraph.View
{
    partial class Lab3Stepa
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Auto = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.radioButton_Auto = new System.Windows.Forms.RadioButton();
            this.radioButton_Bird = new System.Windows.Forms.RadioButton();
            this.radioButton_Boat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Auto);
            this.panel3.Controls.Add(this.button_down);
            this.panel3.Controls.Add(this.button_left);
            this.panel3.Controls.Add(this.button_right);
            this.panel3.Controls.Add(this.button_up);
            this.panel3.Controls.Add(this.radioButton_Auto);
            this.panel3.Controls.Add(this.radioButton_Bird);
            this.panel3.Controls.Add(this.radioButton_Boat);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(614, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 548);
            this.panel3.TabIndex = 0;
            // 
            // button_Auto
            // 
            this.button_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Auto.Location = new System.Drawing.Point(57, 280);
            this.button_Auto.Name = "button_Auto";
            this.button_Auto.Size = new System.Drawing.Size(28, 28);
            this.button_Auto.TabIndex = 10;
            this.button_Auto.Text = "A";
            this.button_Auto.UseVisualStyleBackColor = true;
            this.button_Auto.Visible = false;
            this.button_Auto.Click += new System.EventHandler(this.button_Auto_Click);
            // 
            // button_down
            // 
            this.button_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_down.Location = new System.Drawing.Point(57, 314);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(28, 28);
            this.button_down.TabIndex = 9;
            this.button_down.Text = "↓";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Visible = false;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_left.Location = new System.Drawing.Point(23, 281);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(28, 28);
            this.button_left.TabIndex = 8;
            this.button_left.Text = "←";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Visible = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_right.Location = new System.Drawing.Point(91, 281);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(28, 28);
            this.button_right.TabIndex = 7;
            this.button_right.Text = "→\t";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Visible = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_up
            // 
            this.button_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_up.Location = new System.Drawing.Point(57, 248);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(28, 28);
            this.button_up.TabIndex = 2;
            this.button_up.Text = "↑";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Visible = false;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // radioButton_Auto
            // 
            this.radioButton_Auto.AutoSize = true;
            this.radioButton_Auto.Location = new System.Drawing.Point(3, 156);
            this.radioButton_Auto.Name = "radioButton_Auto";
            this.radioButton_Auto.Size = new System.Drawing.Size(103, 17);
            this.radioButton_Auto.TabIndex = 5;
            this.radioButton_Auto.TabStop = true;
            this.radioButton_Auto.Text = "Автоматически";
            this.radioButton_Auto.UseVisualStyleBackColor = true;
            this.radioButton_Auto.Visible = false;
            this.radioButton_Auto.CheckedChanged += new System.EventHandler(this.radioButton_Auto_CheckedChanged);
            // 
            // radioButton_Bird
            // 
            this.radioButton_Bird.AutoSize = true;
            this.radioButton_Bird.Location = new System.Drawing.Point(3, 202);
            this.radioButton_Bird.Name = "radioButton_Bird";
            this.radioButton_Bird.Size = new System.Drawing.Size(110, 17);
            this.radioButton_Bird.TabIndex = 4;
            this.radioButton_Bird.TabStop = true;
            this.radioButton_Bird.Text = "Чайка(отдельно)";
            this.radioButton_Bird.UseVisualStyleBackColor = true;
            this.radioButton_Bird.Visible = false;
            // 
            // radioButton_Boat
            // 
            this.radioButton_Boat.AutoSize = true;
            this.radioButton_Boat.Location = new System.Drawing.Point(3, 179);
            this.radioButton_Boat.Name = "radioButton_Boat";
            this.radioButton_Boat.Size = new System.Drawing.Size(110, 17);
            this.radioButton_Boat.TabIndex = 2;
            this.radioButton_Boat.TabStop = true;
            this.radioButton_Boat.Text = "Лодка(отдельно)";
            this.radioButton_Boat.UseVisualStyleBackColor = true;
            this.radioButton_Boat.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Основное";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перемещение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Очистка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отрисовка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 548);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 542);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lab3Stepa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Lab3Stepa";
            this.Size = new System.Drawing.Size(773, 572);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_Boat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_Auto;
        private System.Windows.Forms.RadioButton radioButton_Bird;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_Auto;
        private System.Windows.Forms.Timer timer1;
    }
}
