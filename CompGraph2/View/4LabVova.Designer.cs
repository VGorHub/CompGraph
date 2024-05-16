namespace CompGraph.View
{
    partial class _4LabVova
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RotateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.RotateButton1 = new System.Windows.Forms.Button();
            this.RotateButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 535);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RotateTimer
            // 
            this.RotateTimer.Tick += new System.EventHandler(this.RotateTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Controls.Add(this.RotateButton1);
            this.panel1.Controls.Add(this.RotateButton2);
            this.panel1.Location = new System.Drawing.Point(623, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 531);
            this.panel1.TabIndex = 2;
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.Location = new System.Drawing.Point(29, 326);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(148, 49);
            this.ViewButton.TabIndex = 14;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // RotateButton1
            // 
            this.RotateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton1.Location = new System.Drawing.Point(29, 84);
            this.RotateButton1.Margin = new System.Windows.Forms.Padding(2);
            this.RotateButton1.Name = "RotateButton1";
            this.RotateButton1.Size = new System.Drawing.Size(73, 49);
            this.RotateButton1.TabIndex = 13;
            this.RotateButton1.Text = "↻";
            this.RotateButton1.UseVisualStyleBackColor = true;
            // 
            // RotateButton2
            // 
            this.RotateButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton2.Location = new System.Drawing.Point(106, 84);
            this.RotateButton2.Margin = new System.Windows.Forms.Padding(2);
            this.RotateButton2.Name = "RotateButton2";
            this.RotateButton2.Size = new System.Drawing.Size(71, 49);
            this.RotateButton2.TabIndex = 12;
            this.RotateButton2.Text = "↺";
            this.RotateButton2.UseVisualStyleBackColor = true;
            // 
            // _4LabVova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "_4LabVova";
            this.Size = new System.Drawing.Size(829, 535);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer RotateTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button RotateButton1;
        private System.Windows.Forms.Button RotateButton2;
    }
}
