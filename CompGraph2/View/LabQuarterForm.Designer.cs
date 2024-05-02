namespace CompGraph.View
{
    partial class LabQuarterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RotateButton2 = new System.Windows.Forms.Button();
            this.RotateButton1 = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RotateSpeedComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MoveComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ScaleComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RotateButton2
            // 
            this.RotateButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton2.Location = new System.Drawing.Point(84, 62);
            this.RotateButton2.Name = "RotateButton2";
            this.RotateButton2.Size = new System.Drawing.Size(59, 60);
            this.RotateButton2.TabIndex = 1;
            this.RotateButton2.Text = "↺";
            this.RotateButton2.UseVisualStyleBackColor = true;
            this.RotateButton2.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // RotateButton1
            // 
            this.RotateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton1.Location = new System.Drawing.Point(19, 62);
            this.RotateButton1.Name = "RotateButton1";
            this.RotateButton1.Size = new System.Drawing.Size(59, 60);
            this.RotateButton1.TabIndex = 2;
            this.RotateButton1.Text = "↻";
            this.RotateButton1.UseVisualStyleBackColor = true;
            this.RotateButton1.Click += new System.EventHandler(this.RotateButton1_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Ox",
            "Oy",
            "Oz"});
            this.ComboBox1.Location = new System.Drawing.Point(19, 32);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(124, 24);
            this.ComboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите ось:";
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftButton.Location = new System.Drawing.Point(19, 228);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(59, 60);
            this.LeftButton.TabIndex = 5;
            this.LeftButton.Text = "←";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightButton.Location = new System.Drawing.Point(84, 228);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(59, 60);
            this.RightButton.TabIndex = 6;
            this.RightButton.Text = "→";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.Location = new System.Drawing.Point(84, 294);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(59, 60);
            this.MinusButton.TabIndex = 7;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(19, 294);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(59, 60);
            this.PlusButton.TabIndex = 8;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Скорость Поворота:";
            // 
            // RotateSpeedComboBox
            // 
            this.RotateSpeedComboBox.FormattingEnabled = true;
            this.RotateSpeedComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60"});
            this.RotateSpeedComboBox.Location = new System.Drawing.Point(8, 32);
            this.RotateSpeedComboBox.Name = "RotateSpeedComboBox";
            this.RotateSpeedComboBox.Size = new System.Drawing.Size(124, 24);
            this.RotateSpeedComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Скорость Сдвига:";
            // 
            // MoveComboBox
            // 
            this.MoveComboBox.FormattingEnabled = true;
            this.MoveComboBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "50",
            "100"});
            this.MoveComboBox.Location = new System.Drawing.Point(8, 82);
            this.MoveComboBox.Name = "MoveComboBox";
            this.MoveComboBox.Size = new System.Drawing.Size(124, 24);
            this.MoveComboBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Скорость Масштаба:";
            // 
            // ScaleComboBox
            // 
            this.ScaleComboBox.FormattingEnabled = true;
            this.ScaleComboBox.Items.AddRange(new object[] {
            "1,01",
            "1,05",
            "1,1",
            "1,5",
            "2"});
            this.ScaleComboBox.Location = new System.Drawing.Point(8, 132);
            this.ScaleComboBox.Name = "ScaleComboBox";
            this.ScaleComboBox.Size = new System.Drawing.Size(124, 24);
            this.ScaleComboBox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CheckedListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboBox1);
            this.panel1.Controls.Add(this.RotateButton1);
            this.panel1.Controls.Add(this.RotateButton2);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Controls.Add(this.PlusButton);
            this.panel1.Controls.Add(this.MinusButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(636, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 450);
            this.panel1.TabIndex = 15;
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.Location = new System.Drawing.Point(19, 360);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(124, 60);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewButton_MouseDown);
            this.ViewButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewButton_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выберите оси:";
            // 
            // CheckedListBox
            // 
            this.CheckedListBox.FormattingEnabled = true;
            this.CheckedListBox.Items.AddRange(new object[] {
            "Ox",
            "Oy",
            "Oz"});
            this.CheckedListBox.Location = new System.Drawing.Point(19, 159);
            this.CheckedListBox.Name = "CheckedListBox";
            this.CheckedListBox.Size = new System.Drawing.Size(128, 72);
            this.CheckedListBox.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RotateSpeedComboBox);
            this.panel2.Controls.Add(this.ScaleComboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MoveComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 450);
            this.panel2.TabIndex = 16;
            // 
            // LabQuarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LabQuarterForm";
            this.Text = "LabFourthForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RotateButton2;
        private System.Windows.Forms.Button RotateButton1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RotateSpeedComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MoveComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ScaleComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox CheckedListBox;
    }
}