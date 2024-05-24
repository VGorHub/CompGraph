namespace CompGraph.View
{
	partial class _4
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RotateButton2 = new System.Windows.Forms.Button();
            this.RotateButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.RotateButton2.Location = new System.Drawing.Point(84, 19);
            this.RotateButton2.Name = "RotateButton2";
            this.RotateButton2.Size = new System.Drawing.Size(59, 60);
            this.RotateButton2.TabIndex = 1;
            this.RotateButton2.Text = "↺";
            this.RotateButton2.UseVisualStyleBackColor = true;
            this.RotateButton2.Click += new System.EventHandler(this.RotateButton2_Click);
            this.RotateButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateButton2_MouseDown);
            this.RotateButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateButton2_MouseUp);
            // 
            // RotateButton1
            // 
            this.RotateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateButton1.Location = new System.Drawing.Point(19, 19);
            this.RotateButton1.Name = "RotateButton1";
            this.RotateButton1.Size = new System.Drawing.Size(59, 60);
            this.RotateButton1.TabIndex = 2;
            this.RotateButton1.Text = "↻";
            this.RotateButton1.UseVisualStyleBackColor = true;
            this.RotateButton1.Click += new System.EventHandler(this.RotateButton1_Click);
            this.RotateButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateButton1_MouseDown);
            this.RotateButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateButton1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RotateButton1);
            this.panel1.Controls.Add(this.RotateButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(636, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 450);
            this.panel1.TabIndex = 15;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // _4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "_4";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button RotateButton2;
		private System.Windows.Forms.Button RotateButton1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer Timer;
	}
}