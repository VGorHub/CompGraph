namespace CompGraph.View
{
    partial class Grisha_3Laba_Tab
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4_Start = new System.Windows.Forms.Button();
            this.button2_Stop = new System.Windows.Forms.Button();
            this.textBox1_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 520);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 514);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4_Start);
            this.panel2.Controls.Add(this.button2_Stop);
            this.panel2.Controls.Add(this.textBox1_Angle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(460, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 520);
            this.panel2.TabIndex = 1;
            // 
            // button4_Start
            // 
            this.button4_Start.Location = new System.Drawing.Point(7, 218);
            this.button4_Start.Name = "button4_Start";
            this.button4_Start.Size = new System.Drawing.Size(199, 23);
            this.button4_Start.TabIndex = 5;
            this.button4_Start.Text = "Start";
            this.button4_Start.UseVisualStyleBackColor = true;
            this.button4_Start.Click += new System.EventHandler(this.button4_Start_Click);
            // 
            // button2_Stop
            // 
            this.button2_Stop.Location = new System.Drawing.Point(6, 276);
            this.button2_Stop.Name = "button2_Stop";
            this.button2_Stop.Size = new System.Drawing.Size(200, 23);
            this.button2_Stop.TabIndex = 3;
            this.button2_Stop.Text = "Clear";
            this.button2_Stop.UseVisualStyleBackColor = true;
            this.button2_Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_Angle
            // 
            this.textBox1_Angle.Location = new System.Drawing.Point(89, 177);
            this.textBox1_Angle.Name = "textBox1_Angle";
            this.textBox1_Angle.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Angle.TabIndex = 2;
            this.textBox1_Angle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "угол поворота";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 526);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Grisha_3Laba_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "Grisha_3Laba_Tab";
            this.Size = new System.Drawing.Size(691, 532);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1_Angle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4_Start;
        private System.Windows.Forms.Button button2_Stop;
        private System.Windows.Forms.Button button1;
    }
}
